
// Type: KelioSDK.Models.AccountInitialization




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccountInitialization")]
  public class AccountInitialization : AbstractTransferFile
  {
    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }

    [XmlElement(DataType = "short", ElementName = "impactedResult", IsNullable = true)]
    public short? ImpactedResult { get; set; }

    [XmlElement(DataType = "short", ElementName = "calculableType", IsNullable = true)]
    public short? CalculableType { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "keepTheRemainder", IsNullable = true)]
    public bool? KeepTheRemainder { get; set; }

    [XmlElement(DataType = "int", ElementName = "processingPeriodicity", IsNullable = true)]
    public int? ProcessingPeriodicity { get; set; }

    [XmlElement(DataType = "short", ElementName = "initializationType", IsNullable = true)]
    public short? InitializationType { get; set; }
  }
}
