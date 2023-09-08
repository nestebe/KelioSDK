using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KelioSDK.Common
{
    [XmlType(TypeName = "Fault", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Fault
    {
        [XmlElement(ElementName = "faultcode", Namespace = "")]
        public string Faultcode { get; set; }

        [XmlElement(ElementName = "faultstring", Namespace = "")]
        public string Faultstring { get; set; }
    }
}
