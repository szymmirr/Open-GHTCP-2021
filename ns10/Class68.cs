using System;
using System.Runtime.CompilerServices;

namespace ns10
{
	public class Class68
	{
		private int int_0;

		private int int_1;

		private float[] float_0;

		private int[] int_2;

		private float float_1;

		private float[] float_2 = new float[1024];

		private float[] float_3 = new float[1024];

		public void method_0(int int_3)
		{
			int_2 = new int[int_3 / 4];
			float_0 = new float[int_3 + int_3 / 4];
			int_1 = (int)Math.Round(Math.Log(int_3) / Math.Log(2.0));
			int_0 = int_3;
			int num = 0;
			int num2 = 1;
			int num3 = 0 + int_3 / 2;
			int num4 = num3 + 1;
			int num5 = num3 + int_3 / 2;
			int num6 = num5 + 1;
			for (int i = 0; i < int_3 / 4; i++)
			{
				float_0[num + i * 2] = (float)Math.Cos(3.1415926535897931 / int_3 * (4 * i));
				float_0[num2 + i * 2] = -(float)Math.Sin(3.1415926535897931 / int_3 * (4 * i));
				float_0[num3 + i * 2] = (float)Math.Cos(3.1415926535897931 / (2 * int_3) * (2 * i + 1));
				float_0[num4 + i * 2] = (float)Math.Sin(3.1415926535897931 / (2 * int_3) * (2 * i + 1));
			}
			for (int j = 0; j < int_3 / 8; j++)
			{
				float_0[num5 + j * 2] = (float)Math.Cos(3.1415926535897931 / int_3 * (4 * j + 2));
				float_0[num6 + j * 2] = -(float)Math.Sin(3.1415926535897931 / int_3 * (4 * j + 2));
			}
			int num7 = (1 << int_1 - 1) - 1;
			int num8 = 1 << int_1 - 2;
			for (int k = 0; k < int_3 / 8; k++)
			{
				int num9 = 0;
				int num10 = 0;
				while ((uint)num8 >> num10 != 0u)
				{
					if (((uint)num8 >> num10 & (ulong)k) != 0uL)
					{
						num9 |= 1 << num10;
					}
					num10++;
				}
				int_2[k * 2] = (~num9 & num7);
				int_2[k * 2 + 1] = num9;
			}
			float_1 = 4f / int_3;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void method_1(float[] float_4, float[] float_5)
		{
			if (float_2.Length < int_0 / 2)
			{
				float_2 = new float[int_0 / 2];
			}
			if (float_3.Length < int_0 / 2)
			{
				float_3 = new float[int_0 / 2];
			}
			float[] array = float_2;
			float[] float_6 = float_3;
			int num = (int)((uint)int_0 >> 1);
			int num2 = (int)((uint)int_0 >> 2);
			int num3 = (int)((uint)int_0 >> 3);
			int num4 = 1;
			int num5 = 0;
			int num6 = num;
			for (int i = 0; i < num3; i++)
			{
				num6 -= 2;
				array[num5++] = -float_4[num4 + 2] * float_0[num6 + 1] - float_4[num4] * float_0[num6];
				array[num5++] = float_4[num4] * float_0[num6 + 1] - float_4[num4 + 2] * float_0[num6];
				num4 += 4;
			}
			num4 = num - 4;
			for (int i = 0; i < num3; i++)
			{
				num6 -= 2;
				array[num5++] = float_4[num4] * float_0[num6 + 1] + float_4[num4 + 2] * float_0[num6];
				array[num5++] = float_4[num4] * float_0[num6] - float_4[num4 + 2] * float_0[num6 + 1];
				num4 -= 4;
			}
			float[] array2 = method_2(array, float_6, int_0, num, num2, num3);
			int num7 = 0;
			int num8 = num;
			int num9 = num2;
			int num10 = num9 - 1;
			int num11 = num2 + num;
			int num12 = num11 - 1;
			for (int j = 0; j < num2; j++)
			{
				float num13 = array2[num7] * float_0[num8 + 1] - array2[num7 + 1] * float_0[num8];
				float num14 = -(array2[num7] * float_0[num8] + array2[num7 + 1] * float_0[num8 + 1]);
				float_5[num9] = -num13;
				float_5[num10] = num13;
				float_5[num11] = num14;
				float_5[num12] = num14;
				num9++;
				num10--;
				num11++;
				num12--;
				num7 += 2;
				num8 += 2;
			}
		}

		public float[] method_2(float[] float_4, float[] float_5, int int_3, int int_4, int int_5, int int_6)
		{
			int num = int_5;
			int num2 = 0;
			int num3 = int_4;
			for (int i = 0; i < int_5; i++)
			{
				float num4 = float_4[num] - float_4[num2];
				float_5[int_5 + i] = float_4[num++] + float_4[num2++];
				float num5 = float_4[num] - float_4[num2];
				num3 -= 4;
				float_5[i++] = num4 * float_0[num3] + num5 * float_0[num3 + 1];
				float_5[i] = num5 * float_0[num3] - num4 * float_0[num3 + 1];
				float_5[int_5 + i] = float_4[num++] + float_4[num2++];
			}
			for (int j = 0; j < int_1 - 3; j++)
			{
				int num6 = (int)((uint)int_3 >> j + 2);
				int num7 = 1 << j + 3;
				int num8 = int_4 - 2;
				num3 = 0;
				int num9 = 0;
				while (num9 < (uint)num6 >> 2)
				{
					int num10 = num8;
					int num11 = num10 - (num6 >> 1);
					float num12 = float_0[num3];
					float num13 = float_0[num3 + 1];
					num8 -= 2;
					num6++;
					for (int k = 0; k < 2 << j; k++)
					{
						float num14 = float_5[num10] - float_5[num11];
						float_4[num10] = float_5[num10] + float_5[num11];
						float num15 = float_5[++num10] - float_5[++num11];
						float_4[num10] = float_5[num10] + float_5[num11];
						float_4[num11] = num15 * num12 - num14 * num13;
						float_4[num11 - 1] = num14 * num12 + num15 * num13;
						num10 -= num6;
						num11 -= num6;
					}
					num6--;
					num3 += num7;
					num9++;
				}
				float[] array = float_5;
				float_5 = float_4;
				float_4 = array;
			}
			int num16 = int_3;
			int num17 = 0;
			int num18 = 0;
			int num19 = int_4 - 1;
			for (int l = 0; l < int_6; l++)
			{
				int num20 = int_2[num17++];
				int num21 = int_2[num17++];
				float num22 = float_5[num20] - float_5[num21 + 1];
				float num23 = float_5[num20 - 1] + float_5[num21];
				float num24 = float_5[num20] + float_5[num21 + 1];
				float num25 = float_5[num20 - 1] - float_5[num21];
				float num26 = num22 * float_0[num16];
				float num27 = num23 * float_0[num16++];
				float num28 = num22 * float_0[num16];
				float num29 = num23 * float_0[num16++];
				float_4[num18++] = (num24 + num28 + num27) * 0.5f;
				float_4[num19--] = (-num25 + num29 - num26) * 0.5f;
				float_4[num18++] = (num25 + num29 - num26) * 0.5f;
				float_4[num19--] = (num24 - num28 - num27) * 0.5f;
			}
			return float_4;
		}
	}
}
