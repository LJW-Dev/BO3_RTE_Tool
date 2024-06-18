using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using JRPC_Client;
using XDevkitPlusPlus;
using XRPCLib;
using XDevkit;

namespace RTE_tool
{
    public partial class Form2 : DevComponents.DotNetBar.OfficeForm
    {
        XRPC XRPC = new XRPC();
        public Form2()
        {
            InitializeComponent();
            XRPC.Connect();
            MessageBoxEx.EnableGlass = false;
        }

        private void buttonX50_Click(object sender, EventArgs e)
        {
            Byte[] me = XRPC.GetMemory(0x84516100, 12);
            XRPC.SetMemory(0x8451C2B8, me);   
        }

        private void buttonX49_Click(object sender, EventArgs e)
        {
            Byte[] me = XRPC.GetMemory(0x8451C2B8, 12);
            XRPC.SetMemory(0x84516100, me);
        }

        private void buttonX43_Click(object sender, EventArgs e)
        {
            Byte[] zom = XRPC.GetMemory(0x8451C2B8, 12);
            XRPC.SetMemory(0x83688B90, zom);
            XRPC.SetMemory(0x83688EE0, zom);
            XRPC.SetMemory(0x83689230, zom);
            XRPC.SetMemory(0x83689580, zom);
            XRPC.SetMemory(0x836898D0, zom);
            XRPC.SetMemory(0x83689C20, zom);
            XRPC.SetMemory(0x83689F70, zom);
            XRPC.SetMemory(0x8368A2C0, zom);
            XRPC.SetMemory(0x8368A610, zom);
            XRPC.SetMemory(0x8368A960, zom);
            XRPC.SetMemory(0x8368ACB0, zom);
            XRPC.SetMemory(0x8368B000, zom);
            XRPC.SetMemory(0x8368B350, zom);
            XRPC.SetMemory(0x8368B6A0, zom);
            XRPC.SetMemory(0x8368B9F0, zom);
            XRPC.SetMemory(0x8368BD40, zom);
            XRPC.SetMemory(0x8368C090, zom);
            XRPC.SetMemory(0x8368C3E0, zom);
            XRPC.SetMemory(0x8368C730, zom);
            XRPC.SetMemory(0x8368CA80, zom);
        }

        private void buttonX42_Click(object sender, EventArgs e)
        {
            Byte[] zom = XRPC.GetMemory(0x84516100, 12);
            XRPC.SetMemory(0x83688B90, zom);
            XRPC.SetMemory(0x83688EE0, zom);
            XRPC.SetMemory(0x83689230, zom);
            XRPC.SetMemory(0x83689580, zom);
            XRPC.SetMemory(0x836898D0, zom);
            XRPC.SetMemory(0x83689C20, zom);
            XRPC.SetMemory(0x83689F70, zom);
            XRPC.SetMemory(0x8368A2C0, zom);
            XRPC.SetMemory(0x8368A610, zom);
            XRPC.SetMemory(0x8368A960, zom);
            XRPC.SetMemory(0x8368ACB0, zom);
            XRPC.SetMemory(0x8368B000, zom);
            XRPC.SetMemory(0x8368B350, zom);
            XRPC.SetMemory(0x8368B6A0, zom);
            XRPC.SetMemory(0x8368B9F0, zom);
            XRPC.SetMemory(0x8368BD40, zom);
            XRPC.SetMemory(0x8368C090, zom);
            XRPC.SetMemory(0x8368C3E0, zom);
            XRPC.SetMemory(0x8368C730, zom);
            XRPC.SetMemory(0x8368CA80, zom);
        }

        private void buttonX44_Click(object sender, EventArgs e)
        {
            Byte[] zom = XRPC.GetMemory(0x84522470, 12);
            XRPC.SetMemory(0x83688B90, zom);
            XRPC.SetMemory(0x83688EE0, zom);
            XRPC.SetMemory(0x83689230, zom);
            XRPC.SetMemory(0x83689580, zom);
            XRPC.SetMemory(0x836898D0, zom);
            XRPC.SetMemory(0x83689C20, zom);
            XRPC.SetMemory(0x83689F70, zom);
            XRPC.SetMemory(0x8368A2C0, zom);
            XRPC.SetMemory(0x8368A610, zom);
            XRPC.SetMemory(0x8368A960, zom);
            XRPC.SetMemory(0x8368ACB0, zom);
            XRPC.SetMemory(0x8368B000, zom);
            XRPC.SetMemory(0x8368B350, zom);
            XRPC.SetMemory(0x8368B6A0, zom);
            XRPC.SetMemory(0x8368B9F0, zom);
            XRPC.SetMemory(0x8368BD40, zom);
            XRPC.SetMemory(0x8368C090, zom);
            XRPC.SetMemory(0x8368C3E0, zom);
            XRPC.SetMemory(0x8368C730, zom);
            XRPC.SetMemory(0x8368CA80, zom);
        }

        private void buttonX45_Click(object sender, EventArgs e)
        {
            Byte[] zom = XRPC.GetMemory(0x84528628, 12);
            XRPC.SetMemory(0x83688B90, zom);
            XRPC.SetMemory(0x83688EE0, zom);
            XRPC.SetMemory(0x83689230, zom);
            XRPC.SetMemory(0x83689580, zom);
            XRPC.SetMemory(0x836898D0, zom);
            XRPC.SetMemory(0x83689C20, zom);
            XRPC.SetMemory(0x83689F70, zom);
            XRPC.SetMemory(0x8368A2C0, zom);
            XRPC.SetMemory(0x8368A610, zom);
            XRPC.SetMemory(0x8368A960, zom);
            XRPC.SetMemory(0x8368ACB0, zom);
            XRPC.SetMemory(0x8368B000, zom);
            XRPC.SetMemory(0x8368B350, zom);
            XRPC.SetMemory(0x8368B6A0, zom);
            XRPC.SetMemory(0x8368B9F0, zom);
            XRPC.SetMemory(0x8368BD40, zom);
            XRPC.SetMemory(0x8368C090, zom);
            XRPC.SetMemory(0x8368C3E0, zom);
            XRPC.SetMemory(0x8368C730, zom);
            XRPC.SetMemory(0x8368CA80, zom);
        }

        private void buttonX38_Click(object sender, EventArgs e)
        {
            Byte[] them = XRPC.GetMemory(0x84522470, 12);
            XRPC.SetMemory(0x84516100, them);  
        }

        private void buttonX39_Click(object sender, EventArgs e)
        {
            Byte[] me = XRPC.GetMemory(0x84516100, 12);
            XRPC.SetMemory(0x84522470, me);  
        }

        private void buttonX41_Click(object sender, EventArgs e)
        {
            Byte[] me = XRPC.GetMemory(0x84516100, 12);
            XRPC.SetMemory(0x84528628, me);  
        }

        private void buttonX40_Click(object sender, EventArgs e)
        {
            Byte[] me = XRPC.GetMemory(0x84528628, 12);
            XRPC.SetMemory(0x84516100, me);  
        }
    }
}