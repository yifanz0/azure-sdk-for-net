// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of security assessment metadata. </summary>
    internal partial class SecurityAssessmentMetadataResponseList
    {
        /// <summary> Initializes a new instance of SecurityAssessmentMetadataResponseList. </summary>
        internal SecurityAssessmentMetadataResponseList()
        {
            Value = new ChangeTrackingList<SecurityAssessmentMetadataResponseData>();
        }

        /// <summary> Initializes a new instance of SecurityAssessmentMetadataResponseList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal SecurityAssessmentMetadataResponseList(IReadOnlyList<SecurityAssessmentMetadataResponseData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SecurityAssessmentMetadataResponseData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
