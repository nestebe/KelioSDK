
//.ImportEmploymentContractNatureResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmploymentContractNatureResponse")]
  public class ImportEmploymentContractNatureResponse
  {
    [XmlArray(ElementName = "employmentContractNatureInError", IsNullable = false, Order = 0)]
    public List<ContractNature> EmploymentContractNatureInError { get; set; }
  }
}
