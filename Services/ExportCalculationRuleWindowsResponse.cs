
//.ExportCalculationRuleWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCalculationRuleWindowsResponse")]
  public class ExportCalculationRuleWindowsResponse
  {
    [XmlArray(ElementName = "exportedCalculationRuleWindows", IsNullable = false, Order = 0)]
    public List<CalculationRuleWindow> ExportedCalculationRuleWindows { get; set; }
  }
}
