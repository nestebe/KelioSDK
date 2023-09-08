
// Type: KelioSDK.Models.AbsenceRequestPeriod




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenceRequestPeriod")]
  public class AbsenceRequestPeriod : AbsencePeriod
  {
    [XmlElement(DataType = "string", ElementName = "validatorsIdentificationCode", IsNullable = true)]
    public string ValidatorsIdentificationCode { get; set; }

    [XmlElement(DataType = "int", ElementName = "requestType", IsNullable = true)]
    public int? RequestType { get; set; }

    [XmlElement(DataType = "int", ElementName = "requestState", IsNullable = true)]
    public int? RequestState { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsKeys", IsNullable = true)]
    public string ValidatorsKeys { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsSurnames", IsNullable = true)]
    public string ValidatorsSurnames { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceRequestKey", IsNullable = true)]
    public int? AbsenceRequestKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsBadgeCodes", IsNullable = true)]
    public string ValidatorsBadgeCodes { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsLogins", IsNullable = true)]
    public string ValidatorsLogins { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsIdentificationNumbers", IsNullable = true)]
    public string ValidatorsIdentificationNumbers { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorsFirstNames", IsNullable = true)]
    public string ValidatorsFirstNames { get; set; }
  }
}
