
//.DeleteCalculationSetupFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteCalculationSetupFiling")]
  public class DeleteCalculationSetupFiling
  {
    [XmlArray(ElementName = "calculationSetupFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> CalculationSetupFilingToDelete { get; set; }
  }
}
