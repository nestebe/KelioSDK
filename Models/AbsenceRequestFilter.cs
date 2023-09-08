
// Type: KelioSDK.Models.AbsenceRequestFilter




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenceRequestFilter")]
  public class AbsenceRequestFilter : AskedPopulationWithPeriod
  {
    [XmlElement(DataType = "boolean", ElementName = "limitedToAPeriod", IsNullable = true)]
    public bool? LimitedToAPeriod { get; set; }

    [XmlElement(DataType = "short", ElementName = "requestState", IsNullable = true)]
    public short? RequestState { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorSurname", IsNullable = true)]
    public string ValidatorSurname { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorLogin", IsNullable = true)]
    public string ValidatorLogin { get; set; }

    [XmlElement(DataType = "int", ElementName = "validatorKey", IsNullable = true)]
    public int? ValidatorKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorIdentificationNumber", IsNullable = true)]
    public string ValidatorIdentificationNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorFirstName", IsNullable = true)]
    public string ValidatorFirstName { get; set; }

    [XmlElement(DataType = "string", ElementName = "validatorBadgeCode", IsNullable = true)]
    public string ValidatorBadgeCode { get; set; }
  }
}
