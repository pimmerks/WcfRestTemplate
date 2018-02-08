namespace WcfRestTemplate.Service.Example
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// An implementation of <see cref="IExampleService"/>.
    /// </summary>
    public class ExampleService : IExampleService
    {
        /// <inheritdoc />
        public string Hello(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("No name provided.", nameof(name));
            }
            return $"Hello {name}!";
        }
    }
}
