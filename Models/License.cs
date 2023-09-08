
// Type: KelioSDK.Models.License




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "License")]
  public class License : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "activityCapacityAuthorisedEmployees", IsNullable = true)]
    public int? ActivityCapacityAuthorisedEmployees { get; set; }

    [XmlElement(DataType = "int", ElementName = "accessSecurityCapacityUsedEmployees", IsNullable = true)]
    public int? AccessSecurityCapacityUsedEmployees { get; set; }

    [XmlElement(DataType = "int", ElementName = "timeCapacityAuthorisedEmployees", IsNullable = true)]
    public int? TimeCapacityAuthorisedEmployees { get; set; }

    [XmlElement(DataType = "int", ElementName = "accessSecurityNumberAuthorisedAccessPoints", IsNullable = true)]
    public int? AccessSecurityNumberAuthorisedAccessPoints { get; set; }

    [XmlElement(DataType = "int", ElementName = "accessSecurityCapacityAuthorisedEmployees", IsNullable = true)]
    public int? AccessSecurityCapacityAuthorisedEmployees { get; set; }

    [XmlElement(DataType = "int", ElementName = "activityActiveFilesEmployees", IsNullable = true)]
    public int? ActivityActiveFilesEmployees { get; set; }

    [XmlElement(DataType = "int", ElementName = "timeCreatedFilesEmployees", IsNullable = true)]
    public int? TimeCreatedFilesEmployees { get; set; }

    [XmlElement(DataType = "int", ElementName = "timeActiveFilesEmployees", IsNullable = true)]
    public int? TimeActiveFilesEmployees { get; set; }

    [XmlElement(DataType = "int", ElementName = "accessSecurityNumberCreatedAccessPoints", IsNullable = true)]
    public int? AccessSecurityNumberCreatedAccessPoints { get; set; }
  }
}
