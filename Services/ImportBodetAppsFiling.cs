
//.ImportBodetAppsFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBodetAppsFiling")]
  public class ImportBodetAppsFiling
  {
    [XmlArray(ElementName = "bodetAppsFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> BodetAppsFilingToImport { get; set; }
  }
}
