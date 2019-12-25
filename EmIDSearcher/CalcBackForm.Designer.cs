namespace EmIDSearcher
{
    partial class CalcBackForm
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
            this.components = new System.ComponentModel.Container();
            this.PokemonBox = new System.Windows.Forms.ComboBox();
            this.MapBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LvBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IV_H = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.IV_A = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NatureBox = new System.Windows.Forms.ComboBox();
            this.IV_B = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.IV_C = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IV_S = new System.Windows.Forms.NumericUpDown();
            this.IV_D = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCheckedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pSVListItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LvBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_D)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSVListItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PokemonBox
            // 
            this.PokemonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PokemonBox.FormattingEnabled = true;
            this.PokemonBox.Location = new System.Drawing.Point(17, 18);
            this.PokemonBox.Name = "PokemonBox";
            this.PokemonBox.Size = new System.Drawing.Size(100, 20);
            this.PokemonBox.TabIndex = 12;
            // 
            // MapBox
            // 
            this.MapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapBox.FormattingEnabled = true;
            this.MapBox.Location = new System.Drawing.Point(17, 68);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(160, 20);
            this.MapBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LvBox
            // 
            this.LvBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvBox.Location = new System.Drawing.Point(17, 122);
            this.LvBox.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LvBox.Name = "LvBox";
            this.LvBox.Size = new System.Drawing.Size(60, 22);
            this.LvBox.TabIndex = 15;
            this.LvBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LvBox.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "捕まえた時のレベル";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "捕まえたマップ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 39;
            this.label11.Text = "個体値";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 38;
            this.label10.Text = "性格";
            // 
            // IV_H
            // 
            this.IV_H.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IV_H.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IV_H.Location = new System.Drawing.Point(34, 233);
            this.IV_H.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IV_H.Name = "IV_H";
            this.IV_H.Size = new System.Drawing.Size(60, 22);
            this.IV_H.TabIndex = 25;
            this.IV_H.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "H";
            // 
            // IV_A
            // 
            this.IV_A.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IV_A.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IV_A.Location = new System.Drawing.Point(34, 261);
            this.IV_A.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IV_A.Name = "IV_A";
            this.IV_A.Size = new System.Drawing.Size(60, 22);
            this.IV_A.TabIndex = 27;
            this.IV_A.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "A";
            // 
            // NatureBox
            // 
            this.NatureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NatureBox.FormattingEnabled = true;
            this.NatureBox.Location = new System.Drawing.Point(17, 178);
            this.NatureBox.Name = "NatureBox";
            this.NatureBox.Size = new System.Drawing.Size(88, 20);
            this.NatureBox.TabIndex = 37;
            // 
            // IV_B
            // 
            this.IV_B.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IV_B.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IV_B.Location = new System.Drawing.Point(34, 289);
            this.IV_B.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IV_B.Name = "IV_B";
            this.IV_B.Size = new System.Drawing.Size(60, 22);
            this.IV_B.TabIndex = 29;
            this.IV_B.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "B";
            // 
            // IV_C
            // 
            this.IV_C.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IV_C.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IV_C.Location = new System.Drawing.Point(34, 317);
            this.IV_C.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IV_C.Name = "IV_C";
            this.IV_C.Size = new System.Drawing.Size(60, 22);
            this.IV_C.TabIndex = 31;
            this.IV_C.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "C";
            // 
            // IV_S
            // 
            this.IV_S.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IV_S.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IV_S.Location = new System.Drawing.Point(34, 373);
            this.IV_S.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IV_S.Name = "IV_S";
            this.IV_S.Size = new System.Drawing.Size(60, 22);
            this.IV_S.TabIndex = 35;
            this.IV_S.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // IV_D
            // 
            this.IV_D.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IV_D.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IV_D.Location = new System.Drawing.Point(34, 345);
            this.IV_D.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IV_D.Name = "IV_D";
            this.IV_D.Size = new System.Drawing.Size(60, 22);
            this.IV_D.TabIndex = 33;
            this.IV_D.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "D";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MapBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LvBox);
            this.groupBox1.Controls.Add(this.PokemonBox);
            this.groupBox1.Controls.Add(this.IV_H);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.IV_A);
            this.groupBox1.Controls.Add(this.IV_D);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IV_S);
            this.groupBox1.Controls.Add(this.NatureBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IV_B);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IV_C);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 405);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pSVDataGridViewTextBoxColumn,
            this.isCheckedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.pSVListItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(212, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(242, 405);
            this.dataGridView1.TabIndex = 40;
            // 
            // pSVDataGridViewTextBoxColumn
            // 
            this.pSVDataGridViewTextBoxColumn.DataPropertyName = "PSV";
            this.pSVDataGridViewTextBoxColumn.HeaderText = "PSV候補";
            this.pSVDataGridViewTextBoxColumn.Name = "pSVDataGridViewTextBoxColumn";
            this.pSVDataGridViewTextBoxColumn.ReadOnly = true;
            this.pSVDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pSVDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pSVDataGridViewTextBoxColumn.Width = 88;
            // 
            // isCheckedDataGridViewCheckBoxColumn
            // 
            this.isCheckedDataGridViewCheckBoxColumn.DataPropertyName = "isChecked";
            this.isCheckedDataGridViewCheckBoxColumn.HeaderText = "調べた";
            this.isCheckedDataGridViewCheckBoxColumn.Name = "isCheckedDataGridViewCheckBoxColumn";
            this.isCheckedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCheckedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isCheckedDataGridViewCheckBoxColumn.Width = 64;
            // 
            // pSVListItemBindingSource
            // 
            this.pSVListItemBindingSource.DataSource = typeof(EmIDSearcher.PSVListItem);
            // 
            // CalcBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalcBackForm";
            this.ShowIcon = false;
            this.Text = "CalcBackForm";
            this.Load += new System.EventHandler(this.CalcBackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LvBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IV_D)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSVListItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox PokemonBox;
        private System.Windows.Forms.ComboBox MapBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown LvBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown IV_H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IV_A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NatureBox;
        private System.Windows.Forms.NumericUpDown IV_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IV_C;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IV_S;
        private System.Windows.Forms.NumericUpDown IV_D;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pSVListItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCheckedDataGridViewCheckBoxColumn;
    }
}