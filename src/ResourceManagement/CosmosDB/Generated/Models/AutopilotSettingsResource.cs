// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cosmos DB autopilot settings object
    /// </summary>
    public partial class AutopilotSettingsResource
    {
        /// <summary>
        /// Initializes a new instance of the AutopilotSettingsResource class.
        /// </summary>
        public AutopilotSettingsResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutopilotSettingsResource class.
        /// </summary>
        /// <param name="maxThroughput">Represents max throughput an autopilot
        /// container can operate at.</param>
        /// <param name="autoUpgradePolicy">Cosmos DB resource auto-upgrade
        /// policy</param>
        /// <param name="targetMaxThroughput">Represents target max throughput
        /// an autopilot container should operate at once offer is no longer in
        /// pending state.</param>
        public AutopilotSettingsResource(int maxThroughput, AutoUpgradePolicyResource autoUpgradePolicy = default(AutoUpgradePolicyResource), int? targetMaxThroughput = default(int?))
        {
            MaxThroughput = maxThroughput;
            AutoUpgradePolicy = autoUpgradePolicy;
            TargetMaxThroughput = targetMaxThroughput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets represents max throughput an autopilot container can
        /// operate at.
        /// </summary>
        [JsonProperty(PropertyName = "maxThroughput")]
        public int MaxThroughput { get; set; }

        /// <summary>
        /// Gets or sets cosmos DB resource auto-upgrade policy
        /// </summary>
        [JsonProperty(PropertyName = "autoUpgradePolicy")]
        public AutoUpgradePolicyResource AutoUpgradePolicy { get; set; }

        /// <summary>
        /// Gets represents target max throughput an autopilot container should
        /// operate at once offer is no longer in pending state.
        /// </summary>
        [JsonProperty(PropertyName = "targetMaxThroughput")]
        public int? TargetMaxThroughput { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
