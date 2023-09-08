
//.ExportOvertimeHourFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOvertimeHourFilingResponse")]
  public class ExportOvertimeHourFilingResponse
  {
    [XmlArray(ElementName = "exportedOvertimeHourFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedOvertimeHourFiling { get; set; }
  }
}
