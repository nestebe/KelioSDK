﻿
//.ExportAnnualizedHourSchedulesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAnnualizedHourSchedulesResponse")]
  public class ExportAnnualizedHourSchedulesResponse
  {
    [XmlArray(ElementName = "exportedAnnualizedHourSchedules", IsNullable = false, Order = 0)]
    public List<AnnualizedHourSchedule> ExportedAnnualizedHourSchedules { get; set; }
  }
}
