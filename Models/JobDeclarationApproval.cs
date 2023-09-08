
// Type: KelioSDK.Models.JobDeclarationApproval




using System;
using System.Globalization;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "JobDeclarationApproval")]
  public class JobDeclarationApproval : EmployeeInformation
  {
    [XmlElement(DataType = "boolean", ElementName = "userApproval", IsNullable = true)]
    public bool? UserApproval { get; set; }

    [XmlIgnore]
    public TimeSpan? UserApprovalTime { get; set; }

    [XmlElement(DataType = "string", ElementName = "userApprovalTime", IsNullable = true)]
    public string UserApprovalTimeField
    {
      get
      {
        return !this.UserApprovalTime.HasValue ? (string) null : this.UserApprovalTime.Value.ToString("hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      set
      {
        this.UserApprovalTime = value == null ? new TimeSpan?() : new TimeSpan?(TimeSpan.ParseExact(value, "hh\\:mm\\:ss", (IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    [XmlElement(DataType = "date", ElementName = "userApprovalDate", IsNullable = true)]
    public DateTime? UserApprovalDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "userApprovalLogin", IsNullable = true)]
    public string UserApprovalLogin { get; set; }

    [XmlElement(DataType = "date", ElementName = "approvalDate", IsNullable = true)]
    public DateTime? ApprovalDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeLogin", IsNullable = true)]
    public string EmployeeLogin { get; set; }
  }
}
