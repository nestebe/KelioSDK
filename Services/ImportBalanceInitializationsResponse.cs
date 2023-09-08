
//.ImportBalanceInitializationsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBalanceInitializationsResponse")]
  public class ImportBalanceInitializationsResponse
  {
    [XmlArray(ElementName = "balanceInitializationsInError", IsNullable = false, Order = 0)]
    public List<AbsenceBalanceInitialization> BalanceInitializationsInError { get; set; }
  }
}
