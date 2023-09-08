
//.ExportAddDeductWindowsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAddDeductWindowsListResponse")]
  public class ExportAddDeductWindowsListResponse
  {
    [XmlArray(ElementName = "exportedAddDeductWindows", IsNullable = false, Order = 0)]
    public List<AddDeductWindow> ExportedAddDeductWindows { get; set; }
  }
}
