
//.ExportClockingAllowanceWindowsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportClockingAllowanceWindowsList")]
  public class ExportClockingAllowanceWindowsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedWindow> ExportFilter { get; set; }
  }
}
