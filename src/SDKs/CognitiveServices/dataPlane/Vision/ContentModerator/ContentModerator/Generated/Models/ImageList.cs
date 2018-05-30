// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Image List Properties.
    /// </summary>
    public partial class ImageList
    {
        /// <summary>
        /// Initializes a new instance of the ImageList class.
        /// </summary>
        public ImageList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageList class.
        /// </summary>
        /// <param name="id">Image List Id.</param>
        /// <param name="name">Image List Name.</param>
        /// <param name="description">Description for image list.</param>
        /// <param name="metadata">Image List Metadata.</param>
        public ImageList(int? id = default(int?), string name = default(string), string description = default(string), ImageListMetadata metadata = default(ImageListMetadata))
        {
            Id = id;
            Name = name;
            Description = description;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets image List Id.
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets image List Name.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description for image list.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets image List Metadata.
        /// </summary>
        [JsonProperty(PropertyName = "Metadata")]
        public ImageListMetadata Metadata { get; set; }

    }
}
