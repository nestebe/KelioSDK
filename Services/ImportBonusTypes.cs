
//.ImportBonusTypes




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBonusTypes")]
  public class ImportBonusTypes
  {
    [XmlArray(ElementName = "bonusTypesToImport", IsNullable = false, Order = 0)]
    public List<BonusType> BonusTypesToImport { get; set; }
  }
}
