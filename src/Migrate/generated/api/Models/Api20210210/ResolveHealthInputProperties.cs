namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Resolve health input properties.</summary>
    public partial class ResolveHealthInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="HealthError" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthError[] _healthError;

        /// <summary>Health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthError[] HealthError { get => this._healthError; set => this._healthError = value; }

        /// <summary>Creates an new <see cref="ResolveHealthInputProperties" /> instance.</summary>
        public ResolveHealthInputProperties()
        {

        }
    }
    /// Resolve health input properties.
    public partial interface IResolveHealthInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health errors.",
        SerializedName = @"healthErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthError) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthError[] HealthError { get; set; }

    }
    /// Resolve health input properties.
    internal partial interface IResolveHealthInputPropertiesInternal

    {
        /// <summary>Health errors.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthError[] HealthError { get; set; }

    }
}