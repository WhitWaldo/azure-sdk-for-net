// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes an available Cognitive Services SKU.
    /// </summary>
    public partial class ResourceSku
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        public ResourceSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        /// <param name="resourceType">The type of resource the SKU applies
        /// to.</param>
        /// <param name="name">The name of SKU.</param>
        /// <param name="tier">Specifies the tier of Cognitive Services
        /// account.</param>
        /// <param name="kind">The Kind of resources that are supported in this
        /// SKU.</param>
        /// <param name="locations">The set of locations that the SKU is
        /// available.</param>
        /// <param name="restrictions">The restrictions because of which SKU
        /// cannot be used. This is empty if there are no restrictions.</param>
        public ResourceSku(string resourceType = default(string), string name = default(string), string tier = default(string), string kind = default(string), IList<string> locations = default(IList<string>), IList<ResourceSkuRestrictions> restrictions = default(IList<ResourceSkuRestrictions>))
        {
            ResourceType = resourceType;
            Name = name;
            Tier = tier;
            Kind = kind;
            Locations = locations;
            Restrictions = restrictions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of resource the SKU applies to.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets the name of SKU.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets specifies the tier of Cognitive Services account.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; private set; }

        /// <summary>
        /// Gets the Kind of resources that are supported in this SKU.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets the set of locations that the SKU is available.
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; private set; }

        /// <summary>
        /// Gets the restrictions because of which SKU cannot be used. This is
        /// empty if there are no restrictions.
        /// </summary>
        [JsonProperty(PropertyName = "restrictions")]
        public IList<ResourceSkuRestrictions> Restrictions { get; private set; }

    }
}
