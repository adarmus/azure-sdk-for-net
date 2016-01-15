// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Batch.Models;

namespace Microsoft.Azure.Management.Batch
{
    /// <summary>
    /// Operations for managing applications.
    /// </summary>
    public partial interface IApplicationOperations
    {
        /// <summary>
        /// Activates the specified application package.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='id'>
        /// The id of the application.
        /// </param>
        /// <param name='version'>
        /// The version of the application to activate.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ActivateApplicationPackageAsync(string resourceGroupName, string accountName, string id, string version, ActivateApplicationPackageParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds an application to the specified account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> AddApplicationAsync(string resourceGroupName, string accountName, string applicationId, AddApplicationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates an application package record.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='version'>
        /// The version of the application.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response to an ApplicationOperations.AddApplicationPackage request.
        /// </returns>
        Task<AddApplicationPackageResponse> AddApplicationPackageAsync(string resourceGroupName, string accountName, string applicationId, string version, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteApplicationAsync(string resourceGroupName, string accountName, string applicationId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes an application package record and the binary file.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='version'>
        /// The version of the application to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteApplicationPackageAsync(string resourceGroupName, string accountName, string applicationId, string version, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets information about the specified application.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response to an ApplicationOperations.GetApplication request.
        /// </returns>
        Task<GetApplicationResponse> GetApplicationAsync(string resourceGroupName, string accountName, string applicationId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets information about the specified application package.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='version'>
        /// The version of the application.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response to an ApplicationOperations.GetApplicationPackage request.
        /// </returns>
        Task<GetApplicationPackageResponse> GetApplicationPackageAsync(string resourceGroupName, string accountName, string applicationId, string version, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists all of the applications in the specified account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response to an ApplicationOperations.ListApplications request.
        /// </returns>
        Task<ListApplicationsResponse> ListAsync(string resourceGroupName, string accountName, ListApplicationsParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists all of the applications in the specified account.
        /// </summary>
        /// <param name='nextLink'>
        /// A nextLink URL from a previous List response.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response to an ApplicationOperations.ListApplications request.
        /// </returns>
        Task<ListApplicationsResponse> ListNextAsync(string nextLink, ListApplicationsParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates settings for the specified application.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The id of the application.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> UpdateApplicationAsync(string resourceGroupName, string accountName, string applicationId, UpdateApplicationParameters parameters, CancellationToken cancellationToken);
    }
}
