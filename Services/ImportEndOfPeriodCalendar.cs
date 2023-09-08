
//.ImportEndOfPeriodCalendar




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEndOfPeriodCalendar")]
  public class ImportEndOfPeriodCalendar
  {
    [XmlArray(ElementName = "endOfPeriodCalendarToImport", IsNullable = false, Order = 0)]
    public List<EndOfPeriodCalendar> EndOfPeriodCalendarToImport { get; set; }
  }
}
