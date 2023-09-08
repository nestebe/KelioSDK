
//.ExportAddDeductsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAddDeductsListResponse")]
  public class ExportAddDeductsListResponse
  {
    [XmlArray(ElementName = "exportedAddDeducts", IsNullable = false, Order = 0)]
    public List<AddDeduct> ExportedAddDeducts { get; set; }
  }
}
