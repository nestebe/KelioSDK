
// Type: KelioSDK.Models.HourlyRate




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "HourlyRate")]
  public class HourlyRate : ObjectBase
  {
    [XmlElement(DataType = "date", ElementName = "hourlyRateApplicationDate", IsNullable = true)]
    public DateTime? HourlyRateApplicationDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "hourlyRateValue", IsNullable = true)]
    public double? HourlyRateValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyRateDescription", IsNullable = true)]
    public string HourlyRateDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "hourlyRateKey", IsNullable = true)]
    public int? HourlyRateKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyRateAbbreviation", IsNullable = true)]
    public string HourlyRateAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "hourlyRateValueKey", IsNullable = true)]
    public int? HourlyRateValueKey { get; set; }
  }
}
