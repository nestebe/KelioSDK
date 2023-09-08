
//.ExportOvertimeHourTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOvertimeHourTypesResponse")]
  public class ExportOvertimeHourTypesResponse
  {
    [XmlArray(ElementName = "exportedOvertimeHourTypes", IsNullable = false, Order = 0)]
    public List<OvertimeHourType> ExportedOvertimeHourTypes { get; set; }
  }
}
