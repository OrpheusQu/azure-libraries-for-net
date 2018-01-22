// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The usage names that can be used; currently limited to StorageAccount.
    /// </summary>
    public partial class UsageName
    {
        /// <summary>
        /// Initializes a new instance of the UsageName class.
        /// </summary>
        public UsageName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageName class.
        /// </summary>
        /// <param name="value">Gets a string describing the resource
        /// name.</param>
        /// <param name="localizedValue">Gets a localized string describing the
        /// resource name.</param>
        public UsageName(string value = default(string), string localizedValue = default(string))
        {
            Value = value;
            LocalizedValue = localizedValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a string describing the resource name.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        /// <summary>
        /// Gets a localized string describing the resource name.
        /// </summary>
        [JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue { get; private set; }

    }
}
