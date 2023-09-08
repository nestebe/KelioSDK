
//.ExportCoefficientsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCoefficientsResponse")]
  public class ExportCoefficientsResponse
  {
    [XmlArray(ElementName = "exportedCoefficients", IsNullable = false, Order = 0)]
    public List<Coefficient> ExportedCoefficients { get; set; }
  }
}
