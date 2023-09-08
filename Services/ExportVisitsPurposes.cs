
//.ExportVisitsPurposes




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportVisitsPurposes")]
  public class ExportVisitsPurposes
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedVisitPurpose> ExportFilter { get; set; }
  }
}
