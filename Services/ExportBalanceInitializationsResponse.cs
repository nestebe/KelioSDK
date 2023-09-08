
//.ExportBalanceInitializationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBalanceInitializationsResponse")]
  public class ExportBalanceInitializationsResponse
  {
    [XmlArray(ElementName = "exportedBalanceInitializations", IsNullable = false, Order = 0)]
    public List<AbsenceBalanceInitialization> ExportedBalanceInitializations { get; set; }
  }
}
