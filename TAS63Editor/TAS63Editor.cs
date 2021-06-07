using DataManagerCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAS63Editor
{
	public partial class TAS63Editor : Form
	{
		private DataManager _dataManager;
		private List<char> _inputKeys = new List<char>() { 'U', 'D', 'L', 'R', 'Z', 'X', 'C', 'P', 'S', ';', '-', '+'};
		private int _columnOffset = 0;
		private bool _editingList = false;

		public TAS63Editor()
		{
			KeyPreview = true;
			_dataManager = new DataManager(@"C:\Users\Tricia\source\repos\TAS63Editor\DataManager.Tests\TestFiles\test.txt");
			InitializeComponent();
		}

		private void TAS63Editor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Alt)
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
				}
			}
			switch (e.KeyCode)
			{
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
			if (e.Modifiers == Keys.Shift)
			{
				SCheck.Checked = !SCheck.Checked;
			}
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

		private void TAS63Editor_Load(object sender, EventArgs e)
		{
			var keys = _dataManager.ReadKeys();
			var index = -1;
			_columnOffset = (int)Math.Log10(keys.Count) + 1;

			var indexedKeyInputs = keys.Select(x => FormatInputs(x))
			.Select(x => {
				index++;
				return string.Format($"{{0,{-_columnOffset}}}: {{1}}", index, x);
			})
			.ToArray();

			InputsBox.Items.AddRange(indexedKeyInputs);
		}

		private void UpdateInputString(char chr, bool check)
		{
			char[] ch = InputsBox.SelectedItem.ToString().ToCharArray();
			var offset = _inputKeys.IndexOf(chr);
			ch[_columnOffset + 2 + offset] = check ? chr : '_';
			string newstring = new string(ch);
			int index = InputsBox.Items.IndexOf(InputsBox.SelectedItem);
			_editingList = true; //TODO: hack solution, fix
			InputsBox.Items.RemoveAt(index);
			InputsBox.Items.Insert(index, newstring);
			InputsBox.SelectedIndex = index;
			_editingList = false;
		}

		private void InputsBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_editingList)
			{
				UCheck.Checked = InputsBox.SelectedItem.ToString().Contains('U');
				DCheck.Checked = InputsBox.SelectedItem.ToString().Contains('D');
				LCheck.Checked = InputsBox.SelectedItem.ToString().Contains('L');
				RCheck.Checked = InputsBox.SelectedItem.ToString().Contains('R');
				ZCheck.Checked = InputsBox.SelectedItem.ToString().Contains('Z');
				XCheck.Checked = InputsBox.SelectedItem.ToString().Contains('X');
				CCheck.Checked = InputsBox.SelectedItem.ToString().Contains('C');
				PCheck.Checked = InputsBox.SelectedItem.ToString().Contains('P');
				SCheck.Checked = InputsBox.SelectedItem.ToString().Contains('S');
				SemiCheck.Checked = InputsBox.SelectedItem.ToString().Contains(';');
				MinusCheck.Checked = InputsBox.SelectedItem.ToString().Contains('-');
				PlusCheck.Checked = InputsBox.SelectedItem.ToString().Contains('+');
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

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}
	}
}
