namespace WcfRestTemplate.Common.ErrorHandling
{
    using System;
    using System.ServiceModel.Configuration;

    /// <inheritdoc />
    public class WebHttpBehaviorExtension : BehaviorExtensionElement
    {
        /// <inheritdoc />
        protected override object CreateBehavior() { return new CustomWebHttpBehavior(); }

        /// <inheritdoc />
        public override Type BehaviorType => typeof(CustomWebHttpBehavior);
    }
}