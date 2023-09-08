
// Type: KelioSDK.Models.SectionAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "SectionAssignment")]
  public class SectionAssignment : AbstractSectionAssignment
  {
    [XmlElement(DataType = "date", ElementName = "assignmentEndDate", IsNullable = true)]
    public DateTime? AssignmentEndDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "sectionAssignmentKey", IsNullable = true)]
    public int? SectionAssignmentKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "assignmentStartDate", IsNullable = true)]
    public DateTime? AssignmentStartDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "userProfileAssignmentWizardKey", IsNullable = true)]
    public int? UserProfileAssignmentWizardKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "userProfileAssignmentWizardDescription", IsNullable = true)]
    public string UserProfileAssignmentWizardDescription { get; set; }
  }
}
