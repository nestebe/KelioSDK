
// Type: KelioSDK.Models.ExposurePeriod




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "ExposurePeriod")]
  public class ExposurePeriod : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "organisationalPreventiveMeasure", IsNullable = true)]
    public string OrganisationalPreventiveMeasure { get; set; }

    [XmlElement(DataType = "date", ElementName = "exposurePeriodStartDate", IsNullable = true)]
    public DateTime? ExposurePeriodStartDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "defineManuallyWhetherRiskIdentified", IsNullable = true)]
    public bool? DefineManuallyWhetherRiskIdentified { get; set; }

    [XmlElement(DataType = "date", ElementName = "exposurePeriodEndDate", IsNullable = true)]
    public DateTime? ExposurePeriodEndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "exposurePeriodConfigurationValided", IsNullable = true)]
    public bool? ExposurePeriodConfigurationValided { get; set; }

    [XmlElement(DataType = "string", ElementName = "comments", IsNullable = true)]
    public string Comments { get; set; }

    [XmlElement(DataType = "string", ElementName = "individualPreventiveMeasure", IsNullable = true)]
    public string IndividualPreventiveMeasure { get; set; }

    [XmlElement(DataType = "string", ElementName = "collectivePreventiveMeasure", IsNullable = true)]
    public string CollectivePreventiveMeasure { get; set; }

    [XmlElement(DataType = "short", ElementName = "riskType", IsNullable = true)]
    public short? RiskType { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "riskIdentify", IsNullable = true)]
    public bool? RiskIdentify { get; set; }
  }
}
