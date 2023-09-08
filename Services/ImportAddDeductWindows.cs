
//.ImportAddDeductWindows




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAddDeductWindows")]
  public class ImportAddDeductWindows
  {
    [XmlArray(ElementName = "addDeductWindowsToImport", IsNullable = false, Order = 0)]
    public List<AddDeductWindow> AddDeductWindowsToImport { get; set; }
  }
}
