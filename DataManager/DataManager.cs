using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataManagerCore
{
	public class DataManager
	{
		private readonly List<string> _keyInputs;
		private readonly List<string> _mouseInputs;
		private readonly List<string> _rngInputs;

		public DataManager(string path)
		{
			var content = File.ReadAllText(path);
			var segments = content.Split('/');
			_keyInputs = segments[0].Split('#').ToList();
			_mouseInputs = segments[1].Split('#').ToList();
			_rngInputs = segments[2].Split('#').ToList();
		}

		public IReadOnlyList<string> ReadKeys()
		{
			return _keyInputs;
		}

		public void SaveTxt(string path, List<string> keys)
		{
			File.WriteAllText(path, string.Join("#", keys) + "/" + string.Join("#", _mouseInputs) + "/" + string.Join("#", _rngInputs));
		}
	}
}
