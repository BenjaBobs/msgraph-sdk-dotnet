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
    /// The type WorkbookChartSetPositionRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookChartSetPositionRequestBody
    {
    
        /// <summary>
        /// Gets or sets StartCell.
        /// </summary>
        [DataMember(Name = "startCell", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken StartCell { get; set; }
    
        /// <summary>
        /// Gets or sets EndCell.
        /// </summary>
        [DataMember(Name = "endCell", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken EndCell { get; set; }
    
    }
}
