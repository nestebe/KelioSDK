
//.ExportCalculationSetupFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCalculationSetupFilingResponse")]
  public class ExportCalculationSetupFilingResponse
  {
    [XmlArray(ElementName = "exportedCalculationSetupFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedCalculationSetupFiling { get; set; }
  }
}
