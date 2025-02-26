namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>A recoverable server resource.</summary>
    public partial class RecoverableServerResource :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResource,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.Resource();

        /// <summary>Edition of the performance tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string Edition { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).Edition; }

        /// <summary>Hardware generation associated with the service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string HardwareGeneration { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).HardwareGeneration; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>The last available backup date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string LastAvailableBackupDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).LastAvailableBackupDateTime; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Edition</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResourceInternal.Edition { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).Edition; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).Edition = value; }

        /// <summary>Internal Acessors for HardwareGeneration</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResourceInternal.HardwareGeneration { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).HardwareGeneration; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).HardwareGeneration = value; }

        /// <summary>Internal Acessors for LastAvailableBackupDateTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResourceInternal.LastAvailableBackupDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).LastAvailableBackupDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).LastAvailableBackupDateTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.RecoverableServerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ServiceLevelObjective</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResourceInternal.ServiceLevelObjective { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).ServiceLevelObjective; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).ServiceLevelObjective = value; }

        /// <summary>Internal Acessors for VCore</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResourceInternal.VCore { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).VCore; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).VCore = value; }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerResourceInternal.Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).Version = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties _property;

        /// <summary>Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.RecoverableServerProperties()); set => this._property = value; }

        /// <summary>The service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string ServiceLevelObjective { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).ServiceLevelObjective; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>vCore associated with the service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? VCore { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).VCore; }

        /// <summary>The PostgreSQL version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal)Property).Version; }

        /// <summary>Creates an new <see cref="RecoverableServerResource" /> instance.</summary>
        public RecoverableServerResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A recoverable server resource.
    public partial interface IRecoverableServerResource :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResource
    {
        /// <summary>Edition of the performance tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Edition of the performance tier.",
        SerializedName = @"edition",
        PossibleTypes = new [] { typeof(string) })]
        string Edition { get;  }
        /// <summary>Hardware generation associated with the service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Hardware generation associated with the service level objective",
        SerializedName = @"hardwareGeneration",
        PossibleTypes = new [] { typeof(string) })]
        string HardwareGeneration { get;  }
        /// <summary>The last available backup date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last available backup date time.",
        SerializedName = @"lastAvailableBackupDateTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastAvailableBackupDateTime { get;  }
        /// <summary>The service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service level objective",
        SerializedName = @"serviceLevelObjective",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceLevelObjective { get;  }
        /// <summary>vCore associated with the service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"vCore associated with the service level objective",
        SerializedName = @"vCore",
        PossibleTypes = new [] { typeof(int) })]
        int? VCore { get;  }
        /// <summary>The PostgreSQL version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The PostgreSQL version",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// A recoverable server resource.
    internal partial interface IRecoverableServerResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api10.IResourceInternal
    {
        /// <summary>Edition of the performance tier.</summary>
        string Edition { get; set; }
        /// <summary>Hardware generation associated with the service level objective</summary>
        string HardwareGeneration { get; set; }
        /// <summary>The last available backup date time.</summary>
        string LastAvailableBackupDateTime { get; set; }
        /// <summary>Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties Property { get; set; }
        /// <summary>The service level objective</summary>
        string ServiceLevelObjective { get; set; }
        /// <summary>vCore associated with the service level objective</summary>
        int? VCore { get; set; }
        /// <summary>The PostgreSQL version</summary>
        string Version { get; set; }

    }
}