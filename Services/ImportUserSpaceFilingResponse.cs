
//.ImportUserSpaceFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importUserSpaceFilingResponse")]
  public class ImportUserSpaceFilingResponse
  {
    [XmlArray(ElementName = "userSpaceFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> UserSpaceFilingInError { get; set; }
  }
}
