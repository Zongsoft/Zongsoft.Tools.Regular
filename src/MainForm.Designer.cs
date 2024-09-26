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

namespace Zongsoft.Regular
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			mnuMain = new System.Windows.Forms.MenuStrip();
			mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
			mnuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
			mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
			mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			mnuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			mnuTools = new System.Windows.Forms.ToolStripMenuItem();
			mnuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
			mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			tlsDefault = new System.Windows.Forms.ToolStrip();
			newToolStripButton = new System.Windows.Forms.ToolStripButton();
			openToolStripButton = new System.Windows.Forms.ToolStripButton();
			saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			cutToolStripButton = new System.Windows.Forms.ToolStripButton();
			copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			stsMain = new System.Windows.Forms.StatusStrip();
			toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			lblCaptureIndex = new System.Windows.Forms.ToolStripStatusLabel();
			toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			lblCaptureLength = new System.Windows.Forms.ToolStripStatusLabel();
			toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			lblCaptureValue = new System.Windows.Forms.ToolStripStatusLabel();
			SplitContainer1 = new System.Windows.Forms.SplitContainer();
			chkOptionsExplicitCapture = new System.Windows.Forms.CheckBox();
			chkOptionsMultiline = new System.Windows.Forms.CheckBox();
			chkOptionsSingleline = new System.Windows.Forms.CheckBox();
			chkOptionsIgnorePatternWhitespace = new System.Windows.Forms.CheckBox();
			chkOptionsIgnoreCase = new System.Windows.Forms.CheckBox();
			txtPattern = new System.Windows.Forms.TextBox();
			btnMatch = new System.Windows.Forms.Button();
			lblPattern = new System.Windows.Forms.Label();
			SplitContainer2 = new System.Windows.Forms.SplitContainer();
			txtInput = new System.Windows.Forms.TextBox();
			lblInput = new System.Windows.Forms.Label();
			tvwResult = new System.Windows.Forms.TreeView();
			lblResult = new System.Windows.Forms.Label();
			_toolTip = new System.Windows.Forms.ToolTip(components);
			mnuMain.SuspendLayout();
			tlsDefault.SuspendLayout();
			stsMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer1).BeginInit();
			SplitContainer1.Panel1.SuspendLayout();
			SplitContainer1.Panel2.SuspendLayout();
			SplitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainer2).BeginInit();
			SplitContainer2.Panel1.SuspendLayout();
			SplitContainer2.Panel2.SuspendLayout();
			SplitContainer2.SuspendLayout();
			SuspendLayout();
			// 
			// mnuMain
			// 
			mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFile, mnuEdit, mnuTools, mnuHelp });
			mnuMain.Location = new System.Drawing.Point(0, 0);
			mnuMain.Name = "mnuMain";
			mnuMain.Size = new System.Drawing.Size(964, 25);
			mnuMain.TabIndex = 0;
			mnuMain.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFileNew, mnuFileOpen, toolStripSeparator2, mnuFileSave, mnuFileSaveAs, toolStripSeparator3, mnuFileExit });
			mnuFile.Name = "mnuFile";
			mnuFile.Size = new System.Drawing.Size(58, 21);
			mnuFile.Text = "文件(&F)";
			// 
			// mnuFileNew
			// 
			mnuFileNew.Image = (System.Drawing.Image)resources.GetObject("mnuFileNew.Image");
			mnuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			mnuFileNew.Name = "mnuFileNew";
			mnuFileNew.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
			mnuFileNew.Size = new System.Drawing.Size(165, 22);
			mnuFileNew.Text = "新建(&N)";
			mnuFileNew.Click += mnuFileNew_Click;
			// 
			// mnuFileOpen
			// 
			mnuFileOpen.Image = (System.Drawing.Image)resources.GetObject("mnuFileOpen.Image");
			mnuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			mnuFileOpen.Name = "mnuFileOpen";
			mnuFileOpen.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
			mnuFileOpen.Size = new System.Drawing.Size(165, 22);
			mnuFileOpen.Text = "打开(&O)";
			mnuFileOpen.Click += mnuFileOpen_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
			// 
			// mnuFileSave
			// 
			mnuFileSave.Image = (System.Drawing.Image)resources.GetObject("mnuFileSave.Image");
			mnuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			mnuFileSave.Name = "mnuFileSave";
			mnuFileSave.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
			mnuFileSave.Size = new System.Drawing.Size(165, 22);
			mnuFileSave.Text = "保存(&S)";
			mnuFileSave.Click += mnuFileSave_Click;
			// 
			// mnuFileSaveAs
			// 
			mnuFileSaveAs.Name = "mnuFileSaveAs";
			mnuFileSaveAs.Size = new System.Drawing.Size(165, 22);
			mnuFileSaveAs.Text = "另存为(&A)";
			mnuFileSaveAs.Click += mnuFileSaveAs_Click;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
			// 
			// mnuFileExit
			// 
			mnuFileExit.Name = "mnuFileExit";
			mnuFileExit.Size = new System.Drawing.Size(165, 22);
			mnuFileExit.Text = "退出(&X)";
			mnuFileExit.Click += mnuFileExit_Click;
			// 
			// mnuEdit
			// 
			mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuEditUndo, toolStripSeparator5, mnuEditCut, mnuEditCopy, mnuEditPaste, toolStripSeparator6, mnuEditSelectAll });
			mnuEdit.Name = "mnuEdit";
			mnuEdit.Size = new System.Drawing.Size(59, 21);
			mnuEdit.Text = "编辑(&E)";
			// 
			// mnuEditUndo
			// 
			mnuEditUndo.Name = "mnuEditUndo";
			mnuEditUndo.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
			mnuEditUndo.Size = new System.Drawing.Size(185, 22);
			mnuEditUndo.Text = "撤销(&U)";
			mnuEditUndo.Click += mnuEditUndo_Click;
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new System.Drawing.Size(182, 6);
			// 
			// mnuEditCut
			// 
			mnuEditCut.Image = (System.Drawing.Image)resources.GetObject("mnuEditCut.Image");
			mnuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			mnuEditCut.Name = "mnuEditCut";
			mnuEditCut.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
			mnuEditCut.Size = new System.Drawing.Size(185, 22);
			mnuEditCut.Text = "剪切(&T)";
			mnuEditCut.Click += mnuEditCut_Click;
			// 
			// mnuEditCopy
			// 
			mnuEditCopy.Image = (System.Drawing.Image)resources.GetObject("mnuEditCopy.Image");
			mnuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			mnuEditCopy.Name = "mnuEditCopy";
			mnuEditCopy.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
			mnuEditCopy.Size = new System.Drawing.Size(185, 22);
			mnuEditCopy.Text = "复制(&C)";
			mnuEditCopy.Click += mnuEditCopy_Click;
			// 
			// mnuEditPaste
			// 
			mnuEditPaste.Image = (System.Drawing.Image)resources.GetObject("mnuEditPaste.Image");
			mnuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			mnuEditPaste.Name = "mnuEditPaste";
			mnuEditPaste.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
			mnuEditPaste.Size = new System.Drawing.Size(185, 22);
			mnuEditPaste.Text = "粘贴(&P)";
			mnuEditPaste.Click += mnuEditPaste_Click;
			// 
			// toolStripSeparator6
			// 
			toolStripSeparator6.Name = "toolStripSeparator6";
			toolStripSeparator6.Size = new System.Drawing.Size(182, 6);
			// 
			// mnuEditSelectAll
			// 
			mnuEditSelectAll.Name = "mnuEditSelectAll";
			mnuEditSelectAll.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
			mnuEditSelectAll.Size = new System.Drawing.Size(185, 22);
			mnuEditSelectAll.Text = "选取所有(&A)";
			mnuEditSelectAll.Click += mnuEditSelectAll_Click;
			// 
			// mnuTools
			// 
			mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuToolsOptions });
			mnuTools.Name = "mnuTools";
			mnuTools.Size = new System.Drawing.Size(59, 21);
			mnuTools.Text = "工具(&T)";
			// 
			// mnuToolsOptions
			// 
			mnuToolsOptions.Name = "mnuToolsOptions";
			mnuToolsOptions.Size = new System.Drawing.Size(118, 22);
			mnuToolsOptions.Text = "选项(&O)";
			mnuToolsOptions.Click += mnuToolsOptions_Click;
			// 
			// mnuHelp
			// 
			mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuHelpAbout });
			mnuHelp.Name = "mnuHelp";
			mnuHelp.Size = new System.Drawing.Size(61, 21);
			mnuHelp.Text = "帮助(&H)";
			// 
			// mnuHelpAbout
			// 
			mnuHelpAbout.Name = "mnuHelpAbout";
			mnuHelpAbout.Size = new System.Drawing.Size(125, 22);
			mnuHelpAbout.Text = "关于(&A)...";
			mnuHelpAbout.Click += mnuHelpAbout_Click;
			// 
			// tlsDefault
			// 
			tlsDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator1, helpToolStripButton });
			tlsDefault.Location = new System.Drawing.Point(0, 28);
			tlsDefault.Name = "tlsDefault";
			tlsDefault.Size = new System.Drawing.Size(640, 25);
			tlsDefault.TabIndex = 1;
			tlsDefault.Text = "toolStrip1";
			tlsDefault.Visible = false;
			// 
			// newToolStripButton
			// 
			newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			newToolStripButton.Image = (System.Drawing.Image)resources.GetObject("newToolStripButton.Image");
			newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			newToolStripButton.Name = "newToolStripButton";
			newToolStripButton.Size = new System.Drawing.Size(23, 22);
			newToolStripButton.Text = "&New";
			// 
			// openToolStripButton
			// 
			openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			openToolStripButton.Image = (System.Drawing.Image)resources.GetObject("openToolStripButton.Image");
			openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			openToolStripButton.Name = "openToolStripButton";
			openToolStripButton.Size = new System.Drawing.Size(23, 22);
			openToolStripButton.Text = "&Open";
			// 
			// saveToolStripButton
			// 
			saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			saveToolStripButton.Image = (System.Drawing.Image)resources.GetObject("saveToolStripButton.Image");
			saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			saveToolStripButton.Name = "saveToolStripButton";
			saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			saveToolStripButton.Text = "&Save";
			// 
			// toolStripSeparator
			// 
			toolStripSeparator.Name = "toolStripSeparator";
			toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// cutToolStripButton
			// 
			cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			cutToolStripButton.Image = (System.Drawing.Image)resources.GetObject("cutToolStripButton.Image");
			cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			cutToolStripButton.Name = "cutToolStripButton";
			cutToolStripButton.Size = new System.Drawing.Size(23, 22);
			cutToolStripButton.Text = "C&ut";
			// 
			// copyToolStripButton
			// 
			copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			copyToolStripButton.Image = (System.Drawing.Image)resources.GetObject("copyToolStripButton.Image");
			copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			copyToolStripButton.Name = "copyToolStripButton";
			copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			copyToolStripButton.Text = "&Copy";
			// 
			// pasteToolStripButton
			// 
			pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			pasteToolStripButton.Image = (System.Drawing.Image)resources.GetObject("pasteToolStripButton.Image");
			pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			pasteToolStripButton.Name = "pasteToolStripButton";
			pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			pasteToolStripButton.Text = "&Paste";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			helpToolStripButton.Image = (System.Drawing.Image)resources.GetObject("helpToolStripButton.Image");
			helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			helpToolStripButton.Name = "helpToolStripButton";
			helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			helpToolStripButton.Text = "He&lp";
			// 
			// stsMain
			// 
			stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, lblCaptureIndex, toolStripStatusLabel3, lblCaptureLength, toolStripStatusLabel5, lblCaptureValue });
			stsMain.Location = new System.Drawing.Point(0, 692);
			stsMain.Name = "stsMain";
			stsMain.Size = new System.Drawing.Size(964, 29);
			stsMain.TabIndex = 2;
			stsMain.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new System.Drawing.Size(32, 24);
			toolStripStatusLabel1.Text = "位置";
			// 
			// lblCaptureIndex
			// 
			lblCaptureIndex.AutoSize = false;
			lblCaptureIndex.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
			lblCaptureIndex.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			lblCaptureIndex.Name = "lblCaptureIndex";
			lblCaptureIndex.Size = new System.Drawing.Size(60, 24);
			lblCaptureIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel3
			// 
			toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			toolStripStatusLabel3.Size = new System.Drawing.Size(32, 24);
			toolStripStatusLabel3.Text = "长度";
			// 
			// lblCaptureLength
			// 
			lblCaptureLength.AutoSize = false;
			lblCaptureLength.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
			lblCaptureLength.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			lblCaptureLength.Name = "lblCaptureLength";
			lblCaptureLength.Size = new System.Drawing.Size(60, 24);
			lblCaptureLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel5
			// 
			toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			toolStripStatusLabel5.Size = new System.Drawing.Size(44, 24);
			toolStripStatusLabel5.Text = "文本值";
			// 
			// lblCaptureValue
			// 
			lblCaptureValue.AutoSize = false;
			lblCaptureValue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
			lblCaptureValue.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			lblCaptureValue.Name = "lblCaptureValue";
			lblCaptureValue.Size = new System.Drawing.Size(721, 24);
			lblCaptureValue.Spring = true;
			lblCaptureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SplitContainer1
			// 
			SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			SplitContainer1.Location = new System.Drawing.Point(0, 25);
			SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
			SplitContainer1.Name = "SplitContainer1";
			SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SplitContainer1.Panel1
			// 
			SplitContainer1.Panel1.Controls.Add(chkOptionsExplicitCapture);
			SplitContainer1.Panel1.Controls.Add(chkOptionsMultiline);
			SplitContainer1.Panel1.Controls.Add(chkOptionsSingleline);
			SplitContainer1.Panel1.Controls.Add(chkOptionsIgnorePatternWhitespace);
			SplitContainer1.Panel1.Controls.Add(chkOptionsIgnoreCase);
			SplitContainer1.Panel1.Controls.Add(txtPattern);
			SplitContainer1.Panel1.Controls.Add(btnMatch);
			SplitContainer1.Panel1.Controls.Add(lblPattern);
			SplitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4, 0, 136, 0);
			// 
			// SplitContainer1.Panel2
			// 
			SplitContainer1.Panel2.Controls.Add(SplitContainer2);
			SplitContainer1.Size = new System.Drawing.Size(964, 667);
			SplitContainer1.SplitterDistance = 334;
			SplitContainer1.SplitterWidth = 5;
			SplitContainer1.TabIndex = 3;
			// 
			// chkOptionsExplicitCapture
			// 
			chkOptionsExplicitCapture.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			chkOptionsExplicitCapture.AutoEllipsis = true;
			chkOptionsExplicitCapture.Font = new System.Drawing.Font("Arial", 10F);
			chkOptionsExplicitCapture.Location = new System.Drawing.Point(836, 128);
			chkOptionsExplicitCapture.Name = "chkOptionsExplicitCapture";
			chkOptionsExplicitCapture.Size = new System.Drawing.Size(128, 24);
			chkOptionsExplicitCapture.TabIndex = 8;
			chkOptionsExplicitCapture.Text = "ExplicitCapture";
			_toolTip.SetToolTip(chkOptionsExplicitCapture, "仅捕获已被显式命名的组。指定有效的捕获仅为形式为 (?<name>...) 的显式命名或编号的组，这使未命名的圆括号可以充当非捕获组，并且不会使表达式的语法 (?:...)显得笨拙。");
			chkOptionsExplicitCapture.UseVisualStyleBackColor = true;
			// 
			// chkOptionsMultiline
			// 
			chkOptionsMultiline.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			chkOptionsMultiline.AutoEllipsis = true;
			chkOptionsMultiline.Font = new System.Drawing.Font("Arial", 10F);
			chkOptionsMultiline.Location = new System.Drawing.Point(836, 104);
			chkOptionsMultiline.Name = "chkOptionsMultiline";
			chkOptionsMultiline.Size = new System.Drawing.Size(128, 24);
			chkOptionsMultiline.TabIndex = 7;
			chkOptionsMultiline.Text = "Multiline";
			_toolTip.SetToolTip(chkOptionsMultiline, "多行模式。更改 ^ 和 $ 的含义，使它们分别在任意一行的行首和行尾匹配，而不仅仅在整个字符串的开头和结尾匹配。");
			chkOptionsMultiline.UseVisualStyleBackColor = true;
			// 
			// chkOptionsSingleline
			// 
			chkOptionsSingleline.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			chkOptionsSingleline.AutoEllipsis = true;
			chkOptionsSingleline.Font = new System.Drawing.Font("Arial", 10F);
			chkOptionsSingleline.Location = new System.Drawing.Point(836, 80);
			chkOptionsSingleline.Name = "chkOptionsSingleline";
			chkOptionsSingleline.Size = new System.Drawing.Size(128, 24);
			chkOptionsSingleline.TabIndex = 6;
			chkOptionsSingleline.Text = "Singleline";
			_toolTip.SetToolTip(chkOptionsSingleline, "指定单行模式。更改点 (.) 的含义，使它与每一个字符匹配（而不是与除 \\n 之外的每个字符匹配）。");
			chkOptionsSingleline.UseVisualStyleBackColor = true;
			// 
			// chkOptionsIgnorePatternWhitespace
			// 
			chkOptionsIgnorePatternWhitespace.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			chkOptionsIgnorePatternWhitespace.AutoEllipsis = true;
			chkOptionsIgnorePatternWhitespace.Font = new System.Drawing.Font("Arial", 10F);
			chkOptionsIgnorePatternWhitespace.Location = new System.Drawing.Point(836, 56);
			chkOptionsIgnorePatternWhitespace.Name = "chkOptionsIgnorePatternWhitespace";
			chkOptionsIgnorePatternWhitespace.Size = new System.Drawing.Size(128, 24);
			chkOptionsIgnorePatternWhitespace.TabIndex = 5;
			chkOptionsIgnorePatternWhitespace.Text = "IgnorePatternWhitespace";
			_toolTip.SetToolTip(chkOptionsIgnorePatternWhitespace, "消除模式中的非转义空白并启用由 # 标记的注释。但是不会影响或消除字符类中的空白。");
			chkOptionsIgnorePatternWhitespace.UseVisualStyleBackColor = true;
			// 
			// chkOptionsIgnoreCase
			// 
			chkOptionsIgnoreCase.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			chkOptionsIgnoreCase.AutoEllipsis = true;
			chkOptionsIgnoreCase.Font = new System.Drawing.Font("Arial", 10F);
			chkOptionsIgnoreCase.Location = new System.Drawing.Point(836, 32);
			chkOptionsIgnoreCase.Name = "chkOptionsIgnoreCase";
			chkOptionsIgnoreCase.Size = new System.Drawing.Size(128, 24);
			chkOptionsIgnoreCase.TabIndex = 4;
			chkOptionsIgnoreCase.Text = "IgnoreCase";
			_toolTip.SetToolTip(chkOptionsIgnoreCase, "不区分大小写的匹配。");
			chkOptionsIgnoreCase.UseVisualStyleBackColor = true;
			// 
			// txtPattern
			// 
			txtPattern.AcceptsTab = true;
			txtPattern.Dock = System.Windows.Forms.DockStyle.Fill;
			txtPattern.HideSelection = false;
			txtPattern.Location = new System.Drawing.Point(4, 30);
			txtPattern.Margin = new System.Windows.Forms.Padding(4);
			txtPattern.Multiline = true;
			txtPattern.Name = "txtPattern";
			txtPattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			txtPattern.Size = new System.Drawing.Size(824, 304);
			txtPattern.TabIndex = 1;
			txtPattern.WordWrap = false;
			// 
			// btnMatch
			// 
			btnMatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			btnMatch.Location = new System.Drawing.Point(838, 302);
			btnMatch.Margin = new System.Windows.Forms.Padding(4);
			btnMatch.Name = "btnMatch";
			btnMatch.Size = new System.Drawing.Size(120, 32);
			btnMatch.TabIndex = 2;
			btnMatch.Text = "匹配(F5)";
			btnMatch.UseVisualStyleBackColor = true;
			btnMatch.Click += btnMatch_Click;
			// 
			// lblPattern
			// 
			lblPattern.AutoEllipsis = true;
			lblPattern.Dock = System.Windows.Forms.DockStyle.Top;
			lblPattern.Location = new System.Drawing.Point(4, 0);
			lblPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblPattern.Name = "lblPattern";
			lblPattern.Size = new System.Drawing.Size(824, 30);
			lblPattern.TabIndex = 0;
			lblPattern.Text = "正则表达式(&E)";
			lblPattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SplitContainer2
			// 
			SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			SplitContainer2.Location = new System.Drawing.Point(0, 0);
			SplitContainer2.Margin = new System.Windows.Forms.Padding(4);
			SplitContainer2.Name = "SplitContainer2";
			// 
			// SplitContainer2.Panel1
			// 
			SplitContainer2.Panel1.Controls.Add(txtInput);
			SplitContainer2.Panel1.Controls.Add(lblInput);
			SplitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
			// 
			// SplitContainer2.Panel2
			// 
			SplitContainer2.Panel2.Controls.Add(tvwResult);
			SplitContainer2.Panel2.Controls.Add(lblResult);
			SplitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 4);
			SplitContainer2.Size = new System.Drawing.Size(964, 328);
			SplitContainer2.SplitterDistance = 444;
			SplitContainer2.SplitterWidth = 5;
			SplitContainer2.TabIndex = 0;
			// 
			// txtInput
			// 
			txtInput.AcceptsTab = true;
			txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
			txtInput.HideSelection = false;
			txtInput.Location = new System.Drawing.Point(4, 30);
			txtInput.Margin = new System.Windows.Forms.Padding(4);
			txtInput.Multiline = true;
			txtInput.Name = "txtInput";
			txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			txtInput.Size = new System.Drawing.Size(440, 294);
			txtInput.TabIndex = 4;
			txtInput.WordWrap = false;
			// 
			// lblInput
			// 
			lblInput.AutoEllipsis = true;
			lblInput.Dock = System.Windows.Forms.DockStyle.Top;
			lblInput.Location = new System.Drawing.Point(4, 0);
			lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblInput.Name = "lblInput";
			lblInput.Size = new System.Drawing.Size(440, 30);
			lblInput.TabIndex = 3;
			lblInput.Text = "输入文本(&T)";
			lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tvwResult
			// 
			tvwResult.Dock = System.Windows.Forms.DockStyle.Fill;
			tvwResult.HideSelection = false;
			tvwResult.Location = new System.Drawing.Point(0, 30);
			tvwResult.Margin = new System.Windows.Forms.Padding(4);
			tvwResult.Name = "tvwResult";
			tvwResult.Size = new System.Drawing.Size(511, 294);
			tvwResult.TabIndex = 5;
			tvwResult.AfterSelect += tvwResult_AfterSelect;
			// 
			// lblResult
			// 
			lblResult.AutoEllipsis = true;
			lblResult.Dock = System.Windows.Forms.DockStyle.Top;
			lblResult.Location = new System.Drawing.Point(0, 0);
			lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblResult.Name = "lblResult";
			lblResult.Size = new System.Drawing.Size(511, 30);
			lblResult.TabIndex = 4;
			lblResult.Text = "结果(&R)";
			lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _toolTip
			// 
			_toolTip.AutoPopDelay = 10000;
			_toolTip.InitialDelay = 500;
			_toolTip.IsBalloon = true;
			_toolTip.ReshowDelay = 100;
			// 
			// MainForm
			// 
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			ClientSize = new System.Drawing.Size(964, 721);
			Controls.Add(SplitContainer1);
			Controls.Add(stsMain);
			Controls.Add(tlsDefault);
			Controls.Add(mnuMain);
			Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			HelpButton = true;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			MainMenuStrip = mnuMain;
			Margin = new System.Windows.Forms.Padding(4);
			Name = "MainForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "正则表达式测试器";
			Load += FMain_Load;
			KeyUp += FMain_KeyUp;
			mnuMain.ResumeLayout(false);
			mnuMain.PerformLayout();
			tlsDefault.ResumeLayout(false);
			tlsDefault.PerformLayout();
			stsMain.ResumeLayout(false);
			stsMain.PerformLayout();
			SplitContainer1.Panel1.ResumeLayout(false);
			SplitContainer1.Panel1.PerformLayout();
			SplitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainer1).EndInit();
			SplitContainer1.ResumeLayout(false);
			SplitContainer2.Panel1.ResumeLayout(false);
			SplitContainer2.Panel1.PerformLayout();
			SplitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainer2).EndInit();
			SplitContainer2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStrip tlsDefault;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton cutToolStripButton;
		private System.Windows.Forms.ToolStripButton copyToolStripButton;
		private System.Windows.Forms.ToolStripButton pasteToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.StatusStrip stsMain;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
		private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
		private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
		private System.Windows.Forms.ToolStripMenuItem mnuEdit;
		private System.Windows.Forms.ToolStripMenuItem mnuEditUndo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
		private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
		private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem mnuEditSelectAll;
		private System.Windows.Forms.ToolStripMenuItem mnuTools;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsOptions;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
		private System.Windows.Forms.SplitContainer SplitContainer1;
		private System.Windows.Forms.TextBox txtPattern;
		private System.Windows.Forms.Button btnMatch;
		private System.Windows.Forms.Label lblPattern;
		private System.Windows.Forms.SplitContainer SplitContainer2;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.TreeView tvwResult;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lblCaptureIndex;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel lblCaptureLength;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.ToolStripStatusLabel lblCaptureValue;
		private System.Windows.Forms.CheckBox chkOptionsMultiline;
		private System.Windows.Forms.CheckBox chkOptionsSingleline;
		private System.Windows.Forms.CheckBox chkOptionsIgnorePatternWhitespace;
		private System.Windows.Forms.CheckBox chkOptionsIgnoreCase;
		private System.Windows.Forms.CheckBox chkOptionsExplicitCapture;
		private System.Windows.Forms.ToolTip _toolTip;
	}
}