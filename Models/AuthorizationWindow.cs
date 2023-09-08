
// Type: KelioSDK.Models.AuthorizationWindow




using KelioSDK.Common;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AuthorizationWindow")]
  public class AuthorizationWindow : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "authorizationWindowDescription", IsNullable = true)]
    public string AuthorizationWindowDescription { get; set; }

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

    [XmlElement(DataType = "int", ElementName = "authorizationWindowKey", IsNullable = true)]
    public int? AuthorizationWindowKey { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "endTimeAdjustment", IsNullable = true)]
    public bool? EndTimeAdjustment { get; set; }
  }
}
