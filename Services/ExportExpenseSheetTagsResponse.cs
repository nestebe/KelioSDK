
//.ExportExpenseSheetTagsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportExpenseSheetTagsResponse")]
  public class ExportExpenseSheetTagsResponse
  {
    [XmlArray(ElementName = "exportedExpenseSheetTags", IsNullable = false, Order = 0)]
    public List<ExpenseSheetTag> ExportedExpenseSheetTags { get; set; }
  }
}
