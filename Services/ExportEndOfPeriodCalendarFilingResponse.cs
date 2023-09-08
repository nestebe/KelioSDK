
//.ExportEndOfPeriodCalendarFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEndOfPeriodCalendarFilingResponse")]
  public class ExportEndOfPeriodCalendarFilingResponse
  {
    [XmlArray(ElementName = "exportedEndOfPeriodCalendarFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedEndOfPeriodCalendarFiling { get; set; }
  }
}
