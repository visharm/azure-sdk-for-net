// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ImageRegion
    {
        /// <summary>
        /// Initializes a new instance of the ImageRegion class.
        /// </summary>
        public ImageRegion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageRegion class.
        /// </summary>
        public ImageRegion(System.Guid regionId = default(System.Guid), string tagName = default(string), System.DateTime created = default(System.DateTime), System.Guid tagId = default(System.Guid), double left = default(double), double top = default(double), double width = default(double), double height = default(double))
        {
            RegionId = regionId;
            TagName = tagName;
            Created = created;
            TagId = tagId;
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regionId")]
        public System.Guid RegionId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tagName")]
        public string TagName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tagId")]
        public System.Guid TagId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public double Left { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public double Top { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public double Width { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public double Height { get; set; }

    }
}