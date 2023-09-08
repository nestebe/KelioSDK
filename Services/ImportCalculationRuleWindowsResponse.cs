
//.ImportCalculationRuleWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCalculationRuleWindowsResponse")]
  public class ImportCalculationRuleWindowsResponse
  {
    [XmlArray(ElementName = "calculationRuleWindowsInError", IsNullable = false, Order = 0)]
    public List<CalculationRuleWindow> CalculationRuleWindowsInError { get; set; }
  }
}
