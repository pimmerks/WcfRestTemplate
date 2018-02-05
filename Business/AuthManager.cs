namespace WcfRestTemplate.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The <see cref="AuthManager"/>.
    /// </summary>
    public class AuthManager : ServiceAuthorizationManager
    {
        private static readonly log4net.ILog Log
            = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <inheritdoc />
        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            Log.Info($"Request for: {operationContext.IncomingMessageProperties.Via.AbsoluteUri}");
            // TODO: Add authentication.
            return base.CheckAccessCore(operationContext);
        }
    }
}
