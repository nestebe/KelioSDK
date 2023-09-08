
//.ExportJobHourlyRateAssignments




using System;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobHourlyRateAssignments")]
  public class ExportJobHourlyRateAssignments
  {
    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true, Order = 0)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "endDate", IsNullable = true, Order = 1)]
    public DateTime? EndDate { get; set; }
  }
}
