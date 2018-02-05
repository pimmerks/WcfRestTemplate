namespace WcfRestTemplate.Service.Example
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// An implementation for <see cref="IExampleService"/>.
    /// </summary>
    public class ExampleService : IExampleService
    {
        /// <inheritdoc />
        public string Hello(string name)
        {
            return $"Hello {name}!";
        }
    }
}
