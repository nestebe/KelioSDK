
//.ImportBonusFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBonusFiling")]
  public class ImportBonusFiling
  {
    [XmlArray(ElementName = "bonusFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> BonusFilingToImport { get; set; }
  }
}
