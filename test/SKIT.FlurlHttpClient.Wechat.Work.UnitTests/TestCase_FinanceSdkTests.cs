using System.Threading.Tasks;
using Flurl.Http.Configuration;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    using SKIT.FlurlHttpClient;
    using SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance;
    using SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Models;

    public class TestCase_FinanceSdkTests
    {
        [Fact(DisplayName = "测试用例：聊天记录 - 会话内容存档 SDK")]
        public async Task TestFinanceSdk()
        {
            var options = new WechatWorkFinanceClientOptions()
            {
                CorpId = TestConfigs.WechatCorpId,
                SecretKey = TestConfigs.WechatFinanceSecretKey
            };
            options.EncryptionKeyManager.AddEntry(new SDK.Finance.Settings.EncryptionKeyEntry(1, TestConfigs.WechatFinanceEncryptionPrivateKey));
            using var client = new WechatWorkFinanceClient(options);

            var reqGetChatRecords = new GetChatRecordsRequest();
            var resGetChatRecords = await client.ExecuteGetChatRecordsAsync(reqGetChatRecords);

            Assert.True(resGetChatRecords.IsSuccessful());
            Assert.NotEmpty(resGetChatRecords.RecordList);
            
            foreach (var record in resGetChatRecords.RecordList)
            {
                var reqDecryptChatRecord = new DecryptChatRecordRequest()
                {
                    PublicKeyVersion = record.PublicKeyVersion,
                    EncryptedRandomKey = record.EncryptedRandomKey,
                    EncryptedChatMessage = record.EncryptedChatMessage
                };
                var resDecryptChatRecord = await client.ExecuteDecryptChatRecordAsync(reqDecryptChatRecord);

                Assert.True(resDecryptChatRecord.IsSuccessful());
                Assert.NotNull(resDecryptChatRecord.MessageId);
                Assert.NotNull(resDecryptChatRecord.Action);
                Assert.NotNull(resDecryptChatRecord.FromUserId);
                Assert.NotNull(resDecryptChatRecord.MessageType);

                switch (resDecryptChatRecord.MessageType)
                {
                    case "image":
                        {
                            var reqGetMediaFile = new GetMediaFileRequest()
                            {
                                FileId = resDecryptChatRecord.MessageContentAsImage!.FileId
                            };
                            var resGetMediaFile = await client.ExecuteGetMediaFileAsync(reqGetMediaFile);

                            Assert.True(resGetMediaFile.IsSuccessful());
                            Assert.Equal(resDecryptChatRecord.MessageContentAsImage!.FileSize, resGetMediaFile.FileBytes.Length);
                        }
                        break;

                    case "voice":
                        {
                            var reqGetMediaFile = new GetMediaFileRequest()
                            {
                                FileId = resDecryptChatRecord.MessageContentAsVoice!.FileId
                            };
                            var resGetMediaFile = await client.ExecuteGetMediaFileAsync(reqGetMediaFile);

                            Assert.True(resGetMediaFile.IsSuccessful());
                            Assert.Equal(resDecryptChatRecord.MessageContentAsVoice!.FileSize, resGetMediaFile.FileBytes.Length);
                        }
                        break;

                    case "video":
                        {
                            var reqGetMediaFile = new GetMediaFileRequest()
                            {
                                FileId = resDecryptChatRecord.MessageContentAsVideo!.FileId
                            };
                            var resGetMediaFile = await client.ExecuteGetMediaFileAsync(reqGetMediaFile);

                            Assert.True(resGetMediaFile.IsSuccessful());
                            Assert.Equal(resDecryptChatRecord.MessageContentAsVideo!.FileSize, resGetMediaFile.FileBytes.Length);
                        }
                        break;

                    case "file":
                        {
                            var reqGetMediaFile = new GetMediaFileRequest()
                            {
                                FileId = resDecryptChatRecord.MessageContentAsFile!.FileId
                            };
                            var resGetMediaFile = await client.ExecuteGetMediaFileAsync(reqGetMediaFile);

                            Assert.True(resGetMediaFile.IsSuccessful());
                            Assert.Equal(resDecryptChatRecord.MessageContentAsFile!.FileSize, resGetMediaFile.FileBytes.Length);
                        }
                        break;
                }
            }
        }

        [Fact(DisplayName = "测试用例：聊天记录 - 会话内容存档数据结构反序列化")]
        public void TestFinanceSdkModelsDeserialization()
        {
            var newtonsoftJsonSerializer = new FlurlNewtonsoftJsonSerializer();
            var systemTextJsonSerializer = new FlurlSystemTextJsonSerializer();

            #region 用例：聊天记录列表
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""errcode"": 0,
	                    ""errmsg"": ""ok"",
	                    ""chatdata"": [{
		                    ""seq"": 196,
		                    ""msgid"": ""CAQQ2fbb4QUY0On2rYSAgAMgip/yzgs="",
		                    ""publickey_ver"": 3,
		                    ""encrypt_random_key"": ""ftJ+uz3n/z1DsxlkwxNgE+mL38H42/KCvN8T60gbbtPD+Rta1hKTuQPzUzO6Hzne97MgKs7FfdDxDck/v8cDT6gUVjA2tZ/M7euSD0L66opJ/IUeBtpAtvgVSD5qhlaQjvfKJc/zPMGNK2xCLFYqwmQBZXbNT7uA69Fflm512nZKW/piK2RKdYJhRyvQnA1ISxK097sp9WlEgDg250fM5tgwMjujdzr7ehK6gtVBUFldNSJS7ndtIf6aSBfaLktZgwHZ57ONewWq8GJe7WwQf1hwcDbCh7YMG8nsweEwhDfUz+u8rz9an+0lgrYMZFRHnmzjgmLwrR7B/32Qxqd79A=="",
		                    ""encrypt_chat_msg"": ""898WSfGMnIeytTsea7Rc0WsOocs0bIAerF6de0v2cFwqo9uOxrW9wYe5rCjCHHH5bDrNvLxBE/xOoFfcwOTYX0HQxTJaH0ES9OHDZ61p8gcbfGdJKnq2UU4tAEgGb8H+Q9n8syRXIjaI3KuVCqGIi4QGHFmxWenPFfjF/vRuPd0EpzUNwmqfUxLBWLpGhv+dLnqiEOBW41Zdc0OO0St6E+JeIeHlRZAR+E13Isv9eS09xNbF0qQXWIyNUi+ucLr5VuZnPGXBrSfvwX8f0QebTwpy1tT2zvQiMM2MBugKH6NuMzzuvEsXeD+6+3VRqL""
	                    }]
                    }";

                    var model = serializer.Deserialize<GetChatRecordsResponse>(json);
                    Assert.Equal(196, model.RecordList[0]!.Sequence);
                    Assert.Equal("CAQQ2fbb4QUY0On2rYSAgAMgip/yzgs=", model.RecordList[0]!.MessageId);
                    Assert.Equal(3, model.RecordList[0]!.PublicKeyVersion);
                    Assert.Equal("ftJ+uz3n/z1DsxlkwxNgE+mL38H42/KCvN8T60gbbtPD+Rta1hKTuQPzUzO6Hzne97MgKs7FfdDxDck/v8cDT6gUVjA2tZ/M7euSD0L66opJ/IUeBtpAtvgVSD5qhlaQjvfKJc/zPMGNK2xCLFYqwmQBZXbNT7uA69Fflm512nZKW/piK2RKdYJhRyvQnA1ISxK097sp9WlEgDg250fM5tgwMjujdzr7ehK6gtVBUFldNSJS7ndtIf6aSBfaLktZgwHZ57ONewWq8GJe7WwQf1hwcDbCh7YMG8nsweEwhDfUz+u8rz9an+0lgrYMZFRHnmzjgmLwrR7B/32Qxqd79A==", model.RecordList[0]!.EncryptedRandomKey);
                    Assert.Equal("898WSfGMnIeytTsea7Rc0WsOocs0bIAerF6de0v2cFwqo9uOxrW9wYe5rCjCHHH5bDrNvLxBE/xOoFfcwOTYX0HQxTJaH0ES9OHDZ61p8gcbfGdJKnq2UU4tAEgGb8H+Q9n8syRXIjaI3KuVCqGIi4QGHFmxWenPFfjF/vRuPd0EpzUNwmqfUxLBWLpGhv+dLnqiEOBW41Zdc0OO0St6E+JeIeHlRZAR+E13Isv9eS09xNbF0qQXWIyNUi+ucLr5VuZnPGXBrSfvwX8f0QebTwpy1tT2zvQiMM2MBugKH6NuMzzuvEsXeD+6+3VRqL", model.RecordList[0]!.EncryptedChatMessage);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = "{\"msgid\":\"MSGID\",\"action\":\"ACTION\",\"from\":\"FROM\",\"tolist\":[\"TO\"],\"roomid\":\"ROOMID\",\"msgtime\":1234567890}";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("MSGID", model.MessageId);
                    Assert.Equal("ACTION", model.Action);
                    Assert.Equal("FROM", model.FromUserId);
                    Assert.Equal("TO", model.ToUserIdList![0]);
                    Assert.Equal("ROOMID", model.RoomId);
                    Assert.Equal(1234567890, model.MessageTimeMilliseconds);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 文本
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""CAQQluDa4QUY0On2rYSAgAMgzPrShAE="",
	                    ""action"": ""send"",
	                    ""from"": ""XuJinSheng"",
	                    ""tolist"": [""icefog""],
	                    ""roomid"": """",
	                    ""msgtime"": 1547087894783,
	                    ""msgtype"": ""text"",
	                    ""text"": {
		                    ""content"": ""test""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("text", model.MessageType);
                    Assert.Equal("test", model.MessageContentAsText!.Content);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 图片
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""CAQQvPnc4QUY0On2rYSAgAMgooLa0Q8="",
	                    ""action"": ""send"",
	                    ""from"": ""XuJinSheng"",
	                    ""tolist"": [""icefog""],
	                    ""roomid"": """",
	                    ""msgtime"": 0,
	                    ""msgtype"": ""image"",
	                    ""image"": {
		                    ""md5sum"": ""50de8e5ae8ffe4f1df7a93841f71993a"",
		                    ""filesize"": 70961,
		                    ""sdkfileid"": ""FILEID""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("image", model.MessageType);
                    Assert.Equal("FILEID", model.MessageContentAsImage!.FileId);
                    Assert.Equal("50de8e5ae8ffe4f1df7a93841f71993a", model.MessageContentAsImage!.FileMD5);
                    Assert.Equal(70961, model.MessageContentAsImage!.FileSize);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 撤回消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""15775510700152506326_1603875615"",
	                    ""action"": ""recall"",
	                    ""from"": ""kenshin"",
	                    ""tolist"": [""wmUu0zBgAALV7ZymkcMyxvbTe8YdWxxA""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875615723,
	                    ""msgtype"": ""revoke"",
	                    ""revoke"": {
		                    ""pre_msgid"": ""14822339130656386894_1603875600""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("revoke", model.MessageType);
                    Assert.Equal("14822339130656386894_1603875600", model.MessageContentAsRevoke!.PreviousMessageId);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 同意会话聊天内容
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""8891446340739254950_1603875826"",
	                    ""action"": ""send"",
	                    ""from"": ""wmGAgeDQAAvQeaTqWwkMTxGMkvI7OOuQ"",
	                    ""tolist"": [""kenshin""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875826656,
	                    ""msgtype"": ""agree"",
	                    ""agree"": {
		                    ""userid"": ""wmGAgeDQAAvQeaTqWwkMTxGMkvI7OOuQ"",
		                    ""agree_time"": 1603875826656
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("agree", model.MessageType);
                    Assert.Equal("wmGAgeDQAAvQeaTqWwkMTxGMkvI7OOuQ", model.MessageContentAsAgree!.UserId);
                    Assert.Equal(1603875826656, model.MessageContentAsAgree!.AgreeTimeMilliseconds);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 语音
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""10958372969718811103_1603875609"",
	                    ""action"": ""send"",
	                    ""from"": ""wmGAgeDQAAdBjb8CK4ieMPRm7Cqm-9VA"",
	                    ""tolist"": [""kenshin""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875609704,
	                    ""msgtype"": ""voice"",
	                    ""voice"": {
		                    ""md5sum"": ""9db09c7fa627c9e53f17736c786a74d5"",
		                    ""voice_size"": 6810,
		                    ""play_length"": 10,
		                    ""sdkfileid"": ""FILEID""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("voice", model.MessageType);
                    Assert.Equal("FILEID", model.MessageContentAsVoice!.FileId);
                    Assert.Equal("9db09c7fa627c9e53f17736c786a74d5", model.MessageContentAsVoice!.FileMD5);
                    Assert.Equal(6810, model.MessageContentAsVoice!.FileSize);
                    Assert.Equal(10, model.MessageContentAsVoice!.Duration);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 视频
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""17955920891003447432_1603875627"",
	                    ""action"": ""send"",
	                    ""from"": ""kenshin"",
	                    ""tolist"": [""wmGAgeDQAAHuRJbt4ZQI_1cqoQcf41WQ""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875626823,
	                    ""msgtype"": ""video"",
	                    ""video"": {
		                    ""md5sum"": ""d06fc80c01d6fbffcca3b229ba41eac6"",
		                    ""filesize"": 15169724,
		                    ""play_length"": 108,
		                    ""sdkfileid"": ""FILEID""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("video", model.MessageType);
                    Assert.Equal("FILEID", model.MessageContentAsVideo!.FileId);
                    Assert.Equal("d06fc80c01d6fbffcca3b229ba41eac6", model.MessageContentAsVideo!.FileMD5);
                    Assert.Equal(15169724, model.MessageContentAsVideo!.FileSize);
                    Assert.Equal(108, model.MessageContentAsVideo!.Duration);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 名片
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""13714216591700685558_1603875680"",
	                    ""action"": ""send"",
	                    ""from"": ""kenshin"",
	                    ""tolist"": [""wmGAgeDQAAy2Dtr0F8aK4dTuatfm-5Rg""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875680377,
	                    ""msgtype"": ""card"",
	                    ""card"": {
		                    ""corpname"": ""微信联系人"",
		                    ""userid"": ""wmGAgeDQAAGjFmfnP7A3j2JxQDdLNhSw""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("card", model.MessageType);
                    Assert.Equal("微信联系人", model.MessageContentAsBusinessCard!.CorpName);
                    Assert.Equal("wmGAgeDQAAGjFmfnP7A3j2JxQDdLNhSw", model.MessageContentAsBusinessCard!.UserId);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 位置
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""2641513858500683770_1603876152"",
	                    ""action"": ""send"",
	                    ""from"": ""icefog"",
	                    ""tolist"": [""wmN6etBgAA0sbJ3invMvRxPQDFoq9uWA""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603876152141,
	                    ""msgtype"": ""location"",
	                    ""location"": {
		                    ""longitude"": 116.586285899,
		                    ""latitude"": 39.911125799,
		                    ""address"": ""北京市xxx区xxx路xxx大厦x座"",
		                    ""title"": ""xxx管理中心"",
		                    ""zoom"": 15
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("location", model.MessageType);
                    Assert.Equal(116.586285899, model.MessageContentAsLocation!.Longitude);
                    Assert.Equal(39.911125799, model.MessageContentAsLocation!.Latitude);
                    Assert.Equal("北京市xxx区xxx路xxx大厦x座", model.MessageContentAsLocation.Address);
                    Assert.Equal("xxx管理中心", model.MessageContentAsLocation.Title);
                    Assert.Equal(15, model.MessageContentAsLocation.Zoom);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 位置
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""6623217619416669654_1603875612"",
	                    ""action"": ""send"",
	                    ""from"": ""icef"",
	                    ""tolist"": [""wmErxtDgAAhteCglUZH2kUt3rq431qmg""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875611148,
	                    ""msgtype"": ""emotion"",
	                    ""emotion"": {
		                    ""type"": 1,
		                    ""width"": 290,
		                    ""height"": 290,
		                    ""imagesize"": 962604,
		                    ""md5sum"": ""94c2b0bba52cc456cb8221b248096612"",
		                    ""sdkfileid"": ""FILEID""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("emotion", model.MessageType);
                    Assert.Equal(1, model.MessageContentAsEmotion!.Type);
                    Assert.Equal(290, model.MessageContentAsEmotion!.Width);
                    Assert.Equal(290, model.MessageContentAsEmotion!.Height);
                    Assert.Equal("FILEID", model.MessageContentAsEmotion.FileId);
                    Assert.Equal("94c2b0bba52cc456cb8221b248096612", model.MessageContentAsEmotion.FileMD5);
                    Assert.Equal(962604, model.MessageContentAsEmotion.FileSize);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 文件
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""18039699423706571225_1603875608"",
	                    ""action"": ""send"",
	                    ""from"": ""kens"",
	                    ""tolist"": [""wmErxtDgAArDlFIhf76O6w4GxU81al8w""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875608214,
	                    ""msgtype"": ""file"",
	                    ""file"": {
		                    ""md5sum"": ""18e93fc2ea884df23b3d2d3b8667b9f0"",
		                    ""filename"": ""资料.docx"",
		                    ""fileext"": ""docx"",
		                    ""filesize"": 18181,
		                    ""sdkfileid"": ""FILEID""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("file", model.MessageType);
                    Assert.Equal("资料.docx", model.MessageContentAsFile!.FileName);
                    Assert.Equal("docx", model.MessageContentAsFile!.FileExtension);
                    Assert.Equal("FILEID", model.MessageContentAsFile.FileId);
                    Assert.Equal("18e93fc2ea884df23b3d2d3b8667b9f0", model.MessageContentAsFile.FileMD5);
                    Assert.Equal(18181, model.MessageContentAsFile.FileSize);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 链接
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""11788441727514772650_1603875624"",
	                    ""action"": ""send"",
	                    ""from"": ""kenshin"",
	                    ""tolist"": [""0000726""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875624476,
	                    ""msgtype"": ""link"",
	                    ""link"": {
		                    ""title"": ""邀请你加入群聊"",
		                    ""description"": ""技术支持群，进入可查看详情"",
		                    ""link_url"": ""https://work.weixin.qq.com/wework_admin/external_room/join/exceed?vcode=xxx"",
		                    ""image_url"": ""https://wework.qpic.cn/wwpic/xxx/0""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("link", model.MessageType);
                    Assert.Equal("邀请你加入群聊", model.MessageContentAsLink!.Title);
                    Assert.Equal("技术支持群，进入可查看详情", model.MessageContentAsLink!.Description);
                    Assert.Equal("https://work.weixin.qq.com/wework_admin/external_room/join/exceed?vcode=xxx", model.MessageContentAsLink.LinkUrl);
                    Assert.Equal("https://wework.qpic.cn/wwpic/xxx/0", model.MessageContentAsLink.ImageUrl);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 小程序消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""11930598857592605935_1603875608"",
	                    ""action"": ""send"",
	                    ""from"": ""kens"",
	                    ""tolist"": [""wmGAgeDQAAsgQetTQGqRbMxrkodpM3fA""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875608691,
	                    ""msgtype"": ""weapp"",
	                    ""weapp"": {
		                    ""title"": ""开始聊天前请仔细阅读服务须知事项"",
		                    ""description"": ""客户需同意存档聊天记录"",
		                    ""username"": ""xxx@app"",
		                    ""displayname"": ""服务须知""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("weapp", model.MessageType);
                    Assert.Equal("开始聊天前请仔细阅读服务须知事项", model.MessageContentAsMiniProgram!.Title);
                    Assert.Equal("客户需同意存档聊天记录", model.MessageContentAsMiniProgram!.Description);
                    Assert.Equal("xxx@app", model.MessageContentAsMiniProgram.UserName);
                    Assert.Equal("服务须知", model.MessageContentAsMiniProgram.DisplayName);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 会话记录消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""11354299838102555191_1603875658"",
	                    ""action"": ""send"",
	                    ""from"": ""ken"",
	                    ""tolist"": [""icef""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875657905,
	                    ""msgtype"": ""chatrecord"",
	                    ""chatrecord"": {
		                    ""title"": ""群聊"",
		                    ""item"": [{
			                    ""type"": ""ChatRecordText"",
			                    ""msgtime"": 1603875610,
			                    ""content"": ""{\""content\"":\""test\""}"",
			                    ""from_chatroom"": false
		                    }, {
			                    ""type"": ""ChatRecordText"",
			                    ""msgtime"": 1603875620,
			                    ""content"": ""{\""content\"":\""test2\""}"",
			                    ""from_chatroom"": false
		                    }]
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("chatrecord", model.MessageType);
                    Assert.Equal("群聊", model.MessageContentAsChatRecord!.Title);
                    Assert.Equal("ChatRecordText", model.MessageContentAsChatRecord!.RecordList[0]!.MessageType);
                    Assert.Equal("{\"content\":\"test\"}", model.MessageContentAsChatRecord!.RecordList[0]!.MessageContentJson);
                    Assert.Equal(1603875610, model.MessageContentAsChatRecord!.RecordList[0]!.MessageTimestamp);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 待办消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""11354299838102555191_1603875658"",
	                    ""action"": ""send"",
	                    ""from"": ""ken"",
	                    ""tolist"": [""icef""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875657905,
	                    ""msgtype"": ""todo"",
	                    ""todo"": {
		                    ""title"": ""来源文本"",
			                ""content"": ""具体内容""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("todo", model.MessageType);
                    Assert.Equal("来源文本", model.MessageContentAsTodo!.Title);
                    Assert.Equal("具体内容", model.MessageContentAsTodo!.Content);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 投票消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""11354299838102555191_1603875658"",
	                    ""action"": ""send"",
	                    ""from"": ""ken"",
	                    ""tolist"": [""icef""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603875657905,
	                    ""msgtype"": ""vote"",
	                    ""vote"": {
		                    ""votetitle"": ""投票主题"",
	                        ""voteitem"": [""投票选项""],
			                ""votetype"": 101,
			                ""voteid"": ""1603875610""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("vote", model.MessageType);
                    Assert.Equal(101, model.MessageContentAsVote!.Type);
                    Assert.Equal("1603875610", model.MessageContentAsVote!.VoteId);
                    Assert.Equal("投票主题", model.MessageContentAsVote!.Title);
                    Assert.Equal("投票选项", model.MessageContentAsVote!.Options[0]!);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 填表消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""2500536226619379797_1576034482"",
	                    ""action"": ""send"",
	                    ""from"": ""nick"",
	                    ""tolist"": [""XuJinSheng"", ""15108264797""],
	                    ""roomid"": ""wrjc7bDwYAOAhf9quEwRRxyyoMm0QAAA"",
	                    ""msgtime"": 1576034482344,
	                    ""msgtype"": ""collect"",
	                    ""collect"": {
		                    ""room_name"": ""这是一个群"",
		                    ""creator"": ""nick"",
		                    ""create_time"": ""2019-12-11 11:21:22"",
		                    ""title"": ""这是填表title"",
		                    ""details"": [{
			                    ""id"": 1,
			                    ""ques"": ""表项1，文本"",
			                    ""type"": ""Text""
		                    }, {
			                    ""id"": 2,
			                    ""ques"": ""表项2，数字"",
			                    ""type"": ""Number""
		                    }, {
			                    ""id"": 3,
			                    ""ques"": ""表项3，日期"",
			                    ""type"": ""Date""
		                    }, {
			                    ""id"": 4,
			                    ""ques"": ""表项4，时间"",
			                    ""type"": ""Time""
		                    }]
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("collect", model.MessageType);
                    Assert.Equal("这是一个群", model.MessageContentAsCollect!.RoomName);
                    Assert.Equal("nick", model.MessageContentAsCollect!.CreatorName);
                    Assert.Equal("2019-12-11 11:21:22", model.MessageContentAsCollect!.CreateTimeString);
                    Assert.Equal("这是填表title", model.MessageContentAsCollect!.Title);
                    Assert.Equal(1, model.MessageContentAsCollect!.DetailList[0]!.ID);
                    Assert.Equal("Text", model.MessageContentAsCollect!.DetailList[0]!.Type);
                    Assert.Equal("表项1，文本", model.MessageContentAsCollect!.DetailList[0]!.Question);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 红包消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""333590477316965370_1603877439"",
	                    ""action"": ""send"",
	                    ""from"": ""kens"",
	                    ""tolist"": [""1000000444696""],
	                    ""roomid"": """",
	                    ""msgtime"": 1603877439038,
	                    ""msgtype"": ""redpacket"",
	                    ""redpacket"": {
		                    ""type"": 1,
		                    ""wish"": ""恭喜发财，大吉大利"",
		                    ""totalcnt"": 10,
		                    ""totalamount"": 3000
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("redpacket", model.MessageType);
                    Assert.Equal(1, model.MessageContentAsRedPacket!.Type);
                    Assert.Equal("恭喜发财，大吉大利", model.MessageContentAsRedPacket!.Wishing);
                    Assert.Equal(10, model.MessageContentAsRedPacket!.TotalCount);
                    Assert.Equal(3000, model.MessageContentAsRedPacket!.TotalAmount);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 会议邀请消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""5935786683775673543_1603877328"",
	                    ""action"": ""send"",
	                    ""from"": ""ken"",
	                    ""tolist"": [""icef"", ""test""],
	                    ""roomid"": ""wr2vOpDgAAN4zVWKbS"",
	                    ""msgtime"": 1603877328914,
	                    ""msgtype"": ""meeting"",
	                    ""meeting"": {
		                    ""topic"": ""夕会"",
		                    ""starttime"": 1603877400,
		                    ""endtime"": 1603881000,
		                    ""address"": ""地址"",
		                    ""remarks"": ""备注"",
		                    ""meetingtype"": 102,
		                    ""meetingid"": 1210342560,
		                    ""status"": 1
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("meeting", model.MessageType);
                    Assert.Equal(102, model.MessageContentAsMeeting!.Type);
                    Assert.Equal(1210342560, model.MessageContentAsMeeting!.MeetingId);
                    Assert.Equal("夕会", model.MessageContentAsMeeting!.Topic);
                    Assert.Equal(1603877400, model.MessageContentAsMeeting!.StartTimestamp);
                    Assert.Equal(1603881000, model.MessageContentAsMeeting!.EndTimestamp);
                    Assert.Equal("地址", model.MessageContentAsMeeting!.Address);
                    Assert.Equal("备注", model.MessageContentAsMeeting!.Remark);
                    Assert.Equal(1, model.MessageContentAsMeeting!.Status);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 切换企业日志
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""125289002219525886280"",
	                    ""action"": ""switch"",
	                    ""time"": 1554119421840,
	                    ""user"": ""XuJinSheng""
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("XuJinSheng", model.ExtensionData!["user"]!.ToString());
                    Assert.Equal("1554119421840", model.ExtensionData!["time"]!.ToString());
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 在线文档消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""9732089160923053207_1603877765"",
	                    ""action"": ""send"",
	                    ""from"": ""ken"",
	                    ""tolist"": [""icef"", ""test""],
	                    ""roomid"": ""wrJawBCQAAStr3jxVxEH"",
	                    ""msgtime"": 1603877765291,
	                    ""msgtype"": ""docmsg"",
	                    ""doc"": {
		                    ""title"": ""测试&演示客户"",
		                    ""doc_creator"": ""test"",
		                    ""link_url"": ""https://doc.weixin.qq.com/txdoc/excel?docid=xxx""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("docmsg", model.MessageType);
                    Assert.Equal("测试&演示客户", model.MessageContentAsDocument!.Title);
                    Assert.Equal("test", model.MessageContentAsDocument!.CreatorUserId);
                    Assert.Equal("https://doc.weixin.qq.com/txdoc/excel?docid=xxx", model.MessageContentAsDocument!.LinkUrl);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - Markdown 格式消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""7546287934688259248_1603875715"",
	                    ""action"": ""send"",
	                    ""from"": ""ken"",
	                    ""tolist"": [""icef"", ""test""],
	                    ""roomid"": ""wr0SfLCgAAgCaCPeM33UNe"",
	                    ""msgtime"": 1603875715782,
	                    ""msgtype"": ""markdown"",
	                    ""info"": {
		                    ""content"": ""请前往系统查看，谢谢。""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("markdown", model.MessageType);
                    Assert.Equal("请前往系统查看，谢谢。", model.MessageContentAsInfo!.Content);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 日程消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""2345881211604379705_1603877680"",
	                    ""action"": ""send"",
	                    ""from"": ""ken"",
	                    ""tolist"": [""icef"", ""test""],
	                    ""roomid"": ""wr2LO0CAAAFrTZCGWWAxBA"",
	                    ""msgtime"": 1603877680795,
	                    ""msgtype"": ""calendar"",
	                    ""calendar"": {
		                    ""title"": ""xxx业绩复盘会"",
		                    ""creatorname"": ""test"",
		                    ""attendeename"": [""aaa"", ""bbb""],
		                    ""starttime"": 1603882800,
		                    ""endtime"": 1603886400,
		                    ""place"": ""地点"",
		                    ""remarks"": ""备注""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("calendar", model.MessageType);
                    Assert.Equal("xxx业绩复盘会", model.MessageContentAsCalendar!.Title);
                    Assert.Equal("test", model.MessageContentAsCalendar!.CreatorName);
                    Assert.Equal("aaa", model.MessageContentAsCalendar!.AttendeeNameList[0]);
                    Assert.Equal(1603882800, model.MessageContentAsCalendar!.StartTimestamp);
                    Assert.Equal(1603886400, model.MessageContentAsCalendar!.EndTimestamp);
                    Assert.Equal("地点", model.MessageContentAsCalendar!.Place);
                    Assert.Equal("备注", model.MessageContentAsCalendar!.Remark);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 混合消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""DAQQluDa4QUY0On4kYSABAMgzPrShAE="",
	                    ""action"": ""send"",
	                    ""from"": ""HeMiao"",
	                    ""tolist"": [""HeChangTian"", ""LiuZeYu""],
	                    ""roomid"": ""wr_tZ2BwAAUwHpYMwy9cIWqnlU3Hzqfg"",
	                    ""msgtime"": 1577414359072,
	                    ""msgtype"": ""mixed"",
	                    ""mixed"": {
		                    ""item"": [{
			                    ""type"": ""text"",
			                    ""content"": ""{\""content\"":\""你好[微笑]\\n\""}""
		                    }, {
			                    ""type"": ""image"",
			                    ""content"": ""{\""md5sum\"":\""368b6c18c82e6441bfd89b343e9d2429\"",\""filesize\"":13177,\""sdkfileid\"":\""CtYBMzA2OTAyMDEwMjA0NjIzMDYwMDIwMTAwMDWwNDVmYWY4Y2Q3MDIwMzBmNTliMTAyMDQwYzljNTQ3NzAyMDQ1ZTA1NmFlMjA0MjQ2NjM0NjIzNjY2MzYzNTMyMmQzNzYxMzQ2NDJkMzQ2MjYxNjQyZDM4MzMzMzM4MmQ3MTYyMzczMTM4NjM2NDYxMzczMjY2MzkwMjAxMDAwMjAzMDIwMDEwMDQxMDM2OGI2YzE4YzgyZTY0NDFiZmQ4OWIyNDNlOWQyNDI4MDIwMTAyMDIwMTAwMDQwMBI4TkRkZk2UWTRPRGcxTVRneE5URTFNRGc1TVY4eE1UTTFOak0yTURVeFh6RTFOemMwTVRNek5EYz0aIDQzMTY5NDFlM2MxZDRmZjhhMjEwY2M0NDQzZGUXOTEy\""}""
		                    }]
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("mixed", model.MessageType);
                    Assert.Equal("text", model.MessageContentAsMixed!.MessageList[0]!.Type);
                    Assert.Equal("{\"content\":\"你好[微笑]\\n\"}", model.MessageContentAsMixed!.MessageList[0]!.ContentJson);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 音频存档消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""17952229780246929345_1594197637"",
	                    ""action"": ""send"",
	                    ""from"": ""wo137MCgAAYW6pIiKKrDe5SlzEhSgwbA"",
	                    ""tolist"": [""wo137MCgAAYW6pIiKKrDe5SlzEhSgwbA""],
	                    ""msgtime"": 1594197581203,
	                    ""msgtype"": ""meeting_voice_call"",
	                    ""voiceid"": ""grb8a4c48a3c094a70982c518d55e40557"",
	                    ""meeting_voice_call"": {
		                    ""endtime"": 1594197635,
		                    ""sdkfileid"": ""FILEID"",
		                    ""demofiledata"": [{
			                    ""filename"": ""65eb1cdd3e7a3c1740ecd74220b6c627.docx"",
			                    ""demooperator"": ""wo137MCgAAYW6pIiKKrDe5SlzEhSgwbA"",
			                    ""starttime"": 1594197599,
			                    ""endtime"": 1594197609
		                    }],
		                    ""sharescreendata"": [{
			                    ""share"": ""wo137MCgAAYW6pIiKKrDe5SlzEhSgwbA"",
			                    ""starttime"": 1594197624,
			                    ""endtime"": 1594197624
		                    }]
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("meeting_voice_call", model.MessageType);
                    Assert.Equal("grb8a4c48a3c094a70982c518d55e40557", model.VoiceId);
                    Assert.Equal(1594197635, model.MessageContentAsMeetingVoiceCall!.EndTimestamp);
                    Assert.Equal("FILEID", model.MessageContentAsMeetingVoiceCall!.FileId);
                    Assert.Equal("65eb1cdd3e7a3c1740ecd74220b6c627.docx", model.MessageContentAsMeetingVoiceCall!.ShareFileDataList![0]!.FileName);
                    Assert.Equal("wo137MCgAAYW6pIiKKrDe5SlzEhSgwbA", model.MessageContentAsMeetingVoiceCall!.ShareFileDataList![0]!.OperatorUserId);
                    Assert.Equal(1594197599, model.MessageContentAsMeetingVoiceCall!.ShareFileDataList![0]!.StartTimestamp);
                    Assert.Equal(1594197609, model.MessageContentAsMeetingVoiceCall!.ShareFileDataList![0]!.EndTimestamp);
                    Assert.Equal("wo137MCgAAYW6pIiKKrDe5SlzEhSgwbA", model.MessageContentAsMeetingVoiceCall!.ShareScreenDataList![0]!.SharerUserId);
                    Assert.Equal(1594197624, model.MessageContentAsMeetingVoiceCall!.ShareScreenDataList![0]!.StartTimestamp);
                    Assert.Equal(1594197624, model.MessageContentAsMeetingVoiceCall!.ShareScreenDataList![0]!.EndTimestamp);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 音频共享文档消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""16527954622422422847_1594199256"",
	                    ""action"": ""send"",
	                    ""from"": ""18002520162"",
	                    ""tolist"": [""wo137MCgAAYW6pIiKKrDe5SlzEhSgwbA""],
	                    ""msgtime"": 1594199235014,
	                    ""msgtype"": ""voip_doc_share"",
	                    ""voipid"": ""gr2751c98b19300571f8afb3b74514bd32"",
	                    ""voip_doc_share"": {
		                    ""filename"": ""欢迎使用微盘.pdf"",
		                    ""md5sum"": ""ff893900f24e55e216e617a40e5c4648"",
		                    ""filesize"": 4400654,
		                    ""sdkfileid"": ""FILEID""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("voip_doc_share", model.MessageType);
                    Assert.Equal("gr2751c98b19300571f8afb3b74514bd32", model.VoIPId);
                    Assert.Equal("欢迎使用微盘.pdf", model.MessageContentAsVoIPDocumentShare!.FileName);
                    Assert.Equal("FILEID", model.MessageContentAsVoIPDocumentShare!.FileId);
                    Assert.Equal("ff893900f24e55e216e617a40e5c4648", model.MessageContentAsVoIPDocumentShare!.FileMD5);
                    Assert.Equal(4400654, model.MessageContentAsVoIPDocumentShare!.FileSize);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 互通红包消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""8632214264349267353_1603786184"",
	                    ""action"": ""send"",
	                    ""from"": ""woJ7ijBwAAmqwojT8r_DaNMbr_NAvaag"",
	                    ""tolist"": [""woJ7ijBwAA6SjS_sIyPLZtyEPJlT7Cfw"", ""tiny-six768""],
	                    ""roomid"": ""wrJ7ijBwAAG1vly_DzVI72Ghc-PtA5Dw"",
	                    ""msgtime"": 1603786183955,
	                    ""msgtype"": ""external_redpacket"",
	                    ""redpacket"": {
		                    ""type"": 1,
		                    ""wish"": ""恭喜发财，大吉大利"",
		                    ""totalcnt"": 2,
		                    ""totalamount"": 20
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("external_redpacket", model.MessageType);
                    Assert.Equal(1, model.MessageContentAsRedPacket!.Type);
                    Assert.Equal("恭喜发财，大吉大利", model.MessageContentAsRedPacket!.Wishing);
                    Assert.Equal(2, model.MessageContentAsRedPacket!.TotalCount);
                    Assert.Equal(20, model.MessageContentAsRedPacket!.TotalAmount);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 视频号消息
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""5702551662099334532_1619511584_external"",
	                    ""action"": ""send"",
	                    ""from"": ""yangzhu1"",
	                    ""tolist"": [""wmJSb5CgAA4aWXWndJspQGpJMDbsMwMA""],
	                    ""roomid"": """",
	                    ""msgtime"": 1619511584444,
	                    ""msgtype"": ""sphfeed"",
	                    ""sphfeed"": {
		                    ""feed_type"": 4,
		                    ""sph_name"": ""云游天地旅行家"",
		                    ""feed_desc"": ""瑞士丨盖尔默缆车，名副其实的过山车~\n\n#旅行#风景#热门""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("sphfeed", model.MessageType);
                    Assert.Equal(4, model.MessageContentAsChannelsFeed!.FeedType);
                    Assert.Equal("云游天地旅行家", model.MessageContentAsChannelsFeed!.ChannelsNickName);
                    Assert.Equal("瑞士丨盖尔默缆车，名副其实的过山车~\n\n#旅行#风景#热门", model.MessageContentAsChannelsFeed!.Description);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 音视频通话
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""10950316726562067988_1666601563058"",
	                    ""action"": ""send"",
	                    ""from"": ""icef"",
	                    ""tolist"": [""WoBeiQi...""],
	                    ""roomid"": """",
	                    ""msgtime"": 1666601558876,
	                    ""msgtype"": ""voiptext"",
	                    ""info"": {
		                    ""callduration"": 9,
		                    ""invitetype"": 2
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("voiptext", model.MessageType);
                    Assert.Equal(9, model.MessageContentAsInfo!.VoIPCallDuration);
                    Assert.Equal(2, model.MessageContentAsInfo!.VoIPInviteType);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion

            #region 用例：聊天记录 - 微盘文件
            {
                static void AssertModelWithJsonSerializer(ISerializer serializer)
                {
                    const string json = @"{
	                    ""msgid"": ""904076622482680588_1666602581569_external"",
	                    ""action"": ""send"",
	                    ""from"": ""WoBeiQi..."",
	                    ""tolist"": [""wmYKhyDwAAxda9Vrt7e6h0CgRhRVlGdQ""],
	                    ""roomid"": """",
	                    ""msgtime"": 1666602577356,
	                    ""msgtype"": ""qydiskfile"",
	                    ""info"": {
		                    ""filename"": "".sys.log""
	                    }
                    }";

                    var model = serializer.Deserialize<DecryptChatRecordResponse>(json);
                    Assert.Equal("qydiskfile", model.MessageType);
                    Assert.Equal(".sys.log", model.MessageContentAsInfo!.WedriveFileName);
                }

                AssertModelWithJsonSerializer(newtonsoftJsonSerializer);
                AssertModelWithJsonSerializer(systemTextJsonSerializer);
            }
            #endregion
        }
    }
}
