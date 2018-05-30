// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data Lake Analytics account name availability check parameters.
    /// </summary>
    public partial class CheckNameAvailabilityParameters
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityParameters
        /// class.
        /// </summary>
        public CheckNameAvailabilityParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityParameters
        /// class.
        /// </summary>
        /// <param name="name">The Data Lake Analytics name to check
        /// availability for.</param>
        public CheckNameAvailabilityParameters(string name)
        {
            Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for CheckNameAvailabilityParameters class.
        /// </summary>
        static CheckNameAvailabilityParameters()
        {
            Type = "Microsoft.DataLakeAnalytics/accounts";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Data Lake Analytics name to check availability
        /// for.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The resource type. Note: This should not be set by the user, as the
        /// constant value is Microsoft.DataLakeAnalytics/accounts
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
