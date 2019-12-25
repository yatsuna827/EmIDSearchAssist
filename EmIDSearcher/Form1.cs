using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon3genRNGLibrary;
using PokemonPRNG.LCG32;
using static PokemonPRNG.LCG32.LCG32;
using static EmIDSearcher.TSVManager;

namespace EmIDSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private List<IDListItem> IDListItems;
        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            uint minFrame = (uint)BaseFrame.Value;
            uint maxFrame = minFrame + (uint)MaxFrame.Value;

            uint TID = (uint)TIDBox.Value;

            uint InitialSeed = GetLCGSeed(TID, minFrame);

            uint seed = InitialSeed;

            IDListItems = new List<IDListItem>();
            for (uint frame = minFrame; frame <= maxFrame; frame++)
            {
                uint SID = seed.GetRand();

                IDListItems.Add(new IDListItem(frame, TID, SID));
            }
            IDListSource.DataSource = IDListItems;
        }
        
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (!(dataGridView1[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell cell)) return;

            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool)cell.Value;
        }

        private SearchTargetForm subForm2;
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1 || e.RowIndex < 0) return;
            DataGridViewTextBoxCell cell = dataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;

            if (subForm2 == null || subForm2.IsDisposed)
            {
                subForm2 = new SearchTargetForm();
                subForm2.Show(this);
            }
            subForm2.SID = uint.Parse($"{cell.Value}");
            subForm2.Activate();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var data = dataGridView1.Rows[e.RowIndex].DataBoundItem as IDListItem;

            if (data.isChecked)
                e.CellStyle.BackColor = Color.LightGray;
        }

        private void MenuItem_ReadCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                FileName = $"{TIDBox.Value}.csv",
                InitialDirectory = @"Data",
                Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*",
                FilterIndex = 1,
                Title = "読み込むファイルを選択してください",
                RestoreDirectory = true,
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var input = File.ReadAllLines(ofd.FileName);
                    foreach (var row in input)
                    {
                        var cell = row.Split(',');
                        if (!uint.TryParse(cell[0], out uint SV)) continue;
                        if (SV >= 0x2000) continue;
                        if (!bool.TryParse(cell[1], out bool isChecked)) continue;
                        SetTSVChecked(SV, isChecked);
                        if (!bool.TryParse(cell[2], out isChecked)) continue;
                        SetCapturedPokePSV(SV, isChecked);
                    }
                }
            }
        }

        private void MenuItem_WriteCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                FileName = $"{TIDBox.Value}.csv",
                InitialDirectory = @"Data",
                Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*",
                FilterIndex = 1,
                Title = "保存先を選択してください",
                RestoreDirectory = true,
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sfd.FileName, GetCheckList());
                }
            }
        }

        private CalcBackForm subForm;
        private void MenuItem_CalcBack_Click(object sender, EventArgs e)
        {
            if (subForm == null || subForm.IsDisposed)
            {
                subForm = new CalcBackForm();
                subForm.Show(this);
            }
            subForm.Activate();
        }


        private void TextBox_SelectText(object sender, EventArgs e) { ((TextBox)sender).SelectAll(); }
        private void NumericUpDown_SelectValue(object sender, EventArgs e) { ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length); }

    }
}
