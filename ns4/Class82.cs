using System;
using System.IO;
using ns5;
using SharpAudio.ASC.Mp3.Decoding;

namespace ns4
{
	public class Class82
	{
		private int int_0;

		private byte[] byte_0;

		public static byte byte_1;

		public static byte byte_2 = 1;

		private int[] int_1;

		private int int_2;

		private byte[] byte_3;

		private int int_3;

		private int int_4;

		private int int_5;

		private bool bool_0;

		private readonly int[] int_6 = {
			0,
			1,
			3,
			7,
			15,
			31,
			63,
			127,
			255,
			511,
			1023,
			2047,
			4095,
			8191,
			16383,
			32767,
			65535,
			131071
		};

		private readonly zzStreamClass106 class106_0;

		private zzSoundClass class107_0;

		private byte[] byte_4;

		private Class101[] class101_0;

		private bool bool_1 = true;

		private void method_0()
		{
			class101_0 = new Class101[1];
			byte_4 = new byte[4];
			byte_3 = new byte[1732];
			int_1 = new int[433];
			class107_0 = new zzSoundClass();
		}

		public Class82(Stream stream_0, int int_7) : this(new zzStreamClass106(stream_0, int_7))
		{
		}

		public Class82(zzStreamClass106 class106_1)
		{
			method_0();
			if (class106_1 == null)
			{
				throw new NullReferenceException("in");
			}
			method_17(class106_1.method_0());
			class106_0 = class106_1;
			method_7();
		}

		public void method_1()
		{
			try
			{
				class106_0.method_3();
			}
			catch (IOException exception_)
			{
				throw new BitstreamException(BitstreamError.StreamError, exception_);
			}
		}

		public int method_2()
		{
			return int_0;
		}

		public zzSoundClass method_3()
		{
			zzSoundClass @class = null;
			try
			{
				@class = method_4();
				if (bool_1)
				{
					@class.method_2(byte_3);
					bool_1 = false;
				}
			}
			catch (BitstreamException ex)
			{
				if (ex.Error == BitstreamError.InvalidFrame)
				{
					try
					{
						method_7();
						@class = method_4();
						goto IL_7A;
					}
					catch (BitstreamException ex2)
					{
						if (ex2.Error != BitstreamError.StreamEOF)
						{
							throw new BitstreamException(ex2.Error, ex2);
						}
						goto IL_7A;
					}
				}
				if (ex.Error != BitstreamError.StreamEOF)
				{
					throw new BitstreamException(ex.Error, ex);
				}
				IL_7A:;
			}
			return @class;
		}

		private zzSoundClass method_4()
		{
			if (int_2 == -1)
			{
				method_5();
			}
			return class107_0;
		}

		private void method_5()
		{
			class107_0.method_1(this, class101_0);
		}

		public void method_6()
		{
			if (int_3 == -1 && int_4 == -1 && int_2 > 0)
			{
				try
				{
					class106_0.IncrementSomeVariableAndCheckIfTheBackStreamIsFisted(int_2);
				}
				catch (IOException)
				{
					throw new BitstreamException(BitstreamError.StreamError);
				}
			}
		}

		public void method_7()
		{
			int_2 = -1;
			int_3 = -1;
			int_4 = -1;
		}

		public bool method_8(int int_7)
		{
			var num = method_16(byte_4, 0, 4);
			var int_8 = (byte_4[0] << 24 & -16777216) | (byte_4[1] << 16 & 16711680) | (byte_4[2] << 8 & 65280) | byte_4[3] & 255;
			try
			{
				class106_0.IncrementSomeVariableAndCheckIfTheBackStreamIsFisted(num);
			}
			catch (IOException)
			{
			}
			var result = false;
			var num2 = num;
			if (num2 != 0)
			{
				if (num2 == 4)
				{
					result = method_10(int_8, int_7, int_5);
				}
			}
			else
			{
				result = true;
			}
			return result;
		}

		public int method_9(byte byte_5)
		{
			var num = method_16(byte_4, 0, 3);
			if (num != 3)
			{
				throw new BitstreamException(BitstreamError.StreamEOF, null);
			}
			var num2 = (byte_4[0] << 16 & 16711680) | (byte_4[1] << 8 & 65280) | byte_4[2] & 255;
			while (true)
			{
				num2 <<= 8;
				if (method_16(byte_4, 3, 1) != 1)
				{
					break;
				}
				num2 |= byte_4[3] & 255;
				if (method_10(num2, byte_5, int_5))
				{
					return num2;
				}
			}
			throw new BitstreamException(BitstreamError.StreamEOF, null);
		}

