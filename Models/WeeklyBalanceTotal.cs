
// Type: KelioSDK.Models.WeeklyBalanceTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "WeeklyBalanceTotal")]
  public class WeeklyBalanceTotal : AbstractWeeklyTotal
  {
    [XmlElement(DataType = "double", ElementName = "start", IsNullable = true)]
    public double? Start { get; set; }

    [XmlElement(DataType = "double", ElementName = "end", IsNullable = true)]
    public double? End { get; set; }

    [XmlElement(DataType = "double", ElementName = "limitation", IsNullable = true)]
    public double? Limitation { get; set; }

    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }

    [XmlElement(DataType = "double", ElementName = "limitationOnTotal", IsNullable = true)]
    public double? LimitationOnTotal { get; set; }

    [XmlElement(DataType = "double", ElementName = "toBeTransferred", IsNullable = true)]
    public double? ToBeTransferred { get; set; }
  }
}
