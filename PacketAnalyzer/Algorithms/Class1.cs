using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Penis
    {
        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
   
            hexString = hexString.Replace(" ", String.Empty);
            hexString = hexString.Replace("\r", "");
            hexString = hexString.Replace("\n", "");

            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            var hexAsBytes = new byte[hexString.Length / 2];
            for (var index = 0; index < hexAsBytes.Length; index++)
            {
                var byteValue = hexString.Substring(index * 2, 2);
                hexAsBytes[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            if (BitConverter.IsLittleEndian)
                Array.Reverse(hexAsBytes);

            return hexAsBytes;
        }

        private static string MyFirstAlgorithm(byte[] payload)
        {
            short[] shortValues = null;
            int [] intValues = null;
            long[] longValues = null;
            float[] floatValues = null;

            //! Even
            if (payload.Count() % 2 == 0)
            {
                
            }
            else
            {

            }
            return String.Empty;
        }

        public static int IntFromByteArray(ref byte[] bytes, int startIndex, int endIndex = 0)
        {
            int iret = 0;
            if (endIndex == 0) endIndex = startIndex + sizeof (int);
            int iterations = endIndex - startIndex;
            for (var i = 0; i < iterations; ++i)
            {
                iret |= bytes[startIndex++];
                iret <<= 8;
                if (i == 3)
                    return iret;
            }

            var bytesToFill = sizeof (int) - iterations;
            for (var i = 0; i < bytesToFill; ++i)
            {
                iret |= (byte) 0;
                iret <<= 8;
            }

            return iret;
        }
    }
}
