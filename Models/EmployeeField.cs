
// Type: KelioSDK.Models.EmployeeField




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeField")]
  public class EmployeeField : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "employeeFieldDataAbbreviation", IsNullable = true)]
    public string EmployeeFieldDataAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "employeeFieldKey", IsNullable = true)]
    public int? EmployeeFieldKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingEmployeeFieldAbbreviation", IsNullable = true)]
    public bool? SearchUsingEmployeeFieldAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFieldAbbreviation", IsNullable = true)]
    public string EmployeeFieldAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "searchUsingEmployeeFieldValue", IsNullable = true)]
    public bool? SearchUsingEmployeeFieldValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFieldValue", IsNullable = true)]
    public string EmployeeFieldValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFieldComment", IsNullable = true)]
    public string EmployeeFieldComment { get; set; }

    [XmlElement(DataType = "int", ElementName = "fieldValueKey", IsNullable = true)]
    public int? FieldValueKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeFieldDescription", IsNullable = true)]
    public string EmployeeFieldDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isJobCostingField", IsNullable = true)]
    public bool? IsJobCostingField { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isTandAField", IsNullable = true)]
    public bool? IsTandAField { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isHumanResourceField", IsNullable = true)]
    public bool? IsHumanResourceField { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isHistorical", IsNullable = true)]
    public bool? IsHistorical { get; set; }

    [XmlElement(DataType = "int", ElementName = "fieldFormat", IsNullable = true)]
    public int? FieldFormat { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isAccessField", IsNullable = true)]
    public bool? IsAccessField { get; set; }

    [XmlElement(DataType = "string", ElementName = "humanResourceThemeDescription", IsNullable = true)]
    public string HumanResourceThemeDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "isVisitorField", IsNullable = true)]
    public bool? IsVisitorField { get; set; }

    [XmlElement(DataType = "int", ElementName = "interwinPosition", IsNullable = true)]
    public int? InterwinPosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "humanResourceThemeCode", IsNullable = true)]
    public int? HumanResourceThemeCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "administrationEmployeeFileTab", IsNullable = true)]
    public int? AdministrationEmployeeFileTab { get; set; }
  }
}
