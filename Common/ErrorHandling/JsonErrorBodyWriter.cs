namespace WcfRestTemplate.Common.ErrorHandling
{
    using System;
    using System.Runtime.Serialization.Json;
    using System.ServiceModel.Channels;
    using System.Text;
    using System.Xml;
    using Newtonsoft.Json;

    /// <inheritdoc />
    public class JsonErrorBodyWriter : BodyWriter
    {
        private readonly JsonException exc;

        /// <inheritdoc />
        protected override void OnWriteBodyContents(XmlDictionaryWriter writer)
        {
            var json = JsonConvert.SerializeObject(this.exc);
            var jsonBytes = Encoding.UTF8.GetBytes(json);
            using (var reader = JsonReaderWriterFactory.CreateJsonReader(jsonBytes, XmlDictionaryReaderQuotas.Max))
            {
                writer.WriteNode(reader, false);
            }
        }

        /// <inheritdoc />
        public JsonErrorBodyWriter(JsonException ex) : base(true)
        {
            this.exc = ex;
        }
    }
}