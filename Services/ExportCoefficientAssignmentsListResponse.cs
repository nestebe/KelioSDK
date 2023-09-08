
//.ExportCoefficientAssignmentsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCoefficientAssignmentsListResponse")]
  public class ExportCoefficientAssignmentsListResponse
  {
    [XmlArray(ElementName = "exportedCoefficientAssignments", IsNullable = false, Order = 0)]
    public List<CoefficientAssignment> ExportedCoefficientAssignments { get; set; }
  }
}
