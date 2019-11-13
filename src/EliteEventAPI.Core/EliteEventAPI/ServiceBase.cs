using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI
{
    /// <summary>
    /// Baseclass to create own services
    /// </summary>
    public abstract class ServiceBase
    {
        /// <summary>
        /// Servicename
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Indicates whether the service is currently running. 
        /// </summary>
        public bool Running { get; internal set; }

        /// <summary>
        /// Called when the service is initialized.
        /// </summary>
        protected internal virtual void OnInitialize()
        { }

        /// <summary>
        /// Is called when another service has been installed and the Inject service is running.
        /// </summary>
        protected internal virtual void OnModuleInjectUpdate()
        { }

        internal void InternalOnStart()
        {
            try
            {
                Running = true;
                OnStart();
            }
            catch (Exception ex)
            {
                Running = false;
                throw new ServiceRuntimeException($"Error during runtime for {this.GetType().Name}. See InnerException for more details.", ex);
            }
        }

        internal void InternalOnStop()
        {
            Running = false;
            OnStop();
        }

        /// <summary>
        /// Is called when the service is started
        /// </summary>
        protected virtual void OnStart()
        { }

        /// <summary>
        /// Is called when the service ist stopped
        /// </summary>
        protected virtual void OnStop()
        { }
    }
}