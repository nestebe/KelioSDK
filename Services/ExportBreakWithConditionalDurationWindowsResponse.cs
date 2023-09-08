﻿
//.ExportBreakWithConditionalDurationWindowsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportBreakWithConditionalDurationWindowsResponse")]
  public class ExportBreakWithConditionalDurationWindowsResponse
  {
    [XmlArray(ElementName = "exportedBreakWithConditionalDurationWindows", IsNullable = false, Order = 0)]
    public List<BreakWithConditionalDurationWindow> ExportedBreakWithConditionalDurationWindows { get; set; }
  }
}
