// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema.Teams
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// O365 connector card image
    /// </summary>
    public partial class O365ConnectorCardImage
    {
        /// <summary>
        /// Initializes a new instance of the O365ConnectorCardImage class.
        /// </summary>
        public O365ConnectorCardImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the O365ConnectorCardImage class.
        /// </summary>
        /// <param name="image">URL for the image</param>
        /// <param name="title">Alternative text for the image</param>
        public O365ConnectorCardImage(string image = default(string), string title = default(string))
        {
            Image = image;
            Title = title;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL for the image
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets alternative text for the image
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

    }
}
