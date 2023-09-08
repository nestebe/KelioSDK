
//.DeleteWorkbooks




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteWorkbooks")]
  public class DeleteWorkbooks
  {
    [XmlArray(ElementName = "workbooksToDelete", IsNullable = false, Order = 0)]
    public List<Workbook> WorkbooksToDelete { get; set; }
  }
}
