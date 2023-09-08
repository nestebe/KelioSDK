
//.ImportCustomizedReportFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importCustomizedReportFilingResponse")]
  public class ImportCustomizedReportFilingResponse
  {
    [XmlArray(ElementName = "customizedReportFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> CustomizedReportFilingInError { get; set; }
  }
}
