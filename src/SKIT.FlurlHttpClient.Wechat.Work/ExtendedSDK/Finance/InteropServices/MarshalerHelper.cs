using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.InteropServices
{
    internal static class MarshalerHelper
    {
        public static string PtrToStringAnsi(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return default!;

            return Marshal.PtrToStringAnsi(ptr)!;
        }

        public static string PtrToStringUTF8(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return default!;

#if NETCOREAPP || NET5_0_OR_GREATER
            return Marshal.PtrToStringUTF8(ptr)!;
#else
            byte b;
            int offset = 0;

            do
            {
                b = Marshal.ReadByte(ptr, offset);
                offset++;
            }
            while (b != 0);

            byte[] bytes = new byte[offset - 1];
            Marshal.Copy(ptr, bytes, 0, bytes.Length);
            return Encoding.UTF8.GetString(bytes);
#endif
        }
    }
}
