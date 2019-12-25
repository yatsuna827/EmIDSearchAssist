using System;
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

namespace EmIDSearcher
{
    public partial class SearchTargetForm : Form
    {
        public SearchTargetForm()
        {
            InitializeComponent();
        }

        public uint TID { get; set; }
        public uint SID { get { return (uint)SIDBox.Value; } set { SIDBox.Value = value; } }
        private Nature[] SortedNature;

        private void SearchTargetForm_Load(object sender, EventArgs e)
        {
            EncounterTypeBox.SelectedIndex = 0;
            UpdateMapBox();

            var list = Enumerable.Range(0, 25).Select(i => ((Nature)i, ((Nature)i).ToJapanese())).ToList();
            list.Sort((a, b) => string.Compare(a.Item2, b.Item2));

            SortedNature = list.Select(_ => _.Item1).ToArray();
            SynchroBox.Items.Add("---");
            SynchroBox.Items.AddRange(list.Select(_ => _.Item2).ToArray());
            SynchroBox.SelectedIndex = 0;
        }
        private void UpdateMapBox()
        {
            MapBox.Items.Clear();

            var mapList = Rom.Em.GetMapNameList((EncounterType)EncounterTypeBox.SelectedIndex).ToArray();
            MapBox.Items.AddRange(mapList);
            MapBox.SelectedIndex = 0;
        }
        private void CheckForStationary_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            uint minFrame = (uint)MinFrame2.Value;
            uint maxFrame = minFrame + (uint)MaxFrame2.Value;

            uint InitialSeed = GetLCGSeed(0, minFrame);

            uint seed = InitialSeed;
            var generator = Rom.Em.GetStationarySymbol(0).createGenerator(GenerateMethod.Standard);

            uint TSV = TID ^ SID;

            for (uint frame = minFrame; frame <= maxFrame; frame++, seed.Advance())
            {
                var res = generator.Generate(seed);

                if (res.Pokemon.isShiny(TSV))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView2);
                    row.SetValues(new object[] { frame, $"{res.Pokemon.PID:X8}", res.Pokemon.Nature.ToJapanese() });
                    dataGridView2.Rows.Add(row);
                }
            }
        }
        private void CheckForWild_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();

            uint minFrame = (uint)MinFrame2.Value;
            uint maxFrame = minFrame + (uint)MaxFrame2.Value;

            uint InitialSeed = GetLCGSeed(0, minFrame);

            uint seed = InitialSeed;
            FieldAbility ability = (SynchroBox.SelectedIndex == 0) ? new FieldAbility.Other() as FieldAbility : new Synchronize(SortedNature[SynchroBox.SelectedIndex - 1]);
            var generator = Rom.Em.GetMap((EncounterType)EncounterTypeBox.SelectedIndex, MapBox.SelectedIndex).createGenerator(GenerateMethod.Standard, ability);

            uint TSV = TID ^ SID;

            for (uint frame = minFrame; frame <= maxFrame; frame++, seed.Advance())
            {
                var res = generator.Generate(seed);

                if (res.Pokemon.isShiny(TSV))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView3);
                    row.SetValues(new object[] { frame, $"{res.Pokemon.PID:X8}", res.Pokemon.Name, res.Pokemon.Lv, res.Pokemon.Nature.ToJapanese() });
                    dataGridView3.Rows.Add(row);
                }
            }
        }

        private void EncounterTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMapBox();
        }


        private void TextBox_SelectText(object sender, EventArgs e) { ((TextBox)sender).SelectAll(); }
        private void NumericUpDown_SelectValue(object sender, EventArgs e) { ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length); }

    }
}
