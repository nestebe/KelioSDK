
// Type: KelioSDK.Models.ExpenseSheetTag




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ExpenseSheetTag")]
  public class ExpenseSheetTag : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "expenseSheetTagKey", IsNullable = true)]
    public int? ExpenseSheetTagKey { get; set; }

    [XmlElement(DataType = "date", ElementName = "expenseSheetTagDate", IsNullable = true)]
    public DateTime? ExpenseSheetTagDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "expenseSheetTagExportDate", IsNullable = true)]
    public DateTime? ExpenseSheetTagExportDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "expenseSheetTagDescription", IsNullable = true)]
    public string ExpenseSheetTagDescription { get; set; }
  }
}
