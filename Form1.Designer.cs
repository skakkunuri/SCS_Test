namespace SCS_Test
{
    partial class frmTeamAgencyAssignment
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
            this.TeamComboBox = new System.Windows.Forms.ComboBox();
            this.TeamSelectLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectedCountLabel = new System.Windows.Forms.Label();
            this.AllCountLabel = new System.Windows.Forms.Label();
            this.SelectedAgencyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllActiveAgencyDataGridView = new System.Windows.Forms.DataGridView();
            this.MoveAllToSelectedButton = new System.Windows.Forms.Button();
            this.MoveOneToAllbutton = new System.Windows.Forms.Button();
            this.MoveOneToSelectedButton = new System.Windows.Forms.Button();
            this.MoveSelectedToAllButton = new System.Windows.Forms.Button();
            this.SelectedAgencyNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchAllLabel = new System.Windows.Forms.Label();
            this.SearchAllTextBox = new System.Windows.Forms.TextBox();
            this.SearchAllClearButton = new System.Windows.Forms.Button();
            this.SearchSelectedClearButton = new System.Windows.Forms.Button();
            this.SearchAgencyTextbox = new System.Windows.Forms.TextBox();
            this.SearchSelectedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedAgencyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllActiveAgencyDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamComboBox
            // 
            this.TeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamComboBox.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamComboBox.FormattingEnabled = true;
            this.TeamComboBox.Items.AddRange(new object[] {
            "Team 1",
            "Team 2",
            "Team 3",
            "Team 4",
            "Team 5",
            "Team 6",
            "Team 7"});
            this.TeamComboBox.Location = new System.Drawing.Point(347, 37);
            this.TeamComboBox.Name = "TeamComboBox";
            this.TeamComboBox.Size = new System.Drawing.Size(204, 24);
            this.TeamComboBox.TabIndex = 1;
            this.TeamComboBox.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // TeamSelectLabel
            // 
            this.TeamSelectLabel.AutoSize = true;
            this.TeamSelectLabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamSelectLabel.Location = new System.Drawing.Point(257, 41);
            this.TeamSelectLabel.Name = "TeamSelectLabel";
            this.TeamSelectLabel.Size = new System.Drawing.Size(89, 14);
            this.TeamSelectLabel.TabIndex = 0;
            this.TeamSelectLabel.Text = "Select Team:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Active Unassigned Agencies:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchSelectedClearButton);
            this.groupBox1.Controls.Add(this.SearchAgencyTextbox);
            this.groupBox1.Controls.Add(this.SearchSelectedLabel);
            this.groupBox1.Controls.Add(this.SearchAllClearButton);
            this.groupBox1.Controls.Add(this.SearchAllTextBox);
            this.groupBox1.Controls.Add(this.SearchAllLabel);
            this.groupBox1.Controls.Add(this.SelectedCountLabel);
            this.groupBox1.Controls.Add(this.AllCountLabel);
            this.groupBox1.Controls.Add(this.SelectedAgencyDataGridView);
            this.groupBox1.Controls.Add(this.AllActiveAgencyDataGridView);
            this.groupBox1.Controls.Add(this.MoveAllToSelectedButton);
            this.groupBox1.Controls.Add(this.MoveOneToAllbutton);
            this.groupBox1.Controls.Add(this.MoveOneToSelectedButton);
            this.groupBox1.Controls.Add(this.MoveSelectedToAllButton);
            this.groupBox1.Controls.Add(this.SelectedAgencyNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Agencies";
            // 
            // SelectedCountLabel
            // 
            this.SelectedCountLabel.AutoSize = true;
            this.SelectedCountLabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedCountLabel.Location = new System.Drawing.Point(453, 332);
            this.SelectedCountLabel.Name = "SelectedCountLabel";
            this.SelectedCountLabel.Size = new System.Drawing.Size(56, 16);
            this.SelectedCountLabel.TabIndex = 11;
            this.SelectedCountLabel.Text = "Count: 0";
            // 
            // AllCountLabel
            // 
            this.AllCountLabel.AutoSize = true;
            this.AllCountLabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCountLabel.Location = new System.Drawing.Point(9, 332);
            this.AllCountLabel.Name = "AllCountLabel";
            this.AllCountLabel.Size = new System.Drawing.Size(56, 16);
            this.AllCountLabel.TabIndex = 10;
            this.AllCountLabel.Text = "Count: 0";
            // 
            // SelectedAgencyDataGridView
            // 
            this.SelectedAgencyDataGridView.AllowUserToAddRows = false;
            this.SelectedAgencyDataGridView.AllowUserToDeleteRows = false;
            this.SelectedAgencyDataGridView.AllowUserToOrderColumns = true;
            this.SelectedAgencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.SelectedAgencyDataGridView.Location = new System.Drawing.Point(453, 61);
            this.SelectedAgencyDataGridView.Name = "SelectedAgencyDataGridView";
            this.SelectedAgencyDataGridView.ReadOnly = true;
            this.SelectedAgencyDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SelectedAgencyDataGridView.RowHeadersVisible = false;
            this.SelectedAgencyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SelectedAgencyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedAgencyDataGridView.Size = new System.Drawing.Size(349, 268);
            this.SelectedAgencyDataGridView.TabIndex = 9;
            this.SelectedAgencyDataGridView.SelectionChanged += new System.EventHandler(this.SelectedAgencyDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Agency Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // AllActiveAgencyDataGridView
            // 
            this.AllActiveAgencyDataGridView.AllowUserToAddRows = false;
            this.AllActiveAgencyDataGridView.AllowUserToDeleteRows = false;
            this.AllActiveAgencyDataGridView.AllowUserToOrderColumns = true;
            this.AllActiveAgencyDataGridView.Location = new System.Drawing.Point(9, 61);
            this.AllActiveAgencyDataGridView.Name = "AllActiveAgencyDataGridView";
            this.AllActiveAgencyDataGridView.ReadOnly = true;
            this.AllActiveAgencyDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AllActiveAgencyDataGridView.RowHeadersVisible = false;
            this.AllActiveAgencyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AllActiveAgencyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllActiveAgencyDataGridView.Size = new System.Drawing.Size(349, 268);
            this.AllActiveAgencyDataGridView.TabIndex = 8;
            this.AllActiveAgencyDataGridView.SelectionChanged += new System.EventHandler(this.AllActiveAgencyDataGridView_SelectionChanged);
            // 
            // MoveAllToSelectedButton
            // 
            this.MoveAllToSelectedButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MoveAllToSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveAllToSelectedButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveAllToSelectedButton.ForeColor = System.Drawing.Color.White;
            this.MoveAllToSelectedButton.Location = new System.Drawing.Point(368, 131);
            this.MoveAllToSelectedButton.Name = "MoveAllToSelectedButton";
            this.MoveAllToSelectedButton.Size = new System.Drawing.Size(75, 23);
            this.MoveAllToSelectedButton.TabIndex = 2;
            this.MoveAllToSelectedButton.Text = ">>";
            this.MoveAllToSelectedButton.UseVisualStyleBackColor = false;
            this.MoveAllToSelectedButton.Click += new System.EventHandler(this.MoveAllToSelectedButton_Click);
            // 
            // MoveOneToAllbutton
            // 
            this.MoveOneToAllbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MoveOneToAllbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveOneToAllbutton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveOneToAllbutton.ForeColor = System.Drawing.Color.White;
            this.MoveOneToAllbutton.Location = new System.Drawing.Point(368, 189);
            this.MoveOneToAllbutton.Name = "MoveOneToAllbutton";
            this.MoveOneToAllbutton.Size = new System.Drawing.Size(75, 23);
            this.MoveOneToAllbutton.TabIndex = 4;
            this.MoveOneToAllbutton.Text = "<";
            this.MoveOneToAllbutton.UseVisualStyleBackColor = false;
            this.MoveOneToAllbutton.Click += new System.EventHandler(this.MoveOneToAllbutton_Click);
            // 
            // MoveOneToSelectedButton
            // 
            this.MoveOneToSelectedButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MoveOneToSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveOneToSelectedButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveOneToSelectedButton.ForeColor = System.Drawing.Color.White;
            this.MoveOneToSelectedButton.Location = new System.Drawing.Point(368, 160);
            this.MoveOneToSelectedButton.Name = "MoveOneToSelectedButton";
            this.MoveOneToSelectedButton.Size = new System.Drawing.Size(75, 23);
            this.MoveOneToSelectedButton.TabIndex = 3;
            this.MoveOneToSelectedButton.Text = ">";
            this.MoveOneToSelectedButton.UseVisualStyleBackColor = false;
            this.MoveOneToSelectedButton.Click += new System.EventHandler(this.MoveOneToSelectedButton_Click);
            // 
            // MoveSelectedToAllButton
            // 
            this.MoveSelectedToAllButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MoveSelectedToAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveSelectedToAllButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveSelectedToAllButton.ForeColor = System.Drawing.Color.White;
            this.MoveSelectedToAllButton.Location = new System.Drawing.Point(368, 218);
            this.MoveSelectedToAllButton.Name = "MoveSelectedToAllButton";
            this.MoveSelectedToAllButton.Size = new System.Drawing.Size(75, 23);
            this.MoveSelectedToAllButton.TabIndex = 5;
            this.MoveSelectedToAllButton.Text = "<<";
            this.MoveSelectedToAllButton.UseVisualStyleBackColor = false;
            this.MoveSelectedToAllButton.Click += new System.EventHandler(this.MoveSelectedToAllButton_Click);
            // 
            // SelectedAgencyNameLabel
            // 
            this.SelectedAgencyNameLabel.AutoSize = true;
            this.SelectedAgencyNameLabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedAgencyNameLabel.Location = new System.Drawing.Point(453, 15);
            this.SelectedAgencyNameLabel.Name = "SelectedAgencyNameLabel";
            this.SelectedAgencyNameLabel.Size = new System.Drawing.Size(133, 16);
            this.SelectedAgencyNameLabel.TabIndex = 6;
            this.SelectedAgencyNameLabel.Text = "Selected Agencies for:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(814, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Team and Agency assignment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(595, 427);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 25);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(700, 427);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(99, 25);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 17);
            this.StatusLabel.Text = "Ready...";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(4, 427);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 25);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Inventory";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchAllLabel
            // 
            this.SearchAllLabel.AutoSize = true;
            this.SearchAllLabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAllLabel.Location = new System.Drawing.Point(9, 39);
            this.SearchAllLabel.Name = "SearchAllLabel";
            this.SearchAllLabel.Size = new System.Drawing.Size(50, 16);
            this.SearchAllLabel.TabIndex = 12;
            this.SearchAllLabel.Text = "Search:";
            // 
            // SearchAllTextBox
            // 
            this.SearchAllTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchAllTextBox.Location = new System.Drawing.Point(59, 36);
            this.SearchAllTextBox.Name = "SearchAllTextBox";
            this.SearchAllTextBox.Size = new System.Drawing.Size(299, 22);
            this.SearchAllTextBox.TabIndex = 13;
            this.SearchAllTextBox.TextChanged += new System.EventHandler(this.SearchAllTextBox_TextChanged);
            // 
            // SearchAllClearButton
            // 
            this.SearchAllClearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchAllClearButton.Enabled = false;
            this.SearchAllClearButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAllClearButton.Location = new System.Drawing.Point(315, 36);
            this.SearchAllClearButton.Name = "SearchAllClearButton";
            this.SearchAllClearButton.Size = new System.Drawing.Size(43, 22);
            this.SearchAllClearButton.TabIndex = 14;
            this.SearchAllClearButton.Text = "X";
            this.SearchAllClearButton.UseVisualStyleBackColor = false;
            this.SearchAllClearButton.Click += new System.EventHandler(this.SearchAllClearButton_Click);
            // 
            // SearchSelectedClearButton
            // 
            this.SearchSelectedClearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchSelectedClearButton.Enabled = false;
            this.SearchSelectedClearButton.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSelectedClearButton.Location = new System.Drawing.Point(759, 36);
            this.SearchSelectedClearButton.Name = "SearchSelectedClearButton";
            this.SearchSelectedClearButton.Size = new System.Drawing.Size(43, 22);
            this.SearchSelectedClearButton.TabIndex = 17;
            this.SearchSelectedClearButton.Text = "X";
            this.SearchSelectedClearButton.UseVisualStyleBackColor = false;
            this.SearchSelectedClearButton.Click += new System.EventHandler(this.SearchSelectedClearButton_Click);
            // 
            // SearchAgencyTextbox
            // 
            this.SearchAgencyTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchAgencyTextbox.Location = new System.Drawing.Point(503, 36);
            this.SearchAgencyTextbox.Name = "SearchAgencyTextbox";
            this.SearchAgencyTextbox.Size = new System.Drawing.Size(299, 22);
            this.SearchAgencyTextbox.TabIndex = 16;
            // 
            // SearchSelectedLabel
            // 
            this.SearchSelectedLabel.AutoSize = true;
            this.SearchSelectedLabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSelectedLabel.Location = new System.Drawing.Point(453, 39);
            this.SearchSelectedLabel.Name = "SearchSelectedLabel";
            this.SearchSelectedLabel.Size = new System.Drawing.Size(50, 16);
            this.SearchSelectedLabel.TabIndex = 15;
            this.SearchSelectedLabel.Text = "Search:";
            // 
            // frmTeamAgencyAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(811, 479);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TeamSelectLabel);
            this.Controls.Add(this.TeamComboBox);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmTeamAgencyAssignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team & Agency assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedAgencyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllActiveAgencyDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TeamComboBox;
        private System.Windows.Forms.Label TeamSelectLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SelectedAgencyNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MoveSelectedToAllButton;
        private System.Windows.Forms.Button MoveAllToSelectedButton;
        private System.Windows.Forms.Button MoveOneToAllbutton;
        private System.Windows.Forms.Button MoveOneToSelectedButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView AllActiveAgencyDataGridView;
        private System.Windows.Forms.DataGridView SelectedAgencyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label SelectedCountLabel;
        private System.Windows.Forms.Label AllCountLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchAllClearButton;
        private System.Windows.Forms.TextBox SearchAllTextBox;
        private System.Windows.Forms.Label SearchAllLabel;
        private System.Windows.Forms.Button SearchSelectedClearButton;
        private System.Windows.Forms.TextBox SearchAgencyTextbox;
        private System.Windows.Forms.Label SearchSelectedLabel;
    }
}

