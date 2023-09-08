
//.ExportCalculationFunctionExecutionsList




using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCalculationFunctionExecutionsList")]
  public class ExportCalculationFunctionExecutionsList
  {
    [XmlArray(ElementName = "calculationFunctionFilter", IsNullable = false, Order = 0)]
    public List<KelioSDK.Models.CalculationFunctionFilter> CalculationFunctionFilter { get; set; }
  }
}
