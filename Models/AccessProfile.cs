
// Type: KelioSDK.Models.AccessProfile




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccessProfile")]
  public class AccessProfile : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "accessProfileSiteDescription", IsNullable = true)]
    public string AccessProfileSiteDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "accessProfileKey", IsNullable = true)]
    public int? AccessProfileKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "accessProfileDescription", IsNullable = true)]
    public string AccessProfileDescription { get; set; }
  }
}
