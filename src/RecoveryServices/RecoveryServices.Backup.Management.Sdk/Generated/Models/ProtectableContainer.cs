// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Protectable Container Class.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ProtectableContainer")]
    public partial class ProtectableContainer
    {
        /// <summary>
        /// Initializes a new instance of the ProtectableContainer class.
        /// </summary>
        public ProtectableContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProtectableContainer class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup management for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage',
        /// 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        /// <param name="containerId">Fabric Id of the container such as ARM
        /// Id.</param>
        public ProtectableContainer(string friendlyName = default(string), string backupManagementType = default(string), string healthStatus = default(string), string containerId = default(string))
        {
            FriendlyName = friendlyName;
            BackupManagementType = backupManagementType;
            HealthStatus = healthStatus;
            ContainerId = containerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of the container.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets type of backup management for the container. Possible
        /// values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql', 'AzureStorage', 'AzureWorkload',
        /// 'DefaultBackup'
        /// </summary>
        [JsonProperty(PropertyName = "backupManagementType")]
        public string BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets status of health of the container.
        /// </summary>
        [JsonProperty(PropertyName = "healthStatus")]
        public string HealthStatus { get; set; }

        /// <summary>
        /// Gets or sets fabric Id of the container such as ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "containerId")]
        public string ContainerId { get; set; }

    }
}
