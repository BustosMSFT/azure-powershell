namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>ApplyRecoveryPoint input specific to InMageAzureV2 provider.</summary>
    public partial class InMageAzureV2ApplyRecoveryPointInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2ApplyRecoveryPointInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2ApplyRecoveryPointInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput __applyRecoveryPointProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ApplyRecoveryPointProviderSpecificInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal)__applyRecoveryPointProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal)__applyRecoveryPointProviderSpecificInput).InstanceType = value ; }

        /// <summary>Creates an new <see cref="InMageAzureV2ApplyRecoveryPointInput" /> instance.</summary>
        public InMageAzureV2ApplyRecoveryPointInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__applyRecoveryPointProviderSpecificInput), __applyRecoveryPointProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__applyRecoveryPointProviderSpecificInput), __applyRecoveryPointProviderSpecificInput);
        }
    }
    /// ApplyRecoveryPoint input specific to InMageAzureV2 provider.
    public partial interface IInMageAzureV2ApplyRecoveryPointInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput
    {

    }
    /// ApplyRecoveryPoint input specific to InMageAzureV2 provider.
    internal partial interface IInMageAzureV2ApplyRecoveryPointInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal
    {

    }
}