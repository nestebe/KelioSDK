
//.ImportCustomerHourlyRateAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCustomerHourlyRateAssignments")]
  public class ImportCustomerHourlyRateAssignments
  {
    [XmlArray(ElementName = "customerHourlyRateAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<CustomerHourlyRateAssignment> CustomerHourlyRateAssignmentsToImport { get; set; }
  }
}
