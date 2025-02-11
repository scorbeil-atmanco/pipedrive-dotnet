﻿using Newtonsoft.Json;

namespace Pipedrive
{
    public class DealProductUpdate
    {
        [JsonProperty("item_price")]
        public decimal ItemPrice { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("discount")]
        public decimal Discount { get; set; }

        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; } = 1;

        [JsonProperty("product_variation_id")]
        public long? ProductVariationId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("enabled_flag")]
        public bool EnabledFlag { get; set; } = true;
    }
}
