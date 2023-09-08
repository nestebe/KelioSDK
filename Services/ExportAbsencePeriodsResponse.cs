
//.ExportAbsencePeriodsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsencePeriodsResponse")]
  public class ExportAbsencePeriodsResponse
  {
    [XmlArray(ElementName = "exportedAbsencePeriods", IsNullable = false, Order = 0)]
    public List<AbsencePeriod> ExportedAbsencePeriods { get; set; }
  }
}
