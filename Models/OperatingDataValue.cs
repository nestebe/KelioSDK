
// Type: KelioSDK.Models.OperatingDataValue




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "OperatingDataValue")]
  public class OperatingDataValue : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "predefiniedAfternoonValueKey", IsNullable = true)]
    public int? PredefiniedAfternoonValueKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatingDataDescription", IsNullable = true)]
    public string OperatingDataDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "predefiniedMorningValueKey", IsNullable = true)]
    public int? PredefiniedMorningValueKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "predefiniedNightValueKey", IsNullable = true)]
    public int? PredefiniedNightValueKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefiniedNightValueAbbreviation", IsNullable = true)]
    public string PredefiniedNightValueAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefiniedMorningValueAbbreviation", IsNullable = true)]
    public string PredefiniedMorningValueAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefiniedValueAbbreviation", IsNullable = true)]
    public string PredefiniedValueAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "operatingDataKey", IsNullable = true)]
    public int? OperatingDataKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatingDataAbbreviation", IsNullable = true)]
    public string OperatingDataAbbreviation { get; set; }

    [XmlElement(DataType = "double", ElementName = "operatingDataAfternoonValue", IsNullable = true)]
    public double? OperatingDataAfternoonValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefiniedNightValue", IsNullable = true)]
    public string PredefiniedNightValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefiniedValue", IsNullable = true)]
    public string PredefiniedValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "operatingDataValue", IsNullable = true)]
    public double? OperatingDataValueProperty { get; set; }

    [XmlElement(DataType = "date", ElementName = "operatingDataApplicationDate", IsNullable = true)]
    public DateTime? OperatingDataApplicationDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "operatingDataApplicationEndDate", IsNullable = true)]
    public DateTime? OperatingDataApplicationEndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefiniedAfternoonValue", IsNullable = true)]
    public string PredefiniedAfternoonValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "operatingDataNightValue", IsNullable = true)]
    public double? OperatingDataNightValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatingDataMorningTextValue", IsNullable = true)]
    public string OperatingDataMorningTextValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefiniedMorningValue", IsNullable = true)]
    public string PredefiniedMorningValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatingDataNightTextValue", IsNullable = true)]
    public string OperatingDataNightTextValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatingDataAfternoonTextValue", IsNullable = true)]
    public string OperatingDataAfternoonTextValue { get; set; }

    [XmlElement(DataType = "int", ElementName = "predefiniedValueKey", IsNullable = true)]
    public int? PredefiniedValueKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatingDataTextValue", IsNullable = true)]
    public string OperatingDataTextValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "operatingDataMorningValue", IsNullable = true)]
    public double? OperatingDataMorningValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "predefiniedAfternoonValueAbbreviation", IsNullable = true)]
    public string PredefiniedAfternoonValueAbbreviation { get; set; }
  }
}
