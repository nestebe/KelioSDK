
// Type: KelioSDK.Models.ScheduleAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ScheduleAssignment")]
  public class ScheduleAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "assignmentEndDate", IsNullable = true)]
    public DateTime? AssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentDate", IsNullable = true)]
    public DateTime? AssignmentDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "scheduleKey", IsNullable = true)]
    public int? ScheduleKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleAbbreviation", IsNullable = true)]
    public string ScheduleAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "shiftDescription", IsNullable = true)]
    public string ShiftDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "scheduleAssignmentKey", IsNullable = true)]
    public int? ScheduleAssignmentKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "scheduleDescription", IsNullable = true)]
    public string ScheduleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstWeekDescription", IsNullable = true)]
    public string FirstWeekDescription { get; set; }
  }
}
