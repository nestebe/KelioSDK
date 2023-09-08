
// Type: KelioSDK.Models.JobTypeCostCentreTypeLinkFilter




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "JobTypeCostCentreTypeLinkFilter")]
  public class JobTypeCostCentreTypeLinkFilter : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "masterTypeKey", IsNullable = true)]
    public int? MasterTypeKey { get; set; }

    [XmlElement(DataType = "short", ElementName = "masterType", IsNullable = true)]
    public short? MasterType { get; set; }

    [XmlElement(DataType = "string", ElementName = "masterTypeDescription", IsNullable = true)]
    public string MasterTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "masterTypeAbbreviation", IsNullable = true)]
    public string MasterTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "masterTypeCode", IsNullable = true)]
    public string MasterTypeCode { get; set; }
  }
}
