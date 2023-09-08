
//.ImportCoefficientAssignments




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCoefficientAssignments")]
  public class ImportCoefficientAssignments
  {
    [XmlArray(ElementName = "coefficientAssignmentsToImport", IsNullable = false, Order = 0)]
    public List<CoefficientAssignment> CoefficientAssignmentsToImport { get; set; }
  }
}
