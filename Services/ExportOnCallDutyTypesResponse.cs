
//.ExportOnCallDutyTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportOnCallDutyTypesResponse")]
  public class ExportOnCallDutyTypesResponse
  {
    [XmlArray(ElementName = "exportedOnCallDutyTypes", IsNullable = false, Order = 0)]
    public List<OnCallDutyType> ExportedOnCallDutyTypes { get; set; }
  }
}
