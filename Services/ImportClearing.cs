
//.ImportClearing




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importClearing")]
  public class ImportClearing
  {
    [XmlArray(ElementName = "clearingToImport", IsNullable = false, Order = 0)]
    public List<Clearing> ClearingToImport { get; set; }
  }
}
