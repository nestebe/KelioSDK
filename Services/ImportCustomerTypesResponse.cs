
//.ImportCustomerTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCustomerTypesResponse")]
  public class ImportCustomerTypesResponse
  {
    [XmlArray(ElementName = "customerTypesInError", IsNullable = false, Order = 0)]
    public List<CustomerType> CustomerTypesInError { get; set; }
  }
}
