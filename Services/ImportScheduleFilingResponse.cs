
//.ImportScheduleFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importScheduleFilingResponse")]
  public class ImportScheduleFilingResponse
  {
    [XmlArray(ElementName = "scheduleFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> ScheduleFilingInError { get; set; }
  }
}
