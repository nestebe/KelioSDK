
//.ExportAccountInitializations




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccountInitializations")]
  public class ExportAccountInitializations
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedAccountInitialization> ExportFilter { get; set; }
  }
}
