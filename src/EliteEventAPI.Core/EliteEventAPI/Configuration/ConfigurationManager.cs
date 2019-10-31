using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace EliteEventAPI.Configuration
{
    public class ConfigurationManager
    {
        private static Dictionary<Type, ConfigurationBase> _configurationbytype = new Dictionary<Type, ConfigurationBase>();
        private static XmlDocument _configurationdocument;
        private static XmlNode _configurationnode;

        private static readonly string ConfigurationFile = "configuration.xml";

        static ConfigurationManager()
        {
            _configurationdocument = new XmlDocument();

            if (!File.Exists(ConfigurationFile))
            {
                XmlDeclaration xmlDeclaration = _configurationdocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = _configurationdocument.DocumentElement;
                _configurationdocument.InsertBefore(xmlDeclaration, root);

                _configurationnode = _configurationdocument.CreateElement("configuration");
                _configurationdocument.AppendChild(_configurationnode);
                _configurationdocument.Save(ConfigurationFile);
            }
            else
            {
                _configurationdocument.PreserveWhitespace = true;
                _configurationdocument.Load(ConfigurationFile);
                _configurationnode = _configurationdocument.SelectSingleNode("configuration");
            }
        }

        public static T LoadConfiguration<T>()
            where T : ConfigurationBase
        {
            var type = typeof(T);

            if (_configurationbytype.TryGetValue(type, out ConfigurationBase configuration))
            {
                return (T)configuration;
            }
            else
            {
                var instance = Activator.CreateInstance<T>();
                _configurationbytype.Add(type, instance);

                var sectionnode = _configurationnode.SelectSingleNode($"section[@name = \"{instance.Section}\"]");
                if (sectionnode == null)
                {
                    sectionnode = _configurationdocument.CreateElement("section");
                    var sectionnameattribute = _configurationdocument.CreateAttribute("name");
                    sectionnameattribute.Value = instance.Section;

                    sectionnode.Attributes.Append(sectionnameattribute);
                    _configurationnode.AppendChild(sectionnode);

                    foreach (var property in instance.Properties)
                    {
                        var valuenode = _configurationdocument.CreateElement(property.Name);

                        if (property.PropertyType.IsArray)
                        {
                            valuenode.InnerText = string.Join("|", ((object[])property.GetValue(instance)).Select(m => m.ToString()));
                        }
                        else if (property.PropertyType.IsEnum)
                        {
                            throw new NotSupportedException("Enum convert not supported");
                        }
                        else
                        {
                            valuenode.InnerText = property.GetValue(instance).ToString();
                        }

                        sectionnode.AppendChild(valuenode);
                    }

                    _configurationdocument.Save(ConfigurationFile);
                }
                else
                {
                    foreach (XmlNode valuenode in sectionnode.ChildNodes)
                    {
                        var property = instance.Properties.Where(m => m.Name.ToLower() == valuenode.Name.ToLower()).FirstOrDefault();
                        if (property != null)
                        {
                            if (property.PropertyType.IsArray)
                            {
                                var values = valuenode.InnerText.Split('|');
                                var array = new ArrayList(values);
                                var arraybasetypename = property.PropertyType.FullName.Substring(0, property.PropertyType.FullName.Length - 2);
                                var arraybasetype = Type.GetType(arraybasetypename);

                                property.SetValue(instance, array.ToArray(arraybasetype));
                            }
                            else if (property.PropertyType.IsEnum)
                            {
                                throw new NotSupportedException("Enum convert not supported");
                            }
                            else
                            {
                                property.SetValue(instance, valuenode.InnerText);
                            }
                        }
                    }
                }

                return instance;
            }
        }
    }
}