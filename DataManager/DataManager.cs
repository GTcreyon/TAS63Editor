using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataManagerCore
{
	public static class DataManager
	{
		public static IReadOnlyList<IReadOnlyList<string>> LoadFile(string path, bool extract)
		{
			var content = File.ReadAllText(path);
			if (extract)
			{
				content = ExtractSol(content);
			}
			int format;
			if(content[0] == '{')
			{
				var metaIndex = content.IndexOf('}');
				var a = content.Substring(1, metaIndex - 1);
				format = int.Parse(content.Substring(1, metaIndex - 1));
				content = content.Substring(metaIndex + 1);
			}
			else
			{
				format = 0;
			}
			var segments = content.Split('/').Select(x => x.Split('#').ToList()).ToList();
			if (format > 0)
			{
				segments = segments.DecompressData();
			}
			return segments;
		}

		private static List<List<string>> DecompressData(this List<List<string>> segments)
		{
			var keys = segments[0];
			var mouse = segments[1];
			var rng = segments[2];
			for (int i = 0; i < keys.Count; i++)
			{
				var element = keys[i];
				var astIndex = element.IndexOf('*');
				if (astIndex >= 0)
				{
					var part = element.Substring(0, astIndex);
					int multiplier = int.Parse(element.Substring(astIndex + 1));
					for (int r = 0; r < multiplier + 1; r++)
					{
						keys.Insert(i + 1, part);
					}
					keys[i] = part;
					i += multiplier;
				}
			}
			for (int i = 0; i < mouse.Count; i++)
			{
				mouse[i] = mouse[i].Insert(1, ",");
				var element = mouse[i];
				var astIndex = element.IndexOf('*');
				if (astIndex >= 0)
				{
					var part = element.Substring(0, astIndex);
					int multiplier = int.Parse(element.Substring(astIndex + 1));
					for (int r = 0; r < multiplier + 1; r++)
					{
						mouse.Insert(i + 1, part);
					}
					mouse[i] = part;
					i += multiplier + 1;
				}
			}
			var output = new List<List<string>>
			{
				keys,
				mouse,
				rng,
			};
			return output;
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
					data[i] = data[i].Replace("_", "");
					multiplier = 0;
					i++;
					collapseIndex = i;
				}
				else
				{
					data[i] = data[i].Replace("_", "");
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
			File.WriteAllText(path, "{1}" + string.Join("#", CompressData(keys)) + "/" + string.Join("#", CompressMouse(mouse)) + "/" + string.Join("#", rng));
		}
	}
}
