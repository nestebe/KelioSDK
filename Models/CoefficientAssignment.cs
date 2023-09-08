
// Type: KelioSDK.Models.CoefficientAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "CoefficientAssignment")]
  public class CoefficientAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "coefficientAssignmentKey", IsNullable = true)]
    public int? CoefficientAssignmentKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "coefficientAssignmentEndDate", IsNullable = true)]
    public DateTime? CoefficientAssignmentEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalStatusDescription", IsNullable = true)]
    public string ProfessionalStatusDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobPositionDescription", IsNullable = true)]
    public string JobPositionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalStatusCode", IsNullable = true)]
    public string ProfessionalStatusCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "coefficientAssignmentStartDate", IsNullable = true)]
    public DateTime? CoefficientAssignmentStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "CoefficientCode", IsNullable = true)]
    public string CoefficientCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobPositionCode", IsNullable = true)]
    public string JobPositionCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "qualificationCode", IsNullable = true)]
    public string QualificationCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "CoefficientDescription", IsNullable = true)]
    public string CoefficientDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "qualificationDescription", IsNullable = true)]
    public string QualificationDescription { get; set; }
  }
}
