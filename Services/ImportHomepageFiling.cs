
//.ImportHomepageFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importHomepageFiling")]
  public class ImportHomepageFiling
  {
    [XmlArray(ElementName = "homepageFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> HomepageFilingToImport { get; set; }
  }
}
