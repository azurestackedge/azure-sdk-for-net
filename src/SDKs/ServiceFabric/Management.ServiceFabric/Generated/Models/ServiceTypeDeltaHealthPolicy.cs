// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the delta health policy used to evaluate the health of
    /// services belonging to a service type when upgrading the cluster.
    ///
    /// </summary>
    public partial class ServiceTypeDeltaHealthPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ServiceTypeDeltaHealthPolicy
        /// class.
        /// </summary>
        public ServiceTypeDeltaHealthPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceTypeDeltaHealthPolicy
        /// class.
        /// </summary>
        /// <param name="maxPercentDeltaUnhealthyServices">The maximum allowed
        /// percentage of services health degradation allowed during cluster
        /// upgrades.
        /// The delta is measured between the state of the services at the
        /// beginning of upgrade and the state of the services at the time of
        /// the health evaluation.
        /// The check is performed after every upgrade domain upgrade
        /// completion to make sure the global state of the cluster is within
        /// tolerated limits.
        /// </param>
        public ServiceTypeDeltaHealthPolicy(int? maxPercentDeltaUnhealthyServices = default(int?))
        {
            MaxPercentDeltaUnhealthyServices = maxPercentDeltaUnhealthyServices;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum allowed percentage of services health
        /// degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the services at the
        /// beginning of upgrade and the state of the services at the time of
        /// the health evaluation.
        /// The check is performed after every upgrade domain upgrade
        /// completion to make sure the global state of the cluster is within
        /// tolerated limits.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "maxPercentDeltaUnhealthyServices")]
        public int? MaxPercentDeltaUnhealthyServices { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxPercentDeltaUnhealthyServices > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxPercentDeltaUnhealthyServices", 100);
            }
            if (MaxPercentDeltaUnhealthyServices < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxPercentDeltaUnhealthyServices", 0);
            }
        }
    }
}
