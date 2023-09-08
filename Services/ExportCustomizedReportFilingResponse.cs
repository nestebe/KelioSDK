
//.ExportCustomizedReportFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportCustomizedReportFilingResponse")]
  public class ExportCustomizedReportFilingResponse
  {
    [XmlArray(ElementName = "exportedCustomizedReportFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedCustomizedReportFiling { get; set; }
  }
}
