
//.ExportWorkbooksResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportWorkbooksResponse")]
  public class ExportWorkbooksResponse
  {
    [XmlArray(ElementName = "exportedWorkbooks", IsNullable = false, Order = 0)]
    public List<Workbook> ExportedWorkbooks { get; set; }
  }
}
