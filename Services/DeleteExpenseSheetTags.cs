
//.DeleteExpenseSheetTags




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteExpenseSheetTags")]
  public class DeleteExpenseSheetTags
  {
    [XmlArray(ElementName = "expenseSheetTagsToDelete", IsNullable = false, Order = 0)]
    public List<ExpenseSheetTag> ExpenseSheetTagsToDelete { get; set; }
  }
}
