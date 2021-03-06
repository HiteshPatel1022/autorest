// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using Fixtures.AcceptanceTestsAzureCompositeModelClient;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CatalogDictionary
    {
        /// <summary>
        /// Initializes a new instance of the CatalogDictionary class.
        /// </summary>
        public CatalogDictionary() { }

        /// <summary>
        /// Initializes a new instance of the CatalogDictionary class.
        /// </summary>
        /// <param name="productDictionary">Dictionary of products</param>
        public CatalogDictionary(IDictionary<string, Product> productDictionary = default(IDictionary<string, Product>))
        {
            ProductDictionary = productDictionary;
        }

        /// <summary>
        /// Gets or sets dictionary of products
        /// </summary>
        [JsonProperty(PropertyName = "productDictionary")]
        public IDictionary<string, Product> ProductDictionary { get; set; }

    }
}

