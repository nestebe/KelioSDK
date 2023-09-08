
//.ImportOvertimeHourFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOvertimeHourFilingResponse")]
  public class ImportOvertimeHourFilingResponse
  {
    [XmlArray(ElementName = "overtimeHourFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> OvertimeHourFilingInError { get; set; }
  }
}
