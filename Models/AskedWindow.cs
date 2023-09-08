
// Type: KelioSDK.Models.AskedWindow




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedWindow")]
  public class AskedWindow : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "dailyScheduleAbbreviation", IsNullable = true)]
    public string DailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "dailyScheduleDescription", IsNullable = true)]
    public string DailyScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "windowIndex", IsNullable = true)]
    public int? WindowIndex { get; set; }
  }
}
