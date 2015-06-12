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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.tlsDefault = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.stsMain = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblCaptureIndex = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblCaptureLength = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblCaptureValue = new System.Windows.Forms.ToolStripStatusLabel();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.chkOptionsExplicitCapture = new System.Windows.Forms.CheckBox();
			this.chkOptionsMultiline = new System.Windows.Forms.CheckBox();
			this.chkOptionsSingleline = new System.Windows.Forms.CheckBox();
			this.chkOptionsIgnorePatternWhitespace = new System.Windows.Forms.CheckBox();
			this.chkOptionsIgnoreCase = new System.Windows.Forms.CheckBox();
			this.txtPattern = new System.Windows.Forms.TextBox();
			this.btnMatch = new System.Windows.Forms.Button();
			this.lblPattern = new System.Windows.Forms.Label();
			this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.lblInput = new System.Windows.Forms.Label();
			this.tvwResult = new System.Windows.Forms.TreeView();
			this.lblResult = new System.Windows.Forms.Label();
			this._toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.mnuMain.SuspendLayout();
			this.tlsDefault.SuspendLayout();
			this.stsMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
			this.SplitContainer2.Panel1.SuspendLayout();
			this.SplitContainer2.Panel2.SuspendLayout();
			this.SplitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuTools,
            this.mnuHelp});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(640, 24);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.toolStripSeparator2,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripSeparator3,
            this.mnuFileExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(57, 20);
			this.mnuFile.Text = "文件(&F)";
			// 
			// mnuFileNew
			// 
			this.mnuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileNew.Image")));
			this.mnuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuFileNew.Name = "mnuFileNew";
			this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.mnuFileNew.Size = new System.Drawing.Size(162, 22);
			this.mnuFileNew.Text = "新建(&N)";
			this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpen.Image")));
			this.mnuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuFileOpen.Name = "mnuFileOpen";
			this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mnuFileOpen.Size = new System.Drawing.Size(162, 22);
			this.mnuFileOpen.Text = "打开(&O)";
			this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
			// 
			// mnuFileSave
			// 
			this.mnuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileSave.Image")));
			this.mnuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuFileSave.Name = "mnuFileSave";
			this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mnuFileSave.Size = new System.Drawing.Size(162, 22);
			this.mnuFileSave.Text = "保存(&S)";
			this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
			// 
			// mnuFileSaveAs
			// 
			this.mnuFileSaveAs.Name = "mnuFileSaveAs";
			this.mnuFileSaveAs.Size = new System.Drawing.Size(162, 22);
			this.mnuFileSaveAs.Text = "另存为(&A)";
			this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.Size = new System.Drawing.Size(162, 22);
			this.mnuFileExit.Text = "退出(&X)";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// mnuEdit
			// 
			this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditUndo,
            this.toolStripSeparator5,
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.toolStripSeparator6,
            this.mnuEditSelectAll});
			this.mnuEdit.Name = "mnuEdit";
			this.mnuEdit.Size = new System.Drawing.Size(58, 20);
			this.mnuEdit.Text = "编辑(&E)";
			// 
			// mnuEditUndo
			// 
			this.mnuEditUndo.Name = "mnuEditUndo";
			this.mnuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.mnuEditUndo.Size = new System.Drawing.Size(182, 22);
			this.mnuEditUndo.Text = "撤销(&U)";
			this.mnuEditUndo.Click += new System.EventHandler(this.mnuEditUndo_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(179, 6);
			// 
			// mnuEditCut
			// 
			this.mnuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditCut.Image")));
			this.mnuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuEditCut.Name = "mnuEditCut";
			this.mnuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.mnuEditCut.Size = new System.Drawing.Size(182, 22);
			this.mnuEditCut.Text = "剪切(&T)";
			this.mnuEditCut.Click += new System.EventHandler(this.mnuEditCut_Click);
			// 
			// mnuEditCopy
			// 
			this.mnuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditCopy.Image")));
			this.mnuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuEditCopy.Name = "mnuEditCopy";
			this.mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.mnuEditCopy.Size = new System.Drawing.Size(182, 22);
			this.mnuEditCopy.Text = "复制(&C)";
			this.mnuEditCopy.Click += new System.EventHandler(this.mnuEditCopy_Click);
			// 
			// mnuEditPaste
			// 
			this.mnuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditPaste.Image")));
			this.mnuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mnuEditPaste.Name = "mnuEditPaste";
			this.mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.mnuEditPaste.Size = new System.Drawing.Size(182, 22);
			this.mnuEditPaste.Text = "粘贴(&P)";
			this.mnuEditPaste.Click += new System.EventHandler(this.mnuEditPaste_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(179, 6);
			// 
			// mnuEditSelectAll
			// 
			this.mnuEditSelectAll.Name = "mnuEditSelectAll";
			this.mnuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.mnuEditSelectAll.Size = new System.Drawing.Size(182, 22);
			this.mnuEditSelectAll.Text = "选取所有(&A)";
			this.mnuEditSelectAll.Click += new System.EventHandler(this.mnuEditSelectAll_Click);
			// 
			// mnuTools
			// 
			this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsOptions});
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size(58, 20);
			this.mnuTools.Text = "工具(&T)";
			// 
			// mnuToolsOptions
			// 
			this.mnuToolsOptions.Name = "mnuToolsOptions";
			this.mnuToolsOptions.Size = new System.Drawing.Size(116, 22);
			this.mnuToolsOptions.Text = "选项(&O)";
			this.mnuToolsOptions.Click += new System.EventHandler(this.mnuToolsOptions_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(60, 20);
			this.mnuHelp.Text = "帮助(&H)";
			// 
			// mnuHelpAbout
			// 
			this.mnuHelpAbout.Name = "mnuHelpAbout";
			this.mnuHelpAbout.Size = new System.Drawing.Size(123, 22);
			this.mnuHelpAbout.Text = "关于(&A)...";
			this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
			// 
			// tlsDefault
			// 
			this.tlsDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
			this.tlsDefault.Location = new System.Drawing.Point(0, 28);
			this.tlsDefault.Name = "tlsDefault";
			this.tlsDefault.Size = new System.Drawing.Size(640, 25);
			this.tlsDefault.TabIndex = 1;
			this.tlsDefault.Text = "toolStrip1";
			this.tlsDefault.Visible = false;
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "&New";
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "&Open";
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "&Save";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// cutToolStripButton
			// 
			this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
			this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripButton.Name = "cutToolStripButton";
			this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.cutToolStripButton.Text = "C&ut";
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name = "copyToolStripButton";
			this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text = "&Copy";
			// 
			// pasteToolStripButton
			// 
			this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
			this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripButton.Name = "pasteToolStripButton";
			this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.pasteToolStripButton.Text = "&Paste";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text = "He&lp";
			// 
			// stsMain
			// 
			this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCaptureIndex,
            this.toolStripStatusLabel3,
            this.lblCaptureLength,
            this.toolStripStatusLabel5,
            this.lblCaptureValue});
			this.stsMain.Location = new System.Drawing.Point(0, 451);
			this.stsMain.Name = "stsMain";
			this.stsMain.Size = new System.Drawing.Size(640, 29);
			this.stsMain.TabIndex = 2;
			this.stsMain.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 24);
			this.toolStripStatusLabel1.Text = "位置";
			// 
			// lblCaptureIndex
			// 
			this.lblCaptureIndex.AutoSize = false;
			this.lblCaptureIndex.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.lblCaptureIndex.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.lblCaptureIndex.Name = "lblCaptureIndex";
			this.lblCaptureIndex.Size = new System.Drawing.Size(60, 24);
			this.lblCaptureIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(31, 24);
			this.toolStripStatusLabel3.Text = "长度";
			// 
			// lblCaptureLength
			// 
			this.lblCaptureLength.AutoSize = false;
			this.lblCaptureLength.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.lblCaptureLength.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.lblCaptureLength.Name = "lblCaptureLength";
			this.lblCaptureLength.Size = new System.Drawing.Size(60, 24);
			this.lblCaptureLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(43, 24);
			this.toolStripStatusLabel5.Text = "文本值";
			// 
			// lblCaptureValue
			// 
			this.lblCaptureValue.AutoSize = false;
			this.lblCaptureValue.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.lblCaptureValue.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.lblCaptureValue.Name = "lblCaptureValue";
			this.lblCaptureValue.Size = new System.Drawing.Size(400, 24);
			this.lblCaptureValue.Spring = true;
			this.lblCaptureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SplitContainer1
			// 
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Location = new System.Drawing.Point(0, 24);
			this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SplitContainer1.Panel1
			// 
			this.SplitContainer1.Panel1.Controls.Add(this.chkOptionsExplicitCapture);
			this.SplitContainer1.Panel1.Controls.Add(this.chkOptionsMultiline);
			this.SplitContainer1.Panel1.Controls.Add(this.chkOptionsSingleline);
			this.SplitContainer1.Panel1.Controls.Add(this.chkOptionsIgnorePatternWhitespace);
			this.SplitContainer1.Panel1.Controls.Add(this.chkOptionsIgnoreCase);
			this.SplitContainer1.Panel1.Controls.Add(this.txtPattern);
			this.SplitContainer1.Panel1.Controls.Add(this.btnMatch);
			this.SplitContainer1.Panel1.Controls.Add(this.lblPattern);
			this.SplitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4, 0, 136, 0);
			// 
			// SplitContainer1.Panel2
			// 
			this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
			this.SplitContainer1.Size = new System.Drawing.Size(640, 427);
			this.SplitContainer1.SplitterDistance = 214;
			this.SplitContainer1.SplitterWidth = 5;
			this.SplitContainer1.TabIndex = 3;
			// 
			// chkOptionsExplicitCapture
			// 
			this.chkOptionsExplicitCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkOptionsExplicitCapture.AutoEllipsis = true;
			this.chkOptionsExplicitCapture.Font = new System.Drawing.Font("Arial", 10F);
			this.chkOptionsExplicitCapture.Location = new System.Drawing.Point(512, 128);
			this.chkOptionsExplicitCapture.Name = "chkOptionsExplicitCapture";
			this.chkOptionsExplicitCapture.Size = new System.Drawing.Size(128, 24);
			this.chkOptionsExplicitCapture.TabIndex = 8;
			this.chkOptionsExplicitCapture.Text = "ExplicitCapture";
			this._toolTip.SetToolTip(this.chkOptionsExplicitCapture, "仅捕获已被显式命名的组。指定有效的捕获仅为形式为 (?<name>...) 的显式命名或编号的组，这使未命名的圆括号可以充当非捕获组，并且不会使表达式的语法 (?" +
        ":...)显得笨拙。");
			this.chkOptionsExplicitCapture.UseVisualStyleBackColor = true;
			// 
			// chkOptionsMultiline
			// 
			this.chkOptionsMultiline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkOptionsMultiline.AutoEllipsis = true;
			this.chkOptionsMultiline.Font = new System.Drawing.Font("Arial", 10F);
			this.chkOptionsMultiline.Location = new System.Drawing.Point(512, 104);
			this.chkOptionsMultiline.Name = "chkOptionsMultiline";
			this.chkOptionsMultiline.Size = new System.Drawing.Size(128, 24);
			this.chkOptionsMultiline.TabIndex = 7;
			this.chkOptionsMultiline.Text = "Multiline";
			this._toolTip.SetToolTip(this.chkOptionsMultiline, "多行模式。更改 ^ 和 $ 的含义，使它们分别在任意一行的行首和行尾匹配，而不仅仅在整个字符串的开头和结尾匹配。");
			this.chkOptionsMultiline.UseVisualStyleBackColor = true;
			// 
			// chkOptionsSingleline
			// 
			this.chkOptionsSingleline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkOptionsSingleline.AutoEllipsis = true;
			this.chkOptionsSingleline.Font = new System.Drawing.Font("Arial", 10F);
			this.chkOptionsSingleline.Location = new System.Drawing.Point(512, 80);
			this.chkOptionsSingleline.Name = "chkOptionsSingleline";
			this.chkOptionsSingleline.Size = new System.Drawing.Size(128, 24);
			this.chkOptionsSingleline.TabIndex = 6;
			this.chkOptionsSingleline.Text = "Singleline";
			this._toolTip.SetToolTip(this.chkOptionsSingleline, "指定单行模式。更改点 (.) 的含义，使它与每一个字符匹配（而不是与除 \\n 之外的每个字符匹配）。");
			this.chkOptionsSingleline.UseVisualStyleBackColor = true;
			// 
			// chkOptionsIgnorePatternWhitespace
			// 
			this.chkOptionsIgnorePatternWhitespace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkOptionsIgnorePatternWhitespace.AutoEllipsis = true;
			this.chkOptionsIgnorePatternWhitespace.Font = new System.Drawing.Font("Arial", 10F);
			this.chkOptionsIgnorePatternWhitespace.Location = new System.Drawing.Point(512, 56);
			this.chkOptionsIgnorePatternWhitespace.Name = "chkOptionsIgnorePatternWhitespace";
			this.chkOptionsIgnorePatternWhitespace.Size = new System.Drawing.Size(128, 24);
			this.chkOptionsIgnorePatternWhitespace.TabIndex = 5;
			this.chkOptionsIgnorePatternWhitespace.Text = "IgnorePatternWhitespace";
			this._toolTip.SetToolTip(this.chkOptionsIgnorePatternWhitespace, "消除模式中的非转义空白并启用由 # 标记的注释。但是不会影响或消除字符类中的空白。");
			this.chkOptionsIgnorePatternWhitespace.UseVisualStyleBackColor = true;
			// 
			// chkOptionsIgnoreCase
			// 
			this.chkOptionsIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkOptionsIgnoreCase.AutoEllipsis = true;
			this.chkOptionsIgnoreCase.Font = new System.Drawing.Font("Arial", 10F);
			this.chkOptionsIgnoreCase.Location = new System.Drawing.Point(512, 32);
			this.chkOptionsIgnoreCase.Name = "chkOptionsIgnoreCase";
			this.chkOptionsIgnoreCase.Size = new System.Drawing.Size(128, 24);
			this.chkOptionsIgnoreCase.TabIndex = 4;
			this.chkOptionsIgnoreCase.Text = "IgnoreCase";
			this._toolTip.SetToolTip(this.chkOptionsIgnoreCase, "不区分大小写的匹配。");
			this.chkOptionsIgnoreCase.UseVisualStyleBackColor = true;
			// 
			// txtPattern
			// 
			this.txtPattern.AcceptsTab = true;
			this.txtPattern.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPattern.HideSelection = false;
			this.txtPattern.Location = new System.Drawing.Point(4, 30);
			this.txtPattern.Margin = new System.Windows.Forms.Padding(4);
			this.txtPattern.Multiline = true;
			this.txtPattern.Name = "txtPattern";
			this.txtPattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPattern.Size = new System.Drawing.Size(500, 184);
			this.txtPattern.TabIndex = 1;
			this.txtPattern.WordWrap = false;
			// 
			// btnMatch
			// 
			this.btnMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMatch.Location = new System.Drawing.Point(514, 182);
			this.btnMatch.Margin = new System.Windows.Forms.Padding(4);
			this.btnMatch.Name = "btnMatch";
			this.btnMatch.Size = new System.Drawing.Size(120, 32);
			this.btnMatch.TabIndex = 2;
			this.btnMatch.Text = "匹配(F5)";
			this.btnMatch.UseVisualStyleBackColor = true;
			this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
			// 
			// lblPattern
			// 
			this.lblPattern.AutoEllipsis = true;
			this.lblPattern.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblPattern.Location = new System.Drawing.Point(4, 0);
			this.lblPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPattern.Name = "lblPattern";
			this.lblPattern.Size = new System.Drawing.Size(500, 30);
			this.lblPattern.TabIndex = 0;
			this.lblPattern.Text = "正则表达式(&E)";
			this.lblPattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SplitContainer2
			// 
			this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer2.Margin = new System.Windows.Forms.Padding(4);
			this.SplitContainer2.Name = "SplitContainer2";
			// 
			// SplitContainer2.Panel1
			// 
			this.SplitContainer2.Panel1.Controls.Add(this.txtInput);
			this.SplitContainer2.Panel1.Controls.Add(this.lblInput);
			this.SplitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
			// 
			// SplitContainer2.Panel2
			// 
			this.SplitContainer2.Panel2.Controls.Add(this.tvwResult);
			this.SplitContainer2.Panel2.Controls.Add(this.lblResult);
			this.SplitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 4);
			this.SplitContainer2.Size = new System.Drawing.Size(640, 208);
			this.SplitContainer2.SplitterDistance = 295;
			this.SplitContainer2.SplitterWidth = 5;
			this.SplitContainer2.TabIndex = 0;
			// 
			// txtInput
			// 
			this.txtInput.AcceptsTab = true;
			this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInput.HideSelection = false;
			this.txtInput.Location = new System.Drawing.Point(4, 30);
			this.txtInput.Margin = new System.Windows.Forms.Padding(4);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtInput.Size = new System.Drawing.Size(291, 174);
			this.txtInput.TabIndex = 4;
			this.txtInput.WordWrap = false;
			// 
			// lblInput
			// 
			this.lblInput.AutoEllipsis = true;
			this.lblInput.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblInput.Location = new System.Drawing.Point(4, 0);
			this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(291, 30);
			this.lblInput.TabIndex = 3;
			this.lblInput.Text = "输入文本(&T)";
			this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tvwResult
			// 
			this.tvwResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvwResult.HideSelection = false;
			this.tvwResult.Location = new System.Drawing.Point(0, 30);
			this.tvwResult.Margin = new System.Windows.Forms.Padding(4);
			this.tvwResult.Name = "tvwResult";
			this.tvwResult.Size = new System.Drawing.Size(336, 174);
			this.tvwResult.TabIndex = 5;
			this.tvwResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwResult_AfterSelect);
			// 
			// lblResult
			// 
			this.lblResult.AutoEllipsis = true;
			this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblResult.Location = new System.Drawing.Point(0, 0);
			this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(336, 30);
			this.lblResult.TabIndex = 4;
			this.lblResult.Text = "结果(&R)";
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _toolTip
			// 
			this._toolTip.AutoPopDelay = 10000;
			this._toolTip.InitialDelay = 500;
			this._toolTip.IsBalloon = true;
			this._toolTip.ReshowDelay = 100;
			// 
			// FMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.SplitContainer1);
			this.Controls.Add(this.stsMain);
			this.Controls.Add(this.tlsDefault);
			this.Controls.Add(this.mnuMain);
			this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.mnuMain;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "正则表达式测试器";
			this.Load += new System.EventHandler(this.FMain_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FMain_KeyUp);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.tlsDefault.ResumeLayout(false);
			this.tlsDefault.PerformLayout();
			this.stsMain.ResumeLayout(false);
			this.stsMain.PerformLayout();
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel1.PerformLayout();
			this.SplitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
			this.SplitContainer1.ResumeLayout(false);
			this.SplitContainer2.Panel1.ResumeLayout(false);
			this.SplitContainer2.Panel1.PerformLayout();
			this.SplitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
			this.SplitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

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