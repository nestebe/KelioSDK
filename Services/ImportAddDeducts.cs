
//.ImportAddDeducts




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAddDeducts")]
  public class ImportAddDeducts
  {
    [XmlArray(ElementName = "addDeductsToImport", IsNullable = false, Order = 0)]
    public List<AddDeduct> AddDeductsToImport { get; set; }
  }
}
