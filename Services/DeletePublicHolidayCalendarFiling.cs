
//.DeletePublicHolidayCalendarFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deletePublicHolidayCalendarFiling")]
  public class DeletePublicHolidayCalendarFiling
  {
    [XmlArray(ElementName = "publicHolidayCalendarFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> PublicHolidayCalendarFilingToDelete { get; set; }
  }
}
