
//.ImportHomepageFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHomepageFilingResponse")]
  public class ImportHomepageFilingResponse
  {
    [XmlArray(ElementName = "homepageFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> HomepageFilingInError { get; set; }
  }
}
