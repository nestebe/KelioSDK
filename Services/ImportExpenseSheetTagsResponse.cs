
//.ImportExpenseSheetTagsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importExpenseSheetTagsResponse")]
  public class ImportExpenseSheetTagsResponse
  {
    [XmlArray(ElementName = "expenseSheetTagsInError", IsNullable = false, Order = 0)]
    public List<ExpenseSheetTag> ExpenseSheetTagsInError { get; set; }
  }
}
