using DataManagerCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAS63Editor
{
	public partial class TAS63Editor : Form
	{
		private List<char> _inputKeys = new List<char>() { 'U', 'D', 'L', 'R', 'Z', 'X', 'C', 'P', 'S', ';', '-', '+'};
		private int _columnOffsetInputs = 0;
		private int _columnOffsetRng = 0;
		private bool _editingList = false;
		private bool _selecting = false;
		private Random _rand = new Random();
		private string _saveDir = null;

		public TAS63Editor()
		{
			KeyPreview = true;
			InitializeComponent();
		}

		private void TAS63Editor_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Up:
					UCheck.Checked = !UCheck.Checked;
					break;
				case Keys.Down:
					DCheck.Checked = !DCheck.Checked;
					break;
				case Keys.Left:
					LCheck.Checked = !LCheck.Checked;
					break;
				case Keys.Right:
					RCheck.Checked = !RCheck.Checked;
					break;
				case Keys.Z:
					ZCheck.Checked = !ZCheck.Checked;
					break;
				case Keys.X:
					XCheck.Checked = !XCheck.Checked;
					break;
				case Keys.C:
					CCheck.Checked = !CCheck.Checked;
					break;
				case Keys.P:
					PCheck.Checked = !PCheck.Checked;
					break;
				case Keys.S:
					SCheck.Checked = !SCheck.Checked;
					break;
				case Keys.OemSemicolon:
					SemiCheck.Checked = !SemiCheck.Checked;
					break;
				case Keys.OemMinus:
					MinusCheck.Checked = !MinusCheck.Checked;
					break;
				case Keys.Oemplus:
					PlusCheck.Checked = !PlusCheck.Checked;
					break;
			}
			e.Handled = true;
		}

		private string FormatInputs(string str)
		{
			var newStr = "";
			
			foreach (char input in _inputKeys)
			{
				if (str.Contains(input))
				{
					newStr += input;
				}
				else
				{
					newStr += '_';
				}
			}
			return newStr;
		}

		private void LoadInputs(string path, bool extract)
		{
			InputsBox.Items.Clear();
			RngBox.Items.Clear();
			var data = DataManager.LoadFile(path, extract);
			var keys = data[0];
			var mouse = data[1];
			var rng = data[2];
			for (int i = 0; i < keys.Count; i++)
			{
				InputsBox.Items.Add($"{keys[i]}({mouse[i]})");
			}
			RngBox.Items.AddRange(rng.ToArray());
			FixInputIndexes();
			FixRngIndexes();
		}

		private void TAS63Editor_Load(object sender, EventArgs e)
		{
			//LoadInputs();
		}

		private void UpdateInputString(char chr, bool check)
		{
			if (InputsBox.SelectedIndex != -1 && !_selecting)
			{
				var copyList = InputsBox.SelectedItems.Cast<string>().ToList();
				foreach (var item in copyList)
				{
					char[] ch = item.ToString().ToCharArray();
					var offset = _inputKeys.IndexOf(chr);
					ch[_columnOffsetInputs + 2 + offset] = check ? chr : '_';
					string newstring = new string(ch);
					int index = InputsBox.Items.IndexOf(item);
					_editingList = true; //TODO: hack solution, fix
					InputsBox.Items.RemoveAt(index);
					InputsBox.Items.Insert(index, newstring);
					InputsBox.SelectedIndex = index;
					_editingList = false;
				}
				
			}
		}

		private void InputsBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_editingList)
			{
				var inputString = InputsBox.SelectedItem.ToString();
				_selecting = true;
				UCheck.Checked = inputString.Contains('U');
				DCheck.Checked = inputString.Contains('D');
				LCheck.Checked = inputString.Contains('L');
				RCheck.Checked = inputString.Contains('R');
				ZCheck.Checked = inputString.Contains('Z');
				XCheck.Checked = inputString.Contains('X');
				CCheck.Checked = inputString.Contains('C');
				PCheck.Checked = inputString.Contains('P');
				SCheck.Checked = inputString.Contains('S');
				SemiCheck.Checked = inputString.Contains(';');
				MinusCheck.Checked = inputString.Contains('-');
				PlusCheck.Checked = inputString.Contains('+');
				MouseCheck.Checked = inputString[16 + _columnOffsetInputs] == '1';
				var mouseArray = inputString.Substring(18 + _columnOffsetInputs).Replace(")", "").Split(',');
				MouseXTextbox.Text = mouseArray[0];
				MouseYTextbox.Text = mouseArray[1];
				_selecting = false;
			}
		}

		private void UCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('U', UCheck.Checked);
		}

		private void DCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('D', DCheck.Checked);
		}

		private void LCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('L', LCheck.Checked);
		}

		private void RCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('R', RCheck.Checked);
		}

		private void ZCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('Z', ZCheck.Checked);
		}

		private void XCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('X', XCheck.Checked);
		}

		private void CCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('C', CCheck.Checked);
		}

		private void PCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('P', PCheck.Checked);
		}

		private void SCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('S', SCheck.Checked);
		}

		private void SemiCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString(';', SemiCheck.Checked);
		}

		private void MinusCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('-', MinusCheck.Checked);
		}

		private void PlusCheck_CheckedChanged(object sender, EventArgs e)
		{
			UpdateInputString('+', PlusCheck.Checked);
		}

		private void MouseXTextbox_TextChanged(object sender, EventArgs e)
		{
			if (InputsBox.SelectedIndex != -1 && !_selecting)
			{
				var copyList = InputsBox.SelectedItems.Cast<string>().ToList();
				foreach (var item in copyList)
				{
					var regex = new Regex(@",.*,");
					var newString = regex.Replace(item.ToString(), $",{MouseXTextbox.Text},");
					int index = InputsBox.Items.IndexOf(item);
					_editingList = true;
					InputsBox.Items.RemoveAt(index);
					InputsBox.Items.Insert(index, newString);
					InputsBox.SelectedIndices.Add(index);
					_editingList = false;
				}
				
			}
		}

		private void MouseYTextbox_TextChanged(object sender, EventArgs e)
		{
			if (InputsBox.SelectedIndex != -1 && !_selecting)
			{
				var copyList = InputsBox.SelectedItems.Cast<string>().ToList();
				foreach (var item in copyList)
				{
					var regex = new Regex(@",[0-9-]*\)");
					var newString = regex.Replace(item.ToString(), $",{MouseYTextbox.Text})");
					int index = InputsBox.Items.IndexOf(item);
					_editingList = true;
					InputsBox.Items.RemoveAt(index);
					InputsBox.Items.Insert(index, newString);
					InputsBox.SelectedIndices.Add(index);
					_editingList = false;
				}
			}
		}

		private void MouseCheck_CheckedChanged(object sender, EventArgs e)
		{
			var copyList = InputsBox.SelectedItems.Cast<string>().ToList();
			foreach (var item in copyList)
			{
				char[] ch = item.ToString().ToCharArray();
				ch[_columnOffsetInputs + 16] = MouseCheck.Checked ? '1' : '0';
				string newstring = new string(ch);
				int index = InputsBox.Items.IndexOf(item);
				_editingList = true; //TODO: hack solution, fix
				InputsBox.Items.RemoveAt(index);
				InputsBox.Items.Insert(index, newstring);
				InputsBox.SelectedIndices.Add(index);
				_editingList = false;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InputsBox.Items.Clear();
			RngBox.Items.Clear();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"TAS63 Editor\nVersion: {Application.ProductVersion}\nContact: creyon#1828", "About");
		}

		private void githubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/GTcreyon/TAS63Editor");
			Process.Start(sInfo);
		}

		private void discordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo("https://discord.gg/0106azhFbCc9eAUuq");
			Process.Start(sInfo);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveAs = new SaveFileDialog
			{
				InitialDirectory = @"C:\",
				Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
			};

			if (saveAs.ShowDialog() == DialogResult.OK)
			{
				_saveDir = saveAs.FileName;
				SaveData(_saveDir);
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog
			{
				InitialDirectory = @"C:\",
				Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
			};

			if (open.ShowDialog() == DialogResult.OK)
			{
				_saveDir = open.FileName;
				LoadInputs(open.FileName, false);
			}
		}

		private void FixInputIndexes()
		{
			var items = InputsBox.Items.Cast<string>();
			var index = -1;
			_columnOffsetInputs = (int)Math.Log10(items.Count() <= 1 ? 1 : items.Count() - 1) + 1;
			var indexedInputs = items.Select(x => {
				index++;
				var bracketIndex = x.IndexOf("(");
				string mousePart;
				string keysPart;
				if (bracketIndex > 0)
				{
					mousePart = x.Substring(bracketIndex);
					keysPart = x.Substring(0, bracketIndex);
				}
				else
				{
					mousePart = x;
					keysPart = "";
				}
				return string.Format($"{{0,{-_columnOffsetInputs}}}: {{1}} {{2}}", index, FormatInputs(keysPart), mousePart);
			})
			.ToArray();

			InputsBox.Items.Clear();
			InputsBox.Items.AddRange(indexedInputs);
		}

		private void FixRngIndexes()
		{
			var items = RngBox.Items.Cast<string>();
			var index = -1;
			_columnOffsetRng = (int)Math.Log10(items.Count() <= 1 ? 1 : items.Count() - 1) + 1;
			var indexedEvents = items.Select(x => {
				index++;
				if (x.Contains(':'))
				{
					x = x.Substring(x.IndexOf(':') + 2);
				}
				return string.Format($"{{0,{-_columnOffsetRng}}}: {{1}}", index, x);
			})
			.ToArray();

			RngBox.Items.Clear();
			RngBox.Items.AddRange(indexedEvents);
		}

		private void AddFrame_Click(object sender, EventArgs e)
		{
			var index = InputsBox.SelectedIndex == -1 ? 0 : InputsBox.SelectedIndex + 1;
			_editingList = true;
			InputsBox.Items.Insert(index, string.Format($"{{0,{-_columnOffsetInputs}}}: {{1}} (0,0,0)", index, FormatInputs("")));
			FixInputIndexes();
			
			_editingList = false;
			InputsBox.SelectedIndex = index;
		}

		private void RemoveFrame_Click(object sender, EventArgs e)
		{
			if (InputsBox.SelectedIndex != -1)
			{
				var index = InputsBox.SelectedIndex;
				_editingList = true;
				var copyList = InputsBox.SelectedItems.Cast<string>().ToList();
				foreach (var item in copyList)
				{
					InputsBox.Items.Remove(item);
				}
				
				FixInputIndexes();
				
				_editingList = false;
				InputsBox.SelectedIndex = index - 1;
			}
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog
			{
				InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Macromedia\Flash Player\#SharedObjects"),
				Filter = "SharedObject Files (*.sol)|*.sol|All files (*.*)|*.*",
			};

			if (open.ShowDialog() == DialogResult.OK)
			{
				LoadInputs(open.FileName, true);
			}
		}

		private void RandomButton_Click(object sender, EventArgs e)
		{
			RngValue.Value = _rand.Next(1000);
		}

		private void AddEvent_Click(object sender, EventArgs e)
		{
			var index = RngBox.SelectedIndex == -1 ? 0 : RngBox.SelectedIndex + 1;
			_editingList = true;
			RngBox.Items.Insert(index, _rand.Next(1000).ToString());
			FixRngIndexes();
			_editingList = false;
			RngBox.SelectedIndex = index;
		}

		private void RemoveEvent_Click(object sender, EventArgs e)
		{
			if (RngBox.SelectedIndex != -1)
			{
				var index = RngBox.SelectedIndex;
				_editingList = true;
				RngBox.Items.RemoveAt(index);
				FixRngIndexes();
				_editingList = false;
				RngBox.SelectedIndex = index - 1;
			}
		}

		private void RngBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_editingList)
			{
				RngValue.Value = decimal.Parse(RngBox.SelectedItem.ToString().Substring(RngBox.SelectedItem.ToString().IndexOf(':') + 2));
			}
		}

		private void RngValue_ValueChanged(object sender, EventArgs e)
		{
			if (RngBox.SelectedIndex != -1)
			{
				int index = RngBox.Items.IndexOf(RngBox.SelectedItem);
				_editingList = true;
				RngBox.Items.RemoveAt(index);
				RngBox.Items.Insert(index, string.Format($"{{0,{-_columnOffsetRng}}}: {{1}}", index, RngValue.Value.ToString()));
				RngBox.SelectedIndex = index;
				_editingList = false;
			}
		}

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			var index = RngBox.SelectedIndex + 1;
			_editingList = true;
			for (int i = 0; i < GenerateCount.Value; i++)
			{
				RngBox.Items.Insert(index, _rand.Next(1000).ToString());
			}
			FixRngIndexes();
			RngBox.SelectedIndex = index - 1;
			_editingList = false;
		}

		private void DuplicateFrame_Click(object sender, EventArgs e)
		{
			var index = InputsBox.SelectedIndex == -1 ? 0 : InputsBox.SelectedIndex + 1;
			_editingList = true;
			InputsBox.Items.Insert(index, InputsBox.SelectedItem);
			FixInputIndexes();
			_editingList = false;
			InputsBox.SelectedIndex = index;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_saveDir == null)
			{
				SaveFileDialog saveAs = new SaveFileDialog
				{
					InitialDirectory = @"C:\",
					Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
				};

				if (saveAs.ShowDialog() == DialogResult.OK)
				{
					_saveDir = saveAs.FileName;
					SaveData(_saveDir);
				}
			}
			else
			{
				SaveData(_saveDir);
			}
		}

		private void SaveData(string dir)
		{
			var mouse = InputsBox.Items.Cast<string>()
				.Select(x => x.Substring(x.IndexOf("(") + 1).Replace(")", ""))
				.ToList();
			var keys = InputsBox.Items.Cast<string>()
				.Select(x => x.Substring(_columnOffsetInputs + 2, 12).Replace("_", ""))
				.ToList();
			var rng = RngBox.Items.Cast<string>()
				.Select(x => x.Substring(_columnOffsetRng + 2))
				.ToList();
			DataManager.SaveTxt(dir, keys, mouse, rng);
		}
	}
}
