
//.ExportEmployeeHourlyRateAssignments




using System;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeHourlyRateAssignments")]
  public class ExportEmployeeHourlyRateAssignments
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true, Order = 0)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true, Order = 1)]
    public DateTime? EndDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 2)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true, Order = 3)]
    public string GroupFilter { get; set; }
  }
}
