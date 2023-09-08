
//.ExportExceptionalAuthorizationRestrictionAccess




using System;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportExceptionalAuthorizationRestrictionAccess")]
  public class ExportExceptionalAuthorizationRestrictionAccess
  {
    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 0)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true, Order = 1)]
    public string GroupFilter { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true, Order = 2)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true, Order = 3)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "authorizedAccess", IsNullable = true, Order = 4)]
    public bool? AuthorizedAccess { get; set; }
  }
}
