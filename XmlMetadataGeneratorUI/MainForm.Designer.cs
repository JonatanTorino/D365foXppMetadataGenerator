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
            listBoxSuggestions = new ListBox();
            clbSourceFolder = new CheckedListBox();
            btnGenerateXpp = new Button();
            checkBox1 = new CheckBox();
            btnSourceFolder = new Button();
            btnDestinationFolder = new Button();
            grpBoxDestinationFolder = new GroupBox();
            txtDestinationFolder = new TextBox();
            grpBoxSourceFolder = new GroupBox();
            txtSourceFolder = new TextBox();
            tlpMainForm = new TableLayoutPanel();
            grpBoxDestinationFolder.SuspendLayout();
            grpBoxSourceFolder.SuspendLayout();
            tlpMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxSuggestions
            // 
            listBoxSuggestions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxSuggestions.FormattingEnabled = true;
            listBoxSuggestions.HorizontalScrollbar = true;
            listBoxSuggestions.ItemHeight = 15;
            listBoxSuggestions.Location = new Point(3, 48);
            listBoxSuggestions.Name = "listBoxSuggestions";
            listBoxSuggestions.Size = new Size(501, 49);
            listBoxSuggestions.TabIndex = 1;
            // 
            // clbSourceFolder
            // 
            clbSourceFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbSourceFolder.FormattingEnabled = true;
            clbSourceFolder.HorizontalScrollbar = true;
            clbSourceFolder.Location = new Point(3, 177);
            clbSourceFolder.Name = "clbSourceFolder";
            clbSourceFolder.Size = new Size(510, 166);
            clbSourceFolder.TabIndex = 2;
            // 
            // btnGenerateXpp
            // 
            btnGenerateXpp.Anchor = AnchorStyles.None;
            btnGenerateXpp.Location = new Point(520, 226);
            btnGenerateXpp.Name = "btnGenerateXpp";
            btnGenerateXpp.Size = new Size(83, 70);
            btnGenerateXpp.TabIndex = 5;
            btnGenerateXpp.Text = "Generate";
            btnGenerateXpp.UseVisualStyleBackColor = true;
            btnGenerateXpp.Click += btnGenerateXpp_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 352);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(510, 34);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Seleccionar todos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Anchor = AnchorStyles.None;
            btnSourceFolder.Location = new Point(520, 43);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(83, 30);
            btnSourceFolder.TabIndex = 3;
            btnSourceFolder.Text = "Folder";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // 
            // btnDestinationFolder
            // 
            btnDestinationFolder.Anchor = AnchorStyles.None;
            btnDestinationFolder.Location = new Point(520, 130);
            btnDestinationFolder.Name = "btnDestinationFolder";
            btnDestinationFolder.Size = new Size(83, 30);
            btnDestinationFolder.TabIndex = 4;
            btnDestinationFolder.Text = "Folder";
            btnDestinationFolder.UseVisualStyleBackColor = true;
            btnDestinationFolder.Click += btnDestinationFolder_Click;
            // 
            // grpBoxDestinationFolder
            // 
            grpBoxDestinationFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxDestinationFolder.Controls.Add(txtDestinationFolder);
            grpBoxDestinationFolder.Location = new Point(3, 119);
            grpBoxDestinationFolder.Name = "grpBoxDestinationFolder";
            grpBoxDestinationFolder.Size = new Size(510, 52);
            grpBoxDestinationFolder.TabIndex = 1;
            grpBoxDestinationFolder.TabStop = false;
            grpBoxDestinationFolder.Text = "Destination Folder";
            // 
            // txtDestinationFolder
            // 
            txtDestinationFolder.Dock = DockStyle.Fill;
            txtDestinationFolder.Location = new Point(3, 19);
            txtDestinationFolder.Name = "txtDestinationFolder";
            txtDestinationFolder.Size = new Size(504, 23);
            txtDestinationFolder.TabIndex = 0;
            // 
            // grpBoxSourceFolder
            // 
            grpBoxSourceFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxSourceFolder.Controls.Add(listBoxSuggestions);
            grpBoxSourceFolder.Controls.Add(txtSourceFolder);
            grpBoxSourceFolder.Location = new Point(3, 3);
            grpBoxSourceFolder.Name = "grpBoxSourceFolder";
            grpBoxSourceFolder.Size = new Size(510, 110);
            grpBoxSourceFolder.TabIndex = 0;
            grpBoxSourceFolder.TabStop = false;
            grpBoxSourceFolder.Text = "Source Folder";
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Dock = DockStyle.Fill;
            txtSourceFolder.Location = new Point(3, 19);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.Size = new Size(504, 23);
            txtSourceFolder.TabIndex = 0;
            txtSourceFolder.TextChanged += txtSourceFolder_TextChanged;
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
            tlpMainForm.Controls.Add(btnDestinationFolder, 1, 1);
            tlpMainForm.Controls.Add(btnGenerateXpp, 1, 2);
            tlpMainForm.Controls.Add(btnSourceFolder, 1, 0);
            tlpMainForm.Location = new Point(3, 3);
            tlpMainForm.Name = "tlpMainForm";
            tlpMainForm.RowCount = 4;
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlpMainForm.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpMainForm.Size = new Size(608, 389);
            tlpMainForm.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(617, 394);
            Controls.Add(tlpMainForm);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            grpBoxDestinationFolder.ResumeLayout(false);
            grpBoxDestinationFolder.PerformLayout();
            grpBoxSourceFolder.ResumeLayout(false);
            grpBoxSourceFolder.PerformLayout();
            tlpMainForm.ResumeLayout(false);
            tlpMainForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxSuggestions;
        private CheckedListBox clbSourceFolder;
        private Button btnGenerateXpp;
        private CheckBox checkBox1;
        private Button btnSourceFolder;
        private Button btnDestinationFolder;
        private GroupBox grpBoxDestinationFolder;
        private TextBox txtDestinationFolder;
        private GroupBox grpBoxSourceFolder;
        private TextBox txtSourceFolder;
        private TableLayoutPanel tlpMainForm;
    }
}