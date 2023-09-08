
//.ExportWeeklyJobTotalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportWeeklyJobTotalsResponse")]
  public class ExportWeeklyJobTotalsResponse
  {
    [XmlArray(ElementName = "exportedWeeklyJobTotals", IsNullable = false, Order = 0)]
    public List<WeeklyJobTotal> ExportedWeeklyJobTotals { get; set; }
  }
}
