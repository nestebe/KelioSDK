﻿
//.ExportScheduleByExceptionAssignmentsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportScheduleByExceptionAssignmentsList")]
  public class ExportScheduleByExceptionAssignmentsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedPopulationWithPeriod> ExportFilter { get; set; }
  }
}
