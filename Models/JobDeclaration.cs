
// Type: KelioSDK.Models.JobDeclaration




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "JobDeclaration")]
  public class JobDeclaration : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlElement(DataType = "int", ElementName = "jobDeclarationKey", IsNullable = true)]
    public int? JobDeclarationKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "userApproval", IsNullable = true)]
    public bool? UserApproval { get; set; }
  }
}
