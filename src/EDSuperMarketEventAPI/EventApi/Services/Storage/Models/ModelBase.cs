using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Storage.Models
{
    public delegate void ModelPropertyDelegate(ModelBase sender, string propertyname, object value);
    public delegate void ModelActionDelegate(ModelBase sender, string action);

    public abstract class ModelBase
    {
        private readonly string _mytypename;
        private readonly Dictionary<string, object> _map = new Dictionary<string, object>();

        public event ModelPropertyDelegate ModelProperty;
        public event ModelActionDelegate ModelAction;

        public ModelBase()
        {
            _mytypename = GetType().Name;
        }

        protected void OnAction(string name)
        {
            Debug.WriteLine($"Action {_mytypename}.{name}");
            ModelAction?.Invoke(this, name);
        }

        protected TValue GetValue<TValue>(Expression<Func<TValue>> exp)
        {
            if (exp.Body is MemberExpression body)
            {
                if (body.Member is PropertyInfo property)
                {
                    if (_map.TryGetValue(property.Name, out object value))
                        return (TValue)value;
                    else
                        return default;
                }
                else
                {
                    throw new InvalidOperationException($"{nameof(exp)} is not an property");
                }
            }
            else
            {
                throw new InvalidOperationException($"{nameof(exp)} is not an member expression");
            }
        }

        protected void SetValue<TValue>(Expression<Func<TValue>> exp, TValue value)
        {
            if (exp.Body is MemberExpression body)
            {
                if (body.Member is PropertyInfo property)
                {
                    if (_map.ContainsKey(property.Name))
                    {
                        if (Equals(value, _map[property.Name]))
                            return;
                    }

                    _map[property.Name] = value;
                    OnProperty(property.Name, value);
                }
                else
                {
                    throw new InvalidOperationException($"{nameof(exp)} is not an property");
                }
            }
            else
            {
                throw new InvalidOperationException($"{nameof(exp)} is not an member expression");
            }
        }

        protected void OnProperty(string propertyname, object value)
        {
            Debug.WriteLine($"PropertyChanged {_mytypename}.{propertyname} = {value}");
            ModelProperty?.Invoke(this, propertyname, value);
        }

        protected void OnProperty<TProperty>(Expression<Func<TProperty>> exp)
        {
            if (exp.Body is MemberExpression body)
            {
                if (body.Member is PropertyInfo property)
                {
                    var value = property.GetValue(this);

                    Debug.WriteLine($"PropertyChanged {_mytypename}.{property.Name} = {value}");
                    ModelProperty?.Invoke(this, property.Name, value);
                }
                else
                {
                    throw new InvalidOperationException($"{nameof(exp)} is not an property");
                }
            }
            else
            {
                throw new InvalidOperationException($"{nameof(exp)} is not an member expression");
            }
        }
    }
}
