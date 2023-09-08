
//.ImportExpenseSheetTags




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importExpenseSheetTags")]
  public class ImportExpenseSheetTags
  {
    [XmlArray(ElementName = "expenseSheetTagsToImport", IsNullable = false, Order = 0)]
    public List<ExpenseSheetTag> ExpenseSheetTagsToImport { get; set; }
  }
}
