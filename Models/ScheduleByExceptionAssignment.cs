
// Type: KelioSDK.Models.ScheduleByExceptionAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ScheduleByExceptionAssignment")]
  public class ScheduleByExceptionAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "scheduleByExceptionAssignmentKey", IsNullable = true)]
    public int? ScheduleByExceptionAssignmentKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentEndDate", IsNullable = true)]
    public DateTime? AssignmentEndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "scheduleKey", IsNullable = true)]
    public int? ScheduleKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleAbbreviation", IsNullable = true)]
    public string ScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "shiftDescription", IsNullable = true)]
    public string ShiftDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentStartDate", IsNullable = true)]
    public DateTime? AssignmentStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstWeekDescription", IsNullable = true)]
    public string FirstWeekDescription { get; set; }
  }
}
