using EliteEventAPI.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EliteEventAPI
{
    /// <summary>
    /// Controller to manage Services
    /// </summary>
    public static class ServiceController
    {
        private static readonly Dictionary<Type, ServiceBase> _instances = new Dictionary<Type, ServiceBase>();
        private static readonly EventService _eventservice;

        static ServiceController()
        {
            _eventservice= InstallService<EventService>();
        }

        public static void DispatchEvent()
        {
            _eventservice.DispatchEvent();
        }

        /// <summary>
        /// Returns the count of installed services.
        /// </summary>
        public static int Count { get => _instances.Count; }


        /// <summary>
        /// Installs the specified service
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T InstallService<T>()
            where T : ServiceBase
        {
            var type = typeof(T);
            ServiceBase result;

            if (_instances.TryGetValue(type, out ServiceBase module))
            {
                result = module;
            }
            else
            {
                var instance = Activator.CreateInstance<T>();
                _instances.Add(type, instance);
                result = instance;
            }

            UpdateModuleInject();

            result.OnInitialize();

            return (T)result;
        }

        /// <summary>
        /// Delivers an installed service
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetService<T>()
            where T : ServiceBase
        {
            var type = typeof(T);

            if (_instances.TryGetValue(type, out ServiceBase module))
                return (T)module;

            return null;
        }

        /// <summary>
        /// Start the runtime
        /// </summary>
        public static void Start()
        {
            foreach (var item in _instances.Values)
            {
                if (!item.Running)
                    item.InternalOnStart();
            }
        }

        /// <summary>
        /// Stop the runtime
        /// </summary>
        public static void Stop()
        {
            foreach (var item in _instances.Values)
            {
                if (item.Running)
                    item.InternalOnStop();
            }
        }

        private static void UpdateModuleInject()
        {
            foreach (var item in _instances)
            {
                var type = item.Key;
                var instance = item.Value;

                foreach (var property in type.GetProperties())
                {
                    if (property.PropertyType.IsSubclassOf(typeof(ServiceBase)) && _instances.TryGetValue(property.PropertyType, out ServiceBase module))
                    {
                        if (property.GetValue(instance) == null)
                            property.SetValue(instance, module);
                    }
                }

                instance.OnModuleInjectUpdate();
            }
        }
    }
}