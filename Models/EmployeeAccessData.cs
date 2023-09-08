
// Type: KelioSDK.Models.EmployeeAccessData




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeAccessData")]
  public class EmployeeAccessData : EmployeeInformationAndCriterion
  {
    [XmlElement(DataType = "date", ElementName = "currentPublicHolidayCalendarApplicationDate", IsNullable = true)]
    public DateTime? CurrentPublicHolidayCalendarApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "personalCode", IsNullable = true)]
    public string PersonalCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentSectionAssigningDate", IsNullable = true)]
    public DateTime? CurrentSectionAssigningDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentAccessProfileAssigningEndDate", IsNullable = true)]
    public DateTime? CurrentAccessProfileAssigningEndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "concernedByAntiPassbacks", IsNullable = true)]
    public bool? ConcernedByAntiPassbacks { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentAccessProfileDescription", IsNullable = true)]
    public string CurrentAccessProfileDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSectionFullDescription", IsNullable = true)]
    public string CurrentSectionFullDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "visitorSectionDescription", IsNullable = true)]
    public string VisitorSectionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "siteDescriptionOfCurrentAccessProfile", IsNullable = true)]
    public string SiteDescriptionOfCurrentAccessProfile { get; set; }

    [XmlElement(DataType = "int", ElementName = "visitorUsedBadge", IsNullable = true)]
    public int? VisitorUsedBadge { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentSectionAbbreviation", IsNullable = true)]
    public string CurrentSectionAbbreviation { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "superPassEverywhere", IsNullable = true)]
    public bool? SuperPassEverywhere { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "extendedTimeout", IsNullable = true)]
    public bool? ExtendedTimeout { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "receiveVisitor", IsNullable = true)]
    public bool? ReceiveVisitor { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "visitorOfOtherSiteAllowance", IsNullable = true)]
    public bool? VisitorOfOtherSiteAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "superPass", IsNullable = true)]
    public bool? SuperPass { get; set; }

    [XmlElement(DataType = "date", ElementName = "currentAccessProfileAssigningDate", IsNullable = true)]
    public DateTime? CurrentAccessProfileAssigningDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "specificSchedulesAllowance", IsNullable = true)]
    public bool? SpecificSchedulesAllowance { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "centralAlarmSystemManualActivationAllowance", IsNullable = true)]
    public bool? CentralAlarmSystemManualActivationAllowance { get; set; }

    [XmlElement(DataType = "string", ElementName = "currentPublicHolidayCalendarDescription", IsNullable = true)]
    public string CurrentPublicHolidayCalendarDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "specificSchedulesEverywhereAllowance", IsNullable = true)]
    public bool? SpecificSchedulesEverywhereAllowance { get; set; }
  }
}
