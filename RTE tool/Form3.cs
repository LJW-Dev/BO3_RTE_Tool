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

    public partial class Form3 : DevComponents.DotNetBar.OfficeForm
    {
        XRPC XRPC = new XRPC();
        uint p1a = 0x8451BE80;
        uint p2a = 0x84522084;
        uint p3a = 0x845281F0;
        uint p4a = 0x8452E3A8;
        public Form3()
        {
            InitializeComponent();
            XRPC.Connect();
        }

        private void giantcombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonX36_Click(object sender, EventArgs e)
        {

        }

        private void buttonX15_Click_1(object sender, EventArgs e)
        {

        }

        private void giant_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void soe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonX11_Click(object sender, EventArgs e)
        {

        }

        private void buttonX10_Click(object sender, EventArgs e)
        {

        }

        private void buttonX9_Click(object sender, EventArgs e)
        {

        }

        private void buttonX7_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonX9_Click_1(object sender, EventArgs e)
        {
            if (player1.Checked == true)
            {
                UInt32 player1g1 = 0x8451642B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player2.Checked == true)
            {
                UInt32 player1g1 = 0x8451C5E3;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player3.Checked == true)
            {
                UInt32 player1g1 = 0x8452279B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player4.Checked == true)
            {
                UInt32 player1g1 = 0x84528953;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
        }

        private void buttonX10_Click_1(object sender, EventArgs e)
        {
            if (player1.Checked == true)
            {
                UInt32 player1g2 = 0x845163DB;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
            }
            else if (player2.Checked == true)
            {
                UInt32 player1g2 = 0x8451C593;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
            }
            else if (player3.Checked == true)
            {
                UInt32 player1g2 = 0x8452274B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
            }
            else if (player4.Checked == true)
            {
                UInt32 player1g2 = 0x84528903;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g2, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g2, nop);
                    }
                }
            }
        }

        private void buttonX11_Click_1(object sender, EventArgs e)
        {
            if (player1.Checked == true)
            {
                byte[] p1 = XRPC.GetMemory(p1a, 15);
                String p1g = Encoding.ASCII.GetString(p1);
                var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
                XRPC.Call(0x82631630, 0, str1);
            }
            else if (player2.Checked == true)
            {
                byte[] p1 = XRPC.GetMemory(p2a, 15);
                String p1g = Encoding.ASCII.GetString(p1);
                var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
                XRPC.Call(0x82631630, 0, str1);
            }
            else if (player3.Checked == true)
            {
                byte[] p1 = XRPC.GetMemory(p3a, 15);
                String p1g = Encoding.ASCII.GetString(p1);
                var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
                XRPC.Call(0x82631630, 0, str1);
            }
            else if (player4.Checked == true)
            {
                byte[] p1 = XRPC.GetMemory(p4a, 15);
                String p1g = Encoding.ASCII.GetString(p1);
                var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
                XRPC.Call(0x82631630, 0, str1);
            }

            if (player1.Checked == true)
            {
                UInt32 player1g3 = 0x84516453;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
            }
            else if (player2.Checked == true)
            {
                UInt32 player1g3 = 0x8451C60B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
            }
            else if (player3.Checked == true)
            {
                UInt32 player1g3 = 0x845227C3;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
            }
            else if (player4.Checked == true)
            {
                UInt32 player1g3 = 0x8452897B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x07 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x09 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x1A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x20 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x22 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x26 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x24 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x41 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x59 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x61 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x86 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                    {
                        Byte[] nop = { 0x83 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x8A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x8B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                    {
                        Byte[] nop = { 0x93 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                    {
                        Byte[] nop = { 0x9F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA0 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x62 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x66 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x6E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x78 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Base Weapon")
                    {
                        Byte[] nop = { 0x63 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                    {
                        Byte[] nop = { 0x01 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x02 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x04 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x06 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x08 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x0A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x0C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x1B };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x1D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x1F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x21 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XR-2")
                    {
                        Byte[] nop = { 0x25 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x23 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x32 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x33 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x34 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x35 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x3C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x3E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x40 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x4A };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x4C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x4E };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "MR6")
                    {
                        Byte[] nop = { 0x56 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x57 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x58 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                    {
                        Byte[] nop = { 0x5F };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Rockets")
                    {
                        Byte[] nop = { 0x67 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                    {
                        Byte[] nop = { 0x68 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                    {
                        Byte[] nop = { 0x95 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x97 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                    {
                        Byte[] nop = { 0x73 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                    {
                        Byte[] nop = { 0x98 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                    {
                        Byte[] nop = { 0x99 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x91 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                    {
                        Byte[] nop = { 0x75 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                    {
                        Byte[] nop = { 0x8D };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                    {
                        Byte[] nop = { 0x7C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                    {
                        Byte[] nop = { 0x82 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                    {
                        Byte[] nop = { 0x88 };
                        XRPC.SetMemory(player1g3, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                    {
                        Byte[] nop = { 0x8C };
                        XRPC.SetMemory(player1g3, nop);
                    }
                }
            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            if (player1.Checked == true)
            {
                UInt32 player1g1 = 0x8451642B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player2.Checked == true)
            {
                UInt32 player1g1 = 0x8451C5E3;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player3.Checked == true)
            {
                UInt32 player1g1 = 0x8452279B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player4.Checked == true)
            {
                UInt32 player1g1 = 0x84528953;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (player1.Checked == true)
            {
                UInt32 player1g1 = 0x845163DB;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player2.Checked == true)
            {
                UInt32 player1g1 = 0x8451C593;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player3.Checked == true)
            {
                UInt32 player1g1 = 0x8452274B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player4.Checked == true)
            {
                UInt32 player1g1 = 0x84528903;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            if (player1.Checked == true)
            {
                byte[] p1 = XRPC.GetMemory(p1a, 15);
                String p1g = Encoding.ASCII.GetString(p1);
                var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
                XRPC.Call(0x82631630, 0, str1);
            }
            else if (player2.Checked == true)
            {
                byte[] p1 = XRPC.GetMemory(p2a, 15);
                String p1g = Encoding.ASCII.GetString(p1);
                var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
                XRPC.Call(0x82631630, 0, str1);
            }
            else if (player3.Checked == true)
            {
                byte[] p1 = XRPC.GetMemory(p3a, 15);
                String p1g = Encoding.ASCII.GetString(p1);
                var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
                XRPC.Call(0x82631630, 0, str1);
            }
            else if (player4.Checked == true)
            {
                byte[] p1 = XRPC.GetMemory(p4a, 15);
                String p1g = Encoding.ASCII.GetString(p1);
                var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
                XRPC.Call(0x82631630, 0, str1);
            }
            if (player1.Checked == true)
            {
                UInt32 player1g1 = 0x84516453;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player2.Checked == true)
            {
                UInt32 player1g1 = 0x8451C60B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player3.Checked == true)
            {
                UInt32 player1g1 = 0x845227C3;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
            else if (player4.Checked == true)
            {
                UInt32 player1g1 = 0x8452897B;
                if (soe.Checked == true)
                {
                    if (soecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (soecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x13 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x11 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x2A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x28 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x31 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x3A };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x47 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x43 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x45 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x49 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x51 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x53 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x55 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x92 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x89 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x8F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                    {
                        Byte[] nop = { 0x19 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                    {
                        Byte[] nop = { 0xA1 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                    {
                        Byte[] nop = { 0x7F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (giant.Checked == true)
                {
                    if (giantcombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x74 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                    {
                        Byte[] nop = { 0x77 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
                else if (castle.Checked == true)
                {
                    if (castlecombo.SelectedItem == null)
                    {
                        return;
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Vesper")
                    {
                        Byte[] nop = { 0x12 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "VMP")
                    {
                        Byte[] nop = { 0x15 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Kuda")
                    {
                        Byte[] nop = { 0x0E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Pharo")
                    {
                        Byte[] nop = { 0x10 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Weevil")
                    {
                        Byte[] nop = { 0x17 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Razorback")
                    {
                        Byte[] nop = { 0x14 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                    {
                        Byte[] nop = { 0x29 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KN-44")
                    {
                        Byte[] nop = { 0x27 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "M8A7")
                    {
                        Byte[] nop = { 0x2F };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                    {
                        Byte[] nop = { 0x30 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                    {
                        Byte[] nop = { 0x2B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                    {
                        Byte[] nop = { 0x2D };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                    {
                        Byte[] nop = { 0x38 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Argus")
                    {
                        Byte[] nop = { 0x37 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                    {
                        Byte[] nop = { 0x39 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                    {
                        Byte[] nop = { 0x36 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "BRM")
                    {
                        Byte[] nop = { 0x46 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Dingo")
                    {
                        Byte[] nop = { 0x42 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                    {
                        Byte[] nop = { 0x44 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                    {
                        Byte[] nop = { 0x48 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Locus")
                    {
                        Byte[] nop = { 0x50 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Drakon")
                    {
                        Byte[] nop = { 0x52 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                    {
                        Byte[] nop = { 0x54 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "RK5")
                    {
                        Byte[] nop = { 0x5B };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                    {
                        Byte[] nop = { 0x5C };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "XM-53")
                    {
                        Byte[] nop = { 0x5E };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                    {
                        Byte[] nop = { 0x96 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                    else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                    {
                        Byte[] nop = { 0x90 };
                        XRPC.SetMemory(player1g1, nop);
                    }
                }
            }
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {

        }

        private void buttonX13_Click(object sender, EventArgs e)
        {

        }

        private void buttonX12_Click(object sender, EventArgs e)
        {

        }

        private void soe_CheckedChanged_1(object sender, EventArgs e)
        {
            giantcombo.Enabled = false;
            giantcombo.Visible = false;
            castlecombo.Enabled = false;
            castlecombo.Visible = false;
            soecombo.Enabled = true;
            soecombo.Visible = true;
        }

        private void castlecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void giant_CheckedChanged_1(object sender, EventArgs e)
        {
            giantcombo.Enabled = true;
            giantcombo.Visible = true;
            soecombo.Enabled = false;
            soecombo.Visible = false;
            castlecombo.Enabled = false;
            castlecombo.Visible = false;
        }

        private void castle_CheckedChanged(object sender, EventArgs e)
        {
            giantcombo.Enabled = false;
            giantcombo.Visible = false;
            soecombo.Enabled = false;
            soecombo.Visible = false;
            castlecombo.Enabled = true;
            castlecombo.Visible = true;
        }
    }
}