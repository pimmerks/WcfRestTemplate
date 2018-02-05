namespace WcfRestTemplate.Service.Example
{
    using System.ServiceModel;
    using System.ServiceModel.Web;

    /// <summary>
    /// An example service.
    /// </summary>
    [ServiceContract]
    public interface IExampleService
    {
        /// <summary>
        /// Greets the user.
        /// </summary>
        /// <param name="name">The name to say hello to.</param>
        /// <returns>A nice greeting.</returns>
        [OperationContract]
        [WebGet(
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string Hello(string name);
    }
}