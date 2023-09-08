using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KelioSDK.Common
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope<T>
    {
        [XmlElement(ElementName = "Body")]
        public Body<T> Body { get; set; }
    }
}
