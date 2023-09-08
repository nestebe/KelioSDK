
//.ImportSchoolHolidaysFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSchoolHolidaysFilingResponse")]
  public class ImportSchoolHolidaysFilingResponse
  {
    [XmlArray(ElementName = "schoolHolidaysFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> SchoolHolidaysFilingInError { get; set; }
  }
}
