// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a list of of inputs to a Job.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.JobInputs")]
    public partial class JobInputs : JobInput
    {
        /// <summary>
        /// Initializes a new instance of the JobInputs class.
        /// </summary>
        public JobInputs()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobInputs class.
        /// </summary>
        /// <param name="label">A label that is assigned to a JobInput, that is
        /// used to satisfy a reference used in the Transform. For example, a
        /// Transform can be authored so as to take an image file with the
        /// label 'xyz' and apply it as an overlay onto the input video before
        /// it is encoded. When submitting a Job, exactly one of the JobInputs
        /// should be the image file, and it should have the label
        /// 'xyz'.</param>
        /// <param name="inputs">List of inputs to a Job.</param>
        public JobInputs(string label = default(string), IList<JobInput> inputs = default(IList<JobInput>))
            : base(label)
        {
            Inputs = inputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of inputs to a Job.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IList<JobInput> Inputs { get; set; }

    }
}
