
//.ImportCoefficients




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCoefficients")]
  public class ImportCoefficients
  {
    [XmlArray(ElementName = "coefficientsToImport", IsNullable = false, Order = 0)]
    public List<Coefficient> CoefficientsToImport { get; set; }
  }
}
