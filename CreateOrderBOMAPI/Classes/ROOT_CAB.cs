using System;
using Newtonsoft.Json;
using System.Reflection;


namespace CreateOrderBOMAPI.Classes

{
    public partial class ROOT_CAB
    {
        public object this[string propertyName]
        {
            get
            {
                Type myType = typeof(ROOT_CAB);
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                return myPropInfo.GetValue(this, null);
            }
            set
            {
                Type myType = typeof(ROOT_CAB);
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                myPropInfo.SetValue(this, value, null);
            }
        }

        public static ROOT_CAB FromJson(string json) => JsonConvert.DeserializeObject<ROOT_CAB>(json, Converter.Settings);

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }

        [JsonProperty("finish")]
        public ROOT_CABFinish Finish { get; set; }

        [JsonProperty("options")]
        public Options Options { get; set; }

        [JsonProperty("frame")]
        public ROOT_CABFrame Frame { get; set; }

        [JsonProperty("shell")]
        public Shell Shell { get; set; }

        [JsonProperty("extensions")]
        public Extensions Extensions { get; set; }

        [JsonProperty("soffit")]
        public Soffit Soffit { get; set; }

        [JsonProperty("radius")]
        public Radius Radius { get; set; }

        [JsonProperty("openings")]
        public Opening[] Openings { get; set; }
    }

    public partial class Extensions
    {
        [JsonProperty("left")]
        public bool? Left { get; set; }

        [JsonProperty("right")]
        public bool? Right { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }

    public partial class ROOT_CABFinish
    {
        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("customColor")]
        public object CustomColor { get; set; }

        [JsonProperty("shelves")]
        public bool Shelves { get; set; }
    }

    public partial class ROOT_CABFrame
    {
        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("weightNoB")]
        public double WeightNoB { get; set; }

        [JsonProperty("weightWithB")]
        public double WeightWithB { get; set; }

        [JsonProperty("weightVSplit")]
        public double WeightVSplit { get; set; }

        [JsonProperty("weightHSplit")]
        public double WeightHSplit { get; set; }

        [JsonProperty("priceNoB")]
        public double PriceNoB { get; set; }

        [JsonProperty("priceWithB")]
        public double PriceWithB { get; set; }

        [JsonProperty("priceVSplit")]
        public double PriceVSplit { get; set; }

        [JsonProperty("priceHSplit")]
        public double PriceHSplit { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }

        [JsonProperty("finish")]
        public PurpleFinish Finish { get; set; }

        [JsonProperty("bottomRail")]
        public bool BottomRail { get; set; }

        [JsonProperty("gasketLoc")]
        public object GasketLoc { get; set; }

        [JsonProperty("GLWeight")]
        public double GLWeight { get; set; }

        [JsonProperty("GLPrice")]
        public double GLPrice { get; set; }

    }

    public partial class PurpleFinish
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("openingColor")]
        public string OpeningColor { get; set; }
    }

    public partial class Opening
    {
        [JsonProperty("frame")]
        public OpeningFrame Frame { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }

        [JsonProperty("openings", NullValueHandling = NullValueHandling.Ignore)]
        public Opening[] Openings { get; set; }

        [JsonProperty("contents")]
        public Contents Contents { get; set; }
    }

    public partial class Contents
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("shelves")]
        public Shelves Shelves { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("sBWeight")]
        public double SBWeight { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("sBPrice")]
        public double SBPrice { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }

        [JsonProperty("duty")]
        public string Duty { get; set; }

        [JsonProperty("insert")]
        public Insert Insert { get; set; }

        [JsonProperty("finish")]
        public DataFinish Finish { get; set; }

        [JsonProperty("handle")]
        public Handle Handle { get; set; }

        [JsonProperty("topSpace")]
        public double TopSpace { get; set; }

        [JsonProperty("shelf")]
        public Shelf Shelf { get; set; }

        [JsonProperty("drawers")]
        public Drawer[] Drawers { get; set; }

        [JsonProperty("riser")]
        public Riser Riser { get; set; }

        [JsonProperty("bottomNotch")]
        public BottomNotch BottomNotch { get; set; }

        [JsonProperty("locking")]
        public string Locking { get; set; }
    }

    public partial class BottomNotch
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }
    }

    public partial class Drawer
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("weightDiv")]
        public double WeightDiv { get; set; }

        [JsonProperty("linerWeight")]
        public double LinerWeight { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("priceDiv")]
        public double PriceDiv { get; set; }

        [JsonProperty("linerPrice")]
        public double LinerPrice { get; set; }

        [JsonProperty("divisions")]
        public double Divisions { get; set; }

        [JsonProperty("liner")]
        public bool Liner { get; set; }

        [JsonProperty("separators")]
        public double Separators { get; set; }

        [JsonProperty("partsTray")]
        public bool PartsTray { get; set; }

        [JsonProperty("whiteboard")]
        public bool Whiteboard { get; set; }

        [JsonProperty("dividerType")]
        public string DividerType { get; set; }

        [JsonProperty("locking")]
        public object Locking { get; set; }
    }

    public partial class DataFinish
    {
        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("customColor")]
        public object CustomColor { get; set; }

        [JsonProperty("blackAnodizedHandles")]
        public bool BlackAnodizedHandles { get; set; }

        [JsonProperty("shelf")]
        public bool Shelf { get; set; }

        [JsonProperty("drawerFronts")]
        public bool DrawerFronts { get; set; }

        [JsonProperty("insertSides")]
        public bool InsertSides { get; set; }

        [JsonProperty("backPanel")]
        public bool BackPanel { get; set; }
    }

    public partial class Handle
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("swing")]
        public string Swing { get; set; }

        [JsonProperty("locking")]
        public bool Locking { get; set; }

        [JsonProperty("finish")]
        public DataFinish Finish { get; set; }
    }

    public partial class Insert
    {
        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("backPnlWeight")]
        public double BackPnlWeight { get; set; }

        [JsonProperty("hatWeight")]
        public double HatWeight { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("backPnlPrice")]
        public double BackPnlPrice { get; set; }

        [JsonProperty("hatPrice")]
        public double HatPrice { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }
    }

    public partial class Riser
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("offset")]
        public double Offset { get; set; }

    }

    public partial class Shelf
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("overrideSlotSpacing")]
        public bool OverrideSlotSpacing { get; set; }

        [JsonProperty("customSlotSpacing")]
        public double CustomSlotSpacing { get; set; }

        [JsonProperty("frontOffset")]
        public double FrontOffset { get; set; }

        [JsonProperty("rearOffset")]
        public double RearOffset { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }

    public partial class Shelves
    {
        [JsonProperty("adjustable")]
        public double Adjustable { get; set; }

        [JsonProperty("shelfWeight")]
        public double ShelfWeight { get; set; }

        [JsonProperty("shelfPrice")]
        public double ShelfPrice { get; set; }

        [JsonProperty("slideOut")]
        public double SlideOut { get; set; }

        [JsonProperty("hangerBar")]
        public double HangerBar { get; set; }

        [JsonProperty("hangerBarWeight")]
        public double HangerBarWeight { get; set; }

        [JsonProperty("hangerBarPrice")]
        public double HangerBarPrice { get; set; }

        [JsonProperty("liner")]
        public bool Liner { get; set; }

    }

    public partial class OpeningFrame
    {
        [JsonProperty("left")]
        public string Left { get; set; }

        [JsonProperty("right")]
        public string Right { get; set; }

        [JsonProperty("top")]
        public string Top { get; set; }

        [JsonProperty("bottom")]
        public string Bottom { get; set; }

        [JsonProperty("finish")]
        public FluffyFinish Finish { get; set; }
    }

    public partial class FluffyFinish
    {
        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public partial class Options
    {
        [JsonProperty("shelfLiner")]
        public bool ShelfLiner { get; set; }

        [JsonProperty("frameOnly")]
        public bool FrameOnly { get; set; }
    }

    public partial class Radius
    {
        [JsonProperty("left")]
        public bool Left { get; set; }

        [JsonProperty("right")]
        public bool Right { get; set; }

        [JsonProperty("top")]
        public bool Top { get; set; }

        [JsonProperty("bottom")]
        public bool Bottom { get; set; }

        [JsonProperty("lighting")]
        public Lighting Lighting { get; set; }

        [JsonProperty("SPWeight")]
        public double SPWeight { get; set; }

        [JsonProperty("MPWeight")]
        public double MPWeight { get; set; }

        [JsonProperty("SPPrice")]
        public double SPPrice { get; set; }

        [JsonProperty("MPPrice")]
        public double MPPrice { get; set; }
    }

    public partial class Lighting
    {
        [JsonProperty("switches")]
        public string Switches { get; set; }

        [JsonProperty("wiring")]
        public string Wiring { get; set; }

        [JsonProperty("lights")]
        public double Lights { get; set; }

        [JsonProperty("voltage")]
        public object Voltage { get; set; }

        [JsonProperty("lightType")]
        public string LightType { get; set; }
    }

    public partial class Shell
    {
        [JsonProperty("backPanel")]
        public bool BackPanel { get; set; }

        [JsonProperty("topPanel")]
        public bool TopPanel { get; set; }

        [JsonProperty("bottomPanel")]
        public bool BottomPanel { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("bottomPnlWeight")]
        public double BottomPnlWeight { get; set; }

        [JsonProperty("backPnlWeight")]
        public double BackPnlWeight { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("bottomPnlPrice")]
        public double BottomPnlPrice { get; set; }

        [JsonProperty("backPnlPrice")]
        public double BackPnlPrice { get; set; }

        [JsonProperty("toekick")]
        public Toekick Toekick { get; set; }

        [JsonProperty("internalBracing")]
        public Extensions InternalBracing { get; set; }

        [JsonProperty("internalBracingWeight")]
        public double InternalBracingWeight { get; set; }

        [JsonProperty("internalBracingPrice")]
        public double InternalBracingPrice { get; set; }

    }

    public partial class Toekick
    {
        [JsonProperty("adjustableFeet")]
        public bool AdjustableFeet { get; set; }

        [JsonProperty("venting")]
        public bool Venting { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }

    public partial class Soffit
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("left")]
        public bool Left { get; set; }

        [JsonProperty("right")]
        public bool Right { get; set; }

        [JsonProperty("front")]
        public bool Front { get; set; }

        [JsonProperty("LRWeight")]
        public double LRWeight { get; set; }

        [JsonProperty("frontWeight")]
        public double FrontWeight { get; set; }

        [JsonProperty("LRPrice")]
        public double LRPrice { get; set; }

        [JsonProperty("frontPrice")]
        public double FrontPrice { get; set; }
    }

}
