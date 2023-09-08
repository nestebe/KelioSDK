
//.ImportWorkbooksResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importWorkbooksResponse")]
  public class ImportWorkbooksResponse
  {
    [XmlArray(ElementName = "workbooksInError", IsNullable = false, Order = 0)]
    public List<Workbook> WorkbooksInError { get; set; }
  }
}
