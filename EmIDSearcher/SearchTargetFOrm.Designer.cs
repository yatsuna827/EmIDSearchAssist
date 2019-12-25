namespace EmIDSearcher
{
    partial class SearchTargetForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Button_st = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SynchroBox = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_wild = new System.Windows.Forms.Button();
            this.EncounterTypeBox = new System.Windows.Forms.ComboBox();
            this.MapBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxFrame2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.MinFrame2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SIDBox = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinFrame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIDBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 370);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.Button_st);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "固定シンボルで調べる";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(6, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 30;
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.Size = new System.Drawing.Size(617, 303);
            this.dataGridView2.TabIndex = 8;
            // 
            // Button_st
            // 
            this.Button_st.Location = new System.Drawing.Point(6, 6);
            this.Button_st.Name = "Button_st";
            this.Button_st.Size = new System.Drawing.Size(75, 23);
            this.Button_st.TabIndex = 12;
            this.Button_st.Text = "計算";
            this.Button_st.UseVisualStyleBackColor = true;
            this.Button_st.Click += new System.EventHandler(this.CheckForStationary_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.SynchroBox);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.Button_wild);
            this.tabPage2.Controls.Add(this.EncounterTypeBox);
            this.tabPage2.Controls.Add(this.MapBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "野生で調べる";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "シンクロ";
            // 
            // SynchroBox
            // 
            this.SynchroBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SynchroBox.FormattingEnabled = true;
            this.SynchroBox.Location = new System.Drawing.Point(502, 9);
            this.SynchroBox.Name = "SynchroBox";
            this.SynchroBox.Size = new System.Drawing.Size(121, 20);
            this.SynchroBox.TabIndex = 22;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column3});
            this.dataGridView3.Location = new System.Drawing.Point(6, 35);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 30;
            this.dataGridView3.RowTemplate.Height = 21;
            this.dataGridView3.Size = new System.Drawing.Size(617, 303);
            this.dataGridView3.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "F";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn3.Width = 37;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "性格値";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ポケモン";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Lv";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "性格";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Button_wild
            // 
            this.Button_wild.Location = new System.Drawing.Point(6, 6);
            this.Button_wild.Name = "Button_wild";
            this.Button_wild.Size = new System.Drawing.Size(75, 23);
            this.Button_wild.TabIndex = 19;
            this.Button_wild.Text = "計算";
            this.Button_wild.UseVisualStyleBackColor = true;
            this.Button_wild.Click += new System.EventHandler(this.CheckForWild_Click);
            // 
            // EncounterTypeBox
            // 
            this.EncounterTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncounterTypeBox.FormattingEnabled = true;
            this.EncounterTypeBox.Items.AddRange(new object[] {
            "くさむら",
            "なみのり"});
            this.EncounterTypeBox.Location = new System.Drawing.Point(124, 8);
            this.EncounterTypeBox.Name = "EncounterTypeBox";
            this.EncounterTypeBox.Size = new System.Drawing.Size(88, 20);
            this.EncounterTypeBox.TabIndex = 21;
            this.EncounterTypeBox.Click += new System.EventHandler(this.EncounterTypeBox_SelectedIndexChanged);
            // 
            // MapBox
            // 
            this.MapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapBox.FormattingEnabled = true;
            this.MapBox.Location = new System.Drawing.Point(218, 8);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(200, 20);
            this.MapBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "～";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "F";
            // 
            // MaxFrame2
            // 
            this.MaxFrame2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxFrame2.Location = new System.Drawing.Point(179, 40);
            this.MaxFrame2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MaxFrame2.Name = "MaxFrame2";
            this.MaxFrame2.Size = new System.Drawing.Size(88, 22);
            this.MaxFrame2.TabIndex = 27;
            this.MaxFrame2.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxFrame2.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "F";
            // 
            // MinFrame2
            // 
            this.MinFrame2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinFrame2.Location = new System.Drawing.Point(44, 40);
            this.MinFrame2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MinFrame2.Name = "MinFrame2";
            this.MinFrame2.Size = new System.Drawing.Size(88, 22);
            this.MinFrame2.TabIndex = 25;
            this.MinFrame2.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "裏ID";
            // 
            // SIDBox
            // 
            this.SIDBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIDBox.Location = new System.Drawing.Point(44, 11);
            this.SIDBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.SIDBox.Name = "SIDBox";
            this.SIDBox.Size = new System.Drawing.Size(88, 22);
            this.SIDBox.TabIndex = 23;
            this.SIDBox.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "F";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 37;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "性格値";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "性格";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 64;
            // 
            // SearchTargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxFrame2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MinFrame2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SIDBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchTargetForm";
            this.ShowIcon = false;
            this.Text = "SearchTargetForm";
            this.Load += new System.EventHandler(this.SearchTargetForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinFrame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIDBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Button_st;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button Button_wild;
        private System.Windows.Forms.ComboBox EncounterTypeBox;
        private System.Windows.Forms.ComboBox MapBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MaxFrame2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MinFrame2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SIDBox;
        private System.Windows.Forms.ComboBox SynchroBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}