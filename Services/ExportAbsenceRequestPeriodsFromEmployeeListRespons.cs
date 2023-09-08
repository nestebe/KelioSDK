
//.ExportAbsenceRequestPeriodsFromEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceRequestPeriodsFromEmployeeListResponse")]
  public class ExportAbsenceRequestPeriodsFromEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedAbsenceRequestPeriods", IsNullable = false, Order = 0)]
    public List<AbsenceRequestPeriod> ExportedAbsenceRequestPeriods { get; set; }
  }
}
