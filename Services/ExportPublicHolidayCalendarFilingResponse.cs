
//.ExportPublicHolidayCalendarFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPublicHolidayCalendarFilingResponse")]
  public class ExportPublicHolidayCalendarFilingResponse
  {
    [XmlArray(ElementName = "exportedPublicHolidayCalendarFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedPublicHolidayCalendarFiling { get; set; }
  }
}
