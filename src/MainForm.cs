/*
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@gmail.com>
 *
 * The MIT License (MIT)
 * 
 * Copyright (C) 2015 Zongsoft Corporation <http://www.zongsoft.com>
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Zongsoft.Regular
{
	public partial class MainForm : Form
	{
		#region 私有变量
		private RegexOptions _regexOptions;
		private int _position;
		private string _fileName;
		#endregion

		#region 构造函数
		public MainForm()
		{
			InitializeComponent();

			_regexOptions = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.ExplicitCapture;
		}
		#endregion

		#region 事件处理
		private void FMain_Load(object sender, EventArgs e)
		{
			chkOptionsIgnoreCase.DataBindings.Add(this.GetRegexOptionsBinding());
			chkOptionsIgnorePatternWhitespace.DataBindings.Add(this.GetRegexOptionsBinding());
			chkOptionsMultiline.DataBindings.Add(this.GetRegexOptionsBinding());
			chkOptionsSingleline.DataBindings.Add(this.GetRegexOptionsBinding());
			chkOptionsExplicitCapture.DataBindings.Add(this.GetRegexOptionsBinding());
		}

		private void FMain_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.F5)
				btnMatch.PerformClick();
		}

		private void btnMatch_Click(object sender, EventArgs e)
		{
			var pattern = txtPattern.SelectionLength > 0 ? txtPattern.SelectedText : txtPattern.Text;
			var input = txtInput.SelectionLength > 0 ? txtInput.SelectedText : txtInput.Text;

			if(string.IsNullOrEmpty(pattern))
			{
				MessageBox.Show("未指定正则表达式，请输入正确的正则表达式。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtPattern.Focus();
				return;
			}

			if(string.IsNullOrEmpty(input))
			{
				MessageBox.Show("未指定输入文本，请在输入框内指定有效的文本内容。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtInput.Focus();
				return;
			}

			_position = txtInput.SelectionLength > 0 ? txtInput.SelectionStart : 0;

			try
			{
				this.Cursor = Cursors.WaitCursor;

				tvwResult.Nodes.Clear();
				tvwResult.BeginUpdate();

				var regex = GenerateRegex(pattern);
				var match = regex.Match(input);

				while(match.Success)
				{
					if(match.Value.Length > 0)
					{
						var matchNode = tvwResult.Nodes.Add(match.Value);
						matchNode.Tag = match;

						for(int i = 1; i < match.Groups.Count; i++)
						{
							var groupNode = matchNode.Nodes.Add(string.Format("{0}:{1}", regex.GroupNameFromNumber(i), match.Groups[i].Value));
							groupNode.Tag = match.Groups[i];

							if(match.Groups[i].Captures.Count > 1)
							{
								for(int j = 0; j < match.Groups[i].Captures.Count; j++)
								{
									var node = groupNode.Nodes.Add(match.Groups[i].Captures[j].Value);
									node.Tag = match.Groups[i].Captures[j];
								}
							}
						}
					}

					match = match.NextMatch();
				}

				if(tvwResult.Nodes.Count > 0)
				{
					if(tvwResult.Nodes.Count == 1)
						tvwResult.Nodes[0].Expand();

					tvwResult.Focus();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("发生错误：" + Environment.NewLine + ex.Message,
								ex.GetType().FullName,
								MessageBoxButtons.OK, MessageBoxIcon.Error);

				txtPattern.Focus();
			}
			finally
			{
				this.Cursor = Cursors.Default;
				tvwResult.EndUpdate();
			}
		}

		private void tvwResult_AfterSelect(object sender, TreeViewEventArgs e)
		{
			lblCaptureIndex.Text = string.Empty;
			lblCaptureLength.Text = string.Empty;
			lblCaptureValue.Text = string.Empty;

			if(e.Node != null)
			{
				Capture capture = e.Node.Tag as Capture;

				if(capture != null)
				{
					lblCaptureIndex.Text = (_position + capture.Index).ToString();
					lblCaptureLength.Text = capture.Length.ToString();
					lblCaptureValue.Text = capture.Value;

					txtInput.Select(_position + capture.Index, capture.Length);
				}
			}
		}

		private void mnuFileNew_Click(object sender, EventArgs e)
		{
			if(txtPattern.TextLength > 0)
			{
				if(MessageBox.Show("您确认要新建文件么？" + Environment.NewLine + Environment.NewLine + "注意：如果确认新建则当前模式文本的更改将丢失，如果需要保存的话请先执行保存操作。", "新建文件", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
					return;
			}

			_fileName = null;
			txtPattern.Clear();
		}

		private void mnuFileOpen_Click(object sender, EventArgs e)
		{
			using(var dialog = new OpenFileDialog())
			{
				dialog.CheckFileExists = true;
				dialog.CheckPathExists = true;
				dialog.DefaultExt = ".txt";
				dialog.Filter = "文本文件(*.txt)|*.txt";

				if(dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
					txtPattern.Text = File.ReadAllText(dialog.FileName);
					_fileName = dialog.FileName;
				}
			}
		}

		private void mnuFileSave_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(_fileName))
				mnuFileSaveAs.PerformClick();
			else
				File.WriteAllText(_fileName, txtPattern.Text);
		}

		private void mnuFileSaveAs_Click(object sender, EventArgs e)
		{
			using(var dialog = new SaveFileDialog())
			{
				dialog.AddExtension = true;
				dialog.CreatePrompt = true;
				dialog.CheckPathExists = true;
				dialog.DefaultExt = ".txt";
				dialog.Filter = "文本文件(*.txt)|*.txt";
				dialog.FileName = Path.GetFileName(_fileName);

				if(dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
					File.WriteAllText(dialog.FileName, txtPattern.Text);
					_fileName = dialog.FileName;
				}
			}
		}

		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mnuEditUndo_Click(object sender, EventArgs e)
		{
			var editor = this.GetFocusedControl() as TextBoxBase;

			if(editor != null && editor.CanUndo)
				editor.Undo();
		}

		private void mnuEditCut_Click(object sender, EventArgs e)
		{
			var editor = this.GetFocusedControl() as TextBoxBase;

			if(editor != null && editor.SelectionLength > 0)
				editor.Cut();
		}

		private void mnuEditCopy_Click(object sender, EventArgs e)
		{
			var editor = this.GetFocusedControl() as TextBoxBase;

			if(editor != null && editor.SelectionLength > 0)
				editor.Copy();
		}

		private void mnuEditPaste_Click(object sender, EventArgs e)
		{
			var editor = this.GetFocusedControl() as TextBoxBase;

			if(editor != null)
				editor.Paste();
		}

		private void mnuEditSelectAll_Click(object sender, EventArgs e)
		{
			var editor = this.GetFocusedControl() as TextBoxBase;

			if(editor != null)
				editor.SelectAll();
		}

		private void mnuHelpAbout_Click(object sender, EventArgs e)
		{
			using(AboutDialog dialog = new AboutDialog())
			{
				dialog.ShowDialog(this);
			}
		}

		private void mnuToolsOptions_Click(object sender, EventArgs e)
		{
			MessageBox.Show("正则选项值：" + Environment.NewLine + _regexOptions.ToString() + Environment.NewLine + Environment.NewLine +
				"本版本不支持选项设置，敬请关注最新升级版本。",
				"系统选项",
				MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		#endregion

		#region 选项绑定
		private Binding GetRegexOptionsBinding()
		{
			var binding = new Binding("Checked", _regexOptions, "", true, DataSourceUpdateMode.OnPropertyChanged);
			binding.Format += new ConvertEventHandler(RegexOptionsBinding_Format);
			binding.Parse += new ConvertEventHandler(RegexOptionsBinding_Parse);
			return binding;
		}

		private void RegexOptionsBinding_Format(object sender, ConvertEventArgs e)
		{
			if(e.DesiredType == typeof(bool))
			{
				var binding = (Binding)sender;

				if(binding.Control == chkOptionsIgnoreCase)
					e.Value = (((RegexOptions)e.Value) & RegexOptions.IgnoreCase) == RegexOptions.IgnoreCase;
				else if(binding.Control == chkOptionsIgnorePatternWhitespace)
					e.Value = (((RegexOptions)e.Value) & RegexOptions.IgnorePatternWhitespace) == RegexOptions.IgnorePatternWhitespace;
				else if(binding.Control == chkOptionsMultiline)
					e.Value = (((RegexOptions)e.Value) & RegexOptions.Multiline) == RegexOptions.Multiline;
				else if(binding.Control == chkOptionsSingleline)
					e.Value = (((RegexOptions)e.Value) & RegexOptions.Singleline) == RegexOptions.Singleline;
				else if(binding.Control == chkOptionsExplicitCapture)
					e.Value = (((RegexOptions)e.Value) & RegexOptions.ExplicitCapture) == RegexOptions.ExplicitCapture;
			}
		}

		private void RegexOptionsBinding_Parse(object sender, ConvertEventArgs e)
		{
			if(e.DesiredType == typeof(RegexOptions))
			{
				var binding = (Binding)sender;

				if(binding.Control == chkOptionsIgnoreCase)
					e.Value = (bool)e.Value ? (_regexOptions | RegexOptions.IgnoreCase) : (_regexOptions & (~RegexOptions.IgnoreCase));
				else if(binding.Control == chkOptionsIgnorePatternWhitespace)
					e.Value = (bool)e.Value ? (_regexOptions | RegexOptions.IgnorePatternWhitespace) : (_regexOptions & (~RegexOptions.IgnorePatternWhitespace));
				else if(binding.Control == chkOptionsMultiline)
					e.Value = (bool)e.Value ? (_regexOptions | RegexOptions.Multiline) : (_regexOptions & (~RegexOptions.Multiline));
				else if(binding.Control == chkOptionsSingleline)
					e.Value = (bool)e.Value ? (_regexOptions | RegexOptions.Singleline) : (_regexOptions & (~RegexOptions.Singleline));
				else if(binding.Control == chkOptionsExplicitCapture)
					e.Value = (bool)e.Value ? (_regexOptions | RegexOptions.ExplicitCapture) : (_regexOptions & (~RegexOptions.ExplicitCapture));

				_regexOptions = (RegexOptions)e.Value;
			}
		}
		#endregion

		#region 私有方法
		private Regex GenerateRegex(string pattern)
		{
			return new Regex(pattern, _regexOptions);
		}

		private Control GetFocusedControl()
		{
			var control = this.ActiveControl;

			while(control is ContainerControl)
			{
				control = ((ContainerControl)control).ActiveControl;
			}

			return control;
		}
		#endregion
	}
}
