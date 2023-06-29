using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHelper.Util
{
    public static class Msg
    {
        public static void Info(string msg)
        {
            MessageBox.Show(msg, "도움말", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
