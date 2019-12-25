using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonPRNG.LCG32;
using Pokemon3genRNGLibrary;

namespace EmIDSearcher
{
    public partial class CalcBackForm : Form
    {
        public CalcBackForm()
        {
            InitializeComponent();
            var pokeList = new List<Pokemon.Species>();
            for (int i = 0; i < 6; i++)
            {
                var mapList = Rom.Em.GetMapList((EncounterType)i).ToList();
                mapList.ForEach(_ => pokeList.AddRange(_.GetPokeList()));
            }

            pokeList = pokeList.Distinct().ToList();
            pokeList.Sort((a, b) => string.Compare(a.Name, b.Name));
            SortedPokemonList = pokeList.ToArray();
            PokemonBox.Items.AddRange(pokeList.Select(_ => _.Name).ToArray());
        }

        Pokemon.Species[] SortedPokemonList;
        Nature[] SortedNatureList;
        private void CalcBackForm_Load(object sender, EventArgs e)
        {
            SortedPokemonList = SortedPokemonList.ToArray();
            PokemonBox.Items.AddRange(SortedPokemonList.Select(_ => _.GetFullName()).ToArray());
            PokemonBox.SelectedIndex = 27;

            string[] encStr = new string[] { "くさむら", "なみのり", "ボロ", "いい", "すごい", "いわくだき" };
            var MapList = new List<string>();
            for(int i=0; i<6; i++)
            {
                var mapList = Rom.Em.GetMapNameList((EncounterType)i).Select(_ => _.RegaxReplace("[ ].*$", string.Empty).RegaxReplace("[(].*$", string.Empty)).ToArray();
                Array.Sort(mapList);
                MapList.AddRange(mapList);
            }

            List<(string mapName, int tag)> TaggedMapList = MapList.Select(_ => (_, _.Contains("すいどう") || _.Contains("どうろ") ? 0 : (_.Contains("タウン") || _.Contains("シティ") ? 1 : 2))).ToList();


            TaggedMapList.Sort((a, b) => ((a.tag - b.tag) << 1) + string.Compare(a.mapName, b.mapName));
            MapBox.Items.AddRange(TaggedMapList.Select(_ => _.mapName).Distinct().ToArray());
            MapBox.SelectedIndex = 0;


            var natures = Enumerable.Range(0, 25).Select(_ => ((Nature)_, ((Nature)_).ToJapanese())).ToList();
            natures.Sort((a, b) => string.Compare(a.Item2, b.Item2));
            SortedNatureList = natures.Select(_ => _.Item1).ToArray();
            NatureBox.Items.AddRange(natures.Select(_ => _.Item2).ToArray());
            NatureBox.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            uint HAB = (uint)IV_H.Value + ((uint)IV_A.Value << 5) + ((uint)IV_B.Value << 10);
            uint SCD = (uint)IV_S.Value + ((uint)IV_C.Value << 5) + ((uint)IV_D.Value << 10);

            var seedList = GeneratingSeedFinder.FindGeneratingSeed(HAB, SCD, false, false);
            seedList.AddRange(GeneratingSeedFinder.FindGeneratingSeed(HAB, SCD, false, true));
            seedList.AddRange(GeneratingSeedFinder.FindGeneratingSeed(HAB, SCD, true, false));

            // 全マップ参照する。効率悪いけど。マップ名がSelectedMapNameを含む && そのマップで当該ポケモンが出現するなら検索処理へ。
            // ネストの深さは罪の深さ。
            string targetMapName = MapBox.Text;
            uint targetLv = (uint)LvBox.Value;
            Nature targetNature = SortedNatureList[NatureBox.SelectedIndex];
            var targetPokemon = SortedPokemonList[PokemonBox.SelectedIndex];
            var resList = new List<GeneratingSeedResult>();
            for (int i = 0; i < 6; i++)
            {
                var mapList = Rom.Em.GetMapList((EncounterType)i);
                foreach(var map in mapList)
                {
                    if (map.GetMapName().Contains(targetMapName) && map.GetPokeList().Contains(targetPokemon))
                    {
                        foreach(var seed in seedList)
                        {
                            resList.AddRange(map.createSeedFinder(GenerateMethod.MiddleInterrupt).FindEncounterSeed(seed).Where(_=>_.Pokemon.Name == targetPokemon.Name && _.Pokemon.Lv == targetLv && _.Pokemon.Nature == targetNature));
                        }
                    }
                }
            }

            var PSVList = resList.Select(res => ((res.Pokemon.PID >> 16) ^ (res.Pokemon.PID & 0xFFFF)) >> 3).Distinct().ToArray();
            foreach(var PSV in PSVList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.SetValues(new object[] { PSV });
                dataGridView1.Rows.Add(row);
            }
        }


        private void TextBox_SelectText(object sender, EventArgs e) { ((TextBox)sender).SelectAll(); }
        private void NumericUpDown_SelectValue(object sender, EventArgs e) { ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length); }

    }
}
