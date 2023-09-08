
//.ImportUserSpaceFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importUserSpaceFiling")]
  public class ImportUserSpaceFiling
  {
    [XmlArray(ElementName = "userSpaceFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> UserSpaceFilingToImport { get; set; }
  }
}
