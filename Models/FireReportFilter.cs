
// Type: KelioSDK.Models.FireReportFilter




using KelioSDK.Common;
using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "FireReportFilter")]
  public class FireReportFilter : ObjectBase
  {
    [XmlElement(DataType = "int", ElementName = "fireReportMonitoringKey", IsNullable = true)]
    public int? FireReportMonitoringKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "usedFireReportConfigurationKey", IsNullable = true)]
    public int? UsedFireReportConfigurationKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "usedFireReportConfigurationDescription", IsNullable = true)]
    public string UsedFireReportConfigurationDescription { get; set; }

    [XmlElement(DataType = "date", ElementName = "reportEndDate", IsNullable = true)]
    public DateTime? ReportEndDate { get; set; }

    [XmlElement(DataType = "date", ElementName = "reportStartDate", IsNullable = true)]
    public DateTime? ReportStartDate { get; set; }
  }
}
