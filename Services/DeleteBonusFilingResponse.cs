
//.DeleteBonusFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteBonusFilingResponse")]
  public class DeleteBonusFilingResponse
  {
    [XmlArray(ElementName = "bonusFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> BonusFilingInError { get; set; }
  }
}
