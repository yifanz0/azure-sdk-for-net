// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Enum to indicate the operation type of the event. </summary>
    public readonly partial struct CosmosDBOperationType : IEquatable<CosmosDBOperationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBOperationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBOperationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreateValue = "Create";
        private const string ReplaceValue = "Replace";
        private const string DeleteValue = "Delete";
        private const string SystemOperationValue = "SystemOperation";

        /// <summary> Create. </summary>
        public static CosmosDBOperationType Create { get; } = new CosmosDBOperationType(CreateValue);
        /// <summary> Replace. </summary>
        public static CosmosDBOperationType Replace { get; } = new CosmosDBOperationType(ReplaceValue);
        /// <summary> Delete. </summary>
        public static CosmosDBOperationType Delete { get; } = new CosmosDBOperationType(DeleteValue);
        /// <summary> SystemOperation. </summary>
        public static CosmosDBOperationType SystemOperation { get; } = new CosmosDBOperationType(SystemOperationValue);
        /// <summary> Determines if two <see cref="CosmosDBOperationType"/> values are the same. </summary>
        public static bool operator ==(CosmosDBOperationType left, CosmosDBOperationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBOperationType"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBOperationType left, CosmosDBOperationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBOperationType"/>. </summary>
        public static implicit operator CosmosDBOperationType(string value) => new CosmosDBOperationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBOperationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBOperationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
