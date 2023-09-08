
// Type: KelioSDK.Models.JobTypeCostCentreTypeLink




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "JobTypeCostCentreTypeLink")]
  public class JobTypeCostCentreTypeLink : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "jobTypeExternalReference", IsNullable = true)]
    public string JobTypeExternalReference { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreTypeAbbreviation", IsNullable = true)]
    public string CostCentreTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreTypeCode", IsNullable = true)]
    public string CostCentreTypeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreTypeDescription", IsNullable = true)]
    public string CostCentreTypeDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "costCentreTypeKey", IsNullable = true)]
    public int? CostCentreTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerTypeExternalReference", IsNullable = true)]
    public string CustomerTypeExternalReference { get; set; }

    [XmlElement(DataType = "int", ElementName = "entityKey", IsNullable = true)]
    public int? EntityKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "workbookKey", IsNullable = true)]
    public int? WorkbookKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "entityDescription", IsNullable = true)]
    public string EntityDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreTypeExternalReference", IsNullable = true)]
    public string CostCentreTypeExternalReference { get; set; }

    [XmlElement(DataType = "string", ElementName = "workbookDescription", IsNullable = true)]
    public string WorkbookDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "customerTypeKey", IsNullable = true)]
    public int? CustomerTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerTypeAbbreviation", IsNullable = true)]
    public string CustomerTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerTypeCode", IsNullable = true)]
    public string CustomerTypeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerTypeDescription", IsNullable = true)]
    public string CustomerTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobTypeDescription", IsNullable = true)]
    public string JobTypeDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "jobTypeKey", IsNullable = true)]
    public int? JobTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobTypeCode", IsNullable = true)]
    public string JobTypeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobTypeAbbreviation", IsNullable = true)]
    public string JobTypeAbbreviation { get; set; }
  }
}
