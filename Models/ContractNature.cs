
// Type: KelioSDK.Models.ContractNature




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ContractNature")]
  public class ContractNature : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "employmentContractDescription", IsNullable = true)]
    public string EmploymentContractDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "employmentContractKey", IsNullable = true)]
    public int? EmploymentContractKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchEmploymentContractUsingAbbreviation", IsNullable = true)]
    public bool? SearchEmploymentContractUsingAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "employmentContractAbbreviation", IsNullable = true)]
    public string EmploymentContractAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchEmploymentContractUsingDescription", IsNullable = true)]
    public bool? SearchEmploymentContractUsingDescription { get; set; }
  }
}
