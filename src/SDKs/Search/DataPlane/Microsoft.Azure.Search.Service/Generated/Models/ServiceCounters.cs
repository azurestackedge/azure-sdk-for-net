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
    using System.Linq;

    /// <summary>
    /// Represents service-level resource counters and quotas.
    /// </summary>
    public partial class ServiceCounters
    {
        /// <summary>
        /// Initializes a new instance of the ServiceCounters class.
        /// </summary>
        public ServiceCounters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceCounters class.
        /// </summary>
        /// <param name="documentCounter">Total number of documents across all
        /// indexes in the service.</param>
        /// <param name="indexCounter">Total number of indexes.</param>
        /// <param name="indexerCounter">Total number of indexers.</param>
        /// <param name="dataSourceCounter">Total number of data
        /// sources.</param>
        /// <param name="storageSizeCounter">Total size of used storage in
        /// bytes.</param>
        /// <param name="synonymMapCounter">Total number of synonym
        /// maps.</param>
        public ServiceCounters(ResourceCounter documentCounter = default(ResourceCounter), ResourceCounter indexCounter = default(ResourceCounter), ResourceCounter indexerCounter = default(ResourceCounter), ResourceCounter dataSourceCounter = default(ResourceCounter), ResourceCounter storageSizeCounter = default(ResourceCounter), ResourceCounter synonymMapCounter = default(ResourceCounter))
        {
            DocumentCounter = documentCounter;
            IndexCounter = indexCounter;
            IndexerCounter = indexerCounter;
            DataSourceCounter = dataSourceCounter;
            StorageSizeCounter = storageSizeCounter;
            SynonymMapCounter = synonymMapCounter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets total number of documents across all indexes in the
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "documentCount")]
        public ResourceCounter DocumentCounter { get; set; }

        /// <summary>
        /// Gets or sets total number of indexes.
        /// </summary>
        [JsonProperty(PropertyName = "indexesCount")]
        public ResourceCounter IndexCounter { get; set; }

        /// <summary>
        /// Gets or sets total number of indexers.
        /// </summary>
        [JsonProperty(PropertyName = "indexersCount")]
        public ResourceCounter IndexerCounter { get; set; }

        /// <summary>
        /// Gets or sets total number of data sources.
        /// </summary>
        [JsonProperty(PropertyName = "dataSourcesCount")]
        public ResourceCounter DataSourceCounter { get; set; }

        /// <summary>
        /// Gets or sets total size of used storage in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "storageSize")]
        public ResourceCounter StorageSizeCounter { get; set; }

        /// <summary>
        /// Gets or sets total number of synonym maps.
        /// </summary>
        [JsonProperty(PropertyName = "synonymMaps")]
        public ResourceCounter SynonymMapCounter { get; set; }

    }
}
