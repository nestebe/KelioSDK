
// Type: KelioSDK.Models.AnnualizedHourSchedule




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AnnualizedHourSchedule")]
  public class AnnualizedHourSchedule : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "annualizedHourScheduleAbbreviation", IsNullable = true)]
    public string AnnualizedHourScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "annualizedHourScheduleDescription", IsNullable = true)]
    public string AnnualizedHourScheduleDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "annualizedHourScheduleContractedTimeCalculation", IsNullable = true)]
    public bool? AnnualizedHourScheduleContractedTimeCalculation { get; set; }

    [XmlElement(DataType = "int", ElementName = "annualizedHourScheduleKey", IsNullable = true)]
    public int? AnnualizedHourScheduleKey { get; set; }
  }
}
