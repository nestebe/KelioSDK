﻿
//.ExportEmployeeJobDataResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeJobDataResponse")]
  public class ExportEmployeeJobDataResponse
  {
    [XmlArray(ElementName = "exportedEmployeeJobData", IsNullable = false, Order = 0)]
    public List<EmployeeJobData> ExportedEmployeeJobData { get; set; }
  }
}
