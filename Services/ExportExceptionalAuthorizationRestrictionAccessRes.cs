﻿
//.ExportExceptionalAuthorizationRestrictionAccessResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportExceptionalAuthorizationRestrictionAccessResponse")]
  public class ExportExceptionalAuthorizationRestrictionAccessResponse
  {
    [XmlArray(ElementName = "exportedExceptionalAuthorizationRestrictionAccess", IsNullable = false, Order = 0)]
    public List<ExceptionalAuthorizationRestrictionAccess> ExportedExceptionalAuthorizationRestrictionAccess { get; set; }
  }
}
