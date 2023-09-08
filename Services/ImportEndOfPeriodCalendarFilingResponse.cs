
//.ImportEndOfPeriodCalendarFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEndOfPeriodCalendarFilingResponse")]
  public class ImportEndOfPeriodCalendarFilingResponse
  {
    [XmlArray(ElementName = "endOfPeriodCalendarFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> EndOfPeriodCalendarFilingInError { get; set; }
  }
}
