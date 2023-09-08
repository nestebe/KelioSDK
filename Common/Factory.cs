using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace KelioSDK.Common
{
    public static class Factory
    {
        private static readonly XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        private static readonly Hashtable serializers;

        static Factory()
        {
            Factory.namespaces.Add("s", "http://schemas.xmlsoap.org/soap/envelope/");
            Factory.namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            Factory.namespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");
            Factory.serializers = new Hashtable();
        }

        public static string Request<T>(T content, out string action) where T : class
        {
            XmlTypeAttribute typeAttribute = Factory.GetTypeAttribute<T>();
            action = typeAttribute.TypeName;
            XmlSerializer serializer = Factory.GetSerializer<T>(typeAttribute);
            Envelope<T> o = new Envelope<T>()
            {
                Body = new Body<T>() { BodyContent = content }
            };
            StringBuilder output = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = true
            };
            using (XmlWriter xmlWriter = XmlWriter.Create(output, settings))
            {
                serializer.Serialize(xmlWriter, (object)o, Factory.namespaces);
                return output.ToString();
            }
        }

        public static T Response<T>(string responsexml) where T : class, new()
        {
            using (TextReader textReader = (TextReader)new StringReader(responsexml))
                return (Factory.GetSerializer<T>(Factory.GetTypeAttribute<T>()).Deserialize(textReader) as Envelope<T>).Body.BodyContent;
        }

        private static XmlTypeAttribute GetTypeAttribute<T>() => typeof(T).GetCustomAttributes(true).OfType<XmlTypeAttribute>().FirstOrDefault<XmlTypeAttribute>() ?? throw new ArgumentNullException("content", "Cannot find XmlTypeAttribute on result class of type " + typeof(T).Name + ".");

        private static XmlSerializer GetSerializer<T>(XmlTypeAttribute typeattr) where T : class
        {
            if (Factory.serializers.ContainsKey((object)typeattr.TypeName))
                return Factory.serializers[(object)typeattr.TypeName] as XmlSerializer;
            XmlAttributes attributes = new XmlAttributes();
            XmlElementAttribute attribute = new XmlElementAttribute()
            {
                Type = typeof(T),
                ElementName = typeattr.TypeName,
                Namespace = typeattr.Namespace
            };
            attributes.XmlElements.Add(attribute);
            XmlAttributeOverrides overrides = new XmlAttributeOverrides();
            overrides.Add(typeof(Body<T>), "BodyContent", attributes);
            XmlSerializer serializer = new XmlSerializer(typeof(Envelope<T>), overrides);
            Factory.serializers.Add((object)typeattr.TypeName, (object)serializer);
            return serializer;
        }
    }
}
