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

		private static IReadOnlyList<string> CompressData(List<string> data)
		{
			var multiplier = 0;
			var collapseIndex = 0;
			int i = 0;
			while (i < data.Count)
			{
				if (i < data.Count - 1 && data[i] == data[i + 1])
				{
					data.RemoveAt(i + 1);
					multiplier++;
				}
				else if (multiplier > 0)
				{
					i = collapseIndex;
					data[i] = $"{data[i]}*{multiplier - 1}";
					multiplier = 0;
					i++;
					collapseIndex = i;
				}
				else
				{
					i++;
					collapseIndex = i;
				}
			}
			return data;
		}

		private static IReadOnlyList<string> CompressMouse(List<string> mouse)
		{
			CompressData(mouse); //Somewhat inefficient, but much cleaner
			return mouse.Select(x => x.Remove(1, 1)).ToList(); //Remove first comma, unneeded
		}

		public static void SaveTxt(string path, List<string> keys, List<string> mouse, List<string> rng)
		{
			File.WriteAllText(path, string.Join("#", CompressData(keys)) + "/" + string.Join("#", CompressMouse(mouse)) + "/" + string.Join("#", rng));
		}
	}
}
