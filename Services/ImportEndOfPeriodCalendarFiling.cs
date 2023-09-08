
//.ImportEndOfPeriodCalendarFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEndOfPeriodCalendarFiling")]
  public class ImportEndOfPeriodCalendarFiling
  {
    [XmlArray(ElementName = "endOfPeriodCalendarFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> EndOfPeriodCalendarFilingToImport { get; set; }
  }
}
