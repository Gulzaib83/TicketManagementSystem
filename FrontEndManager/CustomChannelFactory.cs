using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndManager
{
    /// <summary>
    /// This class creates new channel for WCF Service
    /// This assumes WCF service is hosted over IIS
    /// </summary>
    internal class CustomChannelFactory
    {
        public static T CreateChannel<T>()
        {
            // Here T represents the Generic Class name of WCF Service Contract (Interface name)
            T channel = default(T);
            Type channelType = typeof(T);
            string serviceName = channelType.Name;
            serviceName = serviceName.Substring(1); // Leave "I" of Interface Name
            // Base address of WCF Host project from IIS
            string baseAddress = "http://localhost/CommonHostForWCF/";

            string address = string.Format("{0}{1}.svc", baseAddress, serviceName);

            // Create WCF service EndPoint dynamically
            // Here we are using Basic Http Binding
            // Default Security for Basic Http i.e. provided .NET Framework
            Uri serviceEndPointAddress = new Uri(address);
            {
                var bindings = new BasicHttpBinding();
                var endPoint = new EndpointAddress(serviceEndPointAddress);

                ChannelFactory<T> factory = new ChannelFactory<T>(bindings, endPoint);
                channel = factory.CreateChannel();
                return channel;
            }          
        }
    }
}
