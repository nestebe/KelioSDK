
//.ImportScheduleContractFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importScheduleContractFiling")]
  public class ImportScheduleContractFiling
  {
    [XmlArray(ElementName = "scheduleContractFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> ScheduleContractFilingToImport { get; set; }
  }
}
