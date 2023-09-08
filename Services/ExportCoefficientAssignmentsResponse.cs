
//.ExportCoefficientAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCoefficientAssignmentsResponse")]
  public class ExportCoefficientAssignmentsResponse
  {
    [XmlArray(ElementName = "exportedCoefficientAssignments", IsNullable = false, Order = 0)]
    public List<CoefficientAssignment> ExportedCoefficientAssignments { get; set; }
  }
}
