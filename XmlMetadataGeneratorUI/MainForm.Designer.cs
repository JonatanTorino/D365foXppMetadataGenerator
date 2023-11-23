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
            txtSourceFolder1 = new TextBox();
            grpBoxDestinationFolder = new GroupBox();
            txtDestinationFolder1 = new TextBox();
            btnGenerateXpp = new Button();
            btnDestinationFolder = new Button();
            btnSourceFolder = new Button();
            checkBox1 = new CheckBox();
            tvFolders = new TreeView();
            gbxModel = new GroupBox();
            lbTotalModel = new Label();
            lbModelBar = new Label();
            lbModelProgress = new Label();
            progressBarFiles = new ProgressBar();
            gbxFolder = new GroupBox();
            lbTotalFolder = new Label();
            lbFolderBar = new Label();
            lbFolderProgress = new Label();
            gbxFile = new GroupBox();
            lbTotalFile = new Label();
            lbFileBar = new Label();
            lbFileProgress = new Label();
            progressBarModelos = new ProgressBar();
            progressBarFolders = new ProgressBar();
            tlpMainForm.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            grpBoxDestinationFolder.SuspendLayout();
            gbxModel.SuspendLayout();
            gbxFolder.SuspendLayout();
            gbxFile.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainForm
            // 
            tlpMainForm.AutoSize = true;
            tlpMainForm.ColumnCount = 3;
            tlpMainForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainForm.ColumnStyles.Add(new ColumnStyle());
            tlpMainForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tlpMainForm.Controls.Add(grpBoxSourceFolder, 0, 0);
            tlpMainForm.Controls.Add(grpBoxDestinationFolder, 0, 1);
            tlpMainForm.Controls.Add(btnGenerateXpp, 2, 2);
            tlpMainForm.Controls.Add(btnDestinationFolder, 2, 1);
            tlpMainForm.Controls.Add(btnSourceFolder, 2, 0);
            tlpMainForm.Controls.Add(checkBox1, 0, 3);
            tlpMainForm.Controls.Add(tvFolders, 0, 2);
            tlpMainForm.Controls.Add(gbxModel, 2, 4);
            tlpMainForm.Controls.Add(progressBarFiles, 0, 6);
            tlpMainForm.Controls.Add(gbxFolder, 2, 5);
            tlpMainForm.Controls.Add(gbxFile, 2, 6);
            tlpMainForm.Controls.Add(progressBarModelos, 0, 4);
            tlpMainForm.Controls.Add(progressBarFolders, 0, 5);
            tlpMainForm.Location = new Point(9, 0);
            tlpMainForm.Name = "tlpMainForm";
            tlpMainForm.RowCount = 7;
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpMainForm.Size = new Size(621, 379);
            tlpMainForm.TabIndex = 0;
            // 
            // grpBoxSourceFolder
            // 
            grpBoxSourceFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxSourceFolder.Controls.Add(txtSourceFolder1);
            grpBoxSourceFolder.Location = new Point(3, 3);
            grpBoxSourceFolder.Name = "grpBoxSourceFolder";
            grpBoxSourceFolder.Size = new Size(531, 54);
            grpBoxSourceFolder.TabIndex = 0;
            grpBoxSourceFolder.TabStop = false;
            grpBoxSourceFolder.Text = "Source Folder";
            // 
            // txtSourceFolder1
            // 
            txtSourceFolder1.Location = new Point(0, 19);
            txtSourceFolder1.Name = "txtSourceFolder1";
            txtSourceFolder1.Size = new Size(526, 23);
            txtSourceFolder1.TabIndex = 1;
            // 
            // grpBoxDestinationFolder
            // 
            grpBoxDestinationFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxDestinationFolder.Controls.Add(txtDestinationFolder1);
            grpBoxDestinationFolder.Location = new Point(3, 63);
            grpBoxDestinationFolder.Name = "grpBoxDestinationFolder";
            grpBoxDestinationFolder.Size = new Size(531, 54);
            grpBoxDestinationFolder.TabIndex = 1;
            grpBoxDestinationFolder.TabStop = false;
            grpBoxDestinationFolder.Text = "Destination Folder";
            // 
            // txtDestinationFolder1
            // 
            txtDestinationFolder1.Location = new Point(0, 25);
            txtDestinationFolder1.Name = "txtDestinationFolder1";
            txtDestinationFolder1.Size = new Size(526, 23);
            txtDestinationFolder1.TabIndex = 1;
            // 
            // btnGenerateXpp
            // 
            btnGenerateXpp.Anchor = AnchorStyles.None;
            btnGenerateXpp.Enabled = false;
            btnGenerateXpp.Location = new Point(546, 153);
            btnGenerateXpp.Name = "btnGenerateXpp";
            btnGenerateXpp.Size = new Size(65, 70);
            btnGenerateXpp.TabIndex = 5;
            btnGenerateXpp.Text = "Generate";
            btnGenerateXpp.UseVisualStyleBackColor = true;
            btnGenerateXpp.Click += btnGenerateXpp_Click;
            // 
            // btnDestinationFolder
            // 
            btnDestinationFolder.Anchor = AnchorStyles.None;
            btnDestinationFolder.Location = new Point(546, 75);
            btnDestinationFolder.Name = "btnDestinationFolder";
            btnDestinationFolder.Size = new Size(65, 30);
            btnDestinationFolder.TabIndex = 4;
            btnDestinationFolder.Text = "Folder";
            btnDestinationFolder.UseVisualStyleBackColor = true;
            btnDestinationFolder.Click += btnDestinationFolder_Click;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Anchor = AnchorStyles.None;
            btnSourceFolder.Location = new Point(546, 15);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(65, 30);
            btnSourceFolder.TabIndex = 3;
            btnSourceFolder.Text = "Folder";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 259);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Seleccionar todos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tvFolders
            // 
            tvFolders.CheckBoxes = true;
            tvFolders.Dock = DockStyle.Fill;
            tvFolders.Location = new Point(3, 123);
            tvFolders.Name = "tvFolders";
            tvFolders.Size = new Size(531, 130);
            tvFolders.TabIndex = 6;
            tvFolders.AfterCheck += tvFolders_AfterCheck;
            tvFolders.BeforeExpand += tvFolders_BeforeExpand;
            // 
            // gbxModel
            // 
            gbxModel.Controls.Add(lbTotalModel);
            gbxModel.Controls.Add(lbModelBar);
            gbxModel.Controls.Add(lbModelProgress);
            gbxModel.Dock = DockStyle.Fill;
            gbxModel.Location = new Point(540, 288);
            gbxModel.Name = "gbxModel";
            gbxModel.Size = new Size(78, 31);
            gbxModel.TabIndex = 6;
            gbxModel.TabStop = false;
            // 
            // lbTotalModel
            // 
            lbTotalModel.AutoSize = true;
            lbTotalModel.Location = new Point(43, 8);
            lbTotalModel.Name = "lbTotalModel";
            lbTotalModel.Size = new Size(13, 15);
            lbTotalModel.TabIndex = 3;
            lbTotalModel.Text = "0";
            // 
            // lbModelBar
            // 
            lbModelBar.AutoSize = true;
            lbModelBar.Location = new Point(25, 8);
            lbModelBar.Name = "lbModelBar";
            lbModelBar.Size = new Size(12, 15);
            lbModelBar.TabIndex = 2;
            lbModelBar.Text = "/";
            // 
            // lbModelProgress
            // 
            lbModelProgress.AutoSize = true;
            lbModelProgress.Location = new Point(6, 8);
            lbModelProgress.Name = "lbModelProgress";
            lbModelProgress.Size = new Size(13, 15);
            lbModelProgress.TabIndex = 0;
            lbModelProgress.Text = "0";
            // 
            // progressBarFiles
            // 
            progressBarFiles.Location = new Point(3, 353);
            progressBarFiles.Name = "progressBarFiles";
            progressBarFiles.Size = new Size(180, 20);
            progressBarFiles.TabIndex = 8;
            // 
            // gbxFolder
            // 
            gbxFolder.Controls.Add(lbTotalFolder);
            gbxFolder.Controls.Add(lbFolderBar);
            gbxFolder.Controls.Add(lbFolderProgress);
            gbxFolder.Location = new Point(540, 325);
            gbxFolder.Name = "gbxFolder";
            gbxFolder.Size = new Size(78, 22);
            gbxFolder.TabIndex = 9;
            gbxFolder.TabStop = false;
            // 
            // lbTotalFolder
            // 
            lbTotalFolder.AutoSize = true;
            lbTotalFolder.Location = new Point(43, 4);
            lbTotalFolder.Name = "lbTotalFolder";
            lbTotalFolder.Size = new Size(13, 15);
            lbTotalFolder.TabIndex = 4;
            lbTotalFolder.Text = "0";
            // 
            // lbFolderBar
            // 
            lbFolderBar.AutoSize = true;
            lbFolderBar.Location = new Point(25, 4);
            lbFolderBar.Name = "lbFolderBar";
            lbFolderBar.Size = new Size(12, 15);
            lbFolderBar.TabIndex = 4;
            lbFolderBar.Text = "/";
            // 
            // lbFolderProgress
            // 
            lbFolderProgress.AutoSize = true;
            lbFolderProgress.Location = new Point(6, 4);
            lbFolderProgress.Name = "lbFolderProgress";
            lbFolderProgress.Size = new Size(13, 15);
            lbFolderProgress.TabIndex = 4;
            lbFolderProgress.Text = "0";
            // 
            // gbxFile
            // 
            gbxFile.Controls.Add(lbTotalFile);
            gbxFile.Controls.Add(lbFileBar);
            gbxFile.Controls.Add(lbFileProgress);
            gbxFile.Location = new Point(540, 353);
            gbxFile.Name = "gbxFile";
            gbxFile.Size = new Size(78, 23);
            gbxFile.TabIndex = 10;
            gbxFile.TabStop = false;
            // 
            // lbTotalFile
            // 
            lbTotalFile.AutoSize = true;
            lbTotalFile.Location = new Point(43, 5);
            lbTotalFile.Name = "lbTotalFile";
            lbTotalFile.Size = new Size(13, 15);
            lbTotalFile.TabIndex = 5;
            lbTotalFile.Text = "0";
            // 
            // lbFileBar
            // 
            lbFileBar.AutoSize = true;
            lbFileBar.Location = new Point(25, 5);
            lbFileBar.Name = "lbFileBar";
            lbFileBar.Size = new Size(12, 15);
            lbFileBar.TabIndex = 5;
            lbFileBar.Text = "/";
            // 
            // lbFileProgress
            // 
            lbFileProgress.AutoSize = true;
            lbFileProgress.Location = new Point(6, 5);
            lbFileProgress.Name = "lbFileProgress";
            lbFileProgress.Size = new Size(13, 15);
            lbFileProgress.TabIndex = 5;
            lbFileProgress.Text = "0";
            // 
            // progressBarModelos
            // 
            progressBarModelos.Location = new Point(3, 288);
            progressBarModelos.Name = "progressBarModelos";
            progressBarModelos.Size = new Size(180, 23);
            progressBarModelos.TabIndex = 1;
            // 
            // progressBarFolders
            // 
            progressBarFolders.Location = new Point(3, 325);
            progressBarFolders.Maximum = 5;
            progressBarFolders.Name = "progressBarFolders";
            progressBarFolders.Size = new Size(180, 19);
            progressBarFolders.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(635, 385);
            Controls.Add(tlpMainForm);
            Name = "MainForm";
            Text = "MainForm";
            tlpMainForm.ResumeLayout(false);
            tlpMainForm.PerformLayout();
            grpBoxSourceFolder.ResumeLayout(false);
            grpBoxSourceFolder.PerformLayout();
            grpBoxDestinationFolder.ResumeLayout(false);
            grpBoxDestinationFolder.PerformLayout();
            gbxModel.ResumeLayout(false);
            gbxModel.PerformLayout();
            gbxFolder.ResumeLayout(false);
            gbxFolder.PerformLayout();
            gbxFile.ResumeLayout(false);
            gbxFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel tlpMainForm;
        private GroupBox grpBoxSourceFolder;
        private GroupBox grpBoxDestinationFolder;
        private Button btnSourceFolder;
        private Button btnDestinationFolder;
        private TreeView tvFolders;
        private Button btnGenerateXpp;
        private CheckBox checkBox1;
        private GroupBox gbxModel;
        private Label lbModelBar;
        public Label lbTotalModel;
        public ProgressBar progressBarModelos;
        public Label lbModelProgress;
        private ProgressBar progressBarFolders;
        private ProgressBar progressBarFiles;
        private GroupBox gbxFolder;
        public Label lbTotalFolder;
        private Label lbFolderBar;
        public Label lbFolderProgress;
        private GroupBox gbxFile;
        public Label lbTotalFile;
        private Label lbFileBar;
        public Label lbFileProgress;
        #endregion

        private TextBox txtSourceFolder1;
        private TextBox txtDestinationFolder1;
    }
}