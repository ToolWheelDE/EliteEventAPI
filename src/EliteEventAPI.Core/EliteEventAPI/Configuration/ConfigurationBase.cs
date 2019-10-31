using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace EliteEventAPI.Configuration
{
    public abstract class ConfigurationBase
    {
        public ConfigurationBase()
        {
            Properties = GetType().GetProperties().ToArray();
            Properties = Properties.Where(m => m.Name != "Section").ToArray();
            Properties = Properties.Where(m => m.Name != "Properties").ToArray();

            // Auto default
            foreach (var property in Properties)
            {
                if(property.PropertyType == typeof(string))
                {
                    property.SetValue(this, string.Empty);
                }
            }
        }

        public abstract string Section { get; }

        internal IEnumerable<PropertyInfo> Properties { get; }
    }
}