
// Type: KelioSDK.Models.AbstractTransferFile




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbstractTransferFile")]
  public class AbstractTransferFile : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "double", ElementName = "days", IsNullable = true)]
    public double? Days { get; set; }

    [XmlElement(DataType = "double", ElementName = "hours", IsNullable = true)]
    public double? Hours { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isWeekly", IsNullable = true)]
    public bool? IsWeekly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isCyclical", IsNullable = true)]
    public bool? IsCyclical { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isTotal", IsNullable = true)]
    public bool? IsTotal { get; set; }

    [XmlElement(DataType = "string", ElementName = "accountDescription", IsNullable = true)]
    public string AccountDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "accountAbbreviation", IsNullable = true)]
    public string AccountAbbreviation { get; set; }

    [XmlElement(DataType = "short", ElementName = "accountType", IsNullable = true)]
    public short? AccountType { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isDayly", IsNullable = true)]
    public bool? IsDayly { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isPeriodical", IsNullable = true)]
    public bool? IsPeriodical { get; set; }
  }
}
