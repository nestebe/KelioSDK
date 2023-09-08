
// Type: KelioSDK.Models.AddDeduct




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AddDeduct")]
  public class AddDeduct : AbstractTransferFile
  {
    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string Comment { get; set; }

    [XmlElement(DataType = "double", ElementName = "number", IsNullable = true)]
    public double? Number { get; set; }

    [XmlElement(DataType = "short", ElementName = "frequency", IsNullable = true)]
    public short? Frequency { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "short", ElementName = "recurrence", IsNullable = true)]
    public short? Recurrence { get; set; }
  }
}
