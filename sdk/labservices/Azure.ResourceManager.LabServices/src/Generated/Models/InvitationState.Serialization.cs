// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.LabServices.Models
{
    internal static partial class InvitationStateExtensions
    {
        public static string ToSerialString(this InvitationState value) => value switch
        {
            InvitationState.NotSent => "NotSent",
            InvitationState.Sending => "Sending",
            InvitationState.Sent => "Sent",
            InvitationState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InvitationState value.")
        };

        public static InvitationState ToInvitationState(this string value)
        {
            if (string.Equals(value, "NotSent", StringComparison.InvariantCultureIgnoreCase)) return InvitationState.NotSent;
            if (string.Equals(value, "Sending", StringComparison.InvariantCultureIgnoreCase)) return InvitationState.Sending;
            if (string.Equals(value, "Sent", StringComparison.InvariantCultureIgnoreCase)) return InvitationState.Sent;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return InvitationState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InvitationState value.");
        }
    }
}
