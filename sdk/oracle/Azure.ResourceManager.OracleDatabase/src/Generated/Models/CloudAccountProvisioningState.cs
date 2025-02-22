// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary>
    /// CloudAccountProvisioningState enum
    /// Serialized Name: CloudAccountProvisioningState
    /// </summary>
    public readonly partial struct CloudAccountProvisioningState : IEquatable<CloudAccountProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudAccountProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudAccountProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ProvisioningValue = "Provisioning";
        private const string AvailableValue = "Available";

        /// <summary>
        /// Pending - Initial state when Oracle cloud account is not configured
        /// Serialized Name: CloudAccountProvisioningState.Pending
        /// </summary>
        public static CloudAccountProvisioningState Pending { get; } = new CloudAccountProvisioningState(PendingValue);
        /// <summary>
        /// Provisioning - State when Oracle cloud account is being provisioned
        /// Serialized Name: CloudAccountProvisioningState.Provisioning
        /// </summary>
        public static CloudAccountProvisioningState Provisioning { get; } = new CloudAccountProvisioningState(ProvisioningValue);
        /// <summary>
        /// Available - State when Oracle cloud account cloud linking is complete and it is available
        /// Serialized Name: CloudAccountProvisioningState.Available
        /// </summary>
        public static CloudAccountProvisioningState Available { get; } = new CloudAccountProvisioningState(AvailableValue);
        /// <summary> Determines if two <see cref="CloudAccountProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CloudAccountProvisioningState left, CloudAccountProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudAccountProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CloudAccountProvisioningState left, CloudAccountProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CloudAccountProvisioningState"/>. </summary>
        public static implicit operator CloudAccountProvisioningState(string value) => new CloudAccountProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudAccountProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudAccountProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
