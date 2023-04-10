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
            clbSourceFolder = new CheckedListBox();
            btnSourceFolder = new Button();
            btnDestinationFolder = new Button();
            btnGenerateXpp = new Button();
            tlpMainForm.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            grpBoxDestinationFolder.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainForm
            // 
            tlpMainForm.ColumnCount = 2;
            tlpMainForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainForm.ColumnStyles.Add(new ColumnStyle());
            tlpMainForm.Controls.Add(grpBoxSourceFolder, 0, 0);
            tlpMainForm.Controls.Add(grpBoxDestinationFolder, 0, 1);
            tlpMainForm.Controls.Add(clbSourceFolder, 0, 2);
            tlpMainForm.Controls.Add(btnSourceFolder, 1, 0);
            tlpMainForm.Controls.Add(btnDestinationFolder, 1, 1);
            tlpMainForm.Controls.Add(btnGenerateXpp, 1, 2);
            tlpMainForm.Location = new Point(0, 0);
            tlpMainForm.Name = "tlpMainForm";
            tlpMainForm.RowCount = 3;
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle());
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainForm.Size = new Size(548, 319);
            tlpMainForm.TabIndex = 0;
            // 
            // grpBoxSourceFolder
            // 
            grpBoxSourceFolder.Controls.Add(txtSourceFolder);
            grpBoxSourceFolder.Dock = DockStyle.Fill;
            grpBoxSourceFolder.Location = new Point(3, 3);
            grpBoxSourceFolder.Name = "grpBoxSourceFolder";
            grpBoxSourceFolder.Size = new Size(461, 58);
            grpBoxSourceFolder.TabIndex = 0;
            grpBoxSourceFolder.TabStop = false;
            grpBoxSourceFolder.Text = "Source Folder";
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Dock = DockStyle.Fill;
            txtSourceFolder.Location = new Point(3, 19);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.Size = new Size(455, 23);
            txtSourceFolder.TabIndex = 0;
            txtSourceFolder.TextChanged += txtSourceFolder_TextChanged;
            // 
            // grpBoxDestinationFolder
            // 
            grpBoxDestinationFolder.Controls.Add(txtDestinationFolder);
            grpBoxDestinationFolder.Dock = DockStyle.Fill;
            grpBoxDestinationFolder.Location = new Point(3, 67);
            grpBoxDestinationFolder.Name = "grpBoxDestinationFolder";
            grpBoxDestinationFolder.Size = new Size(461, 58);
            grpBoxDestinationFolder.TabIndex = 1;
            grpBoxDestinationFolder.TabStop = false;
            grpBoxDestinationFolder.Text = "Destination Folder";
            // 
            // txtDestinationFolder
            // 
            txtDestinationFolder.Dock = DockStyle.Fill;
            txtDestinationFolder.Location = new Point(3, 19);
            txtDestinationFolder.Name = "txtDestinationFolder";
            txtDestinationFolder.Size = new Size(455, 23);
            txtDestinationFolder.TabIndex = 0;
            // 
            // clbSourceFolder
            // 
            clbSourceFolder.Dock = DockStyle.Fill;
            clbSourceFolder.FormattingEnabled = true;
            clbSourceFolder.Location = new Point(3, 131);
            clbSourceFolder.Name = "clbSourceFolder";
            clbSourceFolder.Size = new Size(461, 185);
            clbSourceFolder.TabIndex = 2;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Anchor = AnchorStyles.Left;
            btnSourceFolder.Location = new Point(470, 20);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(75, 23);
            btnSourceFolder.TabIndex = 3;
            btnSourceFolder.Text = "Folder";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // 
            // btnDestinationFolder
            // 
            btnDestinationFolder.Anchor = AnchorStyles.Left;
            btnDestinationFolder.Location = new Point(470, 84);
            btnDestinationFolder.Name = "btnDestinationFolder";
            btnDestinationFolder.Size = new Size(75, 23);
            btnDestinationFolder.TabIndex = 4;
            btnDestinationFolder.Text = "Folder";
            btnDestinationFolder.UseVisualStyleBackColor = true;
            btnDestinationFolder.Click += btnDestinationFolder_Click;
            // 
            // btnGenerateXpp
            // 
            btnGenerateXpp.Location = new Point(470, 131);
            btnGenerateXpp.Name = "btnGenerateXpp";
            btnGenerateXpp.Size = new Size(75, 23);
            btnGenerateXpp.TabIndex = 5;
            btnGenerateXpp.Text = "Generate";
            btnGenerateXpp.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 319);
            Controls.Add(tlpMainForm);
            Name = "MainForm";
            Text = "MainForm";
            tlpMainForm.ResumeLayout(false);
            grpBoxSourceFolder.ResumeLayout(false);
            grpBoxSourceFolder.PerformLayout();
            grpBoxDestinationFolder.ResumeLayout(false);
            grpBoxDestinationFolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainForm;
        private GroupBox grpBoxSourceFolder;
        private GroupBox grpBoxDestinationFolder;
        private CheckedListBox clbSourceFolder;
        private Button btnSourceFolder;
        private Button btnDestinationFolder;
        private Button btnGenerateXpp;
        private TextBox txtSourceFolder;
        private TextBox txtDestinationFolder;
    }
}