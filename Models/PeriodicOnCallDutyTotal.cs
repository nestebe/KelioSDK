
// Type: KelioSDK.Models.PeriodicOnCallDutyTotal




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "PeriodicOnCallDutyTotal")]
  public class PeriodicOnCallDutyTotal : AbstractPeriodicTotal
  {
    [XmlElement(DataType = "double", ElementName = "days", IsNullable = true)]
    public double? Days { get; set; }

    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }

    [XmlElement(DataType = "double", ElementName = "transferCount", IsNullable = true)]
    public double? TransferCount { get; set; }

    [XmlElement(DataType = "double", ElementName = "workingTime", IsNullable = true)]
    public double? WorkingTime { get; set; }
  }
}
