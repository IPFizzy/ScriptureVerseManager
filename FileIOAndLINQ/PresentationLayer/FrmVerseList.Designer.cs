namespace FileIOAndLINQ.PresentationLayer
{
    partial class FrmVerseList
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
            mnsFileActions = new MenuStrip();
            tsmFile = new ToolStripMenuItem();
            tsmSave = new ToolStripMenuItem();
            tsmLoad = new ToolStripMenuItem();
            tsmExit = new ToolStripMenuItem();
            grpAddVerse = new GroupBox();
            lblImportanceError = new Label();
            lblMeaningError = new Label();
            lblTextError = new Label();
            lblChapterError = new Label();
            btnAddVerse = new Button();
            nudVerseImportance = new NumericUpDown();
            lblVerseError = new Label();
            txtVerseMeaning = new TextBox();
            txtVerseText = new TextBox();
            txtVerseChapter = new ComboBox();
            lblBookError = new Label();
            txtVerseVerse = new ComboBox();
            cmbVerseBook = new ComboBox();
            lblImportance = new Label();
            lblMeaning = new Label();
            lblText = new Label();
            lblVerse = new Label();
            lblChapter = new Label();
            lblBook = new Label();
            grpFilterAndSort = new GroupBox();
            rdoShowMostImportant = new RadioButton();
            rdoShowLeastImportant = new RadioButton();
            rdoShowAll = new RadioButton();
            trbNumberToShow = new TrackBar();
            dgvVerseDisplay = new DataGridView();
            mnsFileActions.SuspendLayout();
            grpAddVerse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).BeginInit();
            grpFilterAndSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVerseDisplay).BeginInit();
            SuspendLayout();
            // 
            // mnsFileActions
            // 
            mnsFileActions.Items.AddRange(new ToolStripItem[] { tsmFile });
            mnsFileActions.Location = new Point(0, 0);
            mnsFileActions.Name = "mnsFileActions";
            mnsFileActions.Size = new Size(1213, 24);
            mnsFileActions.TabIndex = 0;
            mnsFileActions.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            tsmFile.DropDownItems.AddRange(new ToolStripItem[] { tsmSave, tsmLoad, tsmExit });
            tsmFile.Name = "tsmFile";
            tsmFile.Size = new Size(37, 20);
            tsmFile.Text = "File";
            // 
            // tsmSave
            // 
            tsmSave.Name = "tsmSave";
            tsmSave.Size = new Size(100, 22);
            tsmSave.Text = "Save";
            tsmSave.Click += TsmSaveClickEH;
            // 
            // tsmLoad
            // 
            tsmLoad.Name = "tsmLoad";
            tsmLoad.Size = new Size(100, 22);
            tsmLoad.Text = "Load";
            tsmLoad.Click += TsmLoadClickEH;
            // 
            // tsmExit
            // 
            tsmExit.Name = "tsmExit";
            tsmExit.Size = new Size(100, 22);
            tsmExit.Text = "Exit";
            // 
            // grpAddVerse
            // 
            grpAddVerse.Controls.Add(lblImportanceError);
            grpAddVerse.Controls.Add(lblMeaningError);
            grpAddVerse.Controls.Add(lblTextError);
            grpAddVerse.Controls.Add(lblChapterError);
            grpAddVerse.Controls.Add(btnAddVerse);
            grpAddVerse.Controls.Add(nudVerseImportance);
            grpAddVerse.Controls.Add(lblVerseError);
            grpAddVerse.Controls.Add(txtVerseMeaning);
            grpAddVerse.Controls.Add(txtVerseText);
            grpAddVerse.Controls.Add(txtVerseChapter);
            grpAddVerse.Controls.Add(lblBookError);
            grpAddVerse.Controls.Add(txtVerseVerse);
            grpAddVerse.Controls.Add(cmbVerseBook);
            grpAddVerse.Controls.Add(lblImportance);
            grpAddVerse.Controls.Add(lblMeaning);
            grpAddVerse.Controls.Add(lblText);
            grpAddVerse.Controls.Add(lblVerse);
            grpAddVerse.Controls.Add(lblChapter);
            grpAddVerse.Controls.Add(lblBook);
            grpAddVerse.Location = new Point(12, 27);
            grpAddVerse.Name = "grpAddVerse";
            grpAddVerse.Size = new Size(352, 481);
            grpAddVerse.TabIndex = 1;
            grpAddVerse.TabStop = false;
            grpAddVerse.Text = "Add A Bible Verse";
            // 
            // lblImportanceError
            // 
            lblImportanceError.AutoSize = true;
            lblImportanceError.ForeColor = Color.Red;
            lblImportanceError.Location = new Point(88, 403);
            lblImportanceError.Name = "lblImportanceError";
            lblImportanceError.Size = new Size(96, 15);
            lblImportanceError.TabIndex = 4;
            lblImportanceError.Text = "Importance Error";
            // 
            // lblMeaningError
            // 
            lblMeaningError.AutoSize = true;
            lblMeaningError.ForeColor = Color.Red;
            lblMeaningError.Location = new Point(88, 347);
            lblMeaningError.Name = "lblMeaningError";
            lblMeaningError.Size = new Size(82, 15);
            lblMeaningError.TabIndex = 5;
            lblMeaningError.Text = "Meaning Error";
            // 
            // lblTextError
            // 
            lblTextError.AutoSize = true;
            lblTextError.ForeColor = Color.Red;
            lblTextError.Location = new Point(88, 234);
            lblTextError.Name = "lblTextError";
            lblTextError.Size = new Size(56, 15);
            lblTextError.TabIndex = 6;
            lblTextError.Text = "Text Error";
            // 
            // lblChapterError
            // 
            lblChapterError.AutoSize = true;
            lblChapterError.ForeColor = Color.Red;
            lblChapterError.Location = new Point(88, 91);
            lblChapterError.Name = "lblChapterError";
            lblChapterError.Size = new Size(77, 15);
            lblChapterError.TabIndex = 7;
            lblChapterError.Text = "Chapter Error";
            // 
            // btnAddVerse
            // 
            btnAddVerse.Location = new Point(135, 434);
            btnAddVerse.Name = "btnAddVerse";
            btnAddVerse.Size = new Size(75, 23);
            btnAddVerse.TabIndex = 2;
            btnAddVerse.Text = "Add";
            btnAddVerse.UseVisualStyleBackColor = true;
            btnAddVerse.Click += BtnAddVerseClickEH;
            // 
            // nudVerseImportance
            // 
            nudVerseImportance.Location = new Point(88, 377);
            nudVerseImportance.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudVerseImportance.Name = "nudVerseImportance";
            nudVerseImportance.Size = new Size(251, 23);
            nudVerseImportance.TabIndex = 2;
            nudVerseImportance.Leave += NudVerseImportanceLeaveEH;
            // 
            // lblVerseError
            // 
            lblVerseError.AutoSize = true;
            lblVerseError.ForeColor = Color.Red;
            lblVerseError.Location = new Point(88, 141);
            lblVerseError.Name = "lblVerseError";
            lblVerseError.Size = new Size(62, 15);
            lblVerseError.TabIndex = 3;
            lblVerseError.Text = "Verse Error";
            // 
            // txtVerseMeaning
            // 
            txtVerseMeaning.Location = new Point(88, 265);
            txtVerseMeaning.Multiline = true;
            txtVerseMeaning.Name = "txtVerseMeaning";
            txtVerseMeaning.Size = new Size(251, 79);
            txtVerseMeaning.TabIndex = 9;
            txtVerseMeaning.Leave += TxtVerseMeaningLeaveEH;
            // 
            // txtVerseText
            // 
            txtVerseText.Location = new Point(88, 172);
            txtVerseText.Multiline = true;
            txtVerseText.Name = "txtVerseText";
            txtVerseText.Size = new Size(251, 59);
            txtVerseText.TabIndex = 2;
            txtVerseText.Leave += TxtVerseTextLeaveEH;
            // 
            // txtVerseChapter
            // 
            txtVerseChapter.FormattingEnabled = true;
            txtVerseChapter.Location = new Point(88, 65);
            txtVerseChapter.Name = "txtVerseChapter";
            txtVerseChapter.Size = new Size(251, 23);
            txtVerseChapter.TabIndex = 8;
            txtVerseChapter.Leave += TxtVerseChapterLeaveEH;
            // 
            // lblBookError
            // 
            lblBookError.AutoSize = true;
            lblBookError.ForeColor = Color.Red;
            lblBookError.Location = new Point(88, 42);
            lblBookError.Name = "lblBookError";
            lblBookError.Size = new Size(62, 15);
            lblBookError.TabIndex = 2;
            lblBookError.Text = "Book Error";
            // 
            // txtVerseVerse
            // 
            txtVerseVerse.FormattingEnabled = true;
            txtVerseVerse.Location = new Point(88, 115);
            txtVerseVerse.Name = "txtVerseVerse";
            txtVerseVerse.Size = new Size(251, 23);
            txtVerseVerse.TabIndex = 7;
            txtVerseVerse.Leave += TxtVerseVerseLeaveEH;
            // 
            // cmbVerseBook
            // 
            cmbVerseBook.FormattingEnabled = true;
            cmbVerseBook.Location = new Point(88, 16);
            cmbVerseBook.Name = "cmbVerseBook";
            cmbVerseBook.Size = new Size(251, 23);
            cmbVerseBook.TabIndex = 6;
            cmbVerseBook.Leave += CmbVerseBookLeaveEH;
            // 
            // lblImportance
            // 
            lblImportance.AutoSize = true;
            lblImportance.Location = new Point(11, 379);
            lblImportance.Name = "lblImportance";
            lblImportance.Size = new Size(71, 15);
            lblImportance.TabIndex = 5;
            lblImportance.Text = "Importance:";
            // 
            // lblMeaning
            // 
            lblMeaning.AutoSize = true;
            lblMeaning.Location = new Point(25, 268);
            lblMeaning.Name = "lblMeaning";
            lblMeaning.Size = new Size(57, 15);
            lblMeaning.TabIndex = 4;
            lblMeaning.Text = "Meaning:";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(51, 175);
            lblText.Name = "lblText";
            lblText.Size = new Size(31, 15);
            lblText.TabIndex = 3;
            lblText.Text = "Text:";
            // 
            // lblVerse
            // 
            lblVerse.AutoSize = true;
            lblVerse.Location = new Point(45, 118);
            lblVerse.Name = "lblVerse";
            lblVerse.Size = new Size(37, 15);
            lblVerse.TabIndex = 2;
            lblVerse.Text = "Verse:";
            // 
            // lblChapter
            // 
            lblChapter.AutoSize = true;
            lblChapter.Location = new Point(30, 68);
            lblChapter.Name = "lblChapter";
            lblChapter.Size = new Size(52, 15);
            lblChapter.TabIndex = 1;
            lblChapter.Text = "Chapter:";
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Location = new Point(45, 19);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(37, 15);
            lblBook.TabIndex = 0;
            lblBook.Text = "Book:";
            // 
            // grpFilterAndSort
            // 
            grpFilterAndSort.Controls.Add(rdoShowMostImportant);
            grpFilterAndSort.Controls.Add(rdoShowLeastImportant);
            grpFilterAndSort.Controls.Add(rdoShowAll);
            grpFilterAndSort.Location = new Point(12, 514);
            grpFilterAndSort.Name = "grpFilterAndSort";
            grpFilterAndSort.Size = new Size(352, 143);
            grpFilterAndSort.TabIndex = 2;
            grpFilterAndSort.TabStop = false;
            grpFilterAndSort.Text = "Filter And Sort";
            // 
            // rdoShowMostImportant
            // 
            rdoShowMostImportant.AutoSize = true;
            rdoShowMostImportant.Location = new Point(11, 115);
            rdoShowMostImportant.Name = "rdoShowMostImportant";
            rdoShowMostImportant.Size = new Size(140, 19);
            rdoShowMostImportant.TabIndex = 4;
            rdoShowMostImportant.TabStop = true;
            rdoShowMostImportant.Text = "Show Most Important";
            rdoShowMostImportant.UseVisualStyleBackColor = true;
            rdoShowMostImportant.CheckedChanged += RdoShowMostImportantCheckedChangedEH;
            // 
            // rdoShowLeastImportant
            // 
            rdoShowLeastImportant.AutoSize = true;
            rdoShowLeastImportant.Location = new Point(11, 74);
            rdoShowLeastImportant.Name = "rdoShowLeastImportant";
            rdoShowLeastImportant.Size = new Size(140, 19);
            rdoShowLeastImportant.TabIndex = 5;
            rdoShowLeastImportant.TabStop = true;
            rdoShowLeastImportant.Text = "Show Least Important";
            rdoShowLeastImportant.UseVisualStyleBackColor = true;
            rdoShowLeastImportant.CheckedChanged += RdoShowLeastImportantCheckChangedEH;
            // 
            // rdoShowAll
            // 
            rdoShowAll.AutoSize = true;
            rdoShowAll.Location = new Point(11, 36);
            rdoShowAll.Name = "rdoShowAll";
            rdoShowAll.Size = new Size(71, 19);
            rdoShowAll.TabIndex = 3;
            rdoShowAll.TabStop = true;
            rdoShowAll.Text = "Show All";
            rdoShowAll.UseVisualStyleBackColor = true;
            // 
            // trbNumberToShow
            // 
            trbNumberToShow.Location = new Point(12, 663);
            trbNumberToShow.Name = "trbNumberToShow";
            trbNumberToShow.Size = new Size(352, 45);
            trbNumberToShow.TabIndex = 3;
            trbNumberToShow.Scroll += TrbNumberToShowScrollEH;
            // 
            // dgvVerseDisplay
            // 
            dgvVerseDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerseDisplay.Location = new Point(370, 27);
            dgvVerseDisplay.Name = "dgvVerseDisplay";
            dgvVerseDisplay.Size = new Size(831, 542);
            dgvVerseDisplay.TabIndex = 4;
            // 
            // FrmVerseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 707);
            Controls.Add(dgvVerseDisplay);
            Controls.Add(trbNumberToShow);
            Controls.Add(grpFilterAndSort);
            Controls.Add(grpAddVerse);
            Controls.Add(mnsFileActions);
            MainMenuStrip = mnsFileActions;
            Name = "FrmVerseList";
            Text = "Bible Verses";
            Load += FrmVerseListLoadEH;
            mnsFileActions.ResumeLayout(false);
            mnsFileActions.PerformLayout();
            grpAddVerse.ResumeLayout(false);
            grpAddVerse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).EndInit();
            grpFilterAndSort.ResumeLayout(false);
            grpFilterAndSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVerseDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsFileActions;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsmSave;
        private ToolStripMenuItem tsmLoad;
        private ToolStripMenuItem tsmExit;
        private GroupBox grpAddVerse;
        private Label lblImportance;
        private Label lblMeaning;
        private Label lblText;
        private Label lblVerse;
        private Label lblChapter;
        private Label lblBook;
        private TextBox txtVerseMeaning;
        private TextBox txtVerseText;
        private ComboBox txtVerseChapter;
        private ComboBox txtVerseVerse;
        private ComboBox cmbVerseBook;
        private Label lblChapterError;
        private Button btnAddVerse;
        private NumericUpDown nudVerseImportance;
        private Label lblBookError;
        private Label lblVerseError;
        private Label lblImportanceError;
        private Label lblMeaningError;
        private Label lblTextError;
        private GroupBox grpFilterAndSort;
        private RadioButton rdoShowMostImportant;
        private RadioButton rdoShowLeastImportant;
        private RadioButton rdoShowAll;
        private TrackBar trbNumberToShow;
        private DataGridView dgvVerseDisplay;
    }
}