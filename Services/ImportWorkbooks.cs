
//.ImportWorkbooks




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importWorkbooks")]
  public class ImportWorkbooks
  {
    [XmlArray(ElementName = "workbooksToImport", IsNullable = false, Order = 0)]
    public List<Workbook> WorkbooksToImport { get; set; }
  }
}
