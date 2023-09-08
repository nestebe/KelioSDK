
//.DeleteOvertimeHourFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteOvertimeHourFilingResponse")]
  public class DeleteOvertimeHourFilingResponse
  {
    [XmlArray(ElementName = "overtimeHourFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> OvertimeHourFilingInError { get; set; }
  }
}
