
//.DeleteSchoolHolidaysCalendarFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteSchoolHolidaysCalendarFiling")]
  public class DeleteSchoolHolidaysCalendarFiling
  {
    [XmlArray(ElementName = "schoolHolidaysCalendarFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> SchoolHolidaysCalendarFilingToDelete { get; set; }
  }
}
