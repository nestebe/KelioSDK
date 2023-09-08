﻿
//.DeleteJobAssignmentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteJobAssignmentsResponse")]
  public class DeleteJobAssignmentsResponse
  {
    [XmlArray(ElementName = "jobAssignmentsInError", IsNullable = false, Order = 0)]
    public List<JobAssignment> JobAssignmentsInError { get; set; }
  }
}
