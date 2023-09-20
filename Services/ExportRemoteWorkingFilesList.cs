//.ExportAbsenceFilesList


using System.Xml.Serialization;
using KelioSDK.Models;

namespace KelioSDK.Services;

[XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportRemoteWorkingFilesList")]
public class ExportRemoteWorkingFilesList
{
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedPopulationWithPeriod> ExportFilter { get; set; }
}