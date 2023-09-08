
//.ExportJobHourlyRateAssignmentsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobHourlyRateAssignmentsList")]
  public class ExportJobHourlyRateAssignmentsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedJobHourlyRateAssignment> ExportFilter { get; set; }
  }
}