		public bool method_10(int int_7, int int_8, int int_9)
		{
			bool flag;
			if (int_8 == byte_1)
			{
				flag = ((int_7 & 4292870144L) == 4292870144L);
			}
			else
			{
				flag = ((int_7 & 4292870144L) == 4292870144L && (int_7 & 192) == 192 == bool_0);
			}
			if (flag)
			{
				flag = ((int_7 >> 10 & 3) != 3);
			}
			if (flag)
			{
				flag = ((int_7 >> 17 & 3) != 0);
			}
			if (flag)
			{
				flag = ((int_7 >> 19 & 3) != 1);
			}
			return flag;
		}

		public int method_11(int int_7)
		{
			var result = method_15(byte_3, 0, int_7);
			int_2 = int_7;
			int_3 = -1;
			int_4 = -1;
			return result;
		}

		public void method_12()
		{
			var num = 0;
			var array = byte_3;
			var num2 = int_2;
			for (var i = 0; i < num2; i += 4)
			{
				byte b = 0;
				byte b2 = 0;
				byte b3 = 0;
				var b4 = array[i];
				if (i + 1 < num2)
				{
					b = array[i + 1];
				}
				if (i + 2 < num2)
				{
					b2 = array[i + 2];
				}
				if (i + 3 < num2)
				{
					b3 = array[i + 3];
				}
				int_1[num++] = ((b4 << 24 & -16777216) | (b << 16 & 16711680) | (b2 << 8 & 65280) | b3 & 255);
			}
			int_3 = 0;
			int_4 = 0;
		}

		public int method_13(int int_7)
		{
			var num = int_4 + int_7;
			if (int_3 < 0)
			{
				int_3 = 0;
			}
			int num4;
			if (num <= 32)
			{
				var num2 = int_1[int_3];
				var num3 = 32 - num;
				num4 = (num2 >> num3 & int_6[int_7]);
				if ((int_4 += int_7) == 32)
				{
					int_4 = 0;
					int_3++;
				}
				return num4;
			}
			var num5 = int_1[int_3] & 65535;
			int_3++;
			var num6 = int_1[int_3] & -65536;
			num4 = ((num5 << 16 & -65536) | (num6 >> 16 & 65535));
			var num7 = 48 - num;
			num4 >>= num7;
			num4 &= int_6[int_7];
			int_4 = num - 32;
			return num4;
		}

		public void method_14(int int_7)
		{
			int_5 = (int_7 & -193);
			bool_0 = ((int_7 & 192) == 192);
		}

		private int method_15(byte[] byte_5, int int_7, int int_8)
		{
			var num = 0;
			try
			{
				while (int_8 > 0)
				{
					var num2 = class106_0.method_1(byte_5, int_7, int_8);
					if (num2 == -1 || num2 == 0)
					{
						while (int_8-- > 0)
						{
							byte_5[int_7++] = 0;
						}
						break;
					}
					num += num2;
					int_7 += num2;
					int_8 -= num2;
				}
			}
			catch (IOException exception_)
			{
				throw new BitstreamException(BitstreamError.StreamError, exception_);
			}
			return num;
		}

		private int method_16(byte[] byte_5, int int_7, int int_8)
		{
			var num = 0;
			try
			{
				while (int_8 > 0)
				{
					var num2 = class106_0.method_1(byte_5, int_7, int_8);
					if (num2 == -1 || num2 == 0)
					{
						break;
					}
					num += num2;
					int_7 += num2;
					int_8 -= num2;
				}
			}
			catch (IOException exception_)
			{
				throw new BitstreamException(BitstreamError.StreamError, exception_);
			}
			return num;
		}

		private void method_17(Stream stream_0)
		{
			var position = 0L;
			var num = -1;
			try
			{
				position = stream_0.Position;
				num = smethod_0(stream_0);
				int_0 = num;
			}
			catch (IOException)
			{
			}
			finally
			{
				try
				{
					stream_0.Position = position;
				}
				catch (IOException)
				{
				}
			}
			try
			{
				if (num > 0)
				{
					byte_0 = new byte[num];
					stream_0.Read(byte_0, 0, byte_0.Length);
				}
			}
			catch (IOException)
			{
			}
		}

		private static int smethod_0(Stream stream_0)
		{
			var array = new byte[4];
			var num = -10;
			stream_0.Read(array, 0, 3);
			if (array[0] == 73 && array[1] == 68 && array[2] == 51)
			{
				stream_0.Read(array, 0, 3);
				stream_0.Read(array, 0, 4);
				num = (array[0] << 21) + (array[1] << 14) + (array[2] << 7) + array[3];
			}
			return num + 10;
		}
	}
}
