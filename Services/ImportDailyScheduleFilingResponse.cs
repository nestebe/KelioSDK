
//.ImportDailyScheduleFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importDailyScheduleFilingResponse")]
  public class ImportDailyScheduleFilingResponse
  {
    [XmlArray(ElementName = "dailyScheduleFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> DailyScheduleFilingInError { get; set; }
  }
}
