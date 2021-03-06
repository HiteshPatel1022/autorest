// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureResource.Models
{
    using Fixtures.Azure;
    using Fixtures.Azure.AcceptanceTestsAzureResource;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Some resource
    /// <see href="http://tempuri.org" />
    /// </summary>
    public partial class Resource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        public Resource() { }

        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="name">Resource Name</param>
        public Resource(string id = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string name = default(string))
        {
            Id = id;
            Type = type;
            Tags = tags;
            Location = location;
            Name = name;
        }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }

        /// <summary>
        /// Gets resource Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; protected set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets resource Location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }

    }
}

