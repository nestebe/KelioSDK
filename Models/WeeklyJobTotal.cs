
// Type: KelioSDK.Models.WeeklyJobTotal




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "WeeklyJobTotal")]
  public class WeeklyJobTotal : AbstractJobTotal
  {
    [XmlElement(DataType = "double", ElementName = "cost", IsNullable = true)]
    public double? Cost { get; set; }

    [XmlElement(DataType = "double", ElementName = "days", IsNullable = true)]
    public double? Days { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }
  }
}
