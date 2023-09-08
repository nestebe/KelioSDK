
//.ExportCustomerHourlyRateAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCustomerHourlyRateAssignmentsListResponse")]
  public class ExportCustomerHourlyRateAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedCustomerHourlyRateAssignments", IsNullable = false, Order = 0)]
    public List<CustomerHourlyRateAssignment> ExportedCustomerHourlyRateAssignments { get; set; }
  }
}
