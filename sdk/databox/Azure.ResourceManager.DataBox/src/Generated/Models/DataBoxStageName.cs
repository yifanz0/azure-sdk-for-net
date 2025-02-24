// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Name of the stage which is in progress. </summary>
    public readonly partial struct DataBoxStageName : IEquatable<DataBoxStageName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxStageName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxStageName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeviceOrderedValue = "DeviceOrdered";
        private const string DevicePreparedValue = "DevicePrepared";
        private const string DispatchedValue = "Dispatched";
        private const string DeliveredValue = "Delivered";
        private const string PickedUpValue = "PickedUp";
        private const string AtAzureDCValue = "AtAzureDC";
        private const string DataCopyValue = "DataCopy";
        private const string CompletedValue = "Completed";
        private const string CompletedWithErrorsValue = "CompletedWithErrors";
        private const string CancelledValue = "Cancelled";
        private const string FailedIssueReportedAtCustomerValue = "Failed_IssueReportedAtCustomer";
        private const string FailedIssueDetectedAtAzureDCValue = "Failed_IssueDetectedAtAzureDC";
        private const string AbortedValue = "Aborted";
        private const string CompletedWithWarningsValue = "CompletedWithWarnings";
        private const string ReadyToDispatchFromAzureDCValue = "ReadyToDispatchFromAzureDC";
        private const string ReadyToReceiveAtAzureDCValue = "ReadyToReceiveAtAzureDC";
        private const string CreatedValue = "Created";
        private const string ShippedToAzureDCValue = "ShippedToAzureDC";
        private const string AwaitingShipmentDetailsValue = "AwaitingShipmentDetails";
        private const string PreparingToShipFromAzureDCValue = "PreparingToShipFromAzureDC";
        private const string ShippedToCustomerValue = "ShippedToCustomer";

        /// <summary> An order has been created. </summary>
        public static DataBoxStageName DeviceOrdered { get; } = new DataBoxStageName(DeviceOrderedValue);
        /// <summary> A device has been prepared for the order. </summary>
        public static DataBoxStageName DevicePrepared { get; } = new DataBoxStageName(DevicePreparedValue);
        /// <summary> Device has been dispatched to the user of the order. </summary>
        public static DataBoxStageName Dispatched { get; } = new DataBoxStageName(DispatchedValue);
        /// <summary> Device has been delivered to the user of the order. </summary>
        public static DataBoxStageName Delivered { get; } = new DataBoxStageName(DeliveredValue);
        /// <summary> Device has been picked up from user and in transit to Azure datacenter. </summary>
        public static DataBoxStageName PickedUp { get; } = new DataBoxStageName(PickedUpValue);
        /// <summary> Device has been received at Azure datacenter from the user. </summary>
        public static DataBoxStageName AtAzureDC { get; } = new DataBoxStageName(AtAzureDCValue);
        /// <summary> Data copy from the device at Azure datacenter. </summary>
        public static DataBoxStageName DataCopy { get; } = new DataBoxStageName(DataCopyValue);
        /// <summary> Order has completed. </summary>
        public static DataBoxStageName Completed { get; } = new DataBoxStageName(CompletedValue);
        /// <summary> Order has completed with errors. </summary>
        public static DataBoxStageName CompletedWithErrors { get; } = new DataBoxStageName(CompletedWithErrorsValue);
        /// <summary> Order has been cancelled. </summary>
        public static DataBoxStageName Cancelled { get; } = new DataBoxStageName(CancelledValue);
        /// <summary> Order has failed due to issue reported by user. </summary>
        public static DataBoxStageName FailedIssueReportedAtCustomer { get; } = new DataBoxStageName(FailedIssueReportedAtCustomerValue);
        /// <summary> Order has failed due to issue detected at Azure datacenter. </summary>
        public static DataBoxStageName FailedIssueDetectedAtAzureDC { get; } = new DataBoxStageName(FailedIssueDetectedAtAzureDCValue);
        /// <summary> Order has been aborted. </summary>
        public static DataBoxStageName Aborted { get; } = new DataBoxStageName(AbortedValue);
        /// <summary> Order has completed with warnings. </summary>
        public static DataBoxStageName CompletedWithWarnings { get; } = new DataBoxStageName(CompletedWithWarningsValue);
        /// <summary> Device is ready to be handed to customer from Azure DC. </summary>
        public static DataBoxStageName ReadyToDispatchFromAzureDC { get; } = new DataBoxStageName(ReadyToDispatchFromAzureDCValue);
        /// <summary> Device can be dropped off at Azure DC. </summary>
        public static DataBoxStageName ReadyToReceiveAtAzureDC { get; } = new DataBoxStageName(ReadyToReceiveAtAzureDCValue);
        /// <summary> Job created by the customer. </summary>
        public static DataBoxStageName Created { get; } = new DataBoxStageName(CreatedValue);
        /// <summary> User shipped the device to AzureDC. </summary>
        public static DataBoxStageName ShippedToAzureDC { get; } = new DataBoxStageName(ShippedToAzureDCValue);
        /// <summary> Awaiting shipment details of device from customer. </summary>
        public static DataBoxStageName AwaitingShipmentDetails { get; } = new DataBoxStageName(AwaitingShipmentDetailsValue);
        /// <summary> Preparing the device to ship to customer. </summary>
        public static DataBoxStageName PreparingToShipFromAzureDC { get; } = new DataBoxStageName(PreparingToShipFromAzureDCValue);
        /// <summary> Shipped the device to customer. </summary>
        public static DataBoxStageName ShippedToCustomer { get; } = new DataBoxStageName(ShippedToCustomerValue);
        /// <summary> Determines if two <see cref="DataBoxStageName"/> values are the same. </summary>
        public static bool operator ==(DataBoxStageName left, DataBoxStageName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxStageName"/> values are not the same. </summary>
        public static bool operator !=(DataBoxStageName left, DataBoxStageName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoxStageName"/>. </summary>
        public static implicit operator DataBoxStageName(string value) => new DataBoxStageName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxStageName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxStageName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
