using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltaronLyzer
{
    public class AL_DEBUG
    {
        private static RichTextBox m_logSpace;
        public static RichTextBox LogSpace
        {
            get { return m_logSpace; }
            private set { m_logSpace = value; }
        }

        public static void Log(string msg)
        {
            m_logSpace.Text += DateTime.Now + " :: " + msg + "\n";
        }

        public static void SetLogSpace(RichTextBox lSpace)
        {
            m_logSpace = lSpace;
        }
    }


}
