﻿
//.ExportPaidBreakWithConditionalDurationWindowsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPaidBreakWithConditionalDurationWindowsList")]
  public class ExportPaidBreakWithConditionalDurationWindowsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedWindow> ExportFilter { get; set; }
  }
}
