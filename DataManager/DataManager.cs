using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataManagerCore
{
	public static class DataManager
	{
		public static IReadOnlyList<string>[] LoadFile(string path, bool extract)
		{
			var content = File.ReadAllText(path);
			if (extract)
			{
				content = ExtractSol(content);
			}
			var segments = content.Split('/').Select(x => x.Split('#')).ToArray();
			return segments;
		}

		private static string ExtractSol(string content)
		{
			return content.Substring(36, content.Length-1 - 36);
		}

		public static void SaveTxt(string path, List<string> keys, List<string> mouse, List<string> rng)
		{
			File.WriteAllText(path, string.Join("#", keys) + "/" + string.Join("#", mouse) + "/" + string.Join("#", rng));
		}
	}
}
