using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmIDSearcher.TSVManager;

namespace EmIDSearcher
{
    class IDListItem
    {
        private readonly uint TID;
        public uint Frame { get; set; }
        public uint SID { get; set; }
        public bool isChecked { get { return GetTSVChecked(TID ^ SID); } set { SetTSVChecked(TID ^ SID, value); } }
        public IDListItem(uint Frame, uint TID, uint SID)
        {
            this.Frame = Frame;
            this.TID = TID;
            this.SID = SID;
        }
    }
}
