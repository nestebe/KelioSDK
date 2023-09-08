
//.DeleteBonusFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteBonusFiling")]
  public class DeleteBonusFiling
  {
    [XmlArray(ElementName = "bonusFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> BonusFilingToDelete { get; set; }
  }
}
