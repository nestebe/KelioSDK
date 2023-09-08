
//.ImportEmploymentContractNature




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmploymentContractNature")]
  public class ImportEmploymentContractNature
  {
    [XmlArray(ElementName = "employmentContractNatureToImport", IsNullable = false, Order = 0)]
    public List<ContractNature> EmploymentContractNatureToImport { get; set; }
  }
}
