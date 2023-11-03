namespace XmlMetadataGeneratorUI
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
            tlpMainForm = new TableLayoutPanel();
            grpBoxSourceFolder = new GroupBox();
            txtSourceFolder = new TextBox();
            grpBoxDestinationFolder = new GroupBox();
            txtDestinationFolder = new TextBox();
            btnGenerateXpp = new Button();
            clbSourceFolder = new CheckedListBox();
            btnDestinationFolder = new Button();
            btnSourceFolder = new Button();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            lbTotalFiles = new Label();
            lbBar = new Label();
            progressBar1 = new ProgressBar();
            lbFileProgress = new Label();
            tlpMainForm.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            grpBoxDestinationFolder.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainForm
            // 
            tlpMainForm.Anchor = AnchorStyles.None;
            tlpMainForm.ColumnCount = 3;
            tlpMainForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainForm.ColumnStyles.Add(new ColumnStyle());
            tlpMainForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tlpMainForm.Controls.Add(grpBoxSourceFolder, 0, 0);
            tlpMainForm.Controls.Add(grpBoxDestinationFolder, 0, 1);
            tlpMainForm.Controls.Add(btnGenerateXpp, 2, 2);
            tlpMainForm.Controls.Add(clbSourceFolder, 0, 2);
            tlpMainForm.Controls.Add(btnDestinationFolder, 2, 1);
            tlpMainForm.Controls.Add(btnSourceFolder, 2, 0);
            tlpMainForm.Controls.Add(checkBox1, 0, 3);
            tlpMainForm.Controls.Add(groupBox1, 0, 4);
            tlpMainForm.Location = new Point(0, 0);
            tlpMainForm.Name = "tlpMainForm";
            tlpMainForm.RowCount = 5;
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tlpMainForm.Size = new Size(549, 358);
            tlpMainForm.TabIndex = 0;
            // 
            // grpBoxSourceFolder
            // 
            grpBoxSourceFolder.Controls.Add(txtSourceFolder);
            grpBoxSourceFolder.Dock = DockStyle.Fill;
            grpBoxSourceFolder.Location = new Point(3, 3);
            grpBoxSourceFolder.Name = "grpBoxSourceFolder";
            grpBoxSourceFolder.Size = new Size(459, 58);
            grpBoxSourceFolder.TabIndex = 0;
            grpBoxSourceFolder.TabStop = false;
            grpBoxSourceFolder.Text = "Source Folder";
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Dock = DockStyle.Fill;
            txtSourceFolder.Location = new Point(3, 19);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.Size = new Size(453, 23);
            txtSourceFolder.TabIndex = 0;
            txtSourceFolder.TextChanged += txtSourceFolder_TextChanged;
            // 
            // grpBoxDestinationFolder
            // 
            grpBoxDestinationFolder.Controls.Add(txtDestinationFolder);
            grpBoxDestinationFolder.Dock = DockStyle.Fill;
            grpBoxDestinationFolder.Location = new Point(3, 67);
            grpBoxDestinationFolder.Name = "grpBoxDestinationFolder";
            grpBoxDestinationFolder.Size = new Size(459, 58);
            grpBoxDestinationFolder.TabIndex = 1;
            grpBoxDestinationFolder.TabStop = false;
            grpBoxDestinationFolder.Text = "Destination Folder";
            // 
            // txtDestinationFolder
            // 
            txtDestinationFolder.Dock = DockStyle.Fill;
            txtDestinationFolder.Location = new Point(3, 19);
            txtDestinationFolder.Name = "txtDestinationFolder";
            txtDestinationFolder.Size = new Size(453, 23);
            txtDestinationFolder.TabIndex = 0;
            // 
            // btnGenerateXpp
            // 
            btnGenerateXpp.Location = new Point(468, 131);
            btnGenerateXpp.Name = "btnGenerateXpp";
            btnGenerateXpp.Size = new Size(75, 23);
            btnGenerateXpp.TabIndex = 5;
            btnGenerateXpp.Text = "Generate";
            btnGenerateXpp.UseVisualStyleBackColor = true;
            btnGenerateXpp.Click += btnGenerateXpp_Click;
            // 
            // clbSourceFolder
            // 
            clbSourceFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbSourceFolder.FormattingEnabled = true;
            clbSourceFolder.HorizontalScrollbar = true;
            clbSourceFolder.Location = new Point(3, 131);
            clbSourceFolder.Name = "clbSourceFolder";
            clbSourceFolder.Size = new Size(459, 130);
            clbSourceFolder.TabIndex = 2;
            clbSourceFolder.SelectedIndexChanged += clbSourceFolder_SelectedIndexChanged;
            // 
            // btnDestinationFolder
            // 
            btnDestinationFolder.Anchor = AnchorStyles.Left;
            btnDestinationFolder.Location = new Point(468, 84);
            btnDestinationFolder.Name = "btnDestinationFolder";
            btnDestinationFolder.Size = new Size(75, 23);
            btnDestinationFolder.TabIndex = 4;
            btnDestinationFolder.Text = "Folder";
            btnDestinationFolder.UseVisualStyleBackColor = true;
            btnDestinationFolder.Click += btnDestinationFolder_Click;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Anchor = AnchorStyles.Left;
            btnSourceFolder.Location = new Point(468, 20);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(74, 23);
            btnSourceFolder.TabIndex = 3;
            btnSourceFolder.Text = "Folder";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 278);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Seleccionar todos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTotalFiles);
            groupBox1.Controls.Add(lbBar);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(lbFileProgress);
            groupBox1.Location = new Point(3, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 48);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // lbTotalFiles
            // 
            lbTotalFiles.AutoSize = true;
            lbTotalFiles.Location = new Point(233, 6);
            lbTotalFiles.Name = "lbTotalFiles";
            lbTotalFiles.Size = new Size(13, 15);
            lbTotalFiles.TabIndex = 3;
            lbTotalFiles.Text = "0";
            // 
            // lbBar
            // 
            lbBar.AutoSize = true;
            lbBar.Location = new Point(215, 6);
            lbBar.Name = "lbBar";
            lbBar.Size = new Size(12, 15);
            lbBar.TabIndex = 2;
            lbBar.Text = "/";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(146, 23);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(152, 23);
            progressBar1.TabIndex = 1;
            // 
            // lbFileProgress
            // 
            lbFileProgress.AutoSize = true;
            lbFileProgress.Location = new Point(189, 6);
            lbFileProgress.Name = "lbFileProgress";
            lbFileProgress.Size = new Size(13, 15);
            lbFileProgress.TabIndex = 0;
            lbFileProgress.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(557, 361);
            Controls.Add(tlpMainForm);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            tlpMainForm.ResumeLayout(false);
            tlpMainForm.PerformLayout();
            grpBoxSourceFolder.ResumeLayout(false);
            grpBoxSourceFolder.PerformLayout();
            grpBoxDestinationFolder.ResumeLayout(false);
            grpBoxDestinationFolder.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainForm;
        private GroupBox grpBoxSourceFolder;
        private GroupBox grpBoxDestinationFolder;
        private Button btnSourceFolder;
        private Button btnDestinationFolder;
        private TextBox txtSourceFolder;
        private TextBox txtDestinationFolder;
        private CheckedListBox clbSourceFolder;
        private Button btnGenerateXpp;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Label lbBar;
        public Label lbTotalFiles;
        public ProgressBar progressBar1;
        public Label lbFileProgress;
    }
}