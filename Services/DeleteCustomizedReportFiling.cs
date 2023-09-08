
//.DeleteCustomizedReportFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteCustomizedReportFiling")]
  public class DeleteCustomizedReportFiling
  {
    [XmlArray(ElementName = "customizedReportFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> CustomizedReportFilingToDelete { get; set; }
  }
}
