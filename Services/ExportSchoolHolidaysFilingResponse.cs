
//.ExportSchoolHolidaysFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportSchoolHolidaysFilingResponse")]
  public class ExportSchoolHolidaysFilingResponse
  {
    [XmlArray(ElementName = "exportedSchoolHolidaysFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedSchoolHolidaysFiling { get; set; }
  }
}
