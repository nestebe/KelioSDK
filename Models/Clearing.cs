
// Type: KelioSDK.Models.Clearing




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "Clearing")]
  public class Clearing : ObjectBase
  {
    [XmlElement(DataType = "boolean", ElementName = "clearingActive", IsNullable = true)]
    public bool? ClearingActive { get; set; }

    [XmlElement(DataType = "date", ElementName = "lastClearedDate", IsNullable = true)]
    public DateTime? LastClearedDate { get; set; }

    [XmlElement(DataType = "int", ElementName = "clearingType", IsNullable = true)]
    public int? ClearingType { get; set; }
  }
}
