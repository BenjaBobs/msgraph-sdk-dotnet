// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsSumIfRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsSumIfRequestBody
    {
    
        /// <summary>
        /// Gets or sets Range.
        /// </summary>
        [DataMember(Name = "range", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Range { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria.
        /// </summary>
        [DataMember(Name = "criteria", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Criteria { get; set; }
    
        /// <summary>
        /// Gets or sets SumRange.
        /// </summary>
        [DataMember(Name = "sumRange", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken SumRange { get; set; }
    
    }
}
