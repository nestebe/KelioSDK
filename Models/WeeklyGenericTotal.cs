
// Type: KelioSDK.Models.WeeklyGenericTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "WeeklyGenericTotal")]
  public class WeeklyGenericTotal : AbstractWeeklyTotal
  {
    [XmlElement(DataType = "string", ElementName = "type", IsNullable = true)]
    public string Type { get; set; }

    [XmlElement(DataType = "string", ElementName = "unit", IsNullable = true)]
    public string Unit { get; set; }

    [XmlElement(DataType = "double", ElementName = "secondValue", IsNullable = true)]
    public double? SecondValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "firstValue", IsNullable = true)]
    public double? FirstValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "fourthValue", IsNullable = true)]
    public double? FourthValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "thirdValue", IsNullable = true)]
    public double? ThirdValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "fifthValue", IsNullable = true)]
    public double? FifthValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "sixthValue", IsNullable = true)]
    public double? SixthValue { get; set; }
  }
}
