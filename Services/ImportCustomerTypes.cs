
//.ImportCustomerTypes




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCustomerTypes")]
  public class ImportCustomerTypes
  {
    [XmlArray(ElementName = "customerTypesToImport", IsNullable = false, Order = 0)]
    public List<CustomerType> CustomerTypesToImport { get; set; }
  }
}
