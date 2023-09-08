
// Type: KelioSDK.Models.CalculationRuleWindow




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "CalculationRuleWindow")]
  public class CalculationRuleWindow : DailyScheduleWindow
  {
    [XmlElement(DataType = "int", ElementName = "ruleKey", IsNullable = true)]
    public int? RuleKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "ruleDescription", IsNullable = true)]
    public string RuleDescription { get; set; }
  }
}
