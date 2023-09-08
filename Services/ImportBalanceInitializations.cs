
//.ImportBalanceInitializations




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBalanceInitializations")]
  public class ImportBalanceInitializations
  {
    [XmlArray(ElementName = "balanceInitializationsToImport", IsNullable = false, Order = 0)]
    public List<AbsenceBalanceInitialization> BalanceInitializationsToImport { get; set; }
  }
}
