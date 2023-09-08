﻿
//.ExportAbsenceRequestsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceRequestsResponse")]
  public class ExportAbsenceRequestsResponse
  {
    [XmlArray(ElementName = "exportedAbsenceRequests", IsNullable = false, Order = 0)]
    public List<AbsenceRequest> ExportedAbsenceRequests { get; set; }
  }
}
