
// Type: KelioSDK.Models.AskedClockingDeclaration




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedClockingDeclaration")]
  public class AskedClockingDeclaration : AskedPopulationWithPeriod
  {
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

    [XmlElement(DataType = "short", ElementName = "declarationState", IsNullable = true)]
    public short? DeclarationState { get; set; }
  }
}
