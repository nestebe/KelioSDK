
//.ExportBalanceTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBalanceTypesResponse")]
  public class ExportBalanceTypesResponse
  {
    [XmlArray(ElementName = "exportedBalanceTypes", IsNullable = false, Order = 0)]
    public List<BalanceType> ExportedBalanceTypes { get; set; }
  }
}
