
//.ExportScheduleContractFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportScheduleContractFilingResponse")]
  public class ExportScheduleContractFilingResponse
  {
    [XmlArray(ElementName = "exportedScheduleContractFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedScheduleContractFiling { get; set; }
  }
}
