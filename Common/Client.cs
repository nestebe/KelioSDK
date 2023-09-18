using KelioSDK.Extensions;
using System.Net;

namespace KelioSDK.Common
{
    public static class Client
    {
        public static T Post<S, T>(
            string username,
            string password,
            string baseuri,
            string service,
            S request,
            int timeoutseconds = 60)
            where S : class
            where T : class, new()
        {
            string action;
            string data = Factory.Request<S>(request, out action);
            string address = baseuri.TrimEnd('/') + "/" + service;
            using (KelioWebclient kelioWebclient = new KelioWebclient(username, password, action, timeoutseconds))
            {
                try
                {
                    return Factory.Response<T>(kelioWebclient.UploadString(address, data));
                }
                catch (WebException ex)
                {
                    if (ex == null || ex.Response == null)
                    {
                        throw;
                    }
                    else
                    {
                        using (Stream responseStream = ex.Response.GetResponseStream())
                        {
                            if (responseStream == null)
                            {
                                throw;
                            }
                            else
                            {
                                using (StreamReader streamReader = new StreamReader(responseStream))
                                {
                                    string end = streamReader.ReadToEnd();
                                    streamReader.Close();
                                    throw new InvalidOperationException(Factory.Response<Fault>(end).Faultstring);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static async Task<T> PostAsync<S, T>(
            string username,
            string password,
            string baseuri,
            string service,
            S request,
            int timeoutseconds = 60)
            where S : class
            where T : class, new()
        {
            string action;
            string data = Factory.Request<S>(request, out action);
            string address = baseuri.TrimEnd('/') + "/" + service;
            T obj;
            using (KelioWebclient client = new KelioWebclient(username, password, action, timeoutseconds))
            {
                try
                {
                    obj = Factory.Response<T>(await client.UploadStringTaskAsync(address, data));
                }
                catch (WebException ex)
                {
                    if (ex == null || ex.Response == null)
                    {
                        throw;
                    }
                    else
                    {
                        using (Stream responseStream = ex.Response.GetResponseStream())
                        {
                            if (responseStream == null)
                            {
                                throw;
                            }
                            else
                            {
                                using (StreamReader streamReader = new StreamReader(responseStream))
                                {
                                    string end = streamReader.ReadToEnd();
                                    streamReader.Close();
                                    throw new InvalidOperationException(Factory.Response<Fault>(end).Faultstring);
                                }
                            }
                        }
                    }
                }
            }

            return obj;
        }
    }
}