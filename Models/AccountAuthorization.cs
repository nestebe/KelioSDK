
// Type: KelioSDK.Models.AccountAuthorization




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccountAuthorization")]
  public class AccountAuthorization : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "duplicatePreviousAssignment", IsNullable = true)]
    public bool? DuplicatePreviousAssignment { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedAccountAssignmentEndDate", IsNullable = true)]
    public DateTime? AuthorisedAccountAssignmentEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "authorisedAccountAssignmentStartDate", IsNullable = true)]
    public DateTime? AuthorisedAccountAssignmentStartDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeDescription", IsNullable = true)]
    public string TypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "typeAbbreviation", IsNullable = true)]
    public string TypeAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "typeKey", IsNullable = true)]
    public int? TypeKey { get; set; }
  }
}
