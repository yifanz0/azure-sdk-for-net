// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The event type information for Channels. </summary>
    public partial class EventTypeInfo
    {
        /// <summary> Initializes a new instance of EventTypeInfo. </summary>
        public EventTypeInfo()
        {
            InlineEventTypes = new ChangeTrackingDictionary<string, InlineEventProperties>();
        }

        /// <summary> Initializes a new instance of EventTypeInfo. </summary>
        /// <param name="kind"> The kind of event type used. </param>
        /// <param name="inlineEventTypes">
        /// A collection of inline event types for the resource. The inline event type keys are of type string which represents the name of the event.
        /// An example of a valid inline event name is &quot;Contoso.OrderCreated&quot;.
        /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline event type.
        /// </param>
        internal EventTypeInfo(EventDefinitionKind? kind, IDictionary<string, InlineEventProperties> inlineEventTypes)
        {
            Kind = kind;
            InlineEventTypes = inlineEventTypes;
        }

        /// <summary> The kind of event type used. </summary>
        public EventDefinitionKind? Kind { get; set; }
        /// <summary>
        /// A collection of inline event types for the resource. The inline event type keys are of type string which represents the name of the event.
        /// An example of a valid inline event name is &quot;Contoso.OrderCreated&quot;.
        /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline event type.
        /// </summary>
        public IDictionary<string, InlineEventProperties> InlineEventTypes { get; }
    }
}
