using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Models.Abstractions
{
    public abstract class ChatMessageBase
    {
        /// <summary>
        /// 获取或设置扩展字段。
        /// </summary>
        [Newtonsoft.Json.JsonExtensionData]
        [System.Text.Json.Serialization.JsonExtensionData]
        public IDictionary<string, object>? ExtensionData { get; set; }
    }

    public class TextMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置文本内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = default!;
    }

    public class ImageMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置图片 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdkfileid")]
        [System.Text.Json.Serialization.JsonPropertyName("sdkfileid")]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片文件 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5sum")]
        [System.Text.Json.Serialization.JsonPropertyName("md5sum")]
        public string FileMD5 { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filesize")]
        [System.Text.Json.Serialization.JsonPropertyName("filesize")]
        public int FileSize { get; set; }
    }

    public class RevokeMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置原消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_msgid")]
        public string PreviousMessageId { get; set; } = default!;
    }

    public class AgreeMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置毫秒级时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agree_time")]
        [System.Text.Json.Serialization.JsonPropertyName("agree_time")]
        public long AgreeTimeMilliseconds { get; set; }
    }

    public class VoiceMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置语音时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("play_length")]
        [System.Text.Json.Serialization.JsonPropertyName("play_length")]
        public int Duration { get; set; }

        /// <summary>
        /// 获取或设置语音 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdkfileid")]
        [System.Text.Json.Serialization.JsonPropertyName("sdkfileid")]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 获取或设置语音文件 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5sum")]
        [System.Text.Json.Serialization.JsonPropertyName("md5sum")]
        public string FileMD5 { get; set; } = default!;

        /// <summary>
        /// 获取或设置语音文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voice_size")]
        [System.Text.Json.Serialization.JsonPropertyName("voice_size")]
        public int FileSize { get; set; }
    }

    public class VideoMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置视频时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("play_length")]
        [System.Text.Json.Serialization.JsonPropertyName("play_length")]
        public int Duration { get; set; }

        /// <summary>
        /// 获取或设置视频 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdkfileid")]
        [System.Text.Json.Serialization.JsonPropertyName("sdkfileid")]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 获取或设置视频文件 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5sum")]
        [System.Text.Json.Serialization.JsonPropertyName("md5sum")]
        public string FileMD5 { get; set; } = default!;

        /// <summary>
        /// 获取或设置视频文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filesize")]
        [System.Text.Json.Serialization.JsonPropertyName("filesize")]
        public int FileSize { get; set; }
    }

    public class BusinessCardMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置企业名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpname")]
        [System.Text.Json.Serialization.JsonPropertyName("corpname")]
        public string CorpName { get; set; } = default!;

        /// <summary>
        /// 获取或设置 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;
    }

    public class LocationMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置纬度坐标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latitude")]
        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// 获取或设置经度坐标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longitude")]
        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public decimal Longitude { get; set; }

        /// <summary>
        /// 获取或设置位置名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置详细地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// 获取或设置缩放比例。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zoom")]
        [System.Text.Json.Serialization.JsonPropertyName("zoom")]
        public int Zoom { get; set; }
    }

    public class EmotionMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置表情类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置宽度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        [System.Text.Json.Serialization.JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// 获取或设置高度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("height")]
        [System.Text.Json.Serialization.JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// 获取或设置表情 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdkfileid")]
        [System.Text.Json.Serialization.JsonPropertyName("sdkfileid")]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 获取或设置表情文件 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5sum")]
        [System.Text.Json.Serialization.JsonPropertyName("md5sum")]
        public string FileMD5 { get; set; } = default!;

        /// <summary>
        /// 获取或设置表情文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imagesize")]
        [System.Text.Json.Serialization.JsonPropertyName("imagesize")]
        public int FileSize { get; set; }
    }

    public class FileMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filename")]
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件后缀。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileext")]
        [System.Text.Json.Serialization.JsonPropertyName("fileext")]
        public string FileExtension { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdkfileid")]
        [System.Text.Json.Serialization.JsonPropertyName("sdkfileid")]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5sum")]
        [System.Text.Json.Serialization.JsonPropertyName("md5sum")]
        public string FileMD5 { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filesize")]
        [System.Text.Json.Serialization.JsonPropertyName("filesize")]
        public int FileSize { get; set; }
    }

    public class LinkMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置点击后跳转的链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_url")]
        [System.Text.Json.Serialization.JsonPropertyName("link_url")]
        public string LinkUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置图文标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置图文描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置图文封面的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_url")]
        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = default!;
    }

    public class MiniProgramMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置消息标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayname")]
        [System.Text.Json.Serialization.JsonPropertyName("displayname")]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string UserName { get; set; } = default!;
    }

    public class ChatRecordMessage : ChatMessageBase
    {
        public static class Types
        {
            public class Record
            {
                /// <summary>
                /// 获取或设置消息发送时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgtime")]
                [System.Text.Json.Serialization.JsonPropertyName("msgtime")]
                public long MessageTimestamp { get; set; }

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string MessageType { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息内容 JSON 字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string MessageContentJson { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否来自群聊。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("from_chatroom")]
                [System.Text.Json.Serialization.JsonPropertyName("from_chatroom")]
                public bool IsFromChatroom { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置聊天记录标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置聊天记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Record[] RecordList { get; set; } = default!;
    }

    public class TodoMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置待办的来源文本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置待办的具体内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = default!;
    }

    public class VoteMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置投票 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voteid")]
        [System.Text.Json.Serialization.JsonPropertyName("voteid")]
        public string VoteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置投票类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("votetype")]
        [System.Text.Json.Serialization.JsonPropertyName("votetype")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置投票主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("votetitle")]
        [System.Text.Json.Serialization.JsonPropertyName("votetitle")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置投票选项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voteitem")]
        [System.Text.Json.Serialization.JsonPropertyName("voteitem")]
        public string[] Options { get; set; } = default!;
    }

    public class CollectMessage : ChatMessageBase
    {
        public static class Types
        {
            public class Detail
            {
                /// <summary>
                /// 获取或设置表项 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long ID { get; set; }

                /// <summary>
                /// 获取或设置表项类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置表项名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ques")]
                [System.Text.Json.Serialization.JsonPropertyName("ques")]
                public string Question { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置群聊名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_name")]
        [System.Text.Json.Serialization.JsonPropertyName("room_name")]
        public string RoomName { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建者名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator")]
        [System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string CreatorName { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public string CreateTimeString { get; set; } = default!;

        /// <summary>
        /// 获取或设置表名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置表项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("details")]
        [System.Text.Json.Serialization.JsonPropertyName("details")]
        public Types.Detail[] DetailList { get; set; } = default!;
    }

    public class RedPacketMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置红包类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置红包祝福语。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wish")]
        [System.Text.Json.Serialization.JsonPropertyName("wish")]
        public string Wishing { get; set; } = default!;

        /// <summary>
        /// 获取或设置总个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalcnt")]
        [System.Text.Json.Serialization.JsonPropertyName("totalcnt")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalamount")]
        [System.Text.Json.Serialization.JsonPropertyName("totalamount")]
        public int TotalAmount { get; set; }
    }

    public class MeetingMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置会议类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingtype")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingtype")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long MeetingId { get; set; }

        /// <summary>
        /// 获取或设置会议主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic")]
        [System.Text.Json.Serialization.JsonPropertyName("topic")]
        public string Topic { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("starttime")]
        [System.Text.Json.Serialization.JsonPropertyName("starttime")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endtime")]
        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remarks")]
        [System.Text.Json.Serialization.JsonPropertyName("remarks")]
        public string Remark { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议邀请处理状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }
    }

    public class DocumentMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置文档标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置文档链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_url")]
        [System.Text.Json.Serialization.JsonPropertyName("link_url")]
        public string LinkUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建者 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("doc_creator")]
        [System.Text.Json.Serialization.JsonPropertyName("doc_creator")]
        public string CreatorUserId { get; set; } = default!;
    }

    public class InfoMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 获取或设置图文消息链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? NewsUrl { get; set; }

        /// <summary>
        /// 获取或设置图文消息标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? NewsTitle { get; set; }

        /// <summary>
        /// 获取或设置图文消息描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? NewsDescription { get; set; }

        /// <summary>
        /// 获取或设置 VoIP 通话时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callduration")]
        [System.Text.Json.Serialization.JsonPropertyName("callduration")]
        public int? VoIPCallDuration { get; set; }

        /// <summary>
        /// 获取或设置 VoIP 通话类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invitetype")]
        [System.Text.Json.Serialization.JsonPropertyName("invitetype")]
        public int? VoIPInviteType { get; set; }

        /// <summary>
        /// 获取或设置微盘文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filename")]
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? WedriveFileName { get; set; }

        /// <summary>
        /// 获取或设置会议类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? MeetingId { get; set; }

        /// <summary>
        /// 获取或设置通知类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notification_type")]
        [System.Text.Json.Serialization.JsonPropertyName("notification_type")]
        public int? NotificationType { get; set; }
    }

    public class CalendarMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置日程主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置日程组织者名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creatorname")]
        [System.Text.Json.Serialization.JsonPropertyName("creatorname")]
        public string CreatorName { get; set; } = default!;

        /// <summary>
        /// 获取或设置日程开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("starttime")]
        [System.Text.Json.Serialization.JsonPropertyName("starttime")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置日程结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endtime")]
        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置日程参与人名称列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendeename")]
        [System.Text.Json.Serialization.JsonPropertyName("attendeename")]
        public string[] AttendeeNameList { get; set; } = default!;

        /// <summary>
        /// 获取或设置日程地点。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("place")]
        [System.Text.Json.Serialization.JsonPropertyName("place")]
        public string Place { get; set; } = default!;

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remarks")]
        [System.Text.Json.Serialization.JsonPropertyName("remarks")]
        public string Remark { get; set; } = default!;
    }

    public class MixedMessage : ChatMessageBase
    {
        public static class Types
        {
            public class Message
            {
                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息内容 JSON 字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string ContentJson { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置混合消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Message[] MessageList { get; set; } = default!;
    }

    public class MeetingVoiceCallMessage : ChatMessageBase
    {
        public static class Types
        {
            public class ShareFileData
            {
                /// <summary>
                /// 获取或设置文件名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("filename")]
                [System.Text.Json.Serialization.JsonPropertyName("filename")]
                public string FileName { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作者 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("demooperator")]
                [System.Text.Json.Serialization.JsonPropertyName("demooperator")]
                public string OperatorUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("starttime")]
                [System.Text.Json.Serialization.JsonPropertyName("starttime")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("endtime")]
                [System.Text.Json.Serialization.JsonPropertyName("endtime")]
                public long EndTimestamp { get; set; }
            }

            public class ShareScreenData
            {
                /// <summary>
                /// 获取或设置分享者 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share")]
                [System.Text.Json.Serialization.JsonPropertyName("share")]
                public string SharerUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("starttime")]
                [System.Text.Json.Serialization.JsonPropertyName("starttime")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("endtime")]
                [System.Text.Json.Serialization.JsonPropertyName("endtime")]
                public long EndTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置音频 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdkfileid")]
        [System.Text.Json.Serialization.JsonPropertyName("sdkfileid")]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 获取或设置音频结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endtime")]
        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置文档分享对象列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("demofiledata")]
        [System.Text.Json.Serialization.JsonPropertyName("demofiledata")]
        public Types.ShareFileData[]? ShareFileDataList { get; set; }

        /// <summary>
        /// 获取或设置屏幕共享对象列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharescreendata")]
        [System.Text.Json.Serialization.JsonPropertyName("sharescreendata")]
        public Types.ShareScreenData[]? ShareScreenDataList { get; set; }
    }

    public class VoIPDocumentShareMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置音频文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filename")]
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// 获取或设置音频 FileId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdkfileid")]
        [System.Text.Json.Serialization.JsonPropertyName("sdkfileid")]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 获取或设置音频文件 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5sum")]
        [System.Text.Json.Serialization.JsonPropertyName("md5sum")]
        public string FileMD5 { get; set; } = default!;

        /// <summary>
        /// 获取或设置音频文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filesize")]
        [System.Text.Json.Serialization.JsonPropertyName("filesize")]
        public int FileSize { get; set; }
    }

    public class ChannelsFeedMessage : ChatMessageBase
    {
        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_type")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_type")]
        public int FeedType { get; set; }

        /// <summary>
        /// 获取或设置视频号账号名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sph_name")]
        [System.Text.Json.Serialization.JsonPropertyName("sph_name")]
        public string ChannelsNickName { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_desc")]
        public string Description { get; set; } = default!;
    }
}
