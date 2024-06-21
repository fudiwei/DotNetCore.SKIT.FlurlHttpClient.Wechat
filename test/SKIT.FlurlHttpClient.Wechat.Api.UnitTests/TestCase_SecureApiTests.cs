using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public partial class TestCase_SecureApiTests
    {
        [Fact(DisplayName = "测试用例：API 安全鉴权模式")]
        public async Task TestSecureApiRequestSignature()
        {
            var mockClient = WechatApiClientBuilder
                .Create(new WechatApiClientOptions()
                {
                    AppId = "wxba6223c06417af7b",
                    SecureApiEnabled = true,
                    SecureApiSymmetricNumber = "fa05fe1e5bcc79b81ad5ad4b58acf787",
                    SecureApiSymmetricEncodingKey = "otUpngOjU+nVQaWJIC3D/yMLV17RKaP6t4Ot9tbnzLY=",
                    SecureApiAsymmetricNumber = "97845f6ed842ea860df6fdf65941ff56",
                    SecureApiAsymmetricPrivateKey = "-----BEGIN RSA PRIVATE KEY-----\nMIIEowIBAAKCAQEA3FoQOmOl5/CF5hF7ta4EzCy2LaU3Eu2k9DBwQ73J82I53Sx9\nLAgM1DH3IsYohRRx/BESfbdDI2powvr6QYKVIC+4Yavwg7gzhZRxWWmT1HruEADC\nZAgkUCu+9Il/9FPuitPSoIpBd07NqdkkRe82NBOfrKTdhge/5zd457fl7J81Q5VT\nIxO8vvq7FSw7k6Jtv+eOjR6SZOWbbUO7f9r4UuUkXmvdGv21qiqtaO1EMw4tUCEL\nzY73M7NpCH3RorlommYX3P6q0VrkDHrCE0/QMhmHsF+46E+IRcJ3wtEj3p/mO1Vo\nCpEhawC1U728ZUTwWNEii8hPEhcNAZTKaQMaTQIDAQABAoIBAQCXv5p/a5KcyYKc\n75tfgekh5wTLKIVmDqzT0evuauyCJTouO+4z/ZNAKuzEUO0kwPDCo8s1MpkU8boV\n1Ru1M8WZNePnt65aN+ebbaAl8FRzNvltoeg9VXIUmBvYcjzhOVAE4V2jW7M8A9QU\nzUpyswuED6OeFKfOHtYk2In2IipAqhfbyc6gn7uZSWTQsoO6hGBRQ7Ejx+vgwrbx\nZKVZ7UXbPHD0lOEPraA3PH/QUeUKpNwK2NXQoBxWcR283/HxFSAjjSSsGSBKsCnw\nDN55P2FQ0HNi5YrwUNT9190NIXSeygaRy1b+D+yBfm+yE7/qXwHLZCHsjO+2tMSS\n3KGjllTBAoGBAP9FPeYNKZuu5jt9RpZwXCc9E7Iz7bmM7zws6dun6dQH0xVVWFVm\niGIu07eqyB8HNagXseFzoXLV5EQx+3DaB0bAH+ZEpHGJJpAWSLusigssFUFuTvTF\nw+rC5hxOfidMa6+93SU5pWeJb0zJF8PRDaJ3UmwlwpYubF17sT4PD6p9AoGBANz7\nRlhRSFvggJjhEMpek3OIYWrrlRNO2MVcP7i/fGNTHhrw7OHcNGRof54QZ2Y0baL7\n1vHNokbK2mnT+cQXY/gXMmcE/eV4xyRGYiIL9nBdrkLerc43EYPv+evDvgyji6+y\n4np5cKqHrS8F+YzATk82Jt9HgdI2MvfbJTkSbmgRAoGAHNPL9rPb1An/VA6Ery6H\nKaM7Gy/EE+U3ixsjWbvvqxMrIkieDh7jHftdy2sM6Hwe8hmi6+vr+pTvD0h5tbfZ\nhILj11Q/Idc0NKdflVoZyMM0r0vuvLOsuVFDPUUb+AIoUxNk6vREmpmpqQk4ltN/\n763779yfyef6MuBqFrEKut0CgYB9FfsuuOv1nfINF7EybDCZAETsiee7ozEPHnWv\ndSzK6FytMV1VSBmcEI7UgUKWVu0MifOUsiq+WcsihmvmNLtQzoioSeoSP7ix7ulT\njmP0HQMsNPI7PW67uVZFv2pPqy/Bx8dtPlqpHN3KNV6Z7q0lJ2j/kHGK9UUKidDb\nKnS2kQKBgHZ0cYzwh9YnmfXx9mimF57aQQ8aFc9yaeD5/3G2+a/FZcHtYzUdHQ7P\nPS35blD17/NnhunHhuqakbgarH/LIFMHITCVuGQT4xS34kFVjFVhiT3cHfWyBbJ6\nGbQuzzFxz/UKDDKf3/ON41k8UP20Gdvmv/+c6qQjKPayME81elus\n-----END RSA PRIVATE KEY-----"
                })
                .UseHttpClient(new MockHttpClient())
                .Build();

            var request = new Models.WxaGetUserRiskRankRequest()
            {
                OpenId = "oEWzBfmdLqhFS2mTXCo2E4Y9gJAM",
                Scene = 0,
                ClientIp = "127.0.0.1",
                AccessToken = "ACCESS_TOKEN"
            };
            var response = await mockClient.ExecuteWxaGetUserRiskRankAsync(request);

            Assert.True(Boolean.TrueString == response.GetRawHeaders().GetFirstValueOrEmpty(MOCK_RESP_HEADER_RESULT));
            Assert.Equal(0, response.ErrorCode);
            Assert.Equal("getuserriskrank succ", response.ErrorMessage);
            Assert.Equal(0, response.RiskRank);
            Assert.Equal("2258658297", response.RequestId);
        }
    }

    partial class TestCase_SecureApiTests
    {
        private const string MOCK_RESP_HEADER_RESULT = "x-result";

        public class MockHttpClient : HttpClient
        {
            public MockHttpClient()
                : base(new MockHttpMessageHandler(new HttpClientHandler()))
            {
            }
        }

        public class MockHttpMessageHandler : DelegatingHandler
        {
            public MockHttpMessageHandler(HttpMessageHandler innerHandler)
                : base(innerHandler)
            {
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var resp = new HttpResponseMessage();
                resp.RequestMessage = request;

                if (request.Method == HttpMethod.Post && request.RequestUri?.AbsolutePath == "/wxa/getuserriskrank")
                {
                    resp.StatusCode = HttpStatusCode.OK;
                    resp.Content = new StringContent("{\"iv\":\"r2WDQt56rEAmMuoR\",\"data\":\"HExs66Ik3el+iM4IpeQ7SMEN934FRLFYOd3EmeaIrpP4EPTHckoco6O+PaoRZRa3lqaPRZT7r52f7LUok6gLxc6cdR8C4vpIIfh4xfLC4L7FNy9GbuMK1hcoi8b7gkWJcwZMkuCFNEDmqn3T49oWzAQOrY4LZnnnykv6oUJotdAsnKvmoJkLK7hRh7M2B1d2UnTnRuoIyarXc5Iojwoghx4BOvnV\",\"authtag\":\"z2BFD8QctKXTuBlhICGOjQ==\"}", null, "application/json");
                    resp.Headers.Add("Wechatmp-Appid", "wxba6223c06417af7b");
                    resp.Headers.Add("Wechatmp-TimeStamp", "1635927956");
                    resp.Headers.Add("Wechatmp-Serial", "79ba700ea147819f640941bceb38b1d1");
                    resp.Headers.Add("Wechatmp-Signature", "Ht0VfQkkEweJ4hU266C14Aj64H9AXfkwNi5zxUZETCvR2svU1ZYdosDhFX/voLj1TyszqKsVxAlENGt7PPZZ8RQX7jnA4SKhiPUhW4LTbyTenisHJ+ohSfDjYnXavjQsBHspFS+BlPHuSSJ2xyQzw1+HuC6nid09ZL4FnGSYo4OI5MJrSb9xLzIVZMIDuUQchGKi/KaB1KzxECLEZcfjqbAgmxC7qOmuBLyO1WkHYDM95NJrHJWba5xv4wrwPru9yYTJSNRnlM+zrW5w9pOubC4Jtj3szTAEuOz9AcqUmgaAvMLNAIa8hfODLRe3n/cu4SgYlN/ZkNRU4QXVNbPGMg==");

                    var reqData = await request.Content!.ReadAsStringAsync();
                    var reqJson = JsonObject.Parse(reqData)?.AsObject();
                    bool isReqValid = reqJson is not null
                        && reqJson.ContainsKey("iv")
                        && reqJson.ContainsKey("data")
                        && reqJson.ContainsKey("authtag")
                        && request.Headers.Contains("Wechatmp-Appid")
                        && request.Headers.Contains("Wechatmp-TimeStamp")
                        && request.Headers.Contains("Wechatmp-Signature");
                    resp.Headers.Add(MOCK_RESP_HEADER_RESULT, isReqValid ? Boolean.TrueString : Boolean.FalseString);
                }
                else
                {
                    resp.StatusCode = HttpStatusCode.ServiceUnavailable;
                    resp.Content = new ByteArrayContent(Array.Empty<byte>());
                }

                return resp;
            }
        }

    }
}
