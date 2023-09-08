﻿
//.ExportEmployeeAccessDataList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeAccessDataList")]
  public class ExportEmployeeAccessDataList
  {
    [XmlArray(ElementName = "populationFilter", IsNullable = false, Order = 0)]
    public List<AskedPopulation> PopulationFilter { get; set; }
  }
}
