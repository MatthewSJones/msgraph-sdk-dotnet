// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type TokenMeetingInfo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TokenMeetingInfo : MeetingInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenMeetingInfo"/> class.
        /// </summary>
        public TokenMeetingInfo()
        {
            this.ODataType = "microsoft.graph.tokenMeetingInfo";
        }

        /// <summary>
        /// Gets or sets token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "token", Required = Newtonsoft.Json.Required.Default)]
        public string Token { get; set; }
    
    }
}
