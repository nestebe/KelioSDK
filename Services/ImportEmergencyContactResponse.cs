﻿
//.ImportEmergencyContactResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmergencyContactResponse")]
  public class ImportEmergencyContactResponse
  {
    [XmlArray(ElementName = "emergencyContactInError", IsNullable = false, Order = 0)]
    public List<EmergencyContact> EmergencyContactInError { get; set; }
  }
}
