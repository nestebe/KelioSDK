
// Type: KelioSDK.Models.AccessAuthorization




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccessAuthorization")]
  public class AccessAuthorization : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "accessAuthorizationStartDate", IsNullable = true)]
    public DateTime? AccessAuthorizationStartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "accessAuthorizationEndDate", IsNullable = true)]
    public DateTime? AccessAuthorizationEndDate { get; set; }

    [XmlIgnore]
    public TimeSpan? AccessAuthorizationEndTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessAuthorizationEndTime", IsNullable = true)]
    public string AccessAuthorizationEndTimeField
    {
      get
      {
        return !this.AccessAuthorizationEndTime.HasValue ? (string) null : this.AccessAuthorizationEndTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.AccessAuthorizationEndTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlIgnore]
    public TimeSpan? AccessAuthorizationStartTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessAuthorizationStartTime", IsNullable = true)]
    public string AccessAuthorizationStartTimeField
    {
      get
      {
        return !this.AccessAuthorizationStartTime.HasValue ? (string) null : this.AccessAuthorizationStartTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.AccessAuthorizationStartTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "string", ElementName = "accessAuthorizationSite", IsNullable = true)]
    public string AccessAuthorizationSite { get; set; }
  }
}
