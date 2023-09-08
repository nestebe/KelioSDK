
// Type: KelioSDK.Models.EmployeeHourlyRateAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeHourlyRateAssignment")]
  public class EmployeeHourlyRateAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "startOffset", IsNullable = true)]
    public int? StartOffset { get; set; }

    [XmlElement(DataType = "int", ElementName = "assignmentKey", IsNullable = true)]
    public int? AssignmentKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyRateDescription", IsNullable = true)]
    public string HourlyRateDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "hourlyRateKey", IsNullable = true)]
    public int? HourlyRateKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyRateAbbreviation", IsNullable = true)]
    public string HourlyRateAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "dateMode", IsNullable = true)]
    public int? DateMode { get; set; }
  }
}
