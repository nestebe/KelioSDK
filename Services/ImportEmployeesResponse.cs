﻿
//.ImportEmployeesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeesResponse")]
  public class ImportEmployeesResponse
  {
    [XmlArray(ElementName = "employeesInError", IsNullable = false, Order = 0)]
    public List<Employee> EmployeesInError { get; set; }
  }
}
