
//.ExportAccountInitializationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAccountInitializationsResponse")]
  public class ExportAccountInitializationsResponse
  {
    [XmlArray(ElementName = "exportedAccountInitializations", IsNullable = false, Order = 0)]
    public List<AccountInitialization> ExportedAccountInitializations { get; set; }
  }
}
