
//.ImportSpecialHourFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSpecialHourFilingResponse")]
  public class ImportSpecialHourFilingResponse
  {
    [XmlArray(ElementName = "specialHourFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> SpecialHourFilingInError { get; set; }
  }
}
