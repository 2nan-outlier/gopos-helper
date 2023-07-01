using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoHelper.Util
{
    /// <summary>
    /// 메시지 박스 공통단
    /// </summary>
    public static class Msg
    {
        /// <summary>
        /// 도움말 메시지박스
        /// </summary>
        /// <param name="msg"></param>
        public static void Info(string msg)
        {
            MessageBox.Show(msg, "도움말", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 경고 메시지박스
        /// </summary>
        /// <param name="msg"></param>
        public static void Warning(string msg)
        {
            MessageBox.Show(msg, "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 에러 메시지박스
        /// </summary>
        /// <param name="msg"></param>
        public static void Error(string msg)
        {
            MessageBox.Show(msg, "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 질의 메시지박스
        /// </summary>
        /// <param name="msg"></param>
        public static DialogResult Ask(string msg)
        {
            return MessageBox.Show(msg, "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
