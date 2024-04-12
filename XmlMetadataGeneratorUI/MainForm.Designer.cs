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
            grpFile = new GroupBox();
            progressBarFiles = new ProgressBar();
            lbProgressBarFiles = new Label();
            gbxFolder = new GroupBox();
            lbTotalFolder = new Label();
            lbFolderBar = new Label();
            lbFolderProgress = new Label();
            gbxFile = new GroupBox();
            lbTotalFile = new Label();
            lbFileBar = new Label();
            lbFileProgress = new Label();
            grpModel = new GroupBox();
            progressBarModelos = new ProgressBar();
            lbProgressBarModelos = new Label();
            grpFolder = new GroupBox();
            progressBarFolders = new ProgressBar();
            lbProgressBarFolders = new Label();
            tlpMainForm.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            grpBoxDestinationFolder.SuspendLayout();
            gbxModel.SuspendLayout();
            grpFile.SuspendLayout();
            gbxFolder.SuspendLayout();
            gbxFile.SuspendLayout();
            grpModel.SuspendLayout();
            grpFolder.SuspendLayout();
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
            tlpMainForm.Controls.Add(grpFile, 0, 6);
            tlpMainForm.Controls.Add(gbxFolder, 2, 5);
            tlpMainForm.Controls.Add(gbxFile, 2, 6);
            tlpMainForm.Controls.Add(grpModel, 0, 4);
            tlpMainForm.Controls.Add(grpFolder, 0, 5);
            tlpMainForm.Location = new Point(9, 0);
            tlpMainForm.Name = "tlpMainForm";
            tlpMainForm.RowCount = 7;
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpMainForm.Size = new Size(621, 400);
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
            btnGenerateXpp.Location = new Point(546, 161);
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
            checkBox1.Location = new Point(3, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Select all";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tvFolders
            // 
            tvFolders.CheckBoxes = true;
            tvFolders.Dock = DockStyle.Fill;
            tvFolders.Location = new Point(3, 123);
            tvFolders.Name = "tvFolders";
            tvFolders.Size = new Size(531, 146);
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
            gbxModel.Location = new Point(540, 307);
            gbxModel.Name = "gbxModel";
            gbxModel.Size = new Size(78, 26);
            gbxModel.TabIndex = 6;
            gbxModel.TabStop = false;
            // 
            // lbTotalModel
            // 
            lbTotalModel.AutoSize = true;
            lbTotalModel.Location = new Point(48, 8);
            lbTotalModel.Name = "lbTotalModel";
            lbTotalModel.Size = new Size(13, 15);
            lbTotalModel.TabIndex = 3;
            lbTotalModel.Text = "0";
            // 
            // lbModelBar
            // 
            lbModelBar.AutoSize = true;
            lbModelBar.Location = new Point(30, 8);
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
            // grpFile
            // 
            grpFile.Controls.Add(progressBarFiles);
            grpFile.Controls.Add(lbProgressBarFiles);
            grpFile.Dock = DockStyle.Fill;
            grpFile.Location = new Point(3, 371);
            grpFile.Name = "grpFile";
            grpFile.Size = new Size(531, 26);
            grpFile.TabIndex = 6;
            grpFile.TabStop = false;
            // 
            // progressBarFiles
            // 
            progressBarFiles.Location = new Point(3, 3);
            progressBarFiles.Name = "progressBarFiles";
            progressBarFiles.Size = new Size(250, 23);
            progressBarFiles.TabIndex = 8;
            // 
            // lbProgressBarFiles
            // 
            lbProgressBarFiles.AutoSize = true;
            lbProgressBarFiles.Location = new Point(270, 3);
            lbProgressBarFiles.Name = "lbProgressBarFiles";
            lbProgressBarFiles.Size = new Size(30, 15);
            lbProgressBarFiles.TabIndex = 22;
            lbProgressBarFiles.Text = "Files";
            // 
            // gbxFolder
            // 
            gbxFolder.Controls.Add(lbTotalFolder);
            gbxFolder.Controls.Add(lbFolderBar);
            gbxFolder.Controls.Add(lbFolderProgress);
            gbxFolder.Location = new Point(540, 339);
            gbxFolder.Name = "gbxFolder";
            gbxFolder.Size = new Size(78, 22);
            gbxFolder.TabIndex = 9;
            gbxFolder.TabStop = false;
            // 
            // lbTotalFolder
            // 
            lbTotalFolder.AutoSize = true;
            lbTotalFolder.Location = new Point(48, 4);
            lbTotalFolder.Name = "lbTotalFolder";
            lbTotalFolder.Size = new Size(13, 15);
            lbTotalFolder.TabIndex = 4;
            lbTotalFolder.Text = "0";
            // 
            // lbFolderBar
            // 
            lbFolderBar.AutoSize = true;
            lbFolderBar.Location = new Point(30, 4);
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
            gbxFile.Location = new Point(540, 371);
            gbxFile.Name = "gbxFile";
            gbxFile.Size = new Size(78, 23);
            gbxFile.TabIndex = 10;
            gbxFile.TabStop = false;
            // 
            // lbTotalFile
            // 
            lbTotalFile.AutoSize = true;
            lbTotalFile.Location = new Point(48, 5);
            lbTotalFile.Name = "lbTotalFile";
            lbTotalFile.Size = new Size(13, 15);
            lbTotalFile.TabIndex = 5;
            lbTotalFile.Text = "0";
            // 
            // lbFileBar
            // 
            lbFileBar.AutoSize = true;
            lbFileBar.Location = new Point(30, 5);
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
            // grpModel
            // 
            grpModel.Controls.Add(progressBarModelos);
            grpModel.Controls.Add(lbProgressBarModelos);
            grpModel.Dock = DockStyle.Fill;
            grpModel.Location = new Point(3, 307);
            grpModel.Name = "grpModel";
            grpModel.Size = new Size(531, 26);
            grpModel.TabIndex = 6;
            grpModel.TabStop = false;
            // 
            // progressBarModelos
            // 
            progressBarModelos.Location = new Point(3, 2);
            progressBarModelos.Name = "progressBarModelos";
            progressBarModelos.Size = new Size(250, 23);
            progressBarModelos.TabIndex = 1;
            // 
            // lbProgressBarModelos
            // 
            lbProgressBarModelos.Location = new Point(270, 2);
            lbProgressBarModelos.Name = "lbProgressBarModelos";
            lbProgressBarModelos.Size = new Size(60, 23);
            lbProgressBarModelos.TabIndex = 20;
            lbProgressBarModelos.Text = "Models";
            // 
            // grpFolder
            // 
            grpFolder.Controls.Add(progressBarFolders);
            grpFolder.Controls.Add(lbProgressBarFolders);
            grpFolder.Dock = DockStyle.Fill;
            grpFolder.Location = new Point(3, 339);
            grpFolder.Name = "grpFolder";
            grpFolder.Size = new Size(531, 26);
            grpFolder.TabIndex = 6;
            grpFolder.TabStop = false;
            // 
            // progressBarFolders
            // 
            progressBarFolders.Location = new Point(3, 2);
            progressBarFolders.Maximum = 5;
            progressBarFolders.Name = "progressBarFolders";
            progressBarFolders.Size = new Size(250, 23);
            progressBarFolders.TabIndex = 7;
            // 
            // lbProgressBarFolders
            // 
            lbProgressBarFolders.AutoSize = true;
            lbProgressBarFolders.Location = new Point(270, 3);
            lbProgressBarFolders.Name = "lbProgressBarFolders";
            lbProgressBarFolders.Size = new Size(45, 15);
            lbProgressBarFolders.TabIndex = 21;
            lbProgressBarFolders.Text = "Folders";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(635, 406);
            Controls.Add(tlpMainForm);
            Name = "MainForm";
            Text = "XML Metadata Generator";
            tlpMainForm.ResumeLayout(false);
            tlpMainForm.PerformLayout();
            grpBoxSourceFolder.ResumeLayout(false);
            grpBoxSourceFolder.PerformLayout();
            grpBoxDestinationFolder.ResumeLayout(false);
            grpBoxDestinationFolder.PerformLayout();
            gbxModel.ResumeLayout(false);
            gbxModel.PerformLayout();
            grpFile.ResumeLayout(false);
            grpFile.PerformLayout();
            gbxFolder.ResumeLayout(false);
            gbxFolder.PerformLayout();
            gbxFile.ResumeLayout(false);
            gbxFile.PerformLayout();
            grpModel.ResumeLayout(false);
            grpFolder.ResumeLayout(false);
            grpFolder.PerformLayout();
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
        public Label lbProgressBarModelos;
        public Label lbProgressBarFolders;
        public Label lbProgressBarFiles;
        public GroupBox grpFile;
        public GroupBox grpFolder;
        public GroupBox grpModel;
        #endregion

        private TextBox txtSourceFolder1;
        private TextBox txtDestinationFolder1;
    }
}