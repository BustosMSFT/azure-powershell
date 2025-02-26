namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The tags for the target NICs.</summary>
    public partial class InMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="InMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags" /> instance.
        /// </summary>
        public InMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags()
        {

        }
    }
    /// The tags for the target NICs.
    public partial interface IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags for the target NICs.
    internal partial interface IInMageAzureV2UpdateReplicationProtectedItemInputTargetNicTagsInternal

    {

    }
}