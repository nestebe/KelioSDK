
//.ImportEndOfPeriodCalendarResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEndOfPeriodCalendarResponse")]
  public class ImportEndOfPeriodCalendarResponse
  {
    [XmlArray(ElementName = "endOfPeriodCalendarInError", IsNullable = false, Order = 0)]
    public List<EndOfPeriodCalendar> EndOfPeriodCalendarInError { get; set; }
  }
}
