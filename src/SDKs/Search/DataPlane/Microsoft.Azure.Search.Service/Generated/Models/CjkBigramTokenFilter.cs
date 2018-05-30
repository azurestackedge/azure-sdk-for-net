// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Forms bigrams of CJK terms that are generated from StandardTokenizer.
    /// This token filter is implemented using Apache Lucene.
    /// <see
    /// href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/cjk/CJKBigramFilter.html"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.CjkBigramTokenFilter")]
    public partial class CjkBigramTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the CjkBigramTokenFilter class.
        /// </summary>
        public CjkBigramTokenFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CjkBigramTokenFilter class.
        /// </summary>
        /// <param name="name">The name of the token filter. It must only
        /// contain letters, digits, spaces, dashes or underscores, can only
        /// start and end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="ignoreScripts">The scripts to ignore.</param>
        /// <param name="outputUnigrams">A value indicating whether to output
        /// both unigrams and bigrams (if true), or just bigrams (if false).
        /// Default is false.</param>
        public CjkBigramTokenFilter(string name, IList<CjkBigramTokenFilterScripts> ignoreScripts = default(IList<CjkBigramTokenFilterScripts>), bool? outputUnigrams = default(bool?))
            : base(name)
        {
            IgnoreScripts = ignoreScripts;
            OutputUnigrams = outputUnigrams;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the scripts to ignore.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreScripts")]
        public IList<CjkBigramTokenFilterScripts> IgnoreScripts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to output both unigrams and
        /// bigrams (if true), or just bigrams (if false). Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "outputUnigrams")]
        public bool? OutputUnigrams { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
