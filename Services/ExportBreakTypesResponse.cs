
//.ExportBreakTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBreakTypesResponse")]
  public class ExportBreakTypesResponse
  {
    [XmlArray(ElementName = "exportedBreakTypes", IsNullable = false, Order = 0)]
    public List<AccountType> ExportedBreakTypes { get; set; }
  }
}
