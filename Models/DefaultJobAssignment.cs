
// Type: KelioSDK.Models.DefaultJobAssignment




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "DefaultJobAssignment")]
  public class DefaultJobAssignment : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "customerExternalReference", IsNullable = true)]
    public string CustomerExternalReference { get; set; }

    [XmlElement(DataType = "date", ElementName = "applicationDate", IsNullable = true)]
    public DateTime? ApplicationDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "jobKey", IsNullable = true)]
    public int? JobKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreExternalReference", IsNullable = true)]
    public string CostCentreExternalReference { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreAbbreviation", IsNullable = true)]
    public string CostCentreAbbreviation { get; set; }

    [XmlElement(DataType = "int", ElementName = "defaultJobAssignmentKey", IsNullable = true)]
    public int? DefaultJobAssignmentKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreDescription", IsNullable = true)]
    public string CostCentreDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreCode", IsNullable = true)]
    public string CostCentreCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobExternalReference", IsNullable = true)]
    public string JobExternalReference { get; set; }

    [XmlElement(DataType = "int", ElementName = "costCentreKey", IsNullable = true)]
    public int? CostCentreKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerCode", IsNullable = true)]
    public string CustomerCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "customerKey", IsNullable = true)]
    public int? CustomerKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerAbbreviation", IsNullable = true)]
    public string CustomerAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerDescription", IsNullable = true)]
    public string CustomerDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobAbbreviation", IsNullable = true)]
    public string JobAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobCode", IsNullable = true)]
    public string JobCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobDescription", IsNullable = true)]
    public string JobDescription { get; set; }
  }
}
