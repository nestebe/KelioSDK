
//.ImportOvertimeHourFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOvertimeHourFiling")]
  public class ImportOvertimeHourFiling
  {
    [XmlArray(ElementName = "overtimeHourFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> OvertimeHourFilingToImport { get; set; }
  }
}
