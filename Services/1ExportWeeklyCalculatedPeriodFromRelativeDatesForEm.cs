
//.ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeListResponse")]
  public class ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedWeeklyCalculatedPeriods", IsNullable = false, Order = 0)]
    public List<CalculatedPeriod> ExportedWeeklyCalculatedPeriods { get; set; }
  }
}
