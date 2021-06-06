using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class WechatTenpaySecurityTests
    {
        [Fact(DisplayName = "证书和回调报文解密（AES-GCM）")]
        public void AesGcmDecryptTest()
        {
            string key = "f09b03a7a1902b5b4913856f1fd07ab1";
            string iv = "aae8c2e79c5b";
            string aad = "certificate";
            string cipherText = "x9kkL5w1JuaypcjhrYIP+kVNlN8o8uN4yJyJjy5lg+PyPnQL2Zn//ORaXAyzdaK/WBMVd3u/Y9hLaTBLMyRXzowsrkJ5PT37johye48N7BAJQ0PJwW++d1RdhOOPjoqfmws6rSV5Gv2qhfdKjmpxVjr8xr71dtBt8J2wu+bAV99HHQoAynm/Pp9OQYZgpOQ+1cyFHd43TAxOoFfmixKrXr3HP8lJot0XCUSq4qkr1Hs44FV2KuzntSk8eqKr5N17UcuPF3VYnnnF/AvQ7HuLKWwrHhUbaXfkwy0Q2n36UJMfBj7344S97E8BnS89ojgOPQi+olBPyNgrtDWHgsJAKu7HA6PV/FgmXcrZirje/AH1u25es4z5xItHscm//6rDvALgf7greV5OJzMsSl/KVDtbkjDSzim0j4ZTduIfzh7l6jfOz115ITcNILT9ef2KkcMyBBc89GZlMGeHTbgsBHzGeLawX3dXFjqt5aMnHM3VWCovA2aUM4c//rqkZGf+Va86OEFoJQLiSTFpkOrKxcIxcrbKPLTgiDWRT3wzmnUDg7kSPbluzt3ROvMFq9lB8bO/pBd7TD2w87sfUdKLj69FniX6s37SBeRVhw8GSIvBf5lpLUhqL5zKYlbuAWePuz0wVV4NTtkaVKZlmm8KTODyZDFpsyKPubDDcwT1ftRf5aSVM4x04I/1B7GkNz/TOy+zpJ0h0B7VHdxyO5JYiI/1qsatX/FE2aJdQYMYOtqfDH7ZH5UUKIqo538OKvE2M4MlBR/aVE4z4QDKfE/1kYrOfvVGfDzF/FWHfUrcqB8kdQMvk8vCoM8yYZsX4KE1aoJbNM2pWv2tpr9JE8b/VQgUyHOgPYAha+UOmZki4Sfl9H62687EIWdbM57ZxmwIiBp60SrJLiBfZon9JqXKdtJOKj0CRokQiBnONNXCVerLFeBNQfeKRw8tgJXf+QPohMGYkSDdc8hTgdbmhTwB1Vv01stlYK12QMNRCovlp/fcmpB72Phlq+/3p5pqMzknw+qm5QAz7JnpZJCFHit52gHwAkKRkVPB3HF2rfLrdTYz5c9Bok1ICAY9My47eLFdduIe99V52cjMLQuUmNFBPrDdyZKVqIHJ/wtWO/wIFpAVGSJMHctyEKmeJVc1IQN74Wm00PrpPackHdO3G41bBmkp5pqUdsSgSkwdfNVqv0cMcSe04NrRGNKMcZ7TA/CMaP1YnhxvVE+z8aksJqSJ+gdplvuwl40y5C8UEHeAi1V8Q0Bf4YvYRgOVIWm2Lzjdn2z9PWLGcStUj11/1hthk2li4V3mgm2Cr2IZme2sn4rZmJ6dexGP1nk+ZYOq0xLE8F7oex9gyDN+A/6zHqnuhO/X08qye0gochMr8U89Qvj2c0L3P2mjCea2H1mEriAJPqMPMKIinh1lQJEZufnfCcPxbZLKTtl6zHtHgOztejd1gV/nUyCVKD4MCMfBDy9C/Af8pWx6akOg/QSQNIGA2AI6zprHn9zEjpFIzXJYvruVI22Yt6oF9Xnt7Ki82wRK2M96r4kj6cwSs4exMPGv8fWMrFTm0Br6p6T+HZsxyyn2ChuPIgpfisnce/ZaU/0xCZhK/K79+TK2GeeChq5oEpua/1tx4+kDHi7H9381pLJmy2oXW060c2mmwA9+EpcuwEDhr8fsnghbv41u7b1NhEmWNVUy29Dwaz61PPGUdh5DsvaKLWC+raZ/6UEKPw+tiABJ5o6u2jAWgmEYmmJCKapNgtfPc6D+O0aHH9oqh6u4+8NRAhusPZzDGWBr6AT4pexgWFeEhZhn6bXM9HhpUe0IhOTw5D+tqXrTlNon4kjYibiMUFy1h2YyYS3IEdu1J4xqvo0rFyCxF1C+P6ubc0tClRPkXg==";

            string actualPlain = Utilities.AESUtility.DecryptWithGCM(key: key, iv: iv, aad: aad, cipherText: cipherText);
            string expectdPlain = "-----BEGIN CERTIFICATE-----\nMIID3DCCAsSgAwIBAgIUGZNrTcamx3sFSJsQli3v9C6gZe8wDQYJKoZIhvcNAQEL\nBQAwXjELMAkGA1UEBhMCQ04xEzARBgNVBAoTClRlbnBheS5jb20xHTAbBgNVBAsT\nFFRlbnBheS5jb20gQ0EgQ2VudGVyMRswGQYDVQQDExJUZW5wYXkuY29tIFJvb3Qg\nQ0EwHhcNMjAwODAxMDczNTE4WhcNMjUwNzMxMDczNTE4WjBuMRgwFgYDVQQDDA9U\nZW5wYXkuY29tIHNpZ24xEzARBgNVBAoMClRlbnBheS5jb20xHTAbBgNVBAsMFFRl\nbnBheS5jb20gQ0EgQ2VudGVyMQswCQYDVQQGDAJDTjERMA8GA1UEBwwIU2hlblpo\nZW4wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDOAYHqxCqaRzoTIvgV\nixaYJJvmvHbiczbx5MQ9XL1ITSFxkTsNsk7RKHnO7eBS5imheJgQwd22Ky+XclSe\n7B4odssu/l/+gHo2gooTYrrCpQrOkpvGMf8R8aI56BQIF+vsomDvVq1NojHV2Fql\njMwFXzhj2EmU6p6gDv9iL7q1NrfnxFx8iJe4OhIB5Ek4qn1xXxrTUhiULd2vXlbI\nXhRetZSNcJsLt5Rw7D7c8F+aX2JchfeqsZECwKW7bSjMbVWWC6M9MgkB/aId8P0y\n7qEiiXFJkfkg1I/E1ud2apopsid5tdCyRRR6+MhhX2EC8S04MN4soUT7haqNNxX2\nrKHnAgMBAAGjgYEwfzAJBgNVHRMEAjAAMAsGA1UdDwQEAwIE8DBlBgNVHR8EXjBc\nMFqgWKBWhlRodHRwOi8vZXZjYS5pdHJ1cy5jb20uY24vcHVibGljL2l0cnVzY3Js\nP0NBPTFCRDQyMjBFNTBEQkMwNEIwNkFEMzk3NTQ5ODQ2QzAxQzNFOEVCRDIwDQYJ\nKoZIhvcNAQELBQADggEBAJyg2z4oLQmPfftLQWyzbUc9ONhRMtfA+tVlVBgtLLKn\nWuDlsmEntheM07fu84F4pcfs3yHzjD7pAOFbO4Yt1yhQ50DK35sjbRWepPdWJZLl\nni7KBctcmm0o4zq37oB7vonmBEbFqYs9DaINYOjgI3J25iSBkPVC7dBbvFj2xB0L\ncIcXipq30tDdC/oUem27MNzwZAt49WthKhw6u3HSkcE5cO4LyYTsJhSyG/7LXwvV\nMgX4Jyzo0SSiGOU1/beaZssTVI8sTPJVlHWjhNE3Lc2SaAlKGfGwvt0X3cEZEF+7\noEZIFTkkAF2JhqfnpR3gST0G8Umq1SaVtCPP/zVI8x0=\n-----END CERTIFICATE-----";

            Assert.Equal(expectdPlain, actualPlain);
        }

        [Fact(DisplayName = "从 RSA 证书中提取公钥")]
        public void ExportRsaPublicKeyTest()
        {
            string cerText = "-----BEGIN CERTIFICATE-----\nMIID3DCCAsSgAwIBAgIUGZNrTcamx3sFSJsQli3v9C6gZe8wDQYJKoZIhvcNAQEL\nBQAwXjELMAkGA1UEBhMCQ04xEzARBgNVBAoTClRlbnBheS5jb20xHTAbBgNVBAsT\nFFRlbnBheS5jb20gQ0EgQ2VudGVyMRswGQYDVQQDExJUZW5wYXkuY29tIFJvb3Qg\nQ0EwHhcNMjAwODAxMDczNTE4WhcNMjUwNzMxMDczNTE4WjBuMRgwFgYDVQQDDA9U\nZW5wYXkuY29tIHNpZ24xEzARBgNVBAoMClRlbnBheS5jb20xHTAbBgNVBAsMFFRl\nbnBheS5jb20gQ0EgQ2VudGVyMQswCQYDVQQGDAJDTjERMA8GA1UEBwwIU2hlblpo\nZW4wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDOAYHqxCqaRzoTIvgV\nixaYJJvmvHbiczbx5MQ9XL1ITSFxkTsNsk7RKHnO7eBS5imheJgQwd22Ky+XclSe\n7B4odssu/l/+gHo2gooTYrrCpQrOkpvGMf8R8aI56BQIF+vsomDvVq1NojHV2Fql\njMwFXzhj2EmU6p6gDv9iL7q1NrfnxFx8iJe4OhIB5Ek4qn1xXxrTUhiULd2vXlbI\nXhRetZSNcJsLt5Rw7D7c8F+aX2JchfeqsZECwKW7bSjMbVWWC6M9MgkB/aId8P0y\n7qEiiXFJkfkg1I/E1ud2apopsid5tdCyRRR6+MhhX2EC8S04MN4soUT7haqNNxX2\nrKHnAgMBAAGjgYEwfzAJBgNVHRMEAjAAMAsGA1UdDwQEAwIE8DBlBgNVHR8EXjBc\nMFqgWKBWhlRodHRwOi8vZXZjYS5pdHJ1cy5jb20uY24vcHVibGljL2l0cnVzY3Js\nP0NBPTFCRDQyMjBFNTBEQkMwNEIwNkFEMzk3NTQ5ODQ2QzAxQzNFOEVCRDIwDQYJ\nKoZIhvcNAQELBQADggEBAJyg2z4oLQmPfftLQWyzbUc9ONhRMtfA+tVlVBgtLLKn\nWuDlsmEntheM07fu84F4pcfs3yHzjD7pAOFbO4Yt1yhQ50DK35sjbRWepPdWJZLl\nni7KBctcmm0o4zq37oB7vonmBEbFqYs9DaINYOjgI3J25iSBkPVC7dBbvFj2xB0L\ncIcXipq30tDdC/oUem27MNzwZAt49WthKhw6u3HSkcE5cO4LyYTsJhSyG/7LXwvV\nMgX4Jyzo0SSiGOU1/beaZssTVI8sTPJVlHWjhNE3Lc2SaAlKGfGwvt0X3cEZEF+7\noEZIFTkkAF2JhqfnpR3gST0G8Umq1SaVtCPP/zVI8x0=\n-----END CERTIFICATE-----";

            string actualPublicKey = Utilities.RSAUtility.ExportPublicKey(cerText).Replace("\r", "").Replace("\n", "");
            string expectedPublicKey = "-----BEGIN PUBLIC KEY-----MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAzgGB6sQqmkc6EyL4FYsWmCSb5rx24nM28eTEPVy9SE0hcZE7DbJO0Sh5zu3gUuYpoXiYEMHdtisvl3JUnuweKHbLLv5f/oB6NoKKE2K6wqUKzpKbxjH/EfGiOegUCBfr7KJg71atTaIx1dhapYzMBV84Y9hJlOqeoA7/Yi+6tTa358RcfIiXuDoSAeRJOKp9cV8a01IYlC3dr15WyF4UXrWUjXCbC7eUcOw+3PBfml9iXIX3qrGRAsClu20ozG1VlgujPTIJAf2iHfD9Mu6hIolxSZH5INSPxNbndmqaKbInebXQskUUevjIYV9hAvEtODDeLKFE+4WqjTcV9qyh5wIDAQAB-----END PUBLIC KEY-----";

            Assert.Equal(expectedPublicKey, actualPublicKey, ignoreLineEndingDifferences: true);
        }

        [Fact(DisplayName = "签名生成（SHA256WithRSA）")]
        public void SHA256WithRSASignTest()
        {
            string plainText = "This is raw data string.";
            string privateKey = "-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCquCFMOUauok1G\noY5K/mmL5p9x4NrRzQ8iK7u2XbYV8NuwQsJ8MA8rn6ukgcF8qbn98FyqXBYIGaOX\ncIw0el8ZRl8zQynVuyUJE8UF6gAWWVQquMjDJFZ7N8W5g3wCOe21tDtBeNPjTqpl\nPYI6kcBjbxPWxPDd8tlcsWHM+d61OBQq5Qjn7BXhdWd7rG1jiuSDmF45nc6/esVV\nmrDtFESetBsA2chsUXZM3eZCcuh51VajlG597e5imxpM0Kv4/g/qcjJYY7UVeO+Z\nLObnseIFVmYBKk9W/bMdaVEL1T6+v2V7akycEoP2L0gseUQYmArJAMgP+Vx/bdaf\n1ldcxYV1AgMBAAECggEBAIwkgTkYX5ymIXeU0cFgXfZ5iHQsWJUXl4++hOaswPf7\n8+wasZrOvPVbqsRtvA8BKWx7byZuV6uomHGN85p0xjJyYV4siWAps7pi3z7+m7m8\n9OnpLO18m/2kiAzFEfyl3yxlWqtha9dSUXCwcIJx+ZPmsEuC+hPI8oQ0HQvuJtNt\ncDmaFBp57kxjlO4Xm0xnvq2waSmAF4cO6Dk62gksu8G7//IyIHXqmRWSpI2b/Yqf\n84XtwLN8Zvq/3otYuWc3pFOaKHg2sJ/JwSU+yGdeIOtEXXFIDSD6p3KvIvjrD47D\na4optYReXP1k6e721z+XPBFP31i58iu1K8KOyjjJfsECgYEA41D6V1TrON31OOsM\n4jAtqyY/LVNdzT+I/S6lQruO9siRRJDYlAOdbM9VZnW/3rduPMBu4undbMkL5i8o\nlnwmLeWSupClA2WmUc8DWHlBO2s0lE+ZDZgOtpZ9qOBfm7L6jbjvzbGoyJgV6SeI\navH5SMQbFku5rlIi12hAb0Kv4uUCgYEAwELkPOKDH06SFOiuOzJcI4VyjK0V5LcW\njceTPkaT9d1evkrNgrHiG8CjYQ3V0lqSKhckFg2PwmPk72rC4n3aFCXurimv96rG\n5sBFFLgPbyoKZ3Z9JoDoe/6u6YIAV/GzxJ5QJaWQQ59MxToILYyq6aA6SrNOqRUP\nsKuvN8jBH1ECgYEA3dJ6yNgcRj0KfIWa5+qd1iMXiZKNuamjc3WeXTWL+DSW1bMH\nNcElUTYuHzMOjjavw2cBjjsrEWpLS09/qwHxe95IRfi6nksGd1Ss7hw9VM9z2rqm\nH4bf7LuEWlTB171bFQuAL1iL3VvUHdavH7WLTr/XsvUod/y89TlNj4UjACUCgYBB\nR3UPZyl2O8tF5isiVlsKhIj8UtiYK8IwqY7JGlWqqVs96VAWDCflnGbc0UHEhpQS\nToEmK7ygGCLnV6yMEoc1SBvebrEcupOGTcom2sgCypd1wbmElUhasYLaLhXHxn1v\nSQGVhr2Q+EmsvaOBM73kTU79hhwzNL97ERARNMy9wQKBgHCogsDPxSh8hEJR/PBo\nm6v/3R+Ou86K8nzulbyHGkDM7I2R//zGx4en1VxWFhsqywsGedugv1BMkgEcCFkT\njIXfYh9Uwn5iGUAZCczR5ZoETYAAzK2a/uaWf92iZEU0bHJaBA4egNxk1bFe+ECF\nTteN8Ag+UVtx0HU6ZNlyfetH\n-----END PRIVATE KEY-----";

            string actualSign = Utilities.RSAUtility.SignWithSHA256(privateKey, plainText);
            string expectdSign = "R27epmm4+hCNPyArxoXR03S6m1zb/JSbdGJ5d2xQHUs3BIciAUHOm9seOiUwbE5a8DUCBZq8q78krjEi4+j/ImdRUj2L+LYHD5HU0GB/9rQK5yapl/5gP8vAApZRfvL9PN8zvEC2v0exSM9AhIURe6zoet3MwmvzQBiYmcGblQIdS/gPqmmqJKEncHpgq6P08ARk4cUZjUqx5eOeFsruck/XmZwJbghmZdDIp9/norvJ3S/y295ndCd3WrZG3cK46X0SlD4P+Fr8FttzvvepXFRDRnRXkXWWXZDIJk/fADXBuemaCWjqRq5jdQ4+q4jeyqEeZX3GMpQr+byHyFXw1g==";

            Assert.Equal(expectdSign, actualSign);
        }

        [Fact(DisplayName = "签名验证（SHA256WithRSA）")]
        public void SHA256WithRSAVerifyTest()
        {
            string plainText = "1618999027\n24326286f7bc8e8e1e03122a8a77fdbc\n{\"data\":[{\"effective_time\":\"2020-08-01T15:35:18+08:00\",\"encrypt_certificate\":{\"algorithm\":\"AEAD_AES_256_GCM\",\"associated_data\":\"certificate\",\"ciphertext\":\"x9kkL5w1JuaypcjhrYIP+kVNlN8o8uN4yJyJjy5lg+PyPnQL2Zn//ORaXAyzdaK/WBMVd3u/Y9hLaTBLMyRXzowsrkJ5PT37johye48N7BAJQ0PJwW++d1RdhOOPjoqfmws6rSV5Gv2qhfdKjmpxVjr8xr71dtBt8J2wu+bAV99HHQoAynm/Pp9OQYZgpOQ+1cyFHd43TAxOoFfmixKrXr3HP8lJot0XCUSq4qkr1Hs44FV2KuzntSk8eqKr5N17UcuPF3VYnnnF/AvQ7HuLKWwrHhUbaXfkwy0Q2n36UJMfBj7344S97E8BnS89ojgOPQi+olBPyNgrtDWHgsJAKu7HA6PV/FgmXcrZirje/AH1u25es4z5xItHscm//6rDvALgf7greV5OJzMsSl/KVDtbkjDSzim0j4ZTduIfzh7l6jfOz115ITcNILT9ef2KkcMyBBc89GZlMGeHTbgsBHzGeLawX3dXFjqt5aMnHM3VWCovA2aUM4c//rqkZGf+Va86OEFoJQLiSTFpkOrKxcIxcrbKPLTgiDWRT3wzmnUDg7kSPbluzt3ROvMFq9lB8bO/pBd7TD2w87sfUdKLj69FniX6s37SBeRVhw8GSIvBf5lpLUhqL5zKYlbuAWePuz0wVV4NTtkaVKZlmm8KTODyZDFpsyKPubDDcwT1ftRf5aSVM4x04I/1B7GkNz/TOy+zpJ0h0B7VHdxyO5JYiI/1qsatX/FE2aJdQYMYOtqfDH7ZH5UUKIqo538OKvE2M4MlBR/aVE4z4QDKfE/1kYrOfvVGfDzF/FWHfUrcqB8kdQMvk8vCoM8yYZsX4KE1aoJbNM2pWv2tpr9JE8b/VQgUyHOgPYAha+UOmZki4Sfl9H62687EIWdbM57ZxmwIiBp60SrJLiBfZon9JqXKdtJOKj0CRokQiBnONNXCVerLFeBNQfeKRw8tgJXf+QPohMGYkSDdc8hTgdbmhTwB1Vv01stlYK12QMNRCovlp/fcmpB72Phlq+/3p5pqMzknw+qm5QAz7JnpZJCFHit52gHwAkKRkVPB3HF2rfLrdTYz5c9Bok1ICAY9My47eLFdduIe99V52cjMLQuUmNFBPrDdyZKVqIHJ/wtWO/wIFpAVGSJMHctyEKmeJVc1IQN74Wm00PrpPackHdO3G41bBmkp5pqUdsSgSkwdfNVqv0cMcSe04NrRGNKMcZ7TA/CMaP1YnhxvVE+z8aksJqSJ+gdplvuwl40y5C8UEHeAi1V8Q0Bf4YvYRgOVIWm2Lzjdn2z9PWLGcStUj11/1hthk2li4V3mgm2Cr2IZme2sn4rZmJ6dexGP1nk+ZYOq0xLE8F7oex9gyDN+A/6zHqnuhO/X08qye0gochMr8U89Qvj2c0L3P2mjCea2H1mEriAJPqMPMKIinh1lQJEZufnfCcPxbZLKTtl6zHtHgOztejd1gV/nUyCVKD4MCMfBDy9C/Af8pWx6akOg/QSQNIGA2AI6zprHn9zEjpFIzXJYvruVI22Yt6oF9Xnt7Ki82wRK2M96r4kj6cwSs4exMPGv8fWMrFTm0Br6p6T+HZsxyyn2ChuPIgpfisnce/ZaU/0xCZhK/K79+TK2GeeChq5oEpua/1tx4+kDHi7H9381pLJmy2oXW060c2mmwA9+EpcuwEDhr8fsnghbv41u7b1NhEmWNVUy29Dwaz61PPGUdh5DsvaKLWC+raZ/6UEKPw+tiABJ5o6u2jAWgmEYmmJCKapNgtfPc6D+O0aHH9oqh6u4+8NRAhusPZzDGWBr6AT4pexgWFeEhZhn6bXM9HhpUe0IhOTw5D+tqXrTlNon4kjYibiMUFy1h2YyYS3IEdu1J4xqvo0rFyCxF1C+P6ubc0tClRPkXg==\",\"nonce\":\"aae8c2e79c5b\"},\"expire_time\":\"2025-07-31T15:35:18+08:00\",\"serial_no\":\"19936B4DC6A6C77B05489B10962DEFF42EA065EF\"}]}\n";
            string signText = "W9J+0KIextwTJp7GURTFmZoyk0OT/qqmlnPgizInZIJ+Tj7FoxKBY5v5r+Xawe54bOPqb+2O5P7fvWpPTQtMf/lJL8Rvify051xWHJtaGGiyOi4Cffx/Y4p2c8AaSB3J0tBOiVlBu/iUhORnG/lOhlrhjk1/mVAuYvtmA04U0qpoPO3vT8Pp/cqbt+quZhDkrSCqXku+yz9w8P2lVpPqCQjF83dKP6ZoHFlS8BDNm1qey/qmUDO/7U68pSmqquWbpbrruSBVmsYyLDXVd1gKAuXdOoM71kfm1QLrLW2N8fBz98L/AcGGbEFNyBWjQXfjKUHlCoYiukmlA24Vx1RDGw==";
            string publicKey = "-----BEGIN PUBLIC KEY-----\nMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAzgGB6sQqmkc6EyL4FYsW\nmCSb5rx24nM28eTEPVy9SE0hcZE7DbJO0Sh5zu3gUuYpoXiYEMHdtisvl3JUnuwe\nKHbLLv5f/oB6NoKKE2K6wqUKzpKbxjH/EfGiOegUCBfr7KJg71atTaIx1dhapYzM\nBV84Y9hJlOqeoA7/Yi+6tTa358RcfIiXuDoSAeRJOKp9cV8a01IYlC3dr15WyF4U\nXrWUjXCbC7eUcOw+3PBfml9iXIX3qrGRAsClu20ozG1VlgujPTIJAf2iHfD9Mu6h\nIolxSZH5INSPxNbndmqaKbInebXQskUUevjIYV9hAvEtODDeLKFE+4WqjTcV9qyh\n5wIDAQAB\n-----END PUBLIC KEY-----";
            string cerText = "-----BEGIN CERTIFICATE-----\nMIID3DCCAsSgAwIBAgIUGZNrTcamx3sFSJsQli3v9C6gZe8wDQYJKoZIhvcNAQEL\nBQAwXjELMAkGA1UEBhMCQ04xEzARBgNVBAoTClRlbnBheS5jb20xHTAbBgNVBAsT\nFFRlbnBheS5jb20gQ0EgQ2VudGVyMRswGQYDVQQDExJUZW5wYXkuY29tIFJvb3Qg\nQ0EwHhcNMjAwODAxMDczNTE4WhcNMjUwNzMxMDczNTE4WjBuMRgwFgYDVQQDDA9U\nZW5wYXkuY29tIHNpZ24xEzARBgNVBAoMClRlbnBheS5jb20xHTAbBgNVBAsMFFRl\nbnBheS5jb20gQ0EgQ2VudGVyMQswCQYDVQQGDAJDTjERMA8GA1UEBwwIU2hlblpo\nZW4wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDOAYHqxCqaRzoTIvgV\nixaYJJvmvHbiczbx5MQ9XL1ITSFxkTsNsk7RKHnO7eBS5imheJgQwd22Ky+XclSe\n7B4odssu/l/+gHo2gooTYrrCpQrOkpvGMf8R8aI56BQIF+vsomDvVq1NojHV2Fql\njMwFXzhj2EmU6p6gDv9iL7q1NrfnxFx8iJe4OhIB5Ek4qn1xXxrTUhiULd2vXlbI\nXhRetZSNcJsLt5Rw7D7c8F+aX2JchfeqsZECwKW7bSjMbVWWC6M9MgkB/aId8P0y\n7qEiiXFJkfkg1I/E1ud2apopsid5tdCyRRR6+MhhX2EC8S04MN4soUT7haqNNxX2\nrKHnAgMBAAGjgYEwfzAJBgNVHRMEAjAAMAsGA1UdDwQEAwIE8DBlBgNVHR8EXjBc\nMFqgWKBWhlRodHRwOi8vZXZjYS5pdHJ1cy5jb20uY24vcHVibGljL2l0cnVzY3Js\nP0NBPTFCRDQyMjBFNTBEQkMwNEIwNkFEMzk3NTQ5ODQ2QzAxQzNFOEVCRDIwDQYJ\nKoZIhvcNAQELBQADggEBAJyg2z4oLQmPfftLQWyzbUc9ONhRMtfA+tVlVBgtLLKn\nWuDlsmEntheM07fu84F4pcfs3yHzjD7pAOFbO4Yt1yhQ50DK35sjbRWepPdWJZLl\nni7KBctcmm0o4zq37oB7vonmBEbFqYs9DaINYOjgI3J25iSBkPVC7dBbvFj2xB0L\ncIcXipq30tDdC/oUem27MNzwZAt49WthKhw6u3HSkcE5cO4LyYTsJhSyG/7LXwvV\nMgX4Jyzo0SSiGOU1/beaZssTVI8sTPJVlHWjhNE3Lc2SaAlKGfGwvt0X3cEZEF+7\noEZIFTkkAF2JhqfnpR3gST0G8Umq1SaVtCPP/zVI8x0=\n-----END CERTIFICATE-----";

            Assert.True(Utilities.RSAUtility.VerifyWithSHA256(publicKey, plainText, signText));
            Assert.True(Utilities.RSAUtility.VerifyWithSHA256ByCertificate(cerText, plainText, signText));
        }

        [Fact(DisplayName = "使用 RSA 公钥加密")]
        public void RsaEncryptTest()
        {
            string plainText = "This is raw data string.";
            string publicKey = "-----BEGIN PUBLIC KEY-----\nMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAzgGB6sQqmkc6EyL4FYsW\nmCSb5rx24nM28eTEPVy9SE0hcZE7DbJO0Sh5zu3gUuYpoXiYEMHdtisvl3JUnuwe\nKHbLLv5f/oB6NoKKE2K6wqUKzpKbxjH/EfGiOegUCBfr7KJg71atTaIx1dhapYzM\nBV84Y9hJlOqeoA7/Yi+6tTa358RcfIiXuDoSAeRJOKp9cV8a01IYlC3dr15WyF4U\nXrWUjXCbC7eUcOw+3PBfml9iXIX3qrGRAsClu20ozG1VlgujPTIJAf2iHfD9Mu6h\nIolxSZH5INSPxNbndmqaKbInebXQskUUevjIYV9hAvEtODDeLKFE+4WqjTcV9qyh\n5wIDAQAB\n-----END PUBLIC KEY-----";
            string cerText = "-----BEGIN CERTIFICATE-----\nMIID3DCCAsSgAwIBAgIUGZNrTcamx3sFSJsQli3v9C6gZe8wDQYJKoZIhvcNAQEL\nBQAwXjELMAkGA1UEBhMCQ04xEzARBgNVBAoTClRlbnBheS5jb20xHTAbBgNVBAsT\nFFRlbnBheS5jb20gQ0EgQ2VudGVyMRswGQYDVQQDExJUZW5wYXkuY29tIFJvb3Qg\nQ0EwHhcNMjAwODAxMDczNTE4WhcNMjUwNzMxMDczNTE4WjBuMRgwFgYDVQQDDA9U\nZW5wYXkuY29tIHNpZ24xEzARBgNVBAoMClRlbnBheS5jb20xHTAbBgNVBAsMFFRl\nbnBheS5jb20gQ0EgQ2VudGVyMQswCQYDVQQGDAJDTjERMA8GA1UEBwwIU2hlblpo\nZW4wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDOAYHqxCqaRzoTIvgV\nixaYJJvmvHbiczbx5MQ9XL1ITSFxkTsNsk7RKHnO7eBS5imheJgQwd22Ky+XclSe\n7B4odssu/l/+gHo2gooTYrrCpQrOkpvGMf8R8aI56BQIF+vsomDvVq1NojHV2Fql\njMwFXzhj2EmU6p6gDv9iL7q1NrfnxFx8iJe4OhIB5Ek4qn1xXxrTUhiULd2vXlbI\nXhRetZSNcJsLt5Rw7D7c8F+aX2JchfeqsZECwKW7bSjMbVWWC6M9MgkB/aId8P0y\n7qEiiXFJkfkg1I/E1ud2apopsid5tdCyRRR6+MhhX2EC8S04MN4soUT7haqNNxX2\nrKHnAgMBAAGjgYEwfzAJBgNVHRMEAjAAMAsGA1UdDwQEAwIE8DBlBgNVHR8EXjBc\nMFqgWKBWhlRodHRwOi8vZXZjYS5pdHJ1cy5jb20uY24vcHVibGljL2l0cnVzY3Js\nP0NBPTFCRDQyMjBFNTBEQkMwNEIwNkFEMzk3NTQ5ODQ2QzAxQzNFOEVCRDIwDQYJ\nKoZIhvcNAQELBQADggEBAJyg2z4oLQmPfftLQWyzbUc9ONhRMtfA+tVlVBgtLLKn\nWuDlsmEntheM07fu84F4pcfs3yHzjD7pAOFbO4Yt1yhQ50DK35sjbRWepPdWJZLl\nni7KBctcmm0o4zq37oB7vonmBEbFqYs9DaINYOjgI3J25iSBkPVC7dBbvFj2xB0L\ncIcXipq30tDdC/oUem27MNzwZAt49WthKhw6u3HSkcE5cO4LyYTsJhSyG/7LXwvV\nMgX4Jyzo0SSiGOU1/beaZssTVI8sTPJVlHWjhNE3Lc2SaAlKGfGwvt0X3cEZEF+7\noEZIFTkkAF2JhqfnpR3gST0G8Umq1SaVtCPP/zVI8x0=\n-----END CERTIFICATE-----";

            string actualCipherByPublicKey = Utilities.RSAUtility.EncryptWithECB(publicKey, plainText);
            string actualCipherByCertificate = Utilities.RSAUtility.EncryptWithECBByCertificate(cerText, plainText);

            Assert.NotNull(actualCipherByPublicKey);
            Assert.NotNull(actualCipherByCertificate);
            Assert.NotEqual(actualCipherByPublicKey, actualCipherByCertificate);
        }

        [Fact(DisplayName = "使用 RSA 私钥解密")]
        public void RsaDecryptTest()
        {
            string cipherText = "WgG5o+hqLrLXhurIvyohPaWh7bWSkgY55xT7r+xwyhpUxXclWR2Hkxq0FFeDFmsc12XR6B0yqW5e4UHpmXCvAlkVeAQj1bUlxYwFu93AaD5kHi6dmoxG7/IcJiGhtb9iVfnSueJv0zc6ng22IAOqT+bmdF8u6wHW0Grkn+0wS0gSrgJ6FKo/E1wxFDxVhm5eRGzpK8wRAAckXGFA8VYkwWMzKC5YWW2CVCAKdScSQCPAp872R5V5PHia1+8Ahl5FsJPjSKrLtIuGlK+b+j+/TFSUOQ5Fq519cFTJ+srF5NbMgGJHhRhSfxOC3CCMwgEV0f33trJE5f1y04Lt43qgQw==";
            string privateKey = "-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCquCFMOUauok1G\noY5K/mmL5p9x4NrRzQ8iK7u2XbYV8NuwQsJ8MA8rn6ukgcF8qbn98FyqXBYIGaOX\ncIw0el8ZRl8zQynVuyUJE8UF6gAWWVQquMjDJFZ7N8W5g3wCOe21tDtBeNPjTqpl\nPYI6kcBjbxPWxPDd8tlcsWHM+d61OBQq5Qjn7BXhdWd7rG1jiuSDmF45nc6/esVV\nmrDtFESetBsA2chsUXZM3eZCcuh51VajlG597e5imxpM0Kv4/g/qcjJYY7UVeO+Z\nLObnseIFVmYBKk9W/bMdaVEL1T6+v2V7akycEoP2L0gseUQYmArJAMgP+Vx/bdaf\n1ldcxYV1AgMBAAECggEBAIwkgTkYX5ymIXeU0cFgXfZ5iHQsWJUXl4++hOaswPf7\n8+wasZrOvPVbqsRtvA8BKWx7byZuV6uomHGN85p0xjJyYV4siWAps7pi3z7+m7m8\n9OnpLO18m/2kiAzFEfyl3yxlWqtha9dSUXCwcIJx+ZPmsEuC+hPI8oQ0HQvuJtNt\ncDmaFBp57kxjlO4Xm0xnvq2waSmAF4cO6Dk62gksu8G7//IyIHXqmRWSpI2b/Yqf\n84XtwLN8Zvq/3otYuWc3pFOaKHg2sJ/JwSU+yGdeIOtEXXFIDSD6p3KvIvjrD47D\na4optYReXP1k6e721z+XPBFP31i58iu1K8KOyjjJfsECgYEA41D6V1TrON31OOsM\n4jAtqyY/LVNdzT+I/S6lQruO9siRRJDYlAOdbM9VZnW/3rduPMBu4undbMkL5i8o\nlnwmLeWSupClA2WmUc8DWHlBO2s0lE+ZDZgOtpZ9qOBfm7L6jbjvzbGoyJgV6SeI\navH5SMQbFku5rlIi12hAb0Kv4uUCgYEAwELkPOKDH06SFOiuOzJcI4VyjK0V5LcW\njceTPkaT9d1evkrNgrHiG8CjYQ3V0lqSKhckFg2PwmPk72rC4n3aFCXurimv96rG\n5sBFFLgPbyoKZ3Z9JoDoe/6u6YIAV/GzxJ5QJaWQQ59MxToILYyq6aA6SrNOqRUP\nsKuvN8jBH1ECgYEA3dJ6yNgcRj0KfIWa5+qd1iMXiZKNuamjc3WeXTWL+DSW1bMH\nNcElUTYuHzMOjjavw2cBjjsrEWpLS09/qwHxe95IRfi6nksGd1Ss7hw9VM9z2rqm\nH4bf7LuEWlTB171bFQuAL1iL3VvUHdavH7WLTr/XsvUod/y89TlNj4UjACUCgYBB\nR3UPZyl2O8tF5isiVlsKhIj8UtiYK8IwqY7JGlWqqVs96VAWDCflnGbc0UHEhpQS\nToEmK7ygGCLnV6yMEoc1SBvebrEcupOGTcom2sgCypd1wbmElUhasYLaLhXHxn1v\nSQGVhr2Q+EmsvaOBM73kTU79hhwzNL97ERARNMy9wQKBgHCogsDPxSh8hEJR/PBo\nm6v/3R+Ou86K8nzulbyHGkDM7I2R//zGx4en1VxWFhsqywsGedugv1BMkgEcCFkT\njIXfYh9Uwn5iGUAZCczR5ZoETYAAzK2a/uaWf92iZEU0bHJaBA4egNxk1bFe+ECF\nTteN8Ag+UVtx0HU6ZNlyfetH\n-----END PRIVATE KEY-----";

            string actualPlain = Utilities.RSAUtility.DecryptWithECB(privateKey, cipherText);
            string expectdPlain = "This is raw data string.";

            Assert.Equal(expectdPlain, actualPlain);
        }

        [Fact(DisplayName = "信息摘要（SHA-256）")]
        public void Sha256HashTest()
        {
            string rawData = "This is raw data string.";

            string actualHash = Security.SHA256Utility.Hash(rawData);
            string expectdHash = "5bd1e86d96a5ec138242ee3c743ea004bc8e215ef8ab72178133a6460034f216";

            Assert.Equal(expectdHash, actualHash, ignoreCase: true);
        }
    }
}
