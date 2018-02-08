namespace WcfRestTemplate.Common.ErrorHandling
{
    using System;
    using System.Net;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Dispatcher;

    /// <summary>
    /// The <see cref="RestErrorHandler"/>.
    /// </summary>
    public class RestErrorHandler : IErrorHandler
    {
        /// <inheritdoc />
        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            // Log error to log4net.
            var log = log4net.LogManager.GetLogger(error.TargetSite.DeclaringType);
            log.Error("Exception occurred.", error);

            var ex = JsonException.Make(error);

            // Create the fault.
            fault = Message.CreateMessage(version, string.Empty, new JsonErrorBodyWriter(ex));

            // Return the fault in json format.
            fault.Properties.Add(WebBodyFormatMessageProperty.Name,
                new WebBodyFormatMessageProperty(WebContentFormat.Json));

            // Add message headers and properties.
            var rmp = new HttpResponseMessageProperty { StatusCode = HttpStatusCode.InternalServerError };
            rmp.Headers.Add(HttpResponseHeader.ContentType, "application/json; charset=utf-8");
            fault.Properties.Add(HttpResponseMessageProperty.Name, rmp);
        }

        /// <inheritdoc />
        public bool HandleError(Exception error)
        {
            // TODO: Or return false on custom exceptions.
            return true;
        }
    }
}
