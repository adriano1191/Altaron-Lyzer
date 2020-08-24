using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AltaronLyzer
{
    public class AL_MEMORY_READER
    {
        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        private byte[] ReadBytes(IntPtr pHandle, IntPtr address, int bytesToRead)
        {
            int bytesRead = 0;
            byte[] buffer = new byte[bytesToRead];
            ReadProcessMemory(pHandle, address, buffer, bytesToRead, ref bytesRead);
            return buffer;
        }


        public int GetInt32(IntPtr pHandle, Int32 address) { return BitConverter.ToInt32(ReadBytes(pHandle, new IntPtr(address), 4), 0); }
        public int GetHealth(IntPtr pHandle, Int32 address) { return GetInt32(pHandle, address + (int)ADDRESSES.HEALTH_POINTS); }
        public int GetMaxHealth(IntPtr pHandle, Int32 address) { return GetInt32(pHandle, address + (int)ADDRESSES.MAX_HEALTH_POINTS); }
        public int GetMana(IntPtr pHandle, Int32 address) { return GetInt32(pHandle, address + (int)ADDRESSES.MANA_POINTS); }
        public int GetMaxMana(IntPtr pHandle, Int32 address) { return GetInt32(pHandle, address + (int)ADDRESSES.MAX_MANA_POINTS); }
        
    }
}
