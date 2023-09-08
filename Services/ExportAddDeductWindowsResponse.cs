
//.ExportAddDeductWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAddDeductWindowsResponse")]
  public class ExportAddDeductWindowsResponse
  {
    [XmlArray(ElementName = "exportedAddDeductWindows", IsNullable = false, Order = 0)]
    public List<AddDeductWindow> ExportedAddDeductWindows { get; set; }
  }
}
