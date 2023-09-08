
//.DeleteEndOfPeriodCalendarFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteEndOfPeriodCalendarFilingResponse")]
  public class DeleteEndOfPeriodCalendarFilingResponse
  {
    [XmlArray(ElementName = "endOfPeriodCalendarFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> EndOfPeriodCalendarFilingInError { get; set; }
  }
}
