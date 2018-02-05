namespace WcfRestTemplate.Business
{
    using Ninject.Modules;

    /// <inheritdoc />
    /// <summary>
    /// Ninject module for data layer bindings.
    /// </summary>
    public class BusinessLayerModule : NinjectModule
    {
        /// <inheritdoc />
        public override void Load()
        {
            // TODO: Bind data modules to kernel.
            // this.Kernel.Bind<IDatabaseContext>().To<DatabaseContext>();
        }
    }
}