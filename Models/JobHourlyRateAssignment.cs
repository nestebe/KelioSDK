
// Type: KelioSDK.Models.JobHourlyRateAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "JobHourlyRateAssignment")]
  public class JobHourlyRateAssignment : Type
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "assignmentKey", IsNullable = true)]
    public int? AssignmentKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyRateDescription", IsNullable = true)]
    public string HourlyRateDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "hourlyRateKey", IsNullable = true)]
    public int? HourlyRateKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyRateAbbreviation", IsNullable = true)]
    public string HourlyRateAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "code", IsNullable = true)]
    public string Code { get; set; }
  }
}
