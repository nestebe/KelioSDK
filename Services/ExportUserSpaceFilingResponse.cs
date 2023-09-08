
//.ExportUserSpaceFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportUserSpaceFilingResponse")]
  public class ExportUserSpaceFilingResponse
  {
    [XmlArray(ElementName = "exportedUserSpaceFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedUserSpaceFiling { get; set; }
  }
}
