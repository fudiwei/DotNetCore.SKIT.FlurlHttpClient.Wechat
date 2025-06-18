namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.meeting_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99081 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99082 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98333 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98337 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98341 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98345 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98348 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98352 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98353 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98354 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98355 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98393 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98394 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98395 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98396 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98397 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98771 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98773 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98774 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98775 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98398 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98399 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98400 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98401 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98402 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98404 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98781 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98782 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/98783 ]]>
    /// </para>
    /// </summary>
    public class MeetingChangeEvent : WechatWorkEvent
    {
        public static class Types
        {
            public class OperatedUser
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("UserId")]
                [System.Text.Json.Serialization.JsonPropertyName("UserId")]
                [System.Xml.Serialization.XmlElement("UserId", IsNullable = true)]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置会中临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TmpOpenId")]
                [System.Text.Json.Serialization.JsonPropertyName("TmpOpenId")]
                [System.Xml.Serialization.XmlElement("TmpOpenId", IsNullable = true)]
                public string? TempOpenId { get; set; }

                /// <summary>
                /// 获取或设置成员角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("UserRole")]
                [System.Text.Json.Serialization.JsonPropertyName("UserRole")]
                [System.Xml.Serialization.XmlElement("UserRole", IsNullable = true)]
                public int? Role { get; set; }
            }

            public class WarmUpInfo
            {
                /// <summary>
                /// 获取或设置暖场图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("WarmUpPicture")]
                [System.Text.Json.Serialization.JsonPropertyName("WarmUpPicture")]
                [System.Xml.Serialization.XmlElement("WarmUpPicture", IsNullable = true)]
                public string? WarmUpPictureUrl { get; set; }

                /// <summary>
                /// 获取或设置暖场视频 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("WarmUpVideo")]
                [System.Text.Json.Serialization.JsonPropertyName("WarmUpVideo")]
                [System.Xml.Serialization.XmlElement("WarmUpVideo", IsNullable = true)]
                public string? WarmUpVideoUrl { get; set; }

                /// <summary>
                /// 获取或设置上传结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("UploadStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("UploadStatus")]
                [System.Xml.Serialization.XmlElement("UploadStatus")]
                public int UploadStatus { get; set; }

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ErrorMsg")]
                [System.Text.Json.Serialization.JsonPropertyName("ErrorMsg")]
                [System.Xml.Serialization.XmlElement("ErrorMsg", IsNullable = true)]
                public string? ErrorMessage { get; set; }
            }

            public class UploadInfo
            {
                /// <summary>
                /// 获取或设置素材类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("MediumType")]
                [System.Text.Json.Serialization.JsonPropertyName("MediumType")]
                [System.Xml.Serialization.XmlElement("MediumType")]
                public int MediumType { get; set; }

                /// <summary>
                /// 获取或设置素材 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("MediumUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("MediumUrl")]
                [System.Xml.Serialization.XmlElement("MediumUrl")]
                public string MediumUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置上传结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("UploadStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("UploadStatus")]
                [System.Xml.Serialization.XmlElement("UploadStatus")]
                public int UploadStatus { get; set; }

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ErrorMsg")]
                [System.Text.Json.Serialization.JsonPropertyName("ErrorMsg")]
                [System.Xml.Serialization.XmlElement("ErrorMsg", IsNullable = true)]
                public string? ErrorMessage { get; set; }
            }

            public class MRAInfo
            {
                /// <summary>
                /// 获取或设置信令协议。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Protocol")]
                [System.Text.Json.Serialization.JsonPropertyName("Protocol")]
                [System.Xml.Serialization.XmlElement("Protocol")]
                public int Protocol { get; set; }

                /// <summary>
                /// 获取或设置信令。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("DialString")]
                [System.Text.Json.Serialization.JsonPropertyName("DialString")]
                [System.Xml.Serialization.XmlElement("DialString")]
                public string DialogString { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MeetingId")]
        [System.Text.Json.Serialization.JsonPropertyName("MeetingId")]
        [System.Xml.Serialization.XmlElement("MeetingId")]
        public string MeetingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MeetingRoomId")]
        [System.Text.Json.Serialization.JsonPropertyName("MeetingRoomId")]
        [System.Xml.Serialization.XmlElement("MeetingRoomId", IsNullable = true)]
        public string? MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置操作者会中临时 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FromUserTmpOpenId")]
        [System.Text.Json.Serialization.JsonPropertyName("FromUserTmpOpenId")]
        [System.Xml.Serialization.XmlElement("FromUserTmpOpenId", IsNullable = true)]
        public string? FromUserTempOpenId { get; set; }

        /// <summary>
        /// 获取或设置被操作者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OperatedUser")]
        [System.Text.Json.Serialization.JsonPropertyName("OperatedUser")]
        [System.Xml.Serialization.XmlElement("OperatedUser", IsNullable = true)]
        public Types.OperatedUser? OperatedUser { get; set; }

        /// <summary>
        /// 获取或设置暖场信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WarmUpInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("WarmUpInfo")]
        [System.Xml.Serialization.XmlElement("WarmUpInfo", IsNullable = true)]
        public Types.WarmUpInfo? WarmUpInfo { get; set; }

        /// <summary>
        /// 获取或设置上传信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UploadInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("UploadInfo")]
        [System.Xml.Serialization.XmlElement("UploadInfo", Type = typeof(Types.UploadInfo), IsNullable = true)]
        public Types.UploadInfo[]? UploadInfoList { get; set; }

        /// <summary>
        /// 获取或设置报名 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EnrollId")]
        [System.Text.Json.Serialization.JsonPropertyName("EnrollId")]
        [System.Xml.Serialization.XmlElement("EnrollId", IsNullable = true)]
        public string? EnrollId { get; set; }

        /// <summary>
        /// 获取或设置 Rooms MRA 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MraAddress")]
        [System.Text.Json.Serialization.JsonPropertyName("MraAddress")]
        [System.Xml.Serialization.XmlElement("MraAddress", IsNullable = true)]
        public Types.MRAInfo? RoomsMRAInfo { get; set; }

        /// <summary>
        /// 获取或设置 Rooms 应答结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RoomResponseStatus")]
        [System.Text.Json.Serialization.JsonPropertyName("RoomResponseStatus")]
        [System.Xml.Serialization.XmlElement("RoomResponseStatus", IsNullable = true)]
        public int? RoomsResponseStatus { get; set; }
    }
}
