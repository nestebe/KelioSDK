
// Type: KelioSDK.Models.AccessWeeklyAuthorization




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AccessWeeklyAuthorization")]
  public class AccessWeeklyAuthorization : ObjectBase
  {
    [XmlElement(DataType = "string", ElementName = "mondayAuthorizationWindowDescription", IsNullable = true)]
    public string MondayAuthorizationWindowDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "tuesdayAuthorizationWindowDescription", IsNullable = true)]
    public string TuesdayAuthorizationWindowDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "thursdayAuthorizationWindowDescription", IsNullable = true)]
    public string ThursdayAuthorizationWindowDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "wednesdayAuthorizationWindowDescription", IsNullable = true)]
    public string WednesdayAuthorizationWindowDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "publicHolidayAuthorizationWindowDescription", IsNullable = true)]
    public string PublicHolidayAuthorizationWindowDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "fridayAuthorizationWindowDescription", IsNullable = true)]
    public string FridayAuthorizationWindowDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "saturdayAuthorizationWindowDescription", IsNullable = true)]
    public string SaturdayAuthorizationWindowDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "sundayAuthorizationWindowDescription", IsNullable = true)]
    public string SundayAuthorizationWindowDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "authorizationKey", IsNullable = true)]
    public int? AuthorizationKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "authorizationDescription", IsNullable = true)]
    public string AuthorizationDescription { get; set; }
  }
}
