using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
{
    internal static class MarshalHelper
    {
        [SecurityCritical]
        public static string? PtrToStringAnsi(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return null;

            return Marshal.PtrToStringAnsi(ptr)!;
        }

        [SecurityCritical]
        public static string? PtrToStringUTF8(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return null;

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
