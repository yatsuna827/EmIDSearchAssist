namespace EmIDSearcher
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TIDBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BaseFrame = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxFrame = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSV入出力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ReadCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_WriteCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CalcBack = new System.Windows.Forms.ToolStripMenuItem();
            this.frameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCheckedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDListSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TIDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDListSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TIDBox
            // 
            this.TIDBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIDBox.Location = new System.Drawing.Point(70, 39);
            this.TIDBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TIDBox.Name = "TIDBox";
            this.TIDBox.Size = new System.Drawing.Size(88, 22);
            this.TIDBox.TabIndex = 0;
            this.TIDBox.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "表ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "連打時の所要時間";
            // 
            // BaseFrame
            // 
            this.BaseFrame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseFrame.Location = new System.Drawing.Point(284, 38);
            this.BaseFrame.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.BaseFrame.Name = "BaseFrame";
            this.BaseFrame.Size = new System.Drawing.Size(88, 22);
            this.BaseFrame.TabIndex = 3;
            this.BaseFrame.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.BaseFrame.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "検索上限";
            // 
            // MaxFrame
            // 
            this.MaxFrame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxFrame.Location = new System.Drawing.Point(70, 67);
            this.MaxFrame.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.MaxFrame.Name = "MaxFrame";
            this.MaxFrame.Size = new System.Drawing.Size(88, 22);
            this.MaxFrame.TabIndex = 5;
            this.MaxFrame.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxFrame.Enter += new System.EventHandler(this.NumericUpDown_SelectValue);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "F";
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
            this.frameDataGridViewTextBoxColumn,
            this.sIDDataGridViewTextBoxColumn,
            this.isCheckedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.IDListSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(359, 343);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "メニュー";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSV入出力ToolStripMenuItem,
            this.MenuItem_CalcBack});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // cSV入出力ToolStripMenuItem
            // 
            this.cSV入出力ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ReadCSV,
            this.MenuItem_WriteCSV});
            this.cSV入出力ToolStripMenuItem.Name = "cSV入出力ToolStripMenuItem";
            this.cSV入出力ToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cSV入出力ToolStripMenuItem.Text = "CSV入出力";
            // 
            // MenuItem_ReadCSV
            // 
            this.MenuItem_ReadCSV.Name = "MenuItem_ReadCSV";
            this.MenuItem_ReadCSV.Size = new System.Drawing.Size(159, 22);
            this.MenuItem_ReadCSV.Text = "CSVから読み込み";
            this.MenuItem_ReadCSV.Click += new System.EventHandler(this.MenuItem_ReadCSV_Click);
            // 
            // MenuItem_WriteCSV
            // 
            this.MenuItem_WriteCSV.Name = "MenuItem_WriteCSV";
            this.MenuItem_WriteCSV.Size = new System.Drawing.Size(159, 22);
            this.MenuItem_WriteCSV.Text = "CSVに出力";
            this.MenuItem_WriteCSV.Click += new System.EventHandler(this.MenuItem_WriteCSV_Click);
            // 
            // MenuItem_CalcBack
            // 
            this.MenuItem_CalcBack.Name = "MenuItem_CalcBack";
            this.MenuItem_CalcBack.Size = new System.Drawing.Size(207, 22);
            this.MenuItem_CalcBack.Text = "捕獲済み個体から絞り込み";
            this.MenuItem_CalcBack.Click += new System.EventHandler(this.MenuItem_CalcBack_Click);
            // 
            // frameDataGridViewTextBoxColumn
            // 
            this.frameDataGridViewTextBoxColumn.DataPropertyName = "Frame";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.frameDataGridViewTextBoxColumn.HeaderText = "F";
            this.frameDataGridViewTextBoxColumn.Name = "frameDataGridViewTextBoxColumn";
            this.frameDataGridViewTextBoxColumn.ReadOnly = true;
            this.frameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.frameDataGridViewTextBoxColumn.Width = 37;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sIDDataGridViewTextBoxColumn.HeaderText = "裏ID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // IDListSource
            // 
            this.IDListSource.DataSource = typeof(EmIDSearcher.IDListItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxFrame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BaseFrame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TIDBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "EmIDSearcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TIDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDListSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BaseFrame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MaxFrame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource IDListSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCheckedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSV入出力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ReadCSV;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_WriteCSV;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_CalcBack;
    }
}

