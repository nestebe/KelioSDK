
//.ImportRequirements




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importRequirements")]
  public class ImportRequirements
  {
    [XmlArray(ElementName = "requirementsToImport", IsNullable = false, Order = 0)]
    public List<Requirement> RequirementsToImport { get; set; }
  }
}
