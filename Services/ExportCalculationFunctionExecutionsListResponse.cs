
//.ExportCalculationFunctionExecutionsListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCalculationFunctionExecutionsListResponse")]
  public class ExportCalculationFunctionExecutionsListResponse
  {
    [XmlArray(ElementName = "exportedCalculationFunctionExecutions", IsNullable = false, Order = 0)]
    public List<CalculatingFunction> ExportedCalculationFunctionExecutions { get; set; }
  }
}
