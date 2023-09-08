
//.ImportCustomizedReportFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCustomizedReportFiling")]
  public class ImportCustomizedReportFiling
  {
    [XmlArray(ElementName = "customizedReportFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> CustomizedReportFilingToImport { get; set; }
  }
}
