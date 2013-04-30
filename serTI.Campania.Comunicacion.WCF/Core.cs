using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Xml;

namespace serTI.Campania.Comunicacion.WCF
{
/// <summary>
    /// This class generated a comunication bettwen services and web sites sharepoint etc
    /// </summary>
    public class Core
    {
        /// <summary>
        /// Get a servives path
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetServicePath(string name)
        {
            string path = ConfigurationManager.AppSettings[name].Trim();

            //valida si ya trae la ultima diagonal
            if (!path.EndsWith("/"))
                path += "/";

            return path;
        }
        /// <summary>
        /// Get a bindig config of services
        /// </summary>
        /// <returns></returns>
        public static BasicHttpBinding GetBinding()
        {
            var loBin = new BasicHttpBinding
                            {
                                HostNameComparisonMode = HostNameComparisonMode.StrongWildcard,
                                AllowCookies = false,
                                BypassProxyOnLocal = false,
                                UseDefaultWebProxy = false,
                                OpenTimeout = new TimeSpan(1, 0, 0),
                                CloseTimeout = new TimeSpan(1, 0, 0),
                                ReceiveTimeout = new TimeSpan(1, 0, 0),
                                SendTimeout = new TimeSpan(1, 0, 0),
                                MaxBufferPoolSize = int.MaxValue,
                                MaxBufferSize = int.MaxValue,
                                MaxReceivedMessageSize = int.MaxValue,
                                MessageEncoding = WSMessageEncoding.Text,
                                TransferMode = TransferMode.StreamedResponse
                            };

            var loRQ = new XmlDictionaryReaderQuotas();

            loRQ.MaxArrayLength = int.MaxValue;
            loRQ.MaxBytesPerRead = int.MaxValue;
            loRQ.MaxDepth = int.MaxValue;
            loRQ.MaxStringContentLength = int.MaxValue;
            loRQ.MaxNameTableCharCount = int.MaxValue;

            loBin.ReaderQuotas = loRQ;
            loBin.TextEncoding = Encoding.UTF8;

            return loBin;
        }
    }
}
