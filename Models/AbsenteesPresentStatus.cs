
// Type: KelioSDK.Models.AbsenteesPresentStatus




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenteesPresentStatus")]
  public class AbsenteesPresentStatus : EmployeeInformation
  {
    [XmlElement(DataType = "string", ElementName = "costCentreTypeCode", IsNullable = true)]
    public string CostCentreTypeCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "costCentreTypeKey", IsNullable = true)]
    public int? CostCentreTypeKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "jobTypeKey", IsNullable = true)]
    public int? JobTypeKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenteesPresentStatus", IsNullable = true)]
    public int? AbsenteesPresentStatusProperty { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreTypeAbbreviation", IsNullable = true)]
    public string CostCentreTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "costCentreTypeDescription", IsNullable = true)]
    public string CostCentreTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeDescription", IsNullable = true)]
    public string AbsenceTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "readerDescription", IsNullable = true)]
    public string ReaderDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceTypeKey", IsNullable = true)]
    public int? AbsenceTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "absenceTypeAbbreviation", IsNullable = true)]
    public string AbsenceTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerTypeCode", IsNullable = true)]
    public string CustomerTypeCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "customerTypeKey", IsNullable = true)]
    public int? CustomerTypeKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerTypeAbbreviation", IsNullable = true)]
    public string CustomerTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "customerTypeDescription", IsNullable = true)]
    public string CustomerTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobTypeAbbreviation", IsNullable = true)]
    public string JobTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobTypeCode", IsNullable = true)]
    public string JobTypeCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "jobTypeDescription", IsNullable = true)]
    public string JobTypeDescription { get; set; }
  }
}
