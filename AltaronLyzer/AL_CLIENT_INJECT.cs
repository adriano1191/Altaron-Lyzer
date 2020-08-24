using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaronLyzer
{
    class AL_CLIENT_INJECT
    {
        private IntPtr m_cHandle;
        private IntPtr m_baseAddress;
        private IntPtr m_cHWND;

        public IntPtr cHandle { get { return m_cHandle; } }
        public IntPtr baseAddress { get { return m_baseAddress; } }
        public IntPtr cHWND { get { return m_cHWND; } }

        public AL_CLIENT_INJECT(Process proc)
        {
            this.m_cHandle = proc.Handle;
            this.m_baseAddress = proc.MainModule.BaseAddress;
            this.m_cHWND = proc.MainWindowHandle;
        }
    }
}
