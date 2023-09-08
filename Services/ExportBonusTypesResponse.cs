
//.ExportBonusTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBonusTypesResponse")]
  public class ExportBonusTypesResponse
  {
    [XmlArray(ElementName = "exportedBonusTypes", IsNullable = false, Order = 0)]
    public List<BonusType> ExportedBonusTypes { get; set; }
  }
}
