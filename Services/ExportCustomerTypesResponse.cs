
//.ExportCustomerTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCustomerTypesResponse")]
  public class ExportCustomerTypesResponse
  {
    [XmlArray(ElementName = "exportedCustomerTypes", IsNullable = false, Order = 0)]
    public List<CustomerType> ExportedCustomerTypes { get; set; }
  }
}
