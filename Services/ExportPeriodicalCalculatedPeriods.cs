
//.ExportPeriodicalCalculatedPeriods




using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPeriodicalCalculatedPeriods")]
  public class ExportPeriodicalCalculatedPeriods
  {
    [XmlArray(ElementName = "calculatedPeriodFilter", IsNullable = false, Order = 0)]
    public List<KelioSDK.Models.CalculatedPeriodFilter> CalculatedPeriodFilter { get; set; }
  }
}
