
// Type: KelioSDK.Models.AbsenceBalanceInitialization




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenceBalanceInitialization")]
  public class AbsenceBalanceInitialization : AbstractTransferFile
  {
    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "keepTheRemainder", IsNullable = true)]
    public bool? KeepTheRemainder { get; set; }

    [XmlElement(DataType = "int", ElementName = "absenceBalanceInitializationKey", IsNullable = true)]
    public int? AbsenceBalanceInitializationKey { get; set; }
  }
}
