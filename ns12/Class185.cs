using System;
using System.IO;

namespace ns12
{
	public class Class185 : Interface8
	{
		private static readonly char[] char_0;

		private static readonly char[] char_1;

		static Class185()
		{
			var invalidPathChars = Path.GetInvalidPathChars();
			var num = invalidPathChars.Length + 2;
			char_1 = new char[num];
			Array.Copy(invalidPathChars, 0, char_1, 0, invalidPathChars.Length);
			char_1[num - 1] = '*';
			char_1[num - 2] = '?';
			num = invalidPathChars.Length + 4;
			char_0 = new char[num];
			Array.Copy(invalidPathChars, 0, char_0, 0, invalidPathChars.Length);
			char_0[num - 1] = ':';
			char_0[num - 2] = '\\';
			char_0[num - 3] = '*';
			char_0[num - 4] = '?';
		}
	}
}
