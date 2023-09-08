
// Type: KelioSDK.Models.EmployeeJobData




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeeJobData")]
  public class EmployeeJobData : EmployeeInformationAndCriterion
  {
    [XmlElement(DataType = "date", ElementName = "defaultJobApplicationDate", IsNullable = true)]
    public DateTime? DefaultJobApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCostCentreAbbrevation", IsNullable = true)]
    public string DefaultCostCentreAbbrevation { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCostCentreCode", IsNullable = true)]
    public string DefaultCostCentreCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCustomerDescription", IsNullable = true)]
    public string DefaultCustomerDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "automaticJobGenerationModeDescription", IsNullable = true)]
    public string AutomaticJobGenerationModeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCostCentreExternalReference", IsNullable = true)]
    public string DefaultCostCentreExternalReference { get; set; }

    [XmlElement(DataType = "date", ElementName = "defaultCostCentreApplicationDate", IsNullable = true)]
    public DateTime? DefaultCostCentreApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCustomerCode", IsNullable = true)]
    public string DefaultCustomerCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCustomerAbbreviation", IsNullable = true)]
    public string DefaultCustomerAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultJobAbbreviation", IsNullable = true)]
    public string DefaultJobAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultJobDescription", IsNullable = true)]
    public string DefaultJobDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultJobCode", IsNullable = true)]
    public string DefaultJobCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCostCentreDescription", IsNullable = true)]
    public string DefaultCostCentreDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "defaultCustomerApplicationDate", IsNullable = true)]
    public DateTime? DefaultCustomerApplicationDate { get; set; }

    [XmlElement(DataType = "short", ElementName = "automaticJobGenerationModeCode", IsNullable = true)]
    public short? AutomaticJobGenerationModeCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "automaticJobGenerationApplicationDate", IsNullable = true)]
    public DateTime? AutomaticJobGenerationApplicationDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultJobExternalReference", IsNullable = true)]
    public string DefaultJobExternalReference { get; set; }

    [XmlElement(DataType = "string", ElementName = "defaultCustomerExternalReference", IsNullable = true)]
    public string DefaultCustomerExternalReference { get; set; }
  }
}
