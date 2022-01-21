using System;
using System.Collections.Generic;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_RequestEncryptionTests
    {
        private const string RSA_CERTSN = "mock_sn";
        private const string RSA_CERTIFICATE = "-----BEGIN CERTIFICATE-----MIID9jCCAt6gAwIBAgIUFGJAVFxIU/1hoxpZC8Tc2xKFJHowDQYJKoZIhvcNAQELBQAwXjELMAkGA1UEBhMCQ04xEzARBgNVBAoTClRlbnBheS5jb20xHTAbBgNVBAsTFFRlbnBheS5jb20gQ0EgQ2VudGVyMRswGQYDVQQDExJUZW5wYXkuY29tIFJvb3QgQ0EwHhcNMjAwODAxMDczNTE5WhcNMjUwNzMxMDczNTE5WjCBhzETMBEGA1UEAwwKMTYwMTEwMzMxNDEbMBkGA1UECgwS5b6u5L+h5ZWG5oi357O757ufMTMwMQYDVQQLDCroo5XkurrvvIjkuIrmtbfvvInmlZnogrLnp5HmioDmnInpmZDlhazlj7gxCzAJBgNVBAYMAkNOMREwDwYDVQQHDAhTaGVuWmhlbjCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAKq4IUw5Rq6iTUahjkr+aYvmn3Hg2tHNDyIru7ZdthXw27BCwnwwDyufq6SBwXypuf3wXKpcFggZo5dwjDR6XxlGXzNDKdW7JQkTxQXqABZZVCq4yMMkVns3xbmDfAI57bW0O0F40+NOqmU9gjqRwGNvE9bE8N3y2VyxYcz53rU4FCrlCOfsFeF1Z3usbWOK5IOYXjmdzr96xVWasO0URJ60GwDZyGxRdkzd5kJy6HnVVqOUbn3t7mKbGkzQq/j+D+pyMlhjtRV475ks5uex4gVWZgEqT1b9sx1pUQvVPr6/ZXtqTJwSg/YvSCx5RBiYCskAyA/5XH9t1p/WV1zFhXUCAwEAAaOBgTB/MAkGA1UdEwQCMAAwCwYDVR0PBAQDAgTwMGUGA1UdHwReMFwwWqBYoFaGVGh0dHA6Ly9ldmNhLml0cnVzLmNvbS5jbi9wdWJsaWMvaXRydXNjcmw/Q0E9MUJENDIyMEU1MERCQzA0QjA2QUQzOTc1NDk4NDZDMDFDM0U4RUJEMjANBgkqhkiG9w0BAQsFAAOCAQEAU44msdPGFg/r5JcWgUDEXWOqqCDiFNjWbhM/rO0A3TCV0yP5o7Se/yLsDizHGTUzZ2qg3bC02nn4RysEyMVQ+9tXsOtXQBHrmoZ5vS8ndqbE1YO33N6zxIUb0IN3yGZh3oVmQgTYYe1is4i5Sfiy7JdR6/uUrwQN13fzPaDCnNx6iVzrPSJJf1xiFdtpFFtK021prjMYG7csHiFQeelgyE8XtlQuLk0tsHBrJ2FHSdV4HISqONz0hMPL0xsZkBD/L/bvR3L0lqe8bsHOBCJOMyjxucI21mBRd7tc4AGiJlQt5jrUrbos5hul4/QUq7hFfZNDrEBMINbMyIpYWRbIqQ==-----END CERTIFICATE-----";
        private const string RSA_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----MIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCquCFMOUauok1GoY5K/mmL5p9x4NrRzQ8iK7u2XbYV8NuwQsJ8MA8rn6ukgcF8qbn98FyqXBYIGaOXcIw0el8ZRl8zQynVuyUJE8UF6gAWWVQquMjDJFZ7N8W5g3wCOe21tDtBeNPjTqplPYI6kcBjbxPWxPDd8tlcsWHM+d61OBQq5Qjn7BXhdWd7rG1jiuSDmF45nc6/esVVmrDtFESetBsA2chsUXZM3eZCcuh51VajlG597e5imxpM0Kv4/g/qcjJYY7UVeO+ZLObnseIFVmYBKk9W/bMdaVEL1T6+v2V7akycEoP2L0gseUQYmArJAMgP+Vx/bdaf1ldcxYV1AgMBAAECggEBAIwkgTkYX5ymIXeU0cFgXfZ5iHQsWJUXl4++hOaswPf78+wasZrOvPVbqsRtvA8BKWx7byZuV6uomHGN85p0xjJyYV4siWAps7pi3z7+m7m89OnpLO18m/2kiAzFEfyl3yxlWqtha9dSUXCwcIJx+ZPmsEuC+hPI8oQ0HQvuJtNtcDmaFBp57kxjlO4Xm0xnvq2waSmAF4cO6Dk62gksu8G7//IyIHXqmRWSpI2b/Yqf84XtwLN8Zvq/3otYuWc3pFOaKHg2sJ/JwSU+yGdeIOtEXXFIDSD6p3KvIvjrD47Da4optYReXP1k6e721z+XPBFP31i58iu1K8KOyjjJfsECgYEA41D6V1TrON31OOsM4jAtqyY/LVNdzT+I/S6lQruO9siRRJDYlAOdbM9VZnW/3rduPMBu4undbMkL5i8olnwmLeWSupClA2WmUc8DWHlBO2s0lE+ZDZgOtpZ9qOBfm7L6jbjvzbGoyJgV6SeIavH5SMQbFku5rlIi12hAb0Kv4uUCgYEAwELkPOKDH06SFOiuOzJcI4VyjK0V5LcWjceTPkaT9d1evkrNgrHiG8CjYQ3V0lqSKhckFg2PwmPk72rC4n3aFCXurimv96rG5sBFFLgPbyoKZ3Z9JoDoe/6u6YIAV/GzxJ5QJaWQQ59MxToILYyq6aA6SrNOqRUPsKuvN8jBH1ECgYEA3dJ6yNgcRj0KfIWa5+qd1iMXiZKNuamjc3WeXTWL+DSW1bMHNcElUTYuHzMOjjavw2cBjjsrEWpLS09/qwHxe95IRfi6nksGd1Ss7hw9VM9z2rqmH4bf7LuEWlTB171bFQuAL1iL3VvUHdavH7WLTr/XsvUod/y89TlNj4UjACUCgYBBR3UPZyl2O8tF5isiVlsKhIj8UtiYK8IwqY7JGlWqqVs96VAWDCflnGbc0UHEhpQSToEmK7ygGCLnV6yMEoc1SBvebrEcupOGTcom2sgCypd1wbmElUhasYLaLhXHxn1vSQGVhr2Q+EmsvaOBM73kTU79hhwzNL97ERARNMy9wQKBgHCogsDPxSh8hEJR/PBom6v/3R+Ou86K8nzulbyHGkDM7I2R//zGx4en1VxWFhsqywsGedugv1BMkgEcCFkTjIXfYh9Uwn5iGUAZCczR5ZoETYAAzK2a/uaWf92iZEU0bHJaBA4egNxk1bFe+ECFTteN8Ag+UVtx0HU6ZNlyfetH-----END PRIVATE KEY-----";
        private const string MockText = "mock_text";
        private readonly Lazy<WechatTenpayClient> MockClientInstance = new Lazy<WechatTenpayClient>(() =>
        {
            var certManager = new Settings.InMemoryCertificateManager();
            certManager.AddEntry(new Settings.CertificateEntry(
                serialNumber: RSA_CERTSN,
                certificate: RSA_CERTIFICATE,
                effectiveTime: DateTimeOffset.MinValue,
                expireTime: DateTimeOffset.MaxValue
            ));
            return new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                CertificateManager = certManager
            });
        }, isThreadSafe: false);

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /profitsharing/receivers/add）")]
        public void TestEncryptResponseSensitiveProperty_AddProfitSharingReceiverRequest()
        {
            var mock = new Models.AddProfitSharingReceiverRequest()
            {
                Account = MockText,
                Name = MockText
            };
            var data = MockClientInstance.Value.EncryptRequestSensitiveProperty(mock);

            Assert.Equal(RSA_CERTSN, data.WechatpayCertSerialNumber);
            Assert.Equal(MockText, data.Account);
            Assert.Equal(MockText, Utilities.RSAUtility.DecryptWithECB(RSA_PRIVATE_KEY, data.Name!));
        }

        [Fact(DisplayName = "测试用例：加密请求中的敏感数据（[POST] /profitsharing/orders）")]
        public void TestEncryptResponseSensitiveProperty_CreateProfitSharingOrderRequest()
        {
            var mock = new Models.CreateProfitSharingOrderRequest()
            {
                ReceiverList = new List<Models.CreateProfitSharingOrderRequest.Types.Receiver>()
                {
                    new Models.CreateProfitSharingOrderRequest.Types.Receiver()
                    {
                        Account = MockText,
                        Name = MockText
                    }
                }
            };
            var data = MockClientInstance.Value.EncryptRequestSensitiveProperty(mock);

            Assert.Equal(RSA_CERTSN, data.WechatpayCertSerialNumber);
            Assert.Equal(MockText, data.ReceiverList[0].Account);
            Assert.Equal(MockText, Utilities.RSAUtility.DecryptWithECB(RSA_PRIVATE_KEY, data.ReceiverList[0].Name!));
        }
    }
}
