
// Type: KelioSDK.Models.EmployeeUserData




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeUserData")]
  public class EmployeeUserData : EmployeeInformationAndCriterion
  {
    [XmlElement(DataType = "string", ElementName = "login", IsNullable = true)]
    public string Login { get; set; }

    [XmlElement(DataType = "date", ElementName = "readerGroupStartDate", IsNullable = true)]
    public DateTime? ReaderGroupStartDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useDefaultMobileProfile", IsNullable = true)]
    public bool? UseDefaultMobileProfile { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useDefaultUserPortalProfile", IsNullable = true)]
    public bool? UseDefaultUserPortalProfile { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "passwordNeverChange", IsNullable = true)]
    public bool? PasswordNeverChange { get; set; }

    [XmlElement(DataType = "string", ElementName = "password", IsNullable = true)]
    public string Password { get; set; }

    [XmlElement(DataType = "int", ElementName = "durationVisualization", IsNullable = true)]
    public int? DurationVisualization { get; set; }

    [XmlElement(DataType = "string", ElementName = "sendersEmail", IsNullable = true)]
    public string SendersEmail { get; set; }

    [XmlElement(DataType = "string", ElementName = "recipientsEmail", IsNullable = true)]
    public string RecipientsEmail { get; set; }

    [XmlElement(DataType = "int", ElementName = "language", IsNullable = true)]
    public int? Language { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceValidator", IsNullable = true)]
    public string AbsenceValidator { get; set; }

    [XmlElement(DataType = "string", ElementName = "clockingValidator", IsNullable = true)]
    public string ClockingValidator { get; set; }

    [XmlElement(DataType = "string", ElementName = "personalWorkspaceProfileDescription", IsNullable = true)]
    public string PersonalWorkspaceProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "emailServer", IsNullable = true)]
    public string EmailServer { get; set; }

    [XmlElement(DataType = "string", ElementName = "profileDescription", IsNullable = true)]
    public string ProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "mobileProfileDescription", IsNullable = true)]
    public string MobileProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "userPortalProfileDescription", IsNullable = true)]
    public string UserPortalProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerGroupDescription", IsNullable = true)]
    public string ReaderGroupDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "badge2Code", IsNullable = true)]
    public string Badge2Code { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "authenticate", IsNullable = true)]
    public bool? Authenticate { get; set; }

    [XmlElement(DataType = "string", ElementName = "workingSite", IsNullable = true)]
    public string WorkingSite { get; set; }

    [XmlElement(DataType = "string", ElementName = "emailServerUser", IsNullable = true)]
    public string EmailServerUser { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useDefaultPersonalWorkspaceProfile", IsNullable = true)]
    public bool? UseDefaultPersonalWorkspaceProfile { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "useDefaultTerminalProfile", IsNullable = true)]
    public bool? UseDefaultTerminalProfile { get; set; }
  }
}
