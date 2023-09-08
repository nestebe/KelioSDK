
//.ExportDailyScheduleAssignmentsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportDailyScheduleAssignmentsList")]
  public class ExportDailyScheduleAssignmentsList
  {
    [XmlArray(ElementName = "populationFilter", IsNullable = false, Order = 0)]
    public List<AskedPopulationWithPeriod> PopulationFilter { get; set; }
  }
}
