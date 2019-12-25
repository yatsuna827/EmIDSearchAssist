using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmIDSearcher.TSVManager;

namespace EmIDSearcher
{
    class PSVListItem
    {
        public uint PSV { get; private set; }

        public bool isChecked { get { return GetCapturedPokePSV(PSV); } set { SetCapturedPokePSV(PSV, value); } }
        public PSVListItem(uint PSV)
        {
            this.PSV = PSV;
        }
    }
}
