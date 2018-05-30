// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Routing rules for ramp up testing. This rule allows to redirect static
    /// traffic % to a slot or to gradually change routing % based on
    /// performance.
    /// </summary>
    public partial class RampUpRule
    {
        /// <summary>
        /// Initializes a new instance of the RampUpRule class.
        /// </summary>
        public RampUpRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RampUpRule class.
        /// </summary>
        /// <param name="actionHostName">Hostname of a slot to which the
        /// traffic will be redirected if decided to. E.g.
        /// myapp-stage.azurewebsites.net.</param>
        /// <param name="reroutePercentage">Percentage of the traffic which
        /// will be redirected to
        /// &lt;code&gt;ActionHostName&lt;/code&gt;.</param>
        /// <param name="changeStep">In auto ramp up scenario this is the step
        /// to to add/remove from &lt;code&gt;ReroutePercentage&lt;/code&gt;
        /// until it reaches
        /// &lt;code&gt;MinReroutePercentage&lt;/code&gt; or
        /// &lt;code&gt;MaxReroutePercentage&lt;/code&gt;. Site metrics are
        /// checked every N minutes specificed in
        /// &lt;code&gt;ChangeIntervalInMinutes&lt;/code&gt;.
        /// Custom decision algorithm can be provided in TiPCallback site
        /// extension which URL can be specified in
        /// &lt;code&gt;ChangeDecisionCallbackUrl&lt;/code&gt;.</param>
        /// <param name="changeIntervalInMinutes">Specifies interval in
        /// mimuntes to reevaluate ReroutePercentage.</param>
        /// <param name="minReroutePercentage">Specifies lower boundary above
        /// which ReroutePercentage will stay.</param>
        /// <param name="maxReroutePercentage">Specifies upper boundary below
        /// which ReroutePercentage will stay.</param>
        /// <param name="changeDecisionCallbackUrl">Custom decision algorithm
        /// can be provided in TiPCallback site extension which URL can be
        /// specified. See TiPCallback site extension for the scaffold and
        /// contracts.
        /// https://www.siteextensions.net/packages/TiPCallback/</param>
        /// <param name="name">Name of the routing rule. The recommended name
        /// would be to point to the slot which will receive the traffic in the
        /// experiment.</param>
        public RampUpRule(string actionHostName = default(string), double? reroutePercentage = default(double?), double? changeStep = default(double?), int? changeIntervalInMinutes = default(int?), double? minReroutePercentage = default(double?), double? maxReroutePercentage = default(double?), string changeDecisionCallbackUrl = default(string), string name = default(string))
        {
            ActionHostName = actionHostName;
            ReroutePercentage = reroutePercentage;
            ChangeStep = changeStep;
            ChangeIntervalInMinutes = changeIntervalInMinutes;
            MinReroutePercentage = minReroutePercentage;
            MaxReroutePercentage = maxReroutePercentage;
            ChangeDecisionCallbackUrl = changeDecisionCallbackUrl;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets hostname of a slot to which the traffic will be
        /// redirected if decided to. E.g. myapp-stage.azurewebsites.net.
        /// </summary>
        [JsonProperty(PropertyName = "actionHostName")]
        public string ActionHostName { get; set; }

        /// <summary>
        /// Gets or sets percentage of the traffic which will be redirected to
        /// &amp;lt;code&amp;gt;ActionHostName&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "reroutePercentage")]
        public double? ReroutePercentage { get; set; }

        /// <summary>
        /// Gets or sets in auto ramp up scenario this is the step to to
        /// add/remove from
        /// &amp;lt;code&amp;gt;ReroutePercentage&amp;lt;/code&amp;gt; until it
        /// reaches
        /// &amp;lt;code&amp;gt;MinReroutePercentage&amp;lt;/code&amp;gt; or
        /// &amp;lt;code&amp;gt;MaxReroutePercentage&amp;lt;/code&amp;gt;. Site
        /// metrics are checked every N minutes specificed in
        /// &amp;lt;code&amp;gt;ChangeIntervalInMinutes&amp;lt;/code&amp;gt;.
        /// Custom decision algorithm can be provided in TiPCallback site
        /// extension which URL can be specified in
        /// &amp;lt;code&amp;gt;ChangeDecisionCallbackUrl&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "changeStep")]
        public double? ChangeStep { get; set; }

        /// <summary>
        /// Gets or sets specifies interval in mimuntes to reevaluate
        /// ReroutePercentage.
        /// </summary>
        [JsonProperty(PropertyName = "changeIntervalInMinutes")]
        public int? ChangeIntervalInMinutes { get; set; }

        /// <summary>
        /// Gets or sets specifies lower boundary above which ReroutePercentage
        /// will stay.
        /// </summary>
        [JsonProperty(PropertyName = "minReroutePercentage")]
        public double? MinReroutePercentage { get; set; }

        /// <summary>
        /// Gets or sets specifies upper boundary below which ReroutePercentage
        /// will stay.
        /// </summary>
        [JsonProperty(PropertyName = "maxReroutePercentage")]
        public double? MaxReroutePercentage { get; set; }

        /// <summary>
        /// Gets or sets custom decision algorithm can be provided in
        /// TiPCallback site extension which URL can be specified. See
        /// TiPCallback site extension for the scaffold and contracts.
        /// https://www.siteextensions.net/packages/TiPCallback/
        /// </summary>
        [JsonProperty(PropertyName = "changeDecisionCallbackUrl")]
        public string ChangeDecisionCallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets name of the routing rule. The recommended name would
        /// be to point to the slot which will receive the traffic in the
        /// experiment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
