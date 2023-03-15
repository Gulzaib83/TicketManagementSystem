using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestAppEF
{
    internal class CustomChannelFactory
    {
        public static T CreateChannel<T>()
        {

            T channel = default(T);
            Type channelType = typeof(T);
            string serviceName = channelType.Name;
            serviceName = serviceName.Substring(1); // Leave "I" of Interface Name
            string baseAddress = "http://localhost/CommonHostForWCF/";

            string address = string.Format("{0}{1}.svc", baseAddress, serviceName);

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
