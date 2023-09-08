
// Type: KelioSDK.Models.AskedOperatingDataValue




using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AskedOperatingDataValue")]
  public class AskedOperatingDataValue : AbstractAskedByDates
  {
    [XmlElement(DataType = "string", ElementName = "operatingDataDescription", IsNullable = true)]
    public string OperatingDataDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "operatingDataKey", IsNullable = true)]
    public int? OperatingDataKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "operatingDataAbbreviation", IsNullable = true)]
    public string OperatingDataAbbreviation { get; set; }
  }
}
