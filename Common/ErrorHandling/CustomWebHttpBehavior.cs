namespace WcfRestTemplate.Common.ErrorHandling
{
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel.Description;
    using System.ServiceModel.Dispatcher;
    using System.ServiceModel.Web;
    using System.Text;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// The <see cref="T:WcfRestTemplate.Common.ErrorHandling.CustomWebHttpBehavior" />.
    /// </summary>
    public sealed class CustomWebHttpBehavior : WebHttpBehavior
    {
        /// <inheritdoc />
        public CustomWebHttpBehavior()
        {
            this.DefaultBodyStyle = WebMessageBodyStyle.Wrapped;
            this.HelpEnabled = true;
            this.FaultExceptionEnabled = true;
        }

        /// <inheritdoc />
        protected override void AddServerErrorHandlers(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            // Clear default error handlers.
            endpointDispatcher.ChannelDispatcher.ErrorHandlers.Clear();

            // Add our own error handler.
            endpointDispatcher.ChannelDispatcher.ErrorHandlers.Add(new RestErrorHandler());;
        }
    }
}
