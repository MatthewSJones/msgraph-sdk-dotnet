// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookTableSortApplyRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookTableSortApplyRequestBody
    {
    
        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fields", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WorkbookSortField> Fields { get; set; }
    
        /// <summary>
        /// Gets or sets MatchCase.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "matchCase", Required = Newtonsoft.Json.Required.Default)]
        public bool MatchCase { get; set; }
    
        /// <summary>
        /// Gets or sets Method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "method", Required = Newtonsoft.Json.Required.Default)]
        public string Method { get; set; }
    
    }
}
