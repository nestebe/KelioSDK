
//.ImportPublicHolidayCalendarFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPublicHolidayCalendarFilingResponse")]
  public class ImportPublicHolidayCalendarFilingResponse
  {
    [XmlArray(ElementName = "publicHolidayCalendarFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> PublicHolidayCalendarFilingInError { get; set; }
  }
}
