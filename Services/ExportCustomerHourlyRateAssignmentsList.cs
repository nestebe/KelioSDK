
//.ExportCustomerHourlyRateAssignmentsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCustomerHourlyRateAssignmentsList")]
  public class ExportCustomerHourlyRateAssignmentsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedCustomerHourlyRateAssignment> ExportFilter { get; set; }
  }
}
