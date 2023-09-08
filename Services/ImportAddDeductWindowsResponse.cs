
//.ImportAddDeductWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAddDeductWindowsResponse")]
  public class ImportAddDeductWindowsResponse
  {
    [XmlArray(ElementName = "addDeductWindowsInError", IsNullable = false, Order = 0)]
    public List<AddDeductWindow> AddDeductWindowsInError { get; set; }
  }
}
