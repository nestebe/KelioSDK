//.RemoteWorkingFileServiceClient


using KelioSDK.Common;

namespace KelioSDK.Services;

public class RemoteWorkingFileServiceClient
{
    private const string Service = "RemoteWorkingFileService";
    private readonly string _baseuri;
    private readonly string _password;
    private readonly int _timeoutSeconds;
    private readonly string _username;

    public RemoteWorkingFileServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
        _username = username;
        _password = password;
        _baseuri = baseuri;
        _timeoutSeconds = timeoutSeconds;
    }

    public ExportRemoteWorkingFilesListResponse ExportRemoteWorkingFilesList(
        ExportRemoteWorkingFilesList arg)
    {
        return Client.Post<ExportRemoteWorkingFilesList, ExportRemoteWorkingFilesListResponse>(
            _username, _password, _baseuri, Service, arg, _timeoutSeconds);
    }

    public Task<ExportRemoteWorkingFilesListResponse> ExportRemoteWorkingFilesListAsync(
        ExportRemoteWorkingFilesList arg)
    {
        return Client.PostAsync<ExportRemoteWorkingFilesList, ExportRemoteWorkingFilesListResponse>(
            _username, _password, _baseuri, Service, arg, _timeoutSeconds);
    }
}