
//.ImportCalculationSetupFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCalculationSetupFilingResponse")]
  public class ImportCalculationSetupFilingResponse
  {
    [XmlArray(ElementName = "calculationSetupFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> CalculationSetupFilingInError { get; set; }
  }
}
