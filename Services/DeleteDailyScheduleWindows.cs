
//.DeleteDailyScheduleWindows




using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteDailyScheduleWindows")]
  public class DeleteDailyScheduleWindows
  {
    [XmlElement(DataType = "string", ElementName = "dailyScheduleAbbreviation", IsNullable = true, Order = 0)]
    public string DailyScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "dailyScheduleDescription", IsNullable = true, Order = 1)]
    public string DailyScheduleDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "windowType", IsNullable = true, Order = 2)]
    public int? WindowType { get; set; }

    [XmlElement(DataType = "int", ElementName = "windowIndex", IsNullable = true, Order = 3)]
    public int? WindowIndex { get; set; }
  }
}
