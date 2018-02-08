namespace WcfRestTemplate.Common.ErrorHandling
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The <see cref="JsonException"/>.
    /// </summary>
    [DataContract]
    public class JsonException
    {
        /// <summary>
        /// Gets or sets the exception type.
        /// </summary>
        [DataMember]
        public string ExceptionType { get; set; }

        /// <summary>
        /// Gets or sets the exception message.
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the exception source.
        /// </summary>
        [DataMember]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        [DataMember]
        public Exception Exception { get; set; }

        /// <summary>
        /// Gets or sets the datetime the exception occurred.
        /// </summary>
        [DataMember]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Create an <see cref="JsonException"/> from an regular <see cref="Exception"/>.
        /// </summary>
        /// <param name="ex">The <see cref="Exception"/> to create an json exception from.</param>
        /// <returns>A new <see cref="JsonException"/> object.</returns>
        public static JsonException Make(Exception ex)
        {
            return new JsonException
            {
                Exception = ex,
                ExceptionType = ex.GetType().FullName,
                Message = ex.Message,
                Source = ex.Source,
                DateTime = DateTime.Now,
            };
        }
    }
}
