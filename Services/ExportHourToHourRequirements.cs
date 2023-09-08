
//.ExportHourToHourRequirements




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourToHourRequirements")]
  public class ExportHourToHourRequirements
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedRequirements> ExportFilter { get; set; }
  }
}
