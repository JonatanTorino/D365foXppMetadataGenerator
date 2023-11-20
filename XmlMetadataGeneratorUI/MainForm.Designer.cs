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
            cmbDestinationFolder = new ComboBox();
            grpBoxDestinationFolder = new GroupBox();
            cmbSourceFolder = new ComboBox();
            btnGenerateXpp = new Button();
            btnDestinationFolder = new Button();
            btnSourceFolder = new Button();
            btnSourceFolder = new Button();
            tvFolders = new TreeView();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            lbTotalModel = new Label();
            lbModelBar = new Label();
            lbModelProgress = new Label();
            progressBarFiles = new ProgressBar();
            groupBox2 = new GroupBox();
            lbTotalFolder = new Label();
            lbFolderBar = new Label();
            lbFolderProgress = new Label();
            groupBox3 = new GroupBox();
            lbTotalFile = new Label();
            lbFileBar = new Label();
            lbFileProgress = new Label();
            progressBarModelos = new ProgressBar();
            progressBarFolders = new ProgressBar();
            tlpMainForm.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            grpBoxDestinationFolder.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            tlpMainForm.Location = new Point(0, 0);
            tlpMainForm.Controls.Add(groupBox1, 2, 4);
            tlpMainForm.Controls.Add(progressBarFiles, 0, 6);
            tlpMainForm.Controls.Add(groupBox2, 2, 5);
            tlpMainForm.Controls.Add(groupBox3, 2, 6);
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
            tlpMainForm.Size = new Size(549, 349);
            tlpMainForm.TabIndex = 0;
            // 
            // btnGenerateXpp
            // 
            btnGenerateXpp.Enabled = false;
            btnGenerateXpp.Location = new Point(468, 131);
            btnGenerateXpp.Anchor = AnchorStyles.None;
            btnGenerateXpp.Location = new Point(552, 198);
            btnGenerateXpp.Location = new Point(468, 131);
            btnGenerateXpp.Name = "btnGenerateXpp";
            btnGenerateXpp.Size = new Size(65, 70);
            btnGenerateXpp.TabIndex = 5;
            btnGenerateXpp.Text = "Generate";
            btnGenerateXpp.UseVisualStyleBackColor = true;
            btnGenerateXpp.Click += btnGenerateXpp_Click;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Anchor = AnchorStyles.None;
            btnSourceFolder.Location = new Point(552, 15);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(65, 30);
            btnSourceFolder.TabIndex = 3;
            btnSourceFolder.Text = "Folder";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // // btnDestinationFolder
            // 
            btnDestinationFolder.Anchor = AnchorStyles.None;
            btnDestinationFolder.Location = new Point(552, 75);
            btnDestinationFolder.Name = "btnDestinationFolder";
            btnDestinationFolder.Size = new Size(65, 30);
            btnDestinationFolder.TabIndex = 4;
            btnDestinationFolder.Text = "Folder";
            btnDestinationFolder.UseVisualStyleBackColor = true;
            btnDestinationFolder.Click += btnDestinationFolder_Click;
            // 
            // grpBoxDestinationFolder
            // 
            grpBoxDestinationFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxDestinationFolder.Controls.Add(cmbDestinationFolder);
            grpBoxDestinationFolder.Location = new Point(3, 63);
            grpBoxDestinationFolder.Name = "grpBoxDestinationFolder";
            grpBoxDestinationFolder.Size = new Size(531, 54);
            grpBoxDestinationFolder.TabIndex = 1;
            grpBoxDestinationFolder.TabStop = false;
            grpBoxDestinationFolder.Text = "Destination Folder";
            // 
            // cmbDestinationFolder
            // 
            cmbDestinationFolder.FormattingEnabled = true;
            cmbDestinationFolder.Location = new Point(3, 22);
            cmbDestinationFolder.Name = "cmbDestinationFolder";
            cmbDestinationFolder.Size = new Size(523, 23);
            cmbDestinationFolder.TabIndex = 1;
            // 
            // grpBoxSourceFolder
            // 
            grpBoxSourceFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxSourceFolder.Controls.Add(cmbSourceFolder);
            grpBoxSourceFolder.Location = new Point(3, 3);
            grpBoxSourceFolder.Name = "grpBoxSourceFolder";
            grpBoxSourceFolder.Size = new Size(531, 54);
            grpBoxSourceFolder.TabIndex = 0;
            grpBoxSourceFolder.TabStop = false;
            grpBoxSourceFolder.Text = "Source Folder";
            // 
            // cmbSourceFolder
            // 
            cmbSourceFolder.FormattingEnabled = true;
            cmbSourceFolder.Location = new Point(3, 19);
            cmbSourceFolder.Name = "cmbSourceFolder";
            cmbSourceFolder.Size = new Size(523, 23);
            cmbSourceFolder.TabIndex = 1;
            // 
            // checkBox1
            //
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 229);
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
            tvFolders.Location = new Point(3, 131);
            tvFolders.Name = "tvFolders";
            tvFolders.Size = new Size(459, 130);
            tvFolders.TabIndex = 6;
            tvFolders.AfterCheck += tvFolders_AfterCheck;
            tvFolders.BeforeExpand += tvFolders_BeforeExpand;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTotalModel);
            groupBox1.Controls.Add(lbModelBar);
            groupBox1.Controls.Add(lbModelProgress);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(468, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(78, 31);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
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
            progressBarFiles.Location = new Point(3, 323);
            progressBarFiles.Name = "progressBarFiles";
            progressBarFiles.Size = new Size(180, 20);
            progressBarFiles.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbTotalFolder);
            groupBox2.Controls.Add(lbFolderBar);
            groupBox2.Controls.Add(lbFolderProgress);
            groupBox2.Location = new Point(468, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(78, 22);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(lbTotalFile);
            groupBox3.Controls.Add(lbFileBar);
            groupBox3.Controls.Add(lbFileProgress);
            groupBox3.Location = new Point(468, 323);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(78, 23);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
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
            progressBarModelos.Location = new Point(3, 258);
            progressBarModelos.Name = "progressBarModelos";
            progressBarModelos.Size = new Size(180, 23);
            progressBarModelos.TabIndex = 1;
            // 
            // progressBarFolders
            // 
            progressBarFolders.Location = new Point(3, 295);
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
            ClientSize = new Size(638, 399);
            Controls.Add(tlpMainForm);
            Name = "MainForm";
            Text = "XPP Generator";
            Text = "MainForm";
            tlpMainForm.ResumeLayout(false);
            tlpMainForm.PerformLayout();
            grpBoxSourceFolder.ResumeLayout(false);
            grpBoxSourceFolder.PerformLayout();
            grpBoxDestinationFolder.ResumeLayout(false);
            grpBoxDestinationFolder.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tlpMainForm;
        private GroupBox grpBoxSourceFolder;
        private GroupBox grpBoxDestinationFolder;
        private Button btnSourceFolder;
        private Button btnDestinationFolder;
        private ComboBox cmbSourceFolder;
        private ComboBox cmbDestinationFolder;
        private TreeView tvFolders;
        private Button btnGenerateXpp;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Label lbModelBar;
        public Label lbTotalModel;
        public ProgressBar progressBarModelos;
        public Label lbModelProgress;
        private ProgressBar progressBarFolders;
        private ProgressBar progressBarFiles;
        private GroupBox groupBox2;
        public Label lbTotalFolder;
        private Label lbFolderBar;
        public Label lbFolderProgress;
        private GroupBox groupBox3;
        public Label lbTotalFile;
        private Label lbFileBar;
        public Label lbFileProgress;
        #endregion
    }
}