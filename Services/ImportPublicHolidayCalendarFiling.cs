
//.ImportPublicHolidayCalendarFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPublicHolidayCalendarFiling")]
  public class ImportPublicHolidayCalendarFiling
  {
    [XmlArray(ElementName = "publicHolidayCalendarFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> PublicHolidayCalendarFilingToImport { get; set; }
  }
}
