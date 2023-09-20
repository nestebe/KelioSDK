﻿//.ExportAbsenceFilesLimitedToAPeriodResponse


using System.Xml.Serialization;
using KelioSDK.Models;

namespace KelioSDK.Services;

[XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportRemoteWorkingFilesListResponse")]
public class ExportRemoteWorkingFilesListResponse
{
    [XmlArray(ElementName = "exportedRemoteWorkingFiles", IsNullable = false, Order = 0)]
    public List<RemoteWorkingFile> ExportedRemoteWorkingFilesList { get; set; }
}