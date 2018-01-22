// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Storage.Fluent
{
    using Microsoft.Azure.Management.Storage.Fluent.Models;
    using System;

    internal abstract partial class StorageAccountEncryptionStatusImpl 
    {
        /// <summary>
        /// Gets true if the encryption is enabled for the service false otherwise.
        /// </summary>
        bool Microsoft.Azure.Management.Storage.Fluent.IStorageAccountEncryptionStatus.IsEnabled
        {
            get
            {
                return this.IsEnabled();
            }
        }

        /// <summary>
        /// Gets rough estimate of the date/time when the encryption was last enabled, null if
        /// the encryption is disabled.
        /// </summary>
        System.DateTime? Microsoft.Azure.Management.Storage.Fluent.IStorageAccountEncryptionStatus.LastEnabledTime
        {
            get
            {
                return this.LastEnabledTime();
            }
        }
    }
}