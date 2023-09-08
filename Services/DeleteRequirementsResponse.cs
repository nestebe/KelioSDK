
//.DeleteRequirementsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteRequirementsResponse")]
  public class DeleteRequirementsResponse
  {
    [XmlArray(ElementName = "requirementsInError", IsNullable = false, Order = 0)]
    public List<Requirement> RequirementsInError { get; set; }
  }
}
