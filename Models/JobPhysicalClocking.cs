
// Type: KelioSDK.Models.JobPhysicalClocking




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "JobPhysicalClocking")]
  public class JobPhysicalClocking : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }

    [XmlIgnore]
    public TimeSpan? Time { get; set; }

    [XmlElement(DataType = "string", ElementName = "time", IsNullable = true)]
    public string TimeField
    {
      get
      {
        return !this.Time.HasValue ? (string) null : this.Time.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.Time = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "int", ElementName = "terminalKey", IsNullable = true)]
    public int? TerminalKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreAbbreviation", IsNullable = true)]
    public string CostCentreAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreCode", IsNullable = true)]
    public string CostCentreCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreDescription", IsNullable = true)]
    public string CostCentreDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "costCentreKey", IsNullable = true)]
    public int? CostCentreKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerDescription", IsNullable = true)]
    public string ReaderDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "terminalDescription", IsNullable = true)]
    public string TerminalDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "customerKey", IsNullable = true)]
    public int? CustomerKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerAbbreviation", IsNullable = true)]
    public string CustomerAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerCode", IsNullable = true)]
    public string CustomerCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerDescription", IsNullable = true)]
    public string CustomerDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "clockingKey", IsNullable = true)]
    public int? ClockingKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "readerKey", IsNullable = true)]
    public int? ReaderKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobDescription", IsNullable = true)]
    public string JobDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "jobKey", IsNullable = true)]
    public int? JobKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobCode", IsNullable = true)]
    public string JobCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobAbbreviation", IsNullable = true)]
    public string JobAbbreviation { get; set; }
  }
}
