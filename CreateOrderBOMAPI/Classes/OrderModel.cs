using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CreateOrderBOMAPI.Classes
{
    public partial class OrderModel
    {
        [JsonProperty("Index")]
        public string Index { get; set; }

        [JsonProperty("ModelName")]
        public string ModelName { get; set; }

        [JsonProperty("ModelInstance")]
        public string ModelInstance { get; set; }

        [JsonProperty("ModelData")]
        public ROOT_CAB ModelData { get; set; }

        [JsonProperty("ModelOverrides")]
        public ModelOverrides ModelOverrides { get; set; }

        [JsonProperty("Itemid")]
        public string Itemid { get; set; }

        [JsonProperty("Description")]
        public object Description { get; set; }

        [JsonProperty("Price")]
        public long Price { get; set; }

        [JsonProperty("Quantity")]
        public long Quantity { get; set; }

        [JsonProperty("ExtendedPrice")]
        public long ExtendedPrice { get; set; }

        [JsonProperty("Note")]
        public object Note { get; set; }

        [JsonProperty("ApiModelMap")]
        public string ApiModelMap { get; set; }

        [JsonProperty("ItemType")]
        public long ItemType { get; set; }
    }



    public partial class ModelOverrides
    {
    }

    public partial class OrderModel
    {
        public static OrderModel[] FromJson(string json) => JsonConvert.DeserializeObject<OrderModel[]>(json, Converter.Settings);
    }
}
