
//.DeleteOvertimeHourFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteOvertimeHourFiling")]
  public class DeleteOvertimeHourFiling
  {
    [XmlArray(ElementName = "overtimeHourFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> OvertimeHourFilingToDelete { get; set; }
  }
}
