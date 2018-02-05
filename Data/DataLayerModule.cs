namespace WcfRestTemplate.Data
{
    using Ninject.Modules;

    /// <inheritdoc />
    /// <summary>
    /// Ninject module for data layer bindings.
    /// </summary>
    public class DataLayerModule : NinjectModule
    {
        /// <inheritdoc />
        public override void Load()
        {
            // TODO: Bind data modules to kernel.
            // this.Kernel.Bind<IDatabaseContext>().To<DatabaseContext>();
        }
    }
}