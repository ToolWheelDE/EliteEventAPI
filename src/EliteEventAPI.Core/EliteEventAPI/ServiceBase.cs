using System;
using System.Collections.Generic;
using System.Text;

namespace EliteEventAPI
{
    public abstract class ServiceBase
    {
        public abstract string Name { get; }

        public bool Running { get; internal set; }

        protected internal virtual void OnInitialize()
        { }

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

        protected virtual void OnStart()
        { }

        protected virtual void OnStop()
        { }
    }
}
