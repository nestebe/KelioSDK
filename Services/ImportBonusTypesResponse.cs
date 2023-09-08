
//.ImportBonusTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBonusTypesResponse")]
  public class ImportBonusTypesResponse
  {
    [XmlArray(ElementName = "bonusTypesInError", IsNullable = false, Order = 0)]
    public List<BonusType> BonusTypesInError { get; set; }
  }
}
