
//.ImportOvertimeHourTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importOvertimeHourTypesResponse")]
  public class ImportOvertimeHourTypesResponse
  {
    [XmlArray(ElementName = "overtimeHourTypesInError", IsNullable = false, Order = 0)]
    public List<OvertimeHourType> OvertimeHourTypesInError { get; set; }
  }
}
