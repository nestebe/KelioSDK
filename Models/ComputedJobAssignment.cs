
// Type: KelioSDK.Models.ComputedJobAssignment




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ComputedJobAssignment")]
  public class ComputedJobAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "applicationDate", IsNullable = true)]
    public DateTime? ApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "calculationMode", IsNullable = true)]
    public string CalculationMode { get; set; }

    [XmlElement(DataType = "double", ElementName = "durationInHours", IsNullable = true)]
    public double? DurationInHours { get; set; }

    [XmlIgnore]
    public TimeSpan? PeriodEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "periodEndTime", IsNullable = true)]
    public string PeriodEndTimeField
    {
      get
      {
        return !this.PeriodEndTime.HasValue ? (string) null : this.PeriodEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.PeriodEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? PeriodStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "periodStartTime", IsNullable = true)]
    public string PeriodStartTimeField
    {
      get
      {
        return !this.PeriodStartTime.HasValue ? (string) null : this.PeriodStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.PeriodStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "double", ElementName = "percentage", IsNullable = true)]
    public double? Percentage { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreAbbreviation", IsNullable = true)]
    public string CostCentreAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreCode", IsNullable = true)]
    public string CostCentreCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreDescription", IsNullable = true)]
    public string CostCentreDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "periodStartTimePosition", IsNullable = true)]
    public int? PeriodStartTimePosition { get; set; }

    [XmlElement(DataType = "int", ElementName = "costCentreKey", IsNullable = true)]
    public int? CostCentreKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "periodEndTimePosition", IsNullable = true)]
    public int? PeriodEndTimePosition { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobExternalReference", IsNullable = true)]
    public string JobExternalReference { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerExternalReference", IsNullable = true)]
    public string CustomerExternalReference { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobAbbreviation", IsNullable = true)]
    public string JobAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobCode", IsNullable = true)]
    public string JobCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobDescription", IsNullable = true)]
    public string JobDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "customerKey", IsNullable = true)]
    public int? CustomerKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerAbbreviation", IsNullable = true)]
    public string CustomerAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerCode", IsNullable = true)]
    public string CustomerCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerDescription", IsNullable = true)]
    public string CustomerDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "jobKey", IsNullable = true)]
    public int? JobKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreExternalReference", IsNullable = true)]
    public string CostCentreExternalReference { get; set; }
  }
}
