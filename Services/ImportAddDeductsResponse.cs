
//.ImportAddDeductsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAddDeductsResponse")]
  public class ImportAddDeductsResponse
  {
    [XmlArray(ElementName = "addDeductsInError", IsNullable = false, Order = 0)]
    public List<AddDeduct> AddDeductsInError { get; set; }
  }
}
