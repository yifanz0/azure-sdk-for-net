// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary> A class representing the PaymentMethodLink data model. </summary>
    public partial class PaymentMethodLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of PaymentMethodLinkData. </summary>
        public PaymentMethodLinkData()
        {
        }

        /// <summary> Initializes a new instance of PaymentMethodLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="paymentMethod"> Projection of a payment method. </param>
        internal PaymentMethodLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PaymentMethodProjectionProperties paymentMethod) : base(id, name, resourceType, systemData)
        {
            PaymentMethod = paymentMethod;
        }

        /// <summary> Projection of a payment method. </summary>
        public PaymentMethodProjectionProperties PaymentMethod { get; set; }
    }
}
