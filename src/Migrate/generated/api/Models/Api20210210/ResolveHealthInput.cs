namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Resolve health input.</summary>
    public partial class ResolveHealthInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputInternal
    {

        /// <summary>Health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthError[] HealthError { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputPropertiesInternal)Property).HealthError; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputPropertiesInternal)Property).HealthError = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResolveHealthInputProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputProperties _property;

        /// <summary>Disable resolve health input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResolveHealthInputProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="ResolveHealthInput" /> instance.</summary>
        public ResolveHealthInput()
        {

        }
    }
    /// Resolve health input.
    public partial interface IResolveHealthInput :
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
    /// Resolve health input.
    internal partial interface IResolveHealthInputInternal

    {
        /// <summary>Health errors.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthError[] HealthError { get; set; }
        /// <summary>Disable resolve health input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResolveHealthInputProperties Property { get; set; }

    }
}