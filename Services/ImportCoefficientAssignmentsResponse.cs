
//.ImportCoefficientAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCoefficientAssignmentsResponse")]
  public class ImportCoefficientAssignmentsResponse
  {
    [XmlArray(ElementName = "coefficientAssignmentsInError", IsNullable = false, Order = 0)]
    public List<CoefficientAssignment> CoefficientAssignmentsInError { get; set; }
  }
}
