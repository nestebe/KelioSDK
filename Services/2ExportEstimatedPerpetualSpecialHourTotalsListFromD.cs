
//.ExportEstimatedPerpetualSpecialHourTotalsListFromDate




using System;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEstimatedPerpetualSpecialHourTotalsListFromDate")]
  public class ExportEstimatedPerpetualSpecialHourTotalsListFromDate
  {
    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 0)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "groupFilter", IsNullable = true, Order = 1)]
    public string GroupFilter { get; set; }

    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true, Order = 2)]
    public DateTime? Date { get; set; }
  }
}
