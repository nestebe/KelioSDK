
//.ImportScheduleContractFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importScheduleContractFilingResponse")]
  public class ImportScheduleContractFilingResponse
  {
    [XmlArray(ElementName = "scheduleContractFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> ScheduleContractFilingInError { get; set; }
  }
}
