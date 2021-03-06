// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyComplex.Models
{
    using Fixtures.AcceptanceTestsBodyComplex;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ByteWrapper
    {
        /// <summary>
        /// Initializes a new instance of the ByteWrapper class.
        /// </summary>
        public ByteWrapper() { }

        /// <summary>
        /// Initializes a new instance of the ByteWrapper class.
        /// </summary>
        public ByteWrapper(byte[] field = default(byte[]))
        {
            Field = field;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public byte[] Field { get; set; }

    }
}

