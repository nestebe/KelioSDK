
// Type: KelioSDK.Models.EndOfPeriodDate




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EndOfPeriodDate")]
  public class EndOfPeriodDate : ObjectBase
  {
    [XmlElement(DataType = "date", ElementName = "endOfPeriodDate", IsNullable = true)]
    public DateTime? EndOfPeriodDateProperty { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "blockModificationsForUsersWithoutRights", IsNullable = true)]
    public bool? BlockModificationsForUsersWithoutRights { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "resetAnnualisedOvertime", IsNullable = true)]
    public bool? ResetAnnualisedOvertime { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "dateIsEndOfPeriod", IsNullable = true)]
    public bool? DateIsEndOfPeriod { get; set; }

    [XmlElement(DataType = "string", ElementName = "endOfPeriodCalendarDescription", IsNullable = true)]
    public string EndOfPeriodCalendarDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOfPeriodCalendarKey", IsNullable = true)]
    public int? EndOfPeriodCalendarKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "resetBalance", IsNullable = true)]
    public bool? ResetBalance { get; set; }

    [XmlElement(DataType = "int", ElementName = "endOfPeriodDateKey", IsNullable = true)]
    public int? EndOfPeriodDateKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "lockResults", IsNullable = true)]
    public bool? LockResults { get; set; }

    [XmlElement(DataType = "string", ElementName = "endOfPeriodComment", IsNullable = true)]
    public string EndOfPeriodComment { get; set; }
  }
}
