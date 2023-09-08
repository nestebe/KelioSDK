
//.DeleteSchoolHolidaysCalendarFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteSchoolHolidaysCalendarFilingResponse")]
  public class DeleteSchoolHolidaysCalendarFilingResponse
  {
    [XmlArray(ElementName = "schoolHolidaysCalendarFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> SchoolHolidaysCalendarFilingInError { get; set; }
  }
}
