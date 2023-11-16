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
            clbSourceFolder = new CheckedListBox();
            btnGenerateXpp = new Button();
            checkBox1 = new CheckBox();
            btnSourceFolder = new Button();
            btnDestinationFolder = new Button();
            grpBoxDestinationFolder = new GroupBox();
            cmbDestinationFolder = new ComboBox();
            grpBoxSourceFolder = new GroupBox();
            cmbSourceFolder = new ComboBox();
            tlpMainForm = new TableLayoutPanel();
            grpBoxDestinationFolder.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            tlpMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // clbSourceFolder
            // 
            clbSourceFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbSourceFolder.FormattingEnabled = true;
            clbSourceFolder.HorizontalScrollbar = true;
            clbSourceFolder.Location = new Point(3, 123);
            clbSourceFolder.Name = "clbSourceFolder";
            clbSourceFolder.Size = new Size(531, 220);
            clbSourceFolder.TabIndex = 2;
            // 
            // btnGenerateXpp
            // 
            btnGenerateXpp.Anchor = AnchorStyles.None;
            btnGenerateXpp.Location = new Point(552, 198);
            btnGenerateXpp.Name = "btnGenerateXpp";
            btnGenerateXpp.Size = new Size(65, 70);
            btnGenerateXpp.TabIndex = 5;
            btnGenerateXpp.Text = "Generate";
            btnGenerateXpp.UseVisualStyleBackColor = true;
            btnGenerateXpp.Click += btnGenerateXpp_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 350);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(531, 43);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Seleccionar todos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            // 
            // btnDestinationFolder
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
            // tlpMainForm
            // 
            tlpMainForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpMainForm.AutoSize = true;
            tlpMainForm.ColumnCount = 2;
            tlpMainForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlpMainForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpMainForm.Controls.Add(grpBoxSourceFolder, 0, 0);
            tlpMainForm.Controls.Add(grpBoxDestinationFolder, 0, 1);
            tlpMainForm.Controls.Add(clbSourceFolder, 0, 2);
            tlpMainForm.Controls.Add(checkBox1, 0, 3);
            tlpMainForm.Controls.Add(btnGenerateXpp, 1, 2);
            tlpMainForm.Controls.Add(btnSourceFolder, 1, 0);
            tlpMainForm.Controls.Add(btnDestinationFolder, 1, 1);
            tlpMainForm.Location = new Point(3, 3);
            tlpMainForm.Name = "tlpMainForm";
            tlpMainForm.RowCount = 4;
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 15.151515F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 15.151515F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 57.32323F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3737373F));
            tlpMainForm.Size = new Size(632, 396);
            tlpMainForm.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(638, 399);
            Controls.Add(tlpMainForm);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            grpBoxDestinationFolder.ResumeLayout(false);
            grpBoxSourceFolder.ResumeLayout(false);
            tlpMainForm.ResumeLayout(false);
            tlpMainForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbSourceFolder;
        private Button btnGenerateXpp;
        private CheckBox checkBox1;
        private Button btnSourceFolder;
        private Button btnDestinationFolder;
        private GroupBox grpBoxDestinationFolder;
        private GroupBox grpBoxSourceFolder;
        private TableLayoutPanel tlpMainForm;
        private ComboBox cmbDestinationFolder;
        private TextBox textBox1;
        private ComboBox cmbSourceFolder;
    }
}