// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ElasticPoolsOperations.
    /// </summary>
    public static partial class ElasticPoolsOperationsExtensions
    {
            /// <summary>
            /// Creates a new Azure SQL elastic pool or updates an existing Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be operated on (Updated or
            /// created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an Elastic Pool.
            /// </param>
            public static ElasticPoolInner CreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolInner parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure SQL elastic pool or updates an existing Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be operated on (Updated or
            /// created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an Elastic Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPoolInner> CreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be deleted.
            /// </param>
            public static void Delete(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets information about an Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            public static ElasticPoolInner Get(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.GetAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about an Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPoolInner> GetAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            public static IEnumerable<ElasticPoolInner> ListByServer(this IElasticPoolsOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ElasticPoolInner>> ListByServerAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool for which to get the current
            /// activity.
            /// </param>
            public static IEnumerable<ElasticPoolActivityInner> ListActivity(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.ListActivityAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about Azure SQL elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool for which to get the current
            /// activity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ElasticPoolActivityInner>> ListActivityAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListActivityWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about activity on Azure SQL databases inside of an
            /// Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool.
            /// </param>
            public static IEnumerable<ElasticPoolDatabaseActivityInner> ListDatabaseActivity(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.ListDatabaseActivityAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about activity on Azure SQL databases inside of an
            /// Azure SQL elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ElasticPoolDatabaseActivityInner>> ListDatabaseActivityAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDatabaseActivityWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about an Azure SQL database inside of an Azure SQL elastic
            /// pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the Azure SQL database to be retrieved.
            /// </param>
            public static DatabaseInner GetDatabase(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string databaseName)
            {
                return operations.GetDatabaseAsync(resourceGroupName, serverName, elasticPoolName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about an Azure SQL database inside of an Azure SQL elastic
            /// pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the Azure SQL database to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseInner> GetDatabaseAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns information about an Azure SQL database inside of an Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            public static IEnumerable<DatabaseInner> ListDatabases(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.ListDatabasesAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns information about an Azure SQL database inside of an Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DatabaseInner>> ListDatabasesAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDatabasesWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Azure SQL elastic pool or updates an existing Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be operated on (Updated or
            /// created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an Elastic Pool.
            /// </param>
            public static ElasticPoolInner BeginCreateOrUpdate(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolInner parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, elasticPoolName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure SQL elastic pool or updates an existing Azure SQL
            /// elastic pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the Azure SQL Elastic Pool to be operated on (Updated or
            /// created).
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating an Elastic Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ElasticPoolInner> BeginCreateOrUpdateAsync(this IElasticPoolsOperations operations, string resourceGroupName, string serverName, string elasticPoolName, ElasticPoolInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}