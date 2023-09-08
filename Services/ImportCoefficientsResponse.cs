
//.ImportCoefficientsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCoefficientsResponse")]
  public class ImportCoefficientsResponse
  {
    [XmlArray(ElementName = "coefficientsInError", IsNullable = false, Order = 0)]
    public List<Coefficient> CoefficientsInError { get; set; }
  }
}
