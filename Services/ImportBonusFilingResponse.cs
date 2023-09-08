
//.ImportBonusFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importBonusFilingResponse")]
  public class ImportBonusFilingResponse
  {
    [XmlArray(ElementName = "bonusFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> BonusFilingInError { get; set; }
  }
}
