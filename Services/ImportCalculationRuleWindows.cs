
//.ImportCalculationRuleWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCalculationRuleWindows")]
  public class ImportCalculationRuleWindows
  {
    [XmlArray(ElementName = "calculationRuleWindowsToImport", IsNullable = false, Order = 0)]
    public List<CalculationRuleWindow> CalculationRuleWindowsToImport { get; set; }
  }
}
