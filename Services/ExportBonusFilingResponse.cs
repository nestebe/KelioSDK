
//.ExportBonusFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBonusFilingResponse")]
  public class ExportBonusFilingResponse
  {
    [XmlArray(ElementName = "exportedBonusFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedBonusFiling { get; set; }
  }
}
