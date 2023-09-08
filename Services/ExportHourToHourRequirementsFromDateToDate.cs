
//.ExportHourToHourRequirementsFromDateToDate




using System;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportHourToHourRequirementsFromDateToDate")]
  public class ExportHourToHourRequirementsFromDateToDate
  {
    [XmlElement(DataType = "string", ElementName = "populationFilter", IsNullable = true, Order = 0)]
    public string PopulationFilter { get; set; }

    [XmlElement(DataType = "string", ElementName = "postFilter", IsNullable = true, Order = 1)]
    public string PostFilter { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true, Order = 2)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true, Order = 3)]
    public DateTime? EndDate { get; set; }
  }
}
