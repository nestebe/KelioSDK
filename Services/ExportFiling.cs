
//.ExportFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportFiling")]
  public class ExportFiling
  {
    [XmlArray(ElementName = "filterList", IsNullable = false, Order = 0)]
    public List<AskedFiling> FilterList { get; set; }
  }
}
