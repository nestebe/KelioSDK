
//.ExportHourlyContractResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourlyContractResponse")]
  public class ExportHourlyContractResponse
  {
    [XmlArray(ElementName = "exportedHourlyContract", IsNullable = false, Order = 0)]
    public List<HourlyContract> ExportedHourlyContract { get; set; }
  }
}
