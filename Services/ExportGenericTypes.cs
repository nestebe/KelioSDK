
//.ExportGenericTypes




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportGenericTypes")]
  public class ExportGenericTypes
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<TypeFilter> ExportFilter { get; set; }
  }
}
