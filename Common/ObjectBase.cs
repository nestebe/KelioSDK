using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KelioSDK.Common
{
    [XmlType(TypeName = "Object", Namespace = "http://echange.service.open.bodet.com")]
    public abstract class ObjectBase
    {
        [XmlElement(ElementName = "technicalString")]
        public string TechnicalString { get; set; }

        [XmlElement(ElementName = "errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
