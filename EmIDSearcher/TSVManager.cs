using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmIDSearcher
{
    static class TSVManager
    {
        private static readonly bool[] InputtedTSVCheckList = new bool[8192];
        private static readonly bool[] CapturedPokePSVCheckList = new bool[8192];
        public static bool GetTSVChecked(uint TSV)
        {
            return InputtedTSVCheckList[TSV & 0x1FFF] || CapturedPokePSVCheckList[TSV & 0x1FFF];
        }
        public static void SetTSVChecked(uint TSV, bool isChecked)
        {
            InputtedTSVCheckList[TSV & 0x1FFF] = isChecked;
        }
        public static bool GetCapturedPokePSV(uint PSV)
        {
            return CapturedPokePSVCheckList[PSV & 0x1FFF];
        }
        public static void SetCapturedPokePSV(uint PSV, bool b)
        {
            CapturedPokePSVCheckList[PSV & 0x1FFF] = b;
        }

        public static List<string> GetCheckList()
        {
            return Enumerable.Range(0, 8192).Select(i => $"{i},{InputtedTSVCheckList[i]},{CapturedPokePSVCheckList[i]}").ToList();
        }
    }
}
