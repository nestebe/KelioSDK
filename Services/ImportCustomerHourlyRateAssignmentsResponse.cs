
//.ImportCustomerHourlyRateAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCustomerHourlyRateAssignmentsResponse")]
  public class ImportCustomerHourlyRateAssignmentsResponse
  {
    [XmlArray(ElementName = "customerHourlyRateAssignmentsInError", IsNullable = false, Order = 0)]
    public List<CustomerHourlyRateAssignment> CustomerHourlyRateAssignmentsInError { get; set; }
  }
}
