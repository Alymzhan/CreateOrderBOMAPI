using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CreateOrderBOMAPI.Classes
{
    public partial class Order
    {
        [JsonProperty("Header")]
        public Header Header { get; set; }

        [JsonProperty("Metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("LineItems")]
        public object[] LineItems { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("TransactionNumber")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long TransactionNumber { get; set; }

        [JsonProperty("TransactionReference")]
        public object TransactionReference { get; set; }

        [JsonProperty("CreateDate")]
        public DateTimeOffset CreateDate { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("CustomerId")]
        public string CustomerId { get; set; }

        [JsonProperty("CustomerCompany")]
        public object CustomerCompany { get; set; }

        [JsonProperty("CreatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("EngineerId")]
        public object EngineerId { get; set; }

        [JsonProperty("PromisedShipDate")]
        public DateTimeOffset PromisedShipDate { get; set; }

        [JsonProperty("PlannedShipDate")]
        public object PlannedShipDate { get; set; }

        [JsonProperty("Status")]
        public long Status { get; set; }

        [JsonProperty("Finish")]
        public object Finish { get; set; }

        [JsonProperty("FinishDescription")]
        public object FinishDescription { get; set; }

        [JsonProperty("ShippingAddress")]
        public string ShippingAddress { get; set; }

        [JsonProperty("ShippingCity")]
        public string ShippingCity { get; set; }

        [JsonProperty("ShippingState")]
        public string ShippingState { get; set; }

        [JsonProperty("ShippingZip")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ShippingZip { get; set; }

        [JsonProperty("ShippingMethod")]
        public string ShippingMethod { get; set; }

        [JsonProperty("NetSales")]
        public long NetSales { get; set; }

        [JsonProperty("TotalSales")]
        public long TotalSales { get; set; }

        [JsonProperty("BillingTerms")]
        public string BillingTerms { get; set; }

        [JsonProperty("Note")]
        public object Note { get; set; }

        [JsonProperty("TransactionNotes")]
        public object[] TransactionNotes { get; set; }

        [JsonProperty("BookDate")]
        public object BookDate { get; set; }

        [JsonProperty("InvoiceDate")]
        public object InvoiceDate { get; set; }

        [JsonProperty("ShipDate")]
        public object ShipDate { get; set; }

        [JsonProperty("TrackingNumber")]
        public object TrackingNumber { get; set; }

        [JsonProperty("PONumber")]
        public object PoNumber { get; set; }

        [JsonProperty("ProductionOrderNumber")]
        public object ProductionOrderNumber { get; set; }

        [JsonProperty("PreferredShift")]
        public long PreferredShift { get; set; }

        [JsonProperty("InvoiceNumber")]
        public object InvoiceNumber { get; set; }

        [JsonProperty("History")]
        public object[] History { get; set; }
    }

    public partial class Metadata
    {
        [JsonProperty("EngineeringRequired")]
        public bool EngineeringRequired { get; set; }

        [JsonProperty("Expedite")]
        public bool Expedite { get; set; }
    }

    public partial class Order
    {
        public static Order FromJson(string json) => JsonConvert.DeserializeObject<Order>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Order self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this OrderModel[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

}
