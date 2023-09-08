
//.ImportSpecialHourFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSpecialHourFiling")]
  public class ImportSpecialHourFiling
  {
    [XmlArray(ElementName = "specialHourFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> SpecialHourFilingToImport { get; set; }
  }
}
