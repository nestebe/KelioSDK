
//.ExportEmploymentContractNatureResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmploymentContractNatureResponse")]
  public class ExportEmploymentContractNatureResponse
  {
    [XmlArray(ElementName = "exportedEmploymentContractNature", IsNullable = false, Order = 0)]
    public List<ContractNature> ExportedEmploymentContractNature { get; set; }
  }
}
