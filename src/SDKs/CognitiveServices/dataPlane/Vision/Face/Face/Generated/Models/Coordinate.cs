// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Coordinates within an image
    /// </summary>
    public partial class Coordinate
    {
        /// <summary>
        /// Initializes a new instance of the Coordinate class.
        /// </summary>
        public Coordinate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Coordinate class.
        /// </summary>
        /// <param name="x">The horizontal component, in pixels.</param>
        /// <param name="y">The vertical component, in pixels.</param>
        public Coordinate(double x, double y)
        {
            X = x;
            Y = y;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the horizontal component, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "x")]
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the vertical component, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public double Y { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
