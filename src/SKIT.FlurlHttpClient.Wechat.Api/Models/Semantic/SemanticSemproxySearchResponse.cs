namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /semantic/semproxy/search 接口的响应。</para>
    /// </summary>
    public class SemanticSemproxySearchResponse : WechatApiResponse
    {
        public static class Types
        {
            public interface IDetail
            {
            }

            public class Datetime
            {
                /// <summary>
                /// 获取或设置时间类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string? DateString { get; set; }

                /// <summary>
                /// 获取或设置日期原始字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date_ori")]
                [System.Text.Json.Serialization.JsonPropertyName("date_ori")]
                public string? DateOriginal { get; set; }

                /// <summary>
                /// 获取或设置时间字符串（格式：HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public string? TimeString { get; set; }

                /// <summary>
                /// 获取或设置时间原始字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_ori")]
                [System.Text.Json.Serialization.JsonPropertyName("time_ori")]
                public string? TimeOriginal { get; set; }

                /// <summary>
                /// 获取或设置结束日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                public string? EndDateString { get; set; }

                /// <summary>
                /// 获取或设置结束日期原始字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date_ori")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date_ori")]
                public string? EndDateOriginal { get; set; }

                /// <summary>
                /// 获取或设置结束时间字符串（格式：HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public string? EndTimeString { get; set; }

                /// <summary>
                /// 获取或设置结束时间原始字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time_ori")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time_ori")]
                public string? EndTimeOriginal { get; set; }

                /// <summary>
                /// 获取或设置重复标记字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat")]
                public string? RepeatString { get; set; }

                /// <summary>
                /// 获取或设置重复标记原始字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_ori")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_ori")]
                public string? RepeatOriginal { get; set; }
            }

            public class Location
            {
                /// <summary>
                /// 获取或设置地点类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string? Country { get; set; }

                /// <summary>
                /// 获取或设置省全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string? Province { get; set; }

                /// <summary>
                /// 获取或设置省简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_simple")]
                [System.Text.Json.Serialization.JsonPropertyName("province_simple")]
                public string? ProvinceAbbr { get; set; }

                /// <summary>
                /// 获取或设置市全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? City { get; set; }

                /// <summary>
                /// 获取或设置市简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_simple")]
                [System.Text.Json.Serialization.JsonPropertyName("city_simple")]
                public string? CityAbbr { get; set; }

                /// <summary>
                /// 获取或设置县区全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("town")]
                [System.Text.Json.Serialization.JsonPropertyName("town")]
                public string? Town { get; set; }

                /// <summary>
                /// 获取或设置县区简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("town_simple")]
                [System.Text.Json.Serialization.JsonPropertyName("town_simple")]
                public string? TownAbbr { get; set; }

                /// <summary>
                /// 获取或设置 POI 详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi")]
                [System.Text.Json.Serialization.JsonPropertyName("poi")]
                public string? POI { get; set; }

                /// <summary>
                /// 获取或设置原始地名字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("loc_ori")]
                [System.Text.Json.Serialization.JsonPropertyName("loc_ori")]
                public string LocationOriginal { get; set; } = default!;
            }

            public class Number
            {
                /// <summary>
                /// 获取或设置数字类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置开始值字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin")]
                [System.Text.Json.Serialization.JsonPropertyName("begin")]
                public string BeginString { get; set; } = default!;

                /// <summary>
                /// 获取或设置结束值字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end")]
                [System.Text.Json.Serialization.JsonPropertyName("end")]
                public string EndString { get; set; } = default!;
            }

            public class RestaurantDetail : IDetail
            {
                /// <summary>
                /// 获取或设置地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Location? Location { get; set; }

                /// <summary>
                /// 获取或设置餐馆名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置餐馆类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置菜名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("special")]
                [System.Text.Json.Serialization.JsonPropertyName("special")]
                public string? Special { get; set; }

                /// <summary>
                /// 获取或设置价格信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public Number? Price { get; set; }

                /// <summary>
                /// 获取或设置距离信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("radius")]
                [System.Text.Json.Serialization.JsonPropertyName("radius")]
                public Number? Radius { get; set; }

                /// <summary>
                /// 获取或设置优惠类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon")]
                public int? CouponType { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class MapDetail : IDetail
            {
                /// <summary>
                /// 获取或设置起点区域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_area")]
                [System.Text.Json.Serialization.JsonPropertyName("start_area")]
                public Location? StartArea { get; set; }

                /// <summary>
                /// 获取或设置起点位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_loc")]
                [System.Text.Json.Serialization.JsonPropertyName("start_loc")]
                public Location? StartLocation { get; set; }

                /// <summary>
                /// 获取或设置终点区域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_area")]
                [System.Text.Json.Serialization.JsonPropertyName("end_area")]
                public Location? EndArea { get; set; }

                /// <summary>
                /// 获取或设置终点位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_loc")]
                [System.Text.Json.Serialization.JsonPropertyName("end_loc")]
                public Location? EndLocation { get; set; }

                /// <summary>
                /// 获取或设置出行方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("route_type")]
                [System.Text.Json.Serialization.JsonPropertyName("route_type")]
                public string? RouteType { get; set; }

                /// <summary>
                /// 获取或设置公交车号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bus_num")]
                [System.Text.Json.Serialization.JsonPropertyName("bus_num")]
                public string? BusNumber { get; set; }

                /// <summary>
                /// 获取或设置地铁线路。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subway_num")]
                [System.Text.Json.Serialization.JsonPropertyName("subway_num")]
                public string? SubwayNumber { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int? SortType { get; set; }

                /// <summary>
                /// 获取或设置关键词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                public string? Keyword { get; set; }
            }

            public class NearbyDetail : IDetail
            {
                /// <summary>
                /// 获取或设置地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Location? Location { get; set; }

                /// <summary>
                /// 获取或设置关键词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                public string? Keyword { get; set; }

                /// <summary>
                /// 获取或设置限定词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit")]
                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                public string? Limit { get; set; }

                /// <summary>
                /// 获取或设置价格信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public Number? Price { get; set; }

                /// <summary>
                /// 获取或设置距离信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("radius")]
                [System.Text.Json.Serialization.JsonPropertyName("radius")]
                public Number? Radius { get; set; }

                /// <summary>
                /// 获取或设置优惠类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon")]
                public int? CouponType { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class CouponDetail : IDetail
            {
                /// <summary>
                /// 获取或设置地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Location? Location { get; set; }

                /// <summary>
                /// 获取或设置价格信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public Number? Price { get; set; }

                /// <summary>
                /// 获取或设置距离信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("radius")]
                [System.Text.Json.Serialization.JsonPropertyName("radius")]
                public Number? Radius { get; set; }

                /// <summary>
                /// 获取或设置关键词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                public string? Keyword { get; set; }

                /// <summary>
                /// 获取或设置优惠类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon")]
                public int? CouponType { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class HotelDetail : IDetail
            {
                /// <summary>
                /// 获取或设置地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Location? Location { get; set; }

                /// <summary>
                /// 获取或设置入住时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date")]
                public Datetime? StartDate { get; set; }

                /// <summary>
                /// 获取或设置离开时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                public Datetime? EndDate { get; set; }

                /// <summary>
                /// 获取或设置酒店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置价格信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public Number? Price { get; set; }

                /// <summary>
                /// 获取或设置距离信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("radius")]
                [System.Text.Json.Serialization.JsonPropertyName("radius")]
                public Number? Radius { get; set; }

                /// <summary>
                /// 获取或设置等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public string? Lavel { get; set; }

                /// <summary>
                /// 获取或设置是否有 Wi-Fi。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wifi")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("wifi")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? HasWifi { get; set; }

                /// <summary>
                /// 获取或设置房间类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("roomtype")]
                [System.Text.Json.Serialization.JsonPropertyName("roomtype")]
                public string? RoomType { get; set; }

                /// <summary>
                /// 获取或设置优惠类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon")]
                public int? CouponType { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class TravelDetail : IDetail
            {
                /// <summary>
                /// 获取或设置旅游目的地。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Location? Location { get; set; }

                /// <summary>
                /// 获取或设置景点名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spot")]
                [System.Text.Json.Serialization.JsonPropertyName("spot")]
                public string? Spot { get; set; }

                /// <summary>
                /// 获取或设置旅游日期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("datetime")]
                [System.Text.Json.Serialization.JsonPropertyName("datetime")]
                public Datetime? Datetime { get; set; }

                /// <summary>
                /// 获取或设置旅游类型词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag")]
                [System.Text.Json.Serialization.JsonPropertyName("tag")]
                public string? Tag { get; set; }

                /// <summary>
                /// 获取或设置分类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public int? Category { get; set; }
            }

            public class FlightDetail : IDetail
            {
                /// <summary>
                /// 获取或设置航班号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flight_no")]
                [System.Text.Json.Serialization.JsonPropertyName("flight_no")]
                public string? FlightNumber { get; set; }

                /// <summary>
                /// 获取或设置出发地。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_loc")]
                [System.Text.Json.Serialization.JsonPropertyName("start_loc")]
                public Location? StartLocation { get; set; }

                /// <summary>
                /// 获取或设置目的地。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_loc")]
                [System.Text.Json.Serialization.JsonPropertyName("end_loc")]
                public Location? EndLocation { get; set; }

                /// <summary>
                /// 获取或设置出发日期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date")]
                public Datetime? StartDate { get; set; }

                /// <summary>
                /// 获取或设置返回日期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                public Datetime? EndDate { get; set; }

                /// <summary>
                /// 获取或设置航空公司。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("airline")]
                [System.Text.Json.Serialization.JsonPropertyName("airline")]
                public string? Airline { get; set; }

                /// <summary>
                /// 获取或设置座位级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seat")]
                [System.Text.Json.Serialization.JsonPropertyName("seat")]
                public string? SeatType { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class TrainDetail : IDetail
            {
                /// <summary>
                /// 获取或设置出发日期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date")]
                public Datetime? StartDate { get; set; }

                /// <summary>
                /// 获取或设置返回日期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                public Datetime? EndDate { get; set; }

                /// <summary>
                /// 获取或设置起点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_loc")]
                [System.Text.Json.Serialization.JsonPropertyName("start_loc")]
                public Location? StartLocation { get; set; }

                /// <summary>
                /// 获取或设置终点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_loc")]
                [System.Text.Json.Serialization.JsonPropertyName("end_loc")]
                public Location? EndLocation { get; set; }

                /// <summary>
                /// 获取或设置往返类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置车次类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置车次代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// 获取或设置座位级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seat")]
                [System.Text.Json.Serialization.JsonPropertyName("seat")]
                public string? SeatType { get; set; }
            }

            public class MovieDetail : IDetail
            {
                /// <summary>
                /// 获取或设置电影名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置主演。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actor")]
                [System.Text.Json.Serialization.JsonPropertyName("actor")]
                public string? Actor { get; set; }

                /// <summary>
                /// 获取或设置导演。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("director")]
                [System.Text.Json.Serialization.JsonPropertyName("director")]
                public string? Director { get; set; }

                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag")]
                [System.Text.Json.Serialization.JsonPropertyName("tag")]
                public string? Tag { get; set; }

                /// <summary>
                /// 获取或设置地区。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string? Country { get; set; }

                /// <summary>
                /// 获取或设置电影院。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cinema")]
                [System.Text.Json.Serialization.JsonPropertyName("cinema")]
                public string? Cinema { get; set; }

                /// <summary>
                /// 获取或设置地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Location? Location { get; set; }

                /// <summary>
                /// 获取或设置时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("datetime")]
                [System.Text.Json.Serialization.JsonPropertyName("datetime")]
                public Datetime? Datetime { get; set; }

                /// <summary>
                /// 获取或设置优惠类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon")]
                public int? CouponType { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class MusicDetail : IDetail
            {
                /// <summary>
                /// 获取或设置歌曲名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("song")]
                [System.Text.Json.Serialization.JsonPropertyName("song")]
                public string? Song { get; set; }

                /// <summary>
                /// 获取或设置歌手。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("singer")]
                [System.Text.Json.Serialization.JsonPropertyName("singer")]
                public string? Singer { get; set; }

                /// <summary>
                /// 获取或设置专辑。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("album")]
                [System.Text.Json.Serialization.JsonPropertyName("album")]
                public string? Album { get; set; }

                /// <summary>
                /// 获取或设置歌曲类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置语言。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("language")]
                [System.Text.Json.Serialization.JsonPropertyName("language")]
                public string? Language { get; set; }

                /// <summary>
                /// 获取或设置电影名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("movie")]
                [System.Text.Json.Serialization.JsonPropertyName("movie")]
                public string? Movie { get; set; }

                /// <summary>
                /// 获取或设置电视剧名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tv")]
                [System.Text.Json.Serialization.JsonPropertyName("tv")]
                public string? TVPlay { get; set; }

                /// <summary>
                /// 获取或设置节目名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show")]
                [System.Text.Json.Serialization.JsonPropertyName("show")]
                public string? Show { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class VideoDetail : IDetail
            {
                /// <summary>
                /// 获取或设置视频名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置主演 / 嘉宾。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actor")]
                [System.Text.Json.Serialization.JsonPropertyName("actor")]
                public string? Actor { get; set; }

                /// <summary>
                /// 获取或设置导演 / 主持人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("director")]
                [System.Text.Json.Serialization.JsonPropertyName("director")]
                public string? Director { get; set; }

                /// <summary>
                /// 获取或设置视频类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag")]
                [System.Text.Json.Serialization.JsonPropertyName("tag")]
                public string? Tag { get; set; }

                /// <summary>
                /// 获取或设置地区。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string? Country { get; set; }

                /// <summary>
                /// 获取或设置季信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("season")]
                [System.Text.Json.Serialization.JsonPropertyName("season")]
                public Number? Season { get; set; }

                /// <summary>
                /// 获取或设置集信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("episode")]
                [System.Text.Json.Serialization.JsonPropertyName("episode")]
                public Number? Episode { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class NovelDetail : IDetail
            {
                /// <summary>
                /// 获取或设置小说名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置小说作者。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("author")]
                [System.Text.Json.Serialization.JsonPropertyName("author")]
                public string? Author { get; set; }

                /// <summary>
                /// 获取或设置小说类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置小说章节。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter")]
                public string? Chapter { get; set; }

                /// <summary>
                /// 获取或设置排序类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class WeatherDetail : IDetail
            {
                /// <summary>
                /// 获取或设置地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Location? Location { get; set; }

                /// <summary>
                /// 获取或设置时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("datetime")]
                [System.Text.Json.Serialization.JsonPropertyName("datetime")]
                public Location? Datetime { get; set; }
            }

            public class StockDetail : IDetail
            {
                /// <summary>
                /// 获取或设置股票名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置标准股票代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// 获取或设置市场。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("datetime")]
                [System.Text.Json.Serialization.JsonPropertyName("datetime")]
                public Location? Datetime { get; set; }
            }

            public class RemindDetail : IDetail
            {
                /// <summary>
                /// 获取或设置时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("datetime")]
                [System.Text.Json.Serialization.JsonPropertyName("datetime")]
                public Location? Datetime { get; set; }

                /// <summary>
                /// 获取或设置事件。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event")]
                [System.Text.Json.Serialization.JsonPropertyName("event")]
                public string? Event { get; set; }

                /// <summary>
                /// 获取或设置提醒类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remind_type")]
                [System.Text.Json.Serialization.JsonPropertyName("remind_type")]
                public int? RemindType { get; set; }
            }

            public class TelephoneDetail : IDetail
            {
                /// <summary>
                /// 获取或设置名字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("telephone")]
                [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                public string? TelephoneNumber { get; set; }
            }

            public class CookbookDetail : IDetail
            {
                /// <summary>
                /// 获取或设置菜名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置菜系。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置食材。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ingredient")]
                [System.Text.Json.Serialization.JsonPropertyName("ingredient")]
                public string? Ingredient { get; set; }
            }

            public class BaikeDetail : IDetail
            {
                /// <summary>
                /// 获取或设置关键词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                public string? Keyword { get; set; }
            }

            public class NewsDetail : IDetail
            {
                /// <summary>
                /// 获取或设置关键词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                public string? Keyword { get; set; }

                /// <summary>
                /// 获取或设置新闻类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }
            }

            public class TVProgramDetail : IDetail
            {
                /// <summary>
                /// 获取或设置播放时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("datetime")]
                [System.Text.Json.Serialization.JsonPropertyName("datetime")]
                public Datetime? Datetime { get; set; }

                /// <summary>
                /// 获取或设置电视台名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tv_name")]
                [System.Text.Json.Serialization.JsonPropertyName("tv_name")]
                public string? TVName { get; set; }

                /// <summary>
                /// 获取或设置电视频道名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tv_channel")]
                [System.Text.Json.Serialization.JsonPropertyName("tv_channel")]
                public string? TVChannel { get; set; }

                /// <summary>
                /// 获取或设置节目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_name")]
                [System.Text.Json.Serialization.JsonPropertyName("show_name")]
                public string? ShowName { get; set; }

                /// <summary>
                /// 获取或设置节目类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }
            }

            public class InstructionDetail : IDetail
            {
                /// <summary>
                /// 获取或设置数字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("number")]
                [System.Text.Json.Serialization.JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// 获取或设置操作值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string? Value { get; set; }

                /// <summary>
                /// 获取或设置操作符。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operator")]
                [System.Text.Json.Serialization.JsonPropertyName("operator")]
                public string? Operator { get; set; }
            }

            public class TVInstructionDetail : InstructionDetail, IDetail
            {
                /// <summary>
                /// 获取或设置电视台名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tv_name")]
                [System.Text.Json.Serialization.JsonPropertyName("tv_name")]
                public string? TVName { get; set; }

                /// <summary>
                /// 获取或设置电视频道名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tv_channel")]
                [System.Text.Json.Serialization.JsonPropertyName("tv_channel")]
                public string? TVChannel { get; set; }

                /// <summary>
                /// 获取或设置节目类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置设备类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device")]
                [System.Text.Json.Serialization.JsonPropertyName("device")]
                public string? Device { get; set; }

                /// <summary>
                /// 获取或设置文件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_type")]
                [System.Text.Json.Serialization.JsonPropertyName("file_type")]
                public string? FileType { get; set; }
            }

            public class CarInstructionDetail : InstructionDetail, IDetail
            {
                /// <summary>
                /// 获取或设置位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("position")]
                [System.Text.Json.Serialization.JsonPropertyName("position")]
                public string? Position { get; set; }
            }

            public class AppDetail : IDetail
            {
                /// <summary>
                /// 获取或设置 App 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置 App 类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置查看类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置排序类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort")]
                [System.Text.Json.Serialization.JsonPropertyName("sort")]
                public int? SortType { get; set; }
            }

            public class WebsiteDetail : IDetail
            {
                /// <summary>
                /// 获取或设置网址名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }
            }

            public class SearchDetail : IDetail
            {
                /// <summary>
                /// 获取或设置关键词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                public string? Keyword { get; set; }

                /// <summary>
                /// 获取或设置搜索引擎类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel")]
                [System.Text.Json.Serialization.JsonPropertyName("channel")]
                public string? Channel { get; set; }
            }

            public class Semantic<D>
                where D : IDetail
            {
                /// <summary>
                /// 获取或设置语义详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("details")]
                [System.Text.Json.Serialization.JsonPropertyName("details")]
                public D Detail { get; set; } = default!;

                /// <summary>
                /// 获取或设置语义意图。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intent")]
                [System.Text.Json.Serialization.JsonPropertyName("intent")]
                public string Intent { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置用户的输入字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string Query { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务的全局类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;
    }

    /// <summary>
    /// <para>表示 [POST] /semantic/semproxy/search 接口的响应。</para>
    /// </summary>
    public class SemanticSemproxySearchResponse<T> : SemanticSemproxySearchResponse
        where T : SemanticSemproxySearchResponse.Types.IDetail
    {
        /// <summary>
        /// 获取或设置语义理解后的结构化标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("semantic")]
        [System.Text.Json.Serialization.JsonPropertyName("semantic")]
        public Types.Semantic<T> Semantic { get; set; } = default!;
    }
}
