
//.ExportVisitsPurposesFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportVisitsPurposesFromRelativeDatesResponse")]
  public class ExportVisitsPurposesFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedVisitsPurposes", IsNullable = false, Order = 0)]
    public List<VisitPurpose> ExportedVisitsPurposes { get; set; }
  }
}
