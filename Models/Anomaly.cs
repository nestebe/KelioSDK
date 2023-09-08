
// Type: KelioSDK.Models.Anomaly




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Anomaly")]
  public class Anomaly : EmployeeInformation
  {
    [XmlElement(DataType = "int", ElementName = "firstTimePosition", IsNullable = true)]
    public int? FirstTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "thirdTimePosition", IsNullable = true)]
    public int? ThirdTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "secondTimePosition", IsNullable = true)]
    public int? SecondTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "criticality", IsNullable = true)]
    public int? Criticality { get; set; }

    [XmlElement(DataType = "double", ElementName = "firstDurationValue", IsNullable = true)]
    public double? FirstDurationValue { get; set; }

    [XmlElement(DataType = "double", ElementName = "thirdDurationValue", IsNullable = true)]
    public double? ThirdDurationValue { get; set; }

    [XmlIgnore]
    public TimeSpan? ThirdTimeValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "thirdTimeValue", IsNullable = true)]
    public string ThirdTimeValueField
    {
      get
      {
        return !this.ThirdTimeValue.HasValue ? (string) null : this.ThirdTimeValue.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.ThirdTimeValue = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? SecondTimeValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "secondTimeValue", IsNullable = true)]
    public string SecondTimeValueField
    {
      get
      {
        return !this.SecondTimeValue.HasValue ? (string) null : this.SecondTimeValue.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.SecondTimeValue = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "double", ElementName = "secondNumberValue", IsNullable = true)]
    public double? SecondNumberValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "anomalyDescription", IsNullable = true)]
    public string AnomalyDescription { get; set; }

    [XmlElement(DataType = "double", ElementName = "secondDurationValue", IsNullable = true)]
    public double? SecondDurationValue { get; set; }

    [XmlIgnore]
    public TimeSpan? FirstTimeValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstTimeValue", IsNullable = true)]
    public string FirstTimeValueField
    {
      get
      {
        return !this.FirstTimeValue.HasValue ? (string) null : this.FirstTimeValue.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.FirstTimeValue = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "double", ElementName = "firstNumberValue", IsNullable = true)]
    public double? FirstNumberValue { get; set; }

    [XmlElement(DataType = "date", ElementName = "firstDateValue", IsNullable = true)]
    public DateTime? FirstDateValue { get; set; }

    [XmlElement(DataType = "string", ElementName = "text", IsNullable = true)]
    public string Text { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "historical", IsNullable = true)]
    public bool? Historical { get; set; }

    [XmlElement(DataType = "string", ElementName = "firstDurationUnit", IsNullable = true)]
    public string FirstDurationUnit { get; set; }

    [XmlElement(DataType = "string", ElementName = "thirdDurationUnit", IsNullable = true)]
    public string ThirdDurationUnit { get; set; }

    [XmlElement(DataType = "string", ElementName = "secondDurationUnit", IsNullable = true)]
    public string SecondDurationUnit { get; set; }

    [XmlElement(DataType = "string", ElementName = "anomalyComment", IsNullable = true)]
    public string AnomalyComment { get; set; }

    [XmlElement(DataType = "int", ElementName = "anomalyKey", IsNullable = true)]
    public int? AnomalyKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "anomalyType", IsNullable = true)]
    public int? AnomalyType { get; set; }

    [XmlElement(DataType = "date", ElementName = "anomalyDate", IsNullable = true)]
    public DateTime? AnomalyDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "balanceAbbreviation", IsNullable = true)]
    public string BalanceAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "balanceDescription", IsNullable = true)]
    public string BalanceDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "acknowledged", IsNullable = true)]
    public bool? Acknowledged { get; set; }
  }
}
