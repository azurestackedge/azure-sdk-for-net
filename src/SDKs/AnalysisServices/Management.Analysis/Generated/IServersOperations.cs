// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Analysis
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServersOperations operations.
    /// </summary>
    public partial interface IServersOperations
    {
        /// <summary>
        /// Gets details about the specified Analysis Services server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be a minimum of 3
        /// characters, and a maximum of 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> GetDetailsWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Provisions the specified Analysis Services server based on the
        /// configuration specified in the request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be a minimum of 3
        /// characters, and a maximum of 63.
        /// </param>
        /// <param name='serverParameters'>
        /// Contains the information used to provision the Analysis Services
        /// server.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> CreateWithHttpMessagesAsync(string resourceGroupName, string serverName, AnalysisServicesServer serverParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Analysis Services server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the current state of the specified Analysis Services
        /// server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='serverUpdateParameters'>
        /// Request object that contains the updated information for the
        /// server.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> UpdateWithHttpMessagesAsync(string resourceGroupName, string serverName, AnalysisServicesServerUpdateParameters serverUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Supends operation of the specified Analysis Services server
        /// instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> SuspendWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resumes operation of the specified Analysis Services server
        /// instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResumeWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the Analysis Services servers for the given resource
        /// group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<AnalysisServicesServer>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<AnalysisServicesServer>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuEnumerationForNewResourceResult>> ListSkusForNewWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists eligible SKUs for an Analysis Services resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuEnumerationForExistingResourceResult>> ListSkusForExistingWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return the gateway status of the specified Analysis Services server
        /// instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="GatewayListStatusErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GatewayListStatusLive>> ListGatewayStatusWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Dissociates a Unified Gateway associated with the server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DissociateGatewayWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Check the name availability in the target location.
        /// </summary>
        /// <param name='location'>
        /// The region name which the operation will lookup into.
        /// </param>
        /// <param name='serverParameters'>
        /// Contains the information used to provision the Analysis Services
        /// server.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CheckServerNameAvailabilityResult>> CheckNameAvailabilityWithHttpMessagesAsync(string location, CheckServerNameAvailabilityParameters serverParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List the result of the specified operation.
        /// </summary>
        /// <param name='location'>
        /// The region name which the operation will lookup into.
        /// </param>
        /// <param name='operationId'>
        /// The target operation Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ListOperationResultsWithHttpMessagesAsync(string location, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List the status of operation.
        /// </summary>
        /// <param name='location'>
        /// The region name which the operation will lookup into.
        /// </param>
        /// <param name='operationId'>
        /// The target operation Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationStatus>> ListOperationStatusesWithHttpMessagesAsync(string location, string operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Provisions the specified Analysis Services server based on the
        /// configuration specified in the request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be a minimum of 3
        /// characters, and a maximum of 63.
        /// </param>
        /// <param name='serverParameters'>
        /// Contains the information used to provision the Analysis Services
        /// server.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string serverName, AnalysisServicesServer serverParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Analysis Services server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the current state of the specified Analysis Services
        /// server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='serverUpdateParameters'>
        /// Request object that contains the updated information for the
        /// server.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AnalysisServicesServer>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string serverName, AnalysisServicesServerUpdateParameters serverUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Supends operation of the specified Analysis Services server
        /// instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginSuspendWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resumes operation of the specified Analysis Services server
        /// instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure Resource group of which a given Analysis
        /// Services server is part. This name must be at least 1 character in
        /// length, and no more than 90.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Analysis Services server. It must be at least 3
        /// characters in length, and no more than 63.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginResumeWithHttpMessagesAsync(string resourceGroupName, string serverName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
