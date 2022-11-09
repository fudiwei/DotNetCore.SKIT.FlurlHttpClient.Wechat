using System;
using System.Text;
using Org.BouncyCastle.Crypto;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    /// <summary>
    /// SM3 算法工具类。
    /// </summary>
    public static class SM3Utility
    {
        internal static class BitOperator
        {
            public static int URShift(int number, int bits)
            {
                if (number >= 0)
                    return number >> bits;
                else
                    return (number >> bits) + (2 << ~bits);
            }

            public static int URShift(int number, long bits)
            {
                return URShift(number, (int)bits);
            }

            public static long URShift(long number, int bits)
            {
                if (number >= 0)
                    return number >> bits;
                else
                    return (number >> bits) + (2L << ~bits);
            }

            public static long URShift(long number, long bits)
            {
                return URShift(number, (int)bits);
            }
        }

        internal abstract class GeneralDigest : IDigest
        {
            private const int ByteLength = 64;
            private readonly byte[] XBuf;
            private int XBufOff;
            private long ByteCount;

            public abstract string AlgorithmName { get; }

            protected GeneralDigest()
            {
                XBuf = new byte[4];
            }

            protected GeneralDigest(GeneralDigest t)
            {
                XBuf = new byte[t.XBuf.Length];
                Array.Copy(t.XBuf, 0, XBuf, 0, t.XBuf.Length);

                XBufOff = t.XBufOff;
                ByteCount = t.ByteCount;
            }

            public void Update(byte input)
            {
                XBuf[XBufOff++] = input;

                if (XBufOff == XBuf.Length)
                {
                    ProcessWord(XBuf, 0);
                    XBufOff = 0;
                }

                ByteCount++;
            }

            public void BlockUpdate(byte[] input, int inOff, int length)
            {
                //更新当前消息摘要
                while ((XBufOff != 0) && (length > 0))
                {
                    Update(input[inOff]);
                    inOff++;
                    length--;
                }

                //处理完整的消息摘要
                while (length > XBuf.Length)
                {
                    ProcessWord(input, inOff);

                    inOff += XBuf.Length;
                    length -= XBuf.Length;
                    ByteCount += XBuf.Length;
                }

                //填充剩余的消息摘要
                while (length > 0)
                {
                    Update(input[inOff]);

                    inOff++;
                    length--;
                }
            }

            public void Finish()
            {
                long bitLength = (ByteCount << 3);

                //添加字节
                Update(unchecked((byte)128));

                while (XBufOff != 0) Update(unchecked((byte)0));
                ProcessLength(bitLength);
                ProcessBlock();
            }

            public virtual void Reset()
            {
                ByteCount = 0;
                XBufOff = 0;
                Array.Clear(XBuf, 0, XBuf.Length);
            }

            public int GetByteLength()
            {
                return ByteLength;
            }

            internal abstract void ProcessWord(byte[] input, int inOff);

            internal abstract void ProcessLength(long bitLength);

            internal abstract void ProcessBlock();

            public abstract int GetDigestSize();

            public abstract int DoFinal(byte[] output, int outOff);
        }

        internal sealed class SM3Digest : GeneralDigest
        {
            private const int DIGEST_LENGTH = 32;
            private const int T_1 = 0x79cc4519;
            private const int T_2 = 0x7a879d8a;

            private static readonly int[] IV = new int[] { 0x7380166f, 0x4914b2b9, 0x172442d7, unchecked((int)0xda8a0600), unchecked((int)0xa96f30bc), 0x163138aa, unchecked((int)0xe38dee4d), unchecked((int)0xb0fb0e4e) };
            private static readonly int[] X0 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            private readonly int[] _v1 = new int[8];
            private readonly int[] _v2 = new int[8];
            private readonly int[] _x = new int[68];
            private int _xOff;

            public override string AlgorithmName { get { return "SM3"; } }

            public SM3Digest()
                : base()
            {
                Reset();
            }

            public SM3Digest(SM3Digest t)
                : base(t)
            {
                Array.Copy(t._x, 0, _x, 0, t._x.Length);
                _xOff = t._xOff;
                Array.Copy(t._v1, 0, _v1, 0, t._v1.Length);
            }

            private static void ConvertIntegerToBigEndian(int num, byte[] bytes, int offset)
            {
                bytes[offset] = (byte)(BitOperator.URShift(num, 24));
                bytes[++offset] = (byte)(BitOperator.URShift(num, 16));
                bytes[++offset] = (byte)(BitOperator.URShift(num, 8));
                bytes[++offset] = (byte)(num);
            }

            private static int Rotate(int x, int n)
            {
                return (x << n) | (BitOperator.URShift(x, (32 - n)));
            }

            private static int P0(int x)
            {
                return (x) ^ Rotate(x, 9) ^ Rotate(x, 17);
            }

            private static int P1(int x)
            {
                return (x) ^ Rotate(x, 15) ^ Rotate(x, 23);
            }

            private static int FFOne(int x, int y, int z)
            {
                return (x ^ y ^ z);
            }

            private static int FFSecond(int x, int y, int z)
            {
                return ((x & y) | (x & z) | (y & z));
            }

            private static int GGOne(int x, int y, int z)
            {
                return (x ^ y ^ z);
            }

            private static int GGSecond(int x, int y, int z)
            {
                return ((x & y) | (~x & z));
            }

            public override void Reset()
            {
                base.Reset();

                Array.Copy(IV, 0, _v1, 0, IV.Length);

                _xOff = 0;
                Array.Copy(X0, 0, _x, 0, X0.Length);
            }

            internal override void ProcessWord(byte[] input, int inOff)
            {
                int n = input[inOff] << 24;
                n |= (input[++inOff] & 0xff) << 16;
                n |= (input[++inOff] & 0xff) << 8;
                n |= (input[++inOff] & 0xff);
                _x[_xOff] = n;

                if (++_xOff == 16)
                {
                    ProcessBlock();
                }
            }

            internal override void ProcessLength(long bitLength)
            {
                if (_xOff > 14)
                {
                    ProcessBlock();
                }

                _x[14] = (int)(BitOperator.URShift(bitLength, 32));
                _x[15] = (int)(bitLength & unchecked((int)0xffffffff));
            }

            internal override void ProcessBlock()
            {
                int j;

                int[] ww = _x;
                int[] ww_ = new int[64];

                for (j = 16; j < 68; j++)
                {
                    ww[j] = P1(ww[j - 16] ^ ww[j - 9] ^ (Rotate(ww[j - 3], 15))) ^ (Rotate(ww[j - 13], 7)) ^ ww[j - 6];
                }
                for (j = 0; j < 64; j++)
                {
                    ww_[j] = ww[j] ^ ww[j + 4];
                }

                int[] vv = _v1;
                int[] vv_ = _v2;

                Array.Copy(vv, 0, vv_, 0, IV.Length);

                int SS1, SS2, TT1, TT2;
                int aaa;

                for (j = 0; j < 16; j++)
                {
                    aaa = Rotate(vv_[0], 12);
                    SS1 = aaa + vv_[4] + Rotate(T_1, j);
                    SS1 = Rotate(SS1, 7);
                    SS2 = SS1 ^ aaa;

                    TT1 = FFOne(vv_[0], vv_[1], vv_[2]) + vv_[3] + SS2 + ww_[j];
                    TT2 = GGOne(vv_[4], vv_[5], vv_[6]) + vv_[7] + SS1 + ww[j];

                    vv_[3] = vv_[2];
                    vv_[2] = Rotate(vv_[1], 9);
                    vv_[1] = vv_[0];
                    vv_[0] = TT1;
                    vv_[7] = vv_[6];
                    vv_[6] = Rotate(vv_[5], 19);
                    vv_[5] = vv_[4];
                    vv_[4] = P0(TT2);
                }

                for (j = 16; j < 64; j++)
                {
                    aaa = Rotate(vv_[0], 12);
                    SS1 = aaa + vv_[4] + Rotate(T_2, j);
                    SS1 = Rotate(SS1, 7);
                    SS2 = SS1 ^ aaa;

                    TT1 = FFSecond(vv_[0], vv_[1], vv_[2]) + vv_[3] + SS2 + ww_[j];
                    TT2 = GGSecond(vv_[4], vv_[5], vv_[6]) + vv_[7] + SS1 + ww[j];

                    vv_[3] = vv_[2];
                    vv_[2] = Rotate(vv_[1], 9);
                    vv_[1] = vv_[0];
                    vv_[0] = TT1;
                    vv_[7] = vv_[6];
                    vv_[6] = Rotate(vv_[5], 19);
                    vv_[5] = vv_[4];
                    vv_[4] = P0(TT2);
                }

                for (j = 0; j < 8; j++)
                {
                    vv[j] ^= vv_[j];
                }

                _xOff = 0;
                Array.Copy(X0, 0, _x, 0, X0.Length);
            }

            public override int GetDigestSize()
            {
                return DIGEST_LENGTH;
            }

            public override int DoFinal(byte[] output, int outOff)
            {
                Finish();
                for (int i = 0; i < 8; i++)
                {
                    ConvertIntegerToBigEndian(_v1[i], output, outOff + i * 4);
                }
                Reset();
                return DIGEST_LENGTH;
            }
        }

        /// <summary>
        /// 获取 SM3 哈希值。
        /// </summary>
        /// <param name="bytes">信息字节数组。</param>
        /// <returns>哈希字节数组。</returns>
        public static byte[] Hash(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            SM3Digest sm3 = new SM3Digest();
            sm3.BlockUpdate(bytes, 0, bytes.Length);
            byte[] hashBytes = new byte[sm3.GetDigestSize()];
            sm3.DoFinal(hashBytes, 0);
            return hashBytes;
        }

        /// <summary>
        /// 获取 SM3 哈希值。
        /// </summary>
        /// <param name="message">文本信息。</param>
        /// <returns>哈希值。</returns>
        public static string Hash(string message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] msgBytes = Encoding.UTF8.GetBytes(message);
            byte[] hashBytes = Hash(msgBytes);
            return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
        }
    }
}
