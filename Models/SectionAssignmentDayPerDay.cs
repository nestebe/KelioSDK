
// Type: KelioSDK.Models.SectionAssignmentDayPerDay




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "SectionAssignmentDayPerDay")]
  public class SectionAssignmentDayPerDay : AbstractSectionAssignment
  {
    [XmlElement(DataType = "date", ElementName = "applicationDate", IsNullable = true)]
    public DateTime? ApplicationDate { get; set; }
  }
}
