
// Type: KelioSDK.Models.EmployeeTrainingAndCareerData




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeTrainingAndCareerData")]
  public class EmployeeTrainingAndCareerData : EmployeeInformationAndCriterion
  {
    [XmlElement(DataType = "string", ElementName = "educationLevelDescription", IsNullable = true)]
    public string EducationLevelDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "educationLevelCode", IsNullable = true)]
    public string EducationLevelCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "nextProfessionalInterviewDate", IsNullable = true)]
    public DateTime? NextProfessionalInterviewDate { get; set; }
  }
}
