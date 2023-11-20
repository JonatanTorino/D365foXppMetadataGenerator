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
            tlpMainForm.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            grpBoxDestinationFolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainForm
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
            tlpMainForm.Name = "tlpMainForm";
            tlpMainForm.RowCount = 4;
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpMainForm.Size = new Size(549, 293);
            tlpMainForm.TabIndex = 0;
            tlpMainForm.TabIndex = 0;
            // 
            // btnGenerateXpp
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
            checkBox1.Location = new Point(3, 267);
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
            ResumeLayout(false);
            PerformLayout();
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
        #endregion
    }
}