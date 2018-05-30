// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.EntitySearch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the identity of a resource.
    /// </summary>
    public partial class Identifiable : ResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the Identifiable class.
        /// </summary>
        public Identifiable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Identifiable class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        public Identifiable(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a String identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
