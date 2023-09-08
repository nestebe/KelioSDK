
//.ImportRequirementsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importRequirementsResponse")]
  public class ImportRequirementsResponse
  {
    [XmlArray(ElementName = "requirementsInError", IsNullable = false, Order = 0)]
    public List<Requirement> RequirementsInError { get; set; }
  }
}
