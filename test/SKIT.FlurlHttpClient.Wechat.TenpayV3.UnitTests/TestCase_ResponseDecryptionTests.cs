using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_ResponseDecryptionTests
    {
        private const string RSA_PRIVATE_KEY = "-----BEGIN PRIVATE KEY-----MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCd094X2jr6wrL1pIBTSbKX5hVqxyCJhKLqaf31KQsw2LdzfXEOL45KiYr6IshwZaSPFok7Sq+1wLrO6/DZ7/GSmzVwdFIV/zjDbI3jaSHt69ZAJGBS212AzC4cwHvpGrHm3kqzVifJyUNxsoTvWklRGSE50pPWaXoxmdPgD5da8IPDHNzkPM0QYTOlHmIRsDQZpWiZRPaFdrN3i/qG9toCRCPVptCVNYrWLDEFXh3ioOqOdTk1fHxFczaNf4YvQhsqXlG/lGiqGbuPuFYfF/RvS9KfptAM1yycknTslkSeiOpA22sFbDdb+m7DHv+nc8DQPPmD7SxDwVIDTcIS7pEJAgMBAAECggEAM6E+czEZwDR3FLKGpDhkqxpCgVa4xyPTo7mesVeG6KjMgoRTup9F/g42n5NHXLVzereVlwbcqiltMwmuFa1PqnUJq0ryG24NZKibVfxrdAiFYyBDPneyg9LHdvJk1qG79tlbOIWDqJglbwlGQYKYn2YIH4FKiYahyZ4X2KFhEwc9mWydHSOyN8zOOJcRCy1FzUcUvITRKob+Q9epz9/4/VX0g1AnB6FwIR5pBqwMYLSv+g+JxfVKPRnSaIxq/2HOvhiyJ7fUqX1yGI+konJJHrn66JIux8xt4SxEnomZBveHlOMUTgTqovxpXisbvXQGBDV7dwW/qhGZet6h57qogQKBgQDNFLP9S6aPnwseeavxK0ygQpgJRbXbHCyqH/mVA/Pg9DaIhxl7+JCC1lS/JuZslow4t3JvjwixAzQEz9SkwUuiRO5vUWb5R+DZJ8HeqtMfoll6wxepu1TQT1pTPnSHliJQP15k5AQ1bkTZjcGA79iUmkksa4EP/GWtOooE8JhMEQKBgQDFA6oyBtbMyWlnGmdsieQuRsjCklZhPL93INX5VUfcfRqQdhqrmoaJg+OZTwVrARp6VHGEaURBTSj6bSoRbBckFNxjVsL6Utpgof+ZWmr5u8ZGHGHIPJMLt7GxI9SItpNNNY33OiUkkfSH4zHK5KZeG9sKKraQwITJCwLZUnnNeQKBgChHkLKHUUeULVLnAuZzYrF3YvUvQ/CtL/iaHyMti5D7Zlqabl7zCy8nea2xrkBVsWTSYx+WMFbUEjt/tnxFmt1cPJiQnHEJtRfxvxpE4wKrmHeMKfGkYZwoec0vzyNyUXsBd0DJqCn2Zn90YDU65ocJZqXa15aUNEQ54zHlL4SBAoGAHbve3OwBUSj4unHWuB/bi0xtkkgJt2U2tGEFSjsfvFw5PSJGBi4tLeX03Ld7ZtnkyB+kfkpw3bYqgBknpzd8CpsHZAq9JJCKmtj4PYnS6Vv4oa4458KUoskXjVeOBRAhDR8PDQf+gRVyJWwZoLh/j2Z+2Xr20MPthnYd+PSko2kCgYBra4rMhYx2Hg0rRe2O7ju+MPm+JK01VpbvwDTnEPnYgMImDmLAXF6GljCt3iy/8X1WcjMPxGjTJ/xfTMne/aqKwvPhZCBL4DdNLNRzppCovsaaMHzrQzy4cvg0IEhIprFeR7ED4eMs8zLUhl3vgNhHOkeQ7cyuEnTl5wB9xOkbSw==-----END PRIVATE KEY-----";
        private const string RSA_PUBLIC_KEY = "-----BEGIN PUBLIC KEY-----MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAndPeF9o6+sKy9aSAU0myl+YVascgiYSi6mn99SkLMNi3c31xDi+OSomK+iLIcGWkjxaJO0qvtcC6zuvw2e/xkps1cHRSFf84w2yN42kh7evWQCRgUttdgMwuHMB76Rqx5t5Ks1YnyclDcbKE71pJURkhOdKT1ml6MZnT4A+XWvCDwxzc5DzNEGEzpR5iEbA0GaVomUT2hXazd4v6hvbaAkQj1abQlTWK1iwxBV4d4qDqjnU5NXx8RXM2jX+GL0IbKl5Rv5Roqhm7j7hWHxf0b0vSn6bQDNcsnJJ07JZEnojqQNtrBWw3W/puwx7/p3PA0Dz5g+0sQ8FSA03CEu6RCQIDAQAB-----END PUBLIC KEY-----";
        private const string MockText = "mock_text";
        private readonly Lazy<WechatTenpayClient> MockClientInstance = new Lazy<WechatTenpayClient>(() =>
        {
            return new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantCertPrivateKey = RSA_PRIVATE_KEY
            });
        }, isThreadSafe: false);

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /certificates）")]
        public async Task TestDecryptResponseSensitiveProperty_QueryCertificatesResponse()
        {
            var client1 = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertSerialNumber = TestConfigs.WechatMerchantCertSerialNumber,
                MerchantCertPrivateKey = TestConfigs.WechatMerchantCertPrivateKey,
                AutoEncryptRequestSensitiveProperty = true,
                AutoDecryptResponseSensitiveProperty = true
            });
            var request1 = new Models.QueryCertificatesRequest();
            var response1 = await client1.ExecuteQueryCertificatesAsync(request1);
            Assert.DoesNotContain(response1.CertificateList, (e => !e.EncryptCertificate.CipherText.StartsWith("-----BEGIN CERTIFICATE-----")));

            var client2 = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertSerialNumber = TestConfigs.WechatMerchantCertSerialNumber,
                MerchantCertPrivateKey = TestConfigs.WechatMerchantCertPrivateKey,
                AutoEncryptRequestSensitiveProperty = false,
                AutoDecryptResponseSensitiveProperty = false
            });
            var request2 = new Models.QueryCertificatesRequest();
            var response2 = await client2.ExecuteQueryCertificatesAsync(request2);
            Assert.DoesNotContain(response2.CertificateList, (e => e.EncryptCertificate.CipherText.StartsWith("-----BEGIN CERTIFICATE-----")));
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /ecommerce/applyments/out-request-no/{out_request_no}）")]
        public void TestDecryptResponseSensitiveProperty_GetEcommerceApplymentByOutRequestNumberResponseTest()
        {
            var mock = new Models.GetEcommerceApplymentByOutRequestNumberResponse()
            {
                RawStatus = 200,
                RawHeaders = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>() { { "K", "V" } }),
                ApplymentState = MockText,
                AccountValidation = new Models.GetEcommerceApplymentByOutRequestNumberResponse.Types.AccountValidation()
                {
                    AccountName = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText),
                    AccountNumber = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText),
                    DestinationAccountName = MockText,
                    DestinationAccountNumber = MockText
                }
            };
            var data = MockClientInstance.Value.DecryptResponseSensitiveProperty(mock);

            Assert.Equal(MockText, data.ApplymentState);
            Assert.Equal(MockText, data.AccountValidation!.AccountNumber);
            Assert.Equal(MockText, data.AccountValidation!.DestinationAccountName);
            Assert.Equal(MockText, data.AccountValidation!.DestinationAccountNumber);
            Assert.Equal(MockText, data.AccountValidation!.AccountName);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /ecommerce/bill/fundflowbill）")]
        public void TestDecryptResponseSensitiveProperty_GetEcommerceBillFundflowBillResponse()
        {
            var mock = new Models.GetEcommerceBillFundflowBillResponse()
            {
                RawStatus = 200,
                DownloadBillCount = 1,
                DownloadBillList = new Models.GetEcommerceBillFundflowBillResponse.Types.DownloadBill[]
                { 
                    new Models.GetEcommerceBillFundflowBillResponse.Types.DownloadBill()
                    { 
                        DownloadUrl = MockText,
                        EncryptKey = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText)
                    },
                    new Models.GetEcommerceBillFundflowBillResponse.Types.DownloadBill()
                    {
                        DownloadUrl = MockText,
                        EncryptKey = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText)
                    }
                }
            };
            var data = MockClientInstance.Value.DecryptResponseSensitiveProperty(mock);

            Assert.Equal(1, data.DownloadBillCount);
            Assert.Equal(MockText, data.DownloadBillList[0].DownloadUrl);
            Assert.Equal(MockText, data.DownloadBillList[0].EncryptKey);
            Assert.Equal(MockText, data.DownloadBillList[1].DownloadUrl);
            Assert.Equal(MockText, data.DownloadBillList[1].EncryptKey);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /merchant-service/complaints-v2/{complaint_id}）")]
        public void TestDecryptResponseSensitiveProperty_GetMerchantServiceComplaintByComplaintIdResponse()
        {
            var mock = new Models.GetMerchantServiceComplaintByComplaintIdResponse()
            {
                RawStatus = 200,
                ComplaintOrderList = new Models.GetMerchantServiceComplaintByComplaintIdResponse.Types.ComplaintOrder[]
                {
                    new Models.GetMerchantServiceComplaintByComplaintIdResponse.Types.ComplaintOrder()
                    {
                        TransactionId = MockText
                    }
                },
                ComplaintDetail = MockText,
                PayerPhone = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText)
            };
            var data = MockClientInstance.Value.DecryptResponseSensitiveProperty(mock);

            Assert.Equal(MockText, data.ComplaintDetail);
            Assert.Equal(MockText, data.PayerPhone);
            Assert.Equal(MockText, data.ComplaintOrderList[0].TransactionId);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /merchant-service/complaints-v2）")]
        public void TestDecryptResponseSensitiveProperty_QueryMerchantServiceComplaintsResponse()
        {
            var mock = new Models.QueryMerchantServiceComplaintsResponse()
            {
                RawStatus = 200,
                ComplaintList = new Models.QueryMerchantServiceComplaintsResponse.Types.Complaint[]
                {
                    new Models.QueryMerchantServiceComplaintsResponse.Types.Complaint()
                    {
                        PayerPhone = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText),
                        PayerOpenId = MockText
                    }
                }
            };
            var data = MockClientInstance.Value.DecryptResponseSensitiveProperty(mock);

            Assert.Equal(MockText, data.ComplaintList[0].PayerPhone);
            Assert.Equal(MockText, data.ComplaintList[0].PayerOpenId);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /smartguide/guides）")]
        public void TestDecryptResponseSensitiveProperty_QuerySmartGuidesResponse()
        {
            var mock = new Models.QuerySmartGuidesResponse()
            {
                RawStatus = 200,
                GuideList = new Models.QuerySmartGuidesResponse.Types.Guide[]
                {
                    new Models.QuerySmartGuidesResponse.Types.Guide()
                    {
                        GuideId = MockText,
                        UserName = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText),
                        UserMobile = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText)
                    }
                }
            };
            var data = MockClientInstance.Value.DecryptResponseSensitiveProperty(mock);

            Assert.Equal(MockText, data.GuideList[0].GuideId);
            Assert.Equal(MockText, data.GuideList[0].UserName);
            Assert.Equal(MockText, data.GuideList[0].UserMobile);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no}）")]
        public void TestDecryptResponseSensitiveProperty_GetTransferBatchDetailByOutDetailNumberResponse()
        {
            var mock = new Models.GetTransferBatchDetailByOutDetailNumberResponse()
            {
                RawStatus = 200,
                UserName = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText),
                OpenId = MockText
            };
            var data = MockClientInstance.Value.DecryptResponseSensitiveProperty(mock);

            Assert.Equal(MockText, data.UserName);
            Assert.Equal(MockText, data.OpenId);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id}）")]
        public void DecryptResponseSensitiveProperty_GetTransferBatchDetailByDetailIdResponse()
        {
            var mock = new Models.GetTransferBatchDetailByDetailIdResponse()
            {
                RawStatus = 200,
                UserName = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText),
                OpenId = MockText
            };
            var data = MockClientInstance.Value.DecryptResponseSensitiveProperty(mock);

            Assert.Equal(MockText, data.UserName);
            Assert.Equal(MockText, data.OpenId);
        }

        [Fact(DisplayName = "测试用例：解密响应中的敏感数据（[GET] /partner-transfer/batches/batch-id/{batch_id}/details/detail-id/{detail_id}）")]
        public void TestDecryptResponseSensitiveProperty_GetPartnerTransferBatchDetailByDetailIdResponse()
        {
            var mock = new Models.GetPartnerTransferBatchDetailByDetailIdResponse()
            {
                RawStatus = 200,
                UserName = Utilities.RSAUtility.EncryptWithECB(RSA_PUBLIC_KEY, MockText),
                OpenId = MockText
            };
            var data = MockClientInstance.Value.DecryptResponseSensitiveProperty(mock);

            Assert.Equal(MockText, data.UserName);
            Assert.Equal(MockText, data.OpenId);
        }
    }
}
