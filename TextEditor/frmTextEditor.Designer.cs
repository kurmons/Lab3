﻿
namespace TextEditor
{
    partial class frmTextEditor
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextEditor));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsTools = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBold = new System.Windows.Forms.ToolStripButton();
            this.tlsItalic = new System.Windows.Forms.ToolStripButton();
            this.tlsUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sstStatus = new System.Windows.Forms.StatusStrip();
            this.stlStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.dlgPrint = new System.Windows.Forms.PrintDialog();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.mnuMainMenu.SuspendLayout();
            this.tlsTools.SuspendLayout();
            this.sstStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.tekstsToolStripMenuItem,
            this.mnuHelp});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(584, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.mnuPrintPreview,
            this.mnuPrint,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(42, 20);
            this.mnuFile.Text = "&Fails";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(215, 22);
            this.mnuNew.Text = "&Jauns";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(215, 22);
            this.mnuOpen.Text = "&Atvērt...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(215, 22);
            this.mnuSave.Text = "&Saglabāt";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuSaveAs.Size = new System.Drawing.Size(215, 22);
            this.mnuSaveAs.Text = "&Saglabāt kā...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.mnuPrintPreview.Size = new System.Drawing.Size(215, 22);
            this.mnuPrintPreview.Text = "&Priekšapskatīt...";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(215, 22);
            this.mnuPrint.Text = "&Drukāt";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuExit.Size = new System.Drawing.Size(215, 22);
            this.mnuExit.Text = "&Iziet";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.toolStripMenuItem3,
            this.mnuCopy,
            this.mnuCut,
            this.mnuPaste,
            this.toolStripMenuItem2,
            this.mnuFont,
            this.mnuOptions});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(59, 20);
            this.mnuEdit.Text = "&Rediģēt";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuUndo.Size = new System.Drawing.Size(208, 22);
            this.mnuUndo.Text = "Atsaukt";
            this.mnuUndo.Click += new System.EventHandler(this.mnuUndo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(205, 6);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(208, 22);
            this.mnuCopy.Text = "&Kopēt";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuCut
            // 
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCut.Size = new System.Drawing.Size(208, 22);
            this.mnuCut.Text = "&Izgriezt";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuPaste.Size = new System.Drawing.Size(208, 22);
            this.mnuPaste.Text = "&Ielīmēt";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.mnuFont.Size = new System.Drawing.Size(208, 22);
            this.mnuFont.Text = "&Fonta izvēle";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // tekstsToolStripMenuItem
            // 
            this.tekstsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBold,
            this.mnuItalic,
            this.mnuUnderline});
            this.tekstsToolStripMenuItem.Name = "tekstsToolStripMenuItem";
            this.tekstsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.tekstsToolStripMenuItem.Text = "Teksts";
            // 
            // mnuBold
            // 
            this.mnuBold.Name = "mnuBold";
            this.mnuBold.Size = new System.Drawing.Size(125, 22);
            this.mnuBold.Text = "&Bold";
            this.mnuBold.Click += new System.EventHandler(this.mnuBold_Click);
            // 
            // mnuItalic
            // 
            this.mnuItalic.Name = "mnuItalic";
            this.mnuItalic.Size = new System.Drawing.Size(125, 22);
            this.mnuItalic.Text = "&Italic";
            this.mnuItalic.Click += new System.EventHandler(this.mnuItalic_Click);
            // 
            // mnuUnderline
            // 
            this.mnuUnderline.Name = "mnuUnderline";
            this.mnuUnderline.Size = new System.Drawing.Size(125, 22);
            this.mnuUnderline.Text = "&Underline";
            this.mnuUnderline.Click += new System.EventHandler(this.mnuUnderline_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(66, 20);
            this.mnuHelp.Text = "&Palīdzība";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(167, 22);
            this.mnuAbout.Text = "Par programmu...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tlsTools
            // 
            this.tlsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripButton1,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripButton2,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.tlsBold,
            this.tlsItalic,
            this.tlsUnderline,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.tlsTools.Location = new System.Drawing.Point(0, 24);
            this.tlsTools.Name = "tlsTools";
            this.tlsTools.Size = new System.Drawing.Size(584, 25);
            this.tlsTools.TabIndex = 1;
            this.tlsTools.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "&PrintPreview";
            this.toolStripButton1.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "&Undo";
            this.toolStripButton2.Click += new System.EventHandler(this.mnuUndo_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "&Cut";
            this.cutToolStripButton.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsBold
            // 
            this.tlsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBold.Image = ((System.Drawing.Image)(resources.GetObject("tlsBold.Image")));
            this.tlsBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBold.Name = "tlsBold";
            this.tlsBold.Size = new System.Drawing.Size(23, 22);
            this.tlsBold.Text = "&Bold";
            this.tlsBold.Click += new System.EventHandler(this.mnuBold_Click);
            // 
            // tlsItalic
            // 
            this.tlsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsItalic.Image = ((System.Drawing.Image)(resources.GetObject("tlsItalic.Image")));
            this.tlsItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsItalic.Name = "tlsItalic";
            this.tlsItalic.Size = new System.Drawing.Size(23, 22);
            this.tlsItalic.Text = "&Italic";
            this.tlsItalic.Click += new System.EventHandler(this.mnuItalic_Click);
            // 
            // tlsUnderline
            // 
            this.tlsUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tlsUnderline.Image")));
            this.tlsUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsUnderline.Name = "tlsUnderline";
            this.tlsUnderline.Size = new System.Drawing.Size(23, 22);
            this.tlsUnderline.Text = "&Underline";
            this.tlsUnderline.Click += new System.EventHandler(this.mnuUnderline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // sstStatus
            // 
            this.sstStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlStatus});
            this.sstStatus.Location = new System.Drawing.Point(0, 279);
            this.sstStatus.Name = "sstStatus";
            this.sstStatus.Size = new System.Drawing.Size(584, 22);
            this.sstStatus.TabIndex = 2;
            this.sstStatus.Text = "statusStrip1";
            // 
            // stlStatus
            // 
            this.stlStatus.Name = "stlStatus";
            this.stlStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtContent
            // 
            this.txtContent.AcceptsTab = true;
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(12, 52);
            this.txtContent.MaxLength = 0;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(560, 224);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged_1);
            // 
            // dlgPrintDocument
            // 
            this.dlgPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.dlgPrintDocument_PrintPage);
            // 
            // dlgPrintPreview
            // 
            this.dlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.ClientSize = new System.Drawing.Size(359, 211);
            this.dlgPrintPreview.Enabled = true;
            this.dlgPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPrintPreview.Icon")));
            this.dlgPrintPreview.Name = "dlgPrintPreview";
            this.dlgPrintPreview.Visible = false;
            // 
            // dlgPrint
            // 
            this.dlgPrint.UseEXDialog = true;
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(208, 22);
            this.mnuOptions.Text = "&Opcijas";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            this.dlgOpenFile.InitialDirectory = global::TextEditor.Properties.Settings.Default.DefaultFolder;
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.InitialDirectory = global::TextEditor.Properties.Settings.Default.DefaultFolder;
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 301);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.sstStatus);
            this.Controls.Add(this.tlsTools);
            this.Controls.Add(this.mnuMainMenu);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TextEditor.Properties.Settings.Default, "EditorLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::TextEditor.Properties.Settings.Default.EditorLocation;
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Teksta Redaktors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTextEditor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTextEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmTextEditor_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.tlsTools.ResumeLayout(false);
            this.tlsTools.PerformLayout();
            this.sstStatus.ResumeLayout(false);
            this.sstStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip tlsTools;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.StatusStrip sstStatus;
        private System.Windows.Forms.ToolStripStatusLabel stlStatus;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Drawing.Printing.PrintDocument dlgPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
        private System.Windows.Forms.PrintDialog dlgPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem tekstsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBold;
        private System.Windows.Forms.ToolStripMenuItem mnuItalic;
        private System.Windows.Forms.ToolStripMenuItem mnuUnderline;
        private System.Windows.Forms.ToolStripButton tlsBold;
        private System.Windows.Forms.ToolStripButton tlsItalic;
        private System.Windows.Forms.ToolStripButton tlsUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
    }
}

