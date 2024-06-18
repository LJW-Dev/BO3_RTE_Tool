using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using JRPC_Client;
using XDevkitPlusPlus;
using XRPCLib;
using XDevkit;


namespace RTE_tool
{
    public partial class Form1 : Office2007Form
    {
        XRPC XRPC = new XRPC();
        bool grav = false;
        bool fps = false;
        bool fall = false;
        bool god = false;
        bool redbox = false;
        bool Aemo = false;
        bool cmove = false;
        bool unspr = false;
        bool recoil = false;
        bool redbox2 = false;
        bool redbox3 = false;
        bool frate = false;
        bool spawn = false;
        uint p1a = 0x8451BE80;
        Byte[] amo = { 0x00, 0x00, 0x00, 0x64 };
        int jump = 1;
        int run = 1;
        public Form1()
        {
            InitializeComponent();
            MessageBoxEx.EnableGlass = false;
        }

        private void connect_Click_1(object sender, EventArgs e)
        {
            try
            {
                XRPC.Connect();
                if (XRPC.activeConnection == true)
                {
                    MessageBoxEx.Show("Connection Successful!", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    points.Enabled = true;
                    Fire.Enabled = true;
                    buttonX5.Enabled = true;
                    buttonX2.Enabled = true;
                    buttonX21.Enabled = true;
                    buttonX19.Enabled = true;
                    buttonX18.Enabled = true;
                    buttonX3.Enabled = true;
                    buttonX16.Enabled = true;
                    buttonX4.Enabled = true;
                    buttonX5.Enabled = true;
                    Dvar.Enabled = true;
                    buttonX7.Enabled = true;
                    buttonX2.Enabled = true;
                    tscalebutton.Enabled = true;
                    buttonX89.Enabled = true;
                    buttonX8.Enabled = true;
                    speed.Enabled = true;
                    lowgrav.Enabled = true;
                    nofall.Enabled = true;
                    buttonX25.Enabled = true;
                    jumpheight.Enabled = true;
                    buttonX9.Enabled = true;
                    buttonX10.Enabled = true;
                    buttonX11.Enabled = true;
                    buttonX14.Enabled = true;
                    buttonX12.Enabled = true;
                    buttonX87.Enabled = true;
                    buttonX13.Enabled = true;
                    checkBoxX1.Enabled = true;
                    buttonX15.Enabled = true;
                    buttonX7.Enabled = true;
                    buttonX86.Enabled = true;
                    buttonX17.Enabled = true;
                    buttonX88.Enabled = true;
                    buttonX90.Enabled = true;
                    buttonX16.Enabled = true;
                    buttonX18.Enabled = true;
                    buttonX19.Enabled = true;
                    buttonX48.Enabled = true;
                    buttonX49.Enabled = true;
                    buttonX50.Enabled = true;
                    buttonX63.Enabled = true;
                    buttonX21.Enabled = true;
                    buttonX20.Enabled = true;
                    buttonX24.Enabled = true;
                    buttonX45.Enabled = true;
                    buttonX67.Enabled = true;
                    buttonX65.Enabled = true;
                    buttonX66.Enabled = true;
                    buttonX36.Enabled = true;
                    buttonX35.Enabled = true;
                    buttonX37.Enabled = true;
                    buttonX46.Enabled = true;
                    buttonX47.Enabled = true;
                    buttonX29.Enabled = true;
                    buttonX23.Enabled = true;
                    buttonX22.Enabled = true;
                    buttonX34.Enabled = true;
                    buttonX38.Enabled = true;
                    buttonX28.Enabled = true;
                    buttonX30.Enabled = true;
                    buttonX31.Enabled = true;
                    buttonX32.Enabled = true;
                    buttonX33.Enabled = true;
                    buttonX22.Enabled = true;
                    buttonX23.Enabled = true;
                    buttonX53.Enabled = true;
                    buttonX54.Enabled = true;
                    buttonX55.Enabled = true;
                    buttonX6.Enabled = true;
                    buttonX56.Enabled = true;
                    buttonX69.Enabled = true;
                    buttonX47.Enabled = true;
                    buttonX52.Enabled = true;
                    buttonX57.Enabled = true;
                    buttonX58.Enabled = true;
                    buttonX59.Enabled = true;
                    buttonX60.Enabled = true;
                    buttonX61.Enabled = true;
                    buttonX62.Enabled = true;
                    buttonX1.Enabled = true;
                    buttonX51.Enabled = true;
                    buttonX75.Enabled = true;
                    buttonX76.Enabled = true;
                    buttonX74.Enabled = true;
                    buttonX80.Enabled = true;
                    buttonX81.Enabled = true;
                    buttonX82.Enabled = true;
                    buttonX83.Enabled = true;
                    buttonX39.Enabled = true;
                    buttonX40.Enabled = true;
                    buttonX41.Enabled = true;
                    buttonX42.Enabled = true;
                }
                else
                {
                    MessageBoxEx.Show("XRPC Connection Failed!", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ce)
            {
                MessageBoxEx.Show("No deafult console set!", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal unsafe static Int64 CanonicalHash(string fname, Int64 mulli)
        {
            string x = fname + "\0";
            fixed (char* c = x)
            {
                Int64 hash = (char.ToLower(*c) ^ mulli) * 0x1000193;
                for (int z = 1; z < x.Length; z++)
                    hash = (char.ToLower(x[z]) ^ hash) * 0x1000193;
                return hash;
            }
            return 0;
        }

        internal unsafe static Int64 CanonicalHashtu8(string fname)
        {
            string x = fname + "\0";
            fixed (char* c = x)
            {
                Int64 hash = (char.ToLower(*c) ^ 0xE5770569) * 0x1000193;
                for (int z = 1; z < x.Length; z++)
                    hash = (char.ToLower(x[z]) ^ hash) * 0x1000193;
                return hash;
            }
            return 0;
        }

        public double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        //public static class Globals
        //{
        //    public static int camo = 1; // Modifiable
        //}

        public void Noclip(int PlayerNum, Byte[] pX, Byte[] pY, Byte[] pZ, Byte[] Ppitch, Byte[] Pyaw)
        {
            Array.Reverse(pX);
            Array.Reverse(pY);
            Array.Reverse(pZ);
            Array.Reverse(Pyaw);
            Array.Reverse(Ppitch);
            float X = BitConverter.ToSingle(pX, 0);
            float Y = BitConverter.ToSingle(pY, 0);
            float Z = BitConverter.ToSingle(pZ, 0);
            float yaw = BitConverter.ToSingle(Pyaw, 0);
            float pit = BitConverter.ToSingle(Ppitch, 0);
            float pitch = pit * -1;
            //x
            float newX = (Convert.ToSingle(Math.Cos(DegreeToRadian(yaw))) * 60) + X;
            Byte[] BnewX = BitConverter.GetBytes(newX);
            Array.Reverse(BnewX);
            //y
            float newY = (Convert.ToSingle(Math.Sin(DegreeToRadian(yaw))) * 60) + Y;
            Byte[] BnewY = BitConverter.GetBytes(newY);
            Array.Reverse(BnewY);
            //z
            float newZ = (Convert.ToSingle(Math.Sin(DegreeToRadian(pitch))) * 60) + Z;
            Byte[] BnewZ = BitConverter.GetBytes(newZ);
            Array.Reverse(BnewZ);
            if (PlayerNum == 0)
            {
                XRPC.SetMemory(0x84516100, BnewX);
                XRPC.SetMemory(0x84516104, BnewY);
                XRPC.SetMemory(0x84516108, BnewZ);
            }
        }

        //public void AnglesToForwardAndScale(int PlayerNum, float scale)
        //{
        //    Byte[] pX = { 0x00, };
        //    Byte[] pY = { 0x00, }; 
        //    Byte[] pZ = { 0x00, };
        //    Byte[] Pyaw = { 0x00, };
        //    Byte[] Ppitch = { 0x00, };
        //    if (PlayerNum == 0)
        //    {
        //        pX = XRPC.GetMemory(0x84516100, 4);
        //        pY = XRPC.GetMemory(0x84516104, 4);
        //        pZ = XRPC.GetMemory(0x84516108, 4);
        //        Pyaw = XRPC.GetMemory(0x84516360, 4);
        //        Ppitch = XRPC.GetMemory(0x8451635C, 4);
        //    }
        //    else if (PlayerNum == 1)
        //    {
        //        pX = XRPC.GetMemory(0x84516100, 4);
        //        pY = XRPC.GetMemory(0x84516104, 4);
        //        pZ = XRPC.GetMemory(0x84516108, 4);
        //        Pyaw = XRPC.GetMemory(0x84516360, 4);
        //        Ppitch = XRPC.GetMemory(0x8451635C, 4);
        //    }
        //    else if (PlayerNum == 2)
        //    {
        //        pX = XRPC.GetMemory(0x84516100, 4);
        //        pY = XRPC.GetMemory(0x84516104, 4);
        //        pZ = XRPC.GetMemory(0x84516108, 4);
        //        Pyaw = XRPC.GetMemory(0x84516360, 4);
        //        Ppitch = XRPC.GetMemory(0x8451635C, 4);
        //    }
        //    else if (PlayerNum == 3)
        //    {
        //        pX = XRPC.GetMemory(0x84516100, 4);
        //        pY = XRPC.GetMemory(0x84516104, 4);
        //        pZ = XRPC.GetMemory(0x84516108, 4);
        //        Pyaw = XRPC.GetMemory(0x84516360, 4);
        //        Ppitch = XRPC.GetMemory(0x8451635C, 4);
        //    }
        //    Array.Reverse(pX);
        //    Array.Reverse(pY);
        //    Array.Reverse(pZ);
        //    Array.Reverse(Pyaw);
        //    Array.Reverse(Ppitch);
        //    float X = BitConverter.ToSingle(pX, 0);
        //    float Y = BitConverter.ToSingle(pY, 0);
        //    float Z = BitConverter.ToSingle(pZ, 0);
        //    float yaw = BitConverter.ToSingle(Pyaw, 0);
        //    float pitch = BitConverter.ToSingle(Ppitch, 0) * -1;
        //    //x
        //    float fnewX = (Convert.ToSingle(Math.Cos(DegreeToRadian(yaw))) * scale) + X;
        //    Byte[] newX = BitConverter.GetBytes(fnewX);
        //    Array.Reverse(newX);
        //    //y
        //    float fnewY = (Convert.ToSingle(Math.Sin(DegreeToRadian(yaw))) * scale) + Y;
        //    Byte[] newY = BitConverter.GetBytes(fnewY);
        //    Array.Reverse(newY);
        //    //z
        //    float fnewZ = (Convert.ToSingle(Math.Sin(DegreeToRadian(pitch))) * scale) + Z;
        //    Byte[] newZ = BitConverter.GetBytes(fnewZ);
        //    Array.Reverse(newZ);
        //}

        private void points_Click_1(object sender, EventArgs e)
        {
            Byte[] points = { 0x00, 0x01, 0xA6, 0xA0 };
            XRPC.SetMemory(0x8451BF5C, points);
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            if (Fire.TextColor == System.Drawing.Color.Red)
            {
                Fire.TextColor = System.Drawing.Color.Green;
                Byte[] firee = { 0x00, 0x00, 0x00, 0xFF };
                XRPC.SetMemory(0xC23B6728, firee);
            }
            else
            {
                Fire.TextColor = System.Drawing.Color.Red;
                Byte[] fireee = { 0x00, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0xC23B6728, fireee);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Byte[] specialclip = { 0x00, 0xFF, 0xFF, 0xFF };
            XRPC.SetMemory(0xC23B6644, specialclip);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            try
            {
                uint input = Convert.ToUInt32(AdressInput.Text, 16);
                byte[] bytes = XRPC.GetMemory(input, 4);
                string bitbytes = BitConverter.ToString(bytes);
                AdressOutput.Text = bitbytes;
            }
            catch (Exception ce)
            {

            }
        }

        private void Dvar_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            XRPC.Call(0x82631630, 0, textBoxX1.Text);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (fps == true)
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "cg_drawFPS 0");
                fps = false;
                buttonX2.Text = "Show FPS: Off";
            }
            else
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "cg_drawFPS 1");
                fps = true;
                buttonX2.Text = "Show FPS: On";
            }
        }

        private void tscalebutton_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            string data = tscale.Text;
            var str = String.Format("timescale {0}", data);
            XRPC.Call(0x82631630, 0, str);
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            uint p1a = 0x8451BE80;
            uint p2a = 0x84522084;
            uint p3a = 0x845281F0;
            uint p4a = 0x8452E3A8;
            byte[] p1 = XRPC.GetMemory(p1a, 15);
            byte[] p2 = XRPC.GetMemory(p2a, 15);
            byte[] p3 = XRPC.GetMemory(p3a, 15);
            byte[] p4 = XRPC.GetMemory(p4a, 15);
            String p1g = Encoding.ASCII.GetString(p1);
            String p2g = Encoding.ASCII.GetString(p2);
            String p3g = Encoding.ASCII.GetString(p3);
            String p4g = Encoding.ASCII.GetString(p4);
            player1.Text = p1g;
            player2.Text = p2g;
            player3.Text = p3g;
            player4.Text = p4g;
        }

        private void lowgrav_Click(object sender, EventArgs e)
        {
            if (grav == true)
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "bg_gravity 800");
                grav = false;
                lowgrav.Text = "Low Gravity: Off";
            }
            else
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "bg_gravity 150");
                grav = true;
                lowgrav.Text = "Low Gravity: On";
            }

        }

        private void nofall_Click(object sender, EventArgs e)
        {
            if (fall == true)
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "bg_falldamagemaxheight 300");
                fall = false;
                nofall.Text = "No Fall Damage: Off";
            }
            else
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "bg_falldamagemaxheight 100000");
                fall = true;
                nofall.Text = "No Fall Damage: On";
            }
        }

        private void jumpheight_Click(object sender, EventArgs e)
        {
            if (jump == 1)
            {
                Byte[] nop = { 0x42, 0xA0 };
                XRPC.SetMemory(0x8209C674, nop);
                jump = 2;
                jumpheight.Text = "Jump Height: 2x";
            }
            else if (jump == 2)
            {
                Byte[] nop = { 0x43, 0x20 };
                XRPC.SetMemory(0x8209C674, nop);
                jump = 4;
                jumpheight.Text = "Jump Height: 4x";
            }
            else if (jump == 4)
            {
                Byte[] nop = { 0x43, 0xA0 };
                XRPC.SetMemory(0x8209C674, nop);
                jump = 8;
                jumpheight.Text = "Jump Height: 8x";
            }
            else if (jump == 8)
            {
                Byte[] nop = { 0x42, 0x1C };
                XRPC.SetMemory(0x8209C674, nop);
                jump = 1;
                jumpheight.Text = "Jump Height: 1x";
            }
        }

        private void writeram_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x8209C674, nop);
        }

        private void buttonX4_Click_1(object sender, EventArgs e)
        {
            Byte[] amo = { 0x00, 0x00, 0x00, 0x64 };
            XRPC.SetMemory(0x8451660C, amo);
            if (soe.Checked == true)
            {
                if (soecombo.SelectedItem == null)
                {
                    return;
                }
                else if (soecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x13 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x11 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x2A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x28 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x31 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x47 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x43 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x45 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x49 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x51 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x53 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x55 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x92 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x89 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x8F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                {
                    Byte[] nop = { 0xA1 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                {
                    Byte[] nop = { 0x7F };
                    XRPC.SetMemory(0x845163DB, nop);
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
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x10 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x29 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x27 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x2F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x46 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x42 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x44 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x48 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x50 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x52 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x54 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x74 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x77 };
                    XRPC.SetMemory(0x845163DB, nop);
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
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x10 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x29 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x27 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x2F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x46 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x42 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x44 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x48 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x50 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x52 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x54 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x96 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                {
                    Byte[] nop = { 0x90 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
            }
        }

        private void soe_CheckedChanged(object sender, EventArgs e)
        {
            giantcombo.Enabled = false;
            giantcombo.Visible = false;
            castlecombo.Enabled = false;
            castlecombo.Visible = false;
            soecombo.Enabled = true;
            soecombo.Visible = true;
        }

        private void giant_CheckedChanged(object sender, EventArgs e)
        {
            giantcombo.Enabled = true;
            giantcombo.Visible = true;
            soecombo.Enabled = false;
            soecombo.Visible = false;
            castlecombo.Enabled = false;
            castlecombo.Visible = false;
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            Byte[] amo = { 0x00, 0x00, 0x00, 0x64 };
            XRPC.SetMemory(0x84516614, amo);
            if (soe.Checked == true)
            {
                if (soecombo.SelectedItem == null)
                {
                    return;
                }
                else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                {
                    Byte[] nop = { 0x66 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x07 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x09 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x1A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x20 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x22 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x26 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x24 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x41 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x59 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x61 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x63 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x86 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                {
                    Byte[] nop = { 0x83 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                {
                    Byte[] nop = { 0x88 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x8A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                {
                    Byte[] nop = { 0x8B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                {
                    Byte[] nop = { 0x8C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x90 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                {
                    Byte[] nop = { 0x93 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                {
                    Byte[] nop = { 0x9F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                {
                    Byte[] nop = { 0xA0 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                {
                    Byte[] nop = { 0x7E };
                    XRPC.SetMemory(0x8451642B, nop);
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
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x08 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x1F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x21 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x25 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x23 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x32 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x40 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x56 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x5F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x82 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Rockets")
                {
                    Byte[] nop = { 0x66 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                {
                    Byte[] nop = { 0x67 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x75 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                {
                    Byte[] nop = { 0x6E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x78 };
                    XRPC.SetMemory(0x8451642B, nop);
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
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x08 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x1F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x21 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x25 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x23 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x32 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x40 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x56 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x5F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Rockets")
                {
                    Byte[] nop = { 0x67 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                {
                    Byte[] nop = { 0x68 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x95 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x97 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                {
                    Byte[] nop = { 0x73 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                {
                    Byte[] nop = { 0x98 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                {
                    Byte[] nop = { 0x99 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                {
                    Byte[] nop = { 0x91 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                {
                    Byte[] nop = { 0x75 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                {
                    Byte[] nop = { 0x8D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                {
                    Byte[] nop = { 0x7C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                {
                    Byte[] nop = { 0x82 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                {
                    Byte[] nop = { 0x88 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                {
                    Byte[] nop = { 0x8C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
            }
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            Byte[] amo = { 0x00, 0x00, 0x00, 0x64 };
            XRPC.SetMemory(0x8451660C, amo);
            if (soe.Checked == true)
            {
                if (soecombo.SelectedItem == null)
                {
                    return;
                }
                else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                {
                    Byte[] nop = { 0x66 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x07 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x09 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x1A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x20 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x22 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x26 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x24 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x41 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x59 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x61 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x63 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x86 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                {
                    Byte[] nop = { 0x83 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                {
                    Byte[] nop = { 0x88 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x8A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                {
                    Byte[] nop = { 0x8B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                {
                    Byte[] nop = { 0x8C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x90 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                {
                    Byte[] nop = { 0x93 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                {
                    Byte[] nop = { 0x9F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                {
                    Byte[] nop = { 0xA0 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                {
                    Byte[] nop = { 0x7E };
                    XRPC.SetMemory(0x845163DB, nop);
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
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x08 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x1F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x21 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x25 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x23 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x32 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x40 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x56 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x5F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x82 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Rockets")
                {
                    Byte[] nop = { 0x66 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                {
                    Byte[] nop = { 0x67 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x75 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                {
                    Byte[] nop = { 0x6E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x78 };
                    XRPC.SetMemory(0x845163DB, nop);
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
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x08 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1B };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x1F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x21 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x25 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x23 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x32 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x40 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4A };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4E };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x56 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x5F };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Rockets")
                {
                    Byte[] nop = { 0x67 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                {
                    Byte[] nop = { 0x68 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x95 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x97 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                {
                    Byte[] nop = { 0x73 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                {
                    Byte[] nop = { 0x98 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                {
                    Byte[] nop = { 0x99 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                {
                    Byte[] nop = { 0x91 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                {
                    Byte[] nop = { 0x75 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                {
                    Byte[] nop = { 0x8D };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                {
                    Byte[] nop = { 0x7C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                {
                    Byte[] nop = { 0x82 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                {
                    Byte[] nop = { 0x88 };
                    XRPC.SetMemory(0x845163DB, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                {
                    Byte[] nop = { 0x8C };
                    XRPC.SetMemory(0x845163DB, nop);
                }
            }
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            byte[] p1 = XRPC.GetMemory(p1a, 15);
            String p1g = Encoding.ASCII.GetString(p1);
            var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
            var str2 = String.Format("setperk {0} specialty_additionalprimaryweapon", p1g);
            Byte[] nop1 = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop1);
            XRPC.SetMemory(0x826AC4F8, nop1);
            XRPC.Call(0x82631630, 0, str1);
            XRPC.Call(0x82631630, 0, str2);
            XRPC.SetMemory(0x84516618, amo);
            if (soe.Checked == true)
            {
                if (soecombo.SelectedItem == null)
                {
                    return;
                }
                else if (soecombo.SelectedItem.ToString() == "Base Weapon")
                {
                    Byte[] nop = { 0x66 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x07 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x09 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x1A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x20 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x22 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x26 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x24 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x41 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bloodhound")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x59 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x61 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x63 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x86 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "INTERDIMENSIONAL_GUN")
                {
                    Byte[] nop = { 0x83 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Lil Arnies")
                {
                    Byte[] nop = { 0x88 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x8A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Widows Wine Nades")
                {
                    Byte[] nop = { 0x8B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Semtex Nades")
                {
                    Byte[] nop = { 0x8C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x90 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Beast Mode Arms")
                {
                    Byte[] nop = { 0x93 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Insect Gun")
                {
                    Byte[] nop = { 0x9F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                {
                    Byte[] nop = { 0xA0 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                {
                    Byte[] nop = { 0x7E };
                    XRPC.SetMemory(0x84516453, nop);
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
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x08 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x1F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x21 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x25 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x23 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x32 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x40 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x56 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x5F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x82 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Rockets")
                {
                    Byte[] nop = { 0x66 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Slow Rockets")
                {
                    Byte[] nop = { 0x67 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x75 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Monkey Bombs")
                {
                    Byte[] nop = { 0x6E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x78 };
                    XRPC.SetMemory(0x84516453, nop);
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
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Deafult Weapon")
                {
                    Byte[] nop = { 0x01 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x02 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x04 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x06 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x08 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x0A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x0C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x1B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x1D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x1F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x21 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XR-2")
                {
                    Byte[] nop = { 0x25 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x23 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x32 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x33 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x34 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x35 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x3C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x3E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x40 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x4A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x4C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x4E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "MR6")
                {
                    Byte[] nop = { 0x56 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x57 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x58 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Combat Knife")
                {
                    Byte[] nop = { 0x5F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Rockets")
                {
                    Byte[] nop = { 0x67 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Slow Rockets")
                {
                    Byte[] nop = { 0x68 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Death Machine")
                {
                    Byte[] nop = { 0x95 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x97 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Monkey Bombs")
                {
                    Byte[] nop = { 0x73 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Widows Wine Nades")
                {
                    Byte[] nop = { 0x98 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Semtex Nades")
                {
                    Byte[] nop = { 0x99 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                {
                    Byte[] nop = { 0x91 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Panzer Spike Nades")
                {
                    Byte[] nop = { 0x75 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Wrath of the Ancients")
                {
                    Byte[] nop = { 0x8D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Shadow Bow")
                {
                    Byte[] nop = { 0x7C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Fire Bow")
                {
                    Byte[] nop = { 0x82 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Lightning Bow")
                {
                    Byte[] nop = { 0x88 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Wolf Bow")
                {
                    Byte[] nop = { 0x8C };
                    XRPC.SetMemory(0x84516453, nop);
                }
            }
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            if (camocombo.SelectedItem == null)
            {
                return;
            }
            else if (camocombo.SelectedItem.ToString() == "No Camo")
            {
                Byte[] nop = { 0x00 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Jungle Tech")
            {
                Byte[] nop = { 0x01 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ash")
            {
                Byte[] nop = { 0x02 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Flectarn")
            {
                Byte[] nop = { 0x03 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Heat Stroke")
            {
                Byte[] nop = { 0x04 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Snow Job")
            {
                Byte[] nop = { 0x05 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Dante")
            {
                Byte[] nop = { 0x06 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Integer")
            {
                Byte[] nop = { 0x07 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "6 Speed")
            {
                Byte[] nop = { 0x08 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Policia")
            {
                Byte[] nop = { 0x09 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ardent")
            {
                Byte[] nop = { 0x0A };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Burnt")
            {
                Byte[] nop = { 0x0B };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Bliss")
            {
                Byte[] nop = { 0x0C };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Battle")
            {
                Byte[] nop = { 0x0D };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Chameleon")
            {
                Byte[] nop = { 0x0E };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Gold")
            {
                Byte[] nop = { 0x0F };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Diamond")
            {
                Byte[] nop = { 0x10 };
                XRPC.SetMemory(0x845160D6, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Dark Matter")
            {
                Byte[] nop = { 0x11 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Arctic")
            {
                Byte[] nop = { 0x12 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Jungle")
            {
                Byte[] nop = { 0x13 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Huntsman")
            {
                Byte[] nop = { 0x14 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Woodlums")
            {
                Byte[] nop = { 0x15 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Contagious")
            {
                Byte[] nop = { 0x16 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Fear")
            {
                Byte[] nop = { 0x17 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "WMD")
            {
                Byte[] nop = { 0x18 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Red Hex")
            {
                Byte[] nop = { 0x19 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "SOE PaP Camo")
            {
                Byte[] nop = { 0x1A };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Black Ops III")
            {
                Byte[] nop = { 0x1B };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Cyborg")
            {
                Byte[] nop = { 0x1D };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "True Vet")
            {
                Byte[] nop = { 0x1E };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Snow Job")
            {
                Byte[] nop = { 0x1F };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "6 Speed")
            {
                Byte[] nop = { 0x20 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Take Out")
            {
                Byte[] nop = { 0x21 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ghostex: Delta 6")
            {
                Byte[] nop = { 0x22 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Nuk3Town")
            {
                Byte[] nop = { 0x23 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 1")
            {
                Byte[] nop = { 0x24 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Burnt")
            {
                Byte[] nop = { 0x25 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 2")
            {
                Byte[] nop = { 0x26 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 3")
            {
                Byte[] nop = { 0x27 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 4")
            {
                Byte[] nop = { 0x28 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 5")
            {
                Byte[] nop = { 0x29 };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Pack-A-Punch")
            {
                Byte[] nop = { 0x2A };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 6")
            {
                Byte[] nop = { 0x2B };
                XRPC.SetMemory(0x84516431, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Weaponized 115")
            {
                Byte[] nop = { 0x1C };
                XRPC.SetMemory(0x84516431, nop);
            }
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            if (camocombo.SelectedItem == null)
            {
                return;
            }
            else if (camocombo.SelectedItem.ToString() == "No Camo")
            {
                Byte[] nop = { 0x00 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Jungle Tech")
            {
                Byte[] nop = { 0x01 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ash")
            {
                Byte[] nop = { 0x02 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Flectarn")
            {
                Byte[] nop = { 0x03 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Heat Stroke")
            {
                Byte[] nop = { 0x04 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Snow Job")
            {
                Byte[] nop = { 0x05 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Dante")
            {
                Byte[] nop = { 0x06 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Integer")
            {
                Byte[] nop = { 0x07 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "6 Speed")
            {
                Byte[] nop = { 0x08 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Policia")
            {
                Byte[] nop = { 0x09 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ardent")
            {
                Byte[] nop = { 0x0A };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Burnt")
            {
                Byte[] nop = { 0x0B };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Bliss")
            {
                Byte[] nop = { 0x0C };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Battle")
            {
                Byte[] nop = { 0x0D };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Chameleon")
            {
                Byte[] nop = { 0x0E };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Gold")
            {
                Byte[] nop = { 0x0F };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Diamond")
            {
                Byte[] nop = { 0x10 };
                XRPC.SetMemory(0x845160D6, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Dark Matter")
            {
                Byte[] nop = { 0x11 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Arctic")
            {
                Byte[] nop = { 0x12 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Jungle")
            {
                Byte[] nop = { 0x13 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Huntsman")
            {
                Byte[] nop = { 0x14 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Woodlums")
            {
                Byte[] nop = { 0x15 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Contagious")
            {
                Byte[] nop = { 0x16 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Fear")
            {
                Byte[] nop = { 0x17 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "WMD")
            {
                Byte[] nop = { 0x18 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Red Hex")
            {
                Byte[] nop = { 0x19 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "SOE PaP Camo")
            {
                Byte[] nop = { 0x1A };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Black Ops III")
            {
                Byte[] nop = { 0x1B };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Cyborg")
            {
                Byte[] nop = { 0x1D };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "True Vet")
            {
                Byte[] nop = { 0x1E };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Snow Job")
            {
                Byte[] nop = { 0x1F };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "6 Speed")
            {
                Byte[] nop = { 0x20 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Take Out")
            {
                Byte[] nop = { 0x21 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ghostex: Delta 6")
            {
                Byte[] nop = { 0x22 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Nuk3Town")
            {
                Byte[] nop = { 0x23 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 1")
            {
                Byte[] nop = { 0x24 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Burnt")
            {
                Byte[] nop = { 0x25 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 2")
            {
                Byte[] nop = { 0x26 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 3")
            {
                Byte[] nop = { 0x27 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 4")
            {
                Byte[] nop = { 0x28 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 5")
            {
                Byte[] nop = { 0x29 };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Pack-A-Punch")
            {
                Byte[] nop = { 0x2A };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 6")
            {
                Byte[] nop = { 0x2B };
                XRPC.SetMemory(0x845163E1, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Weaponized 115")
            {
                Byte[] nop = { 0x1C };
                XRPC.SetMemory(0x845163E1, nop);
            }
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            if (camocombo.SelectedItem == null)
            {
                return;
            }
            else if (camocombo.SelectedItem.ToString() == "No Camo")
            {
                Byte[] nop = { 0x00 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Jungle Tech")
            {
                Byte[] nop = { 0x01 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ash")
            {
                Byte[] nop = { 0x02 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Flectarn")
            {
                Byte[] nop = { 0x03 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Heat Stroke")
            {
                Byte[] nop = { 0x04 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Snow Job")
            {
                Byte[] nop = { 0x05 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Dante")
            {
                Byte[] nop = { 0x06 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Integer")
            {
                Byte[] nop = { 0x07 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "6 Speed")
            {
                Byte[] nop = { 0x08 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Policia")
            {
                Byte[] nop = { 0x09 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ardent")
            {
                Byte[] nop = { 0x0A };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Burnt")
            {
                Byte[] nop = { 0x0B };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Bliss")
            {
                Byte[] nop = { 0x0C };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Battle")
            {
                Byte[] nop = { 0x0D };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Chameleon")
            {
                Byte[] nop = { 0x0E };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Gold")
            {
                Byte[] nop = { 0x0F };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Diamond")
            {
                Byte[] nop = { 0x10 };
                XRPC.SetMemory(0x845160D6, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Dark Matter")
            {
                Byte[] nop = { 0x11 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Arctic")
            {
                Byte[] nop = { 0x12 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Jungle")
            {
                Byte[] nop = { 0x13 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Huntsman")
            {
                Byte[] nop = { 0x14 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Woodlums")
            {
                Byte[] nop = { 0x15 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Contagious")
            {
                Byte[] nop = { 0x16 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Fear")
            {
                Byte[] nop = { 0x17 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "WMD")
            {
                Byte[] nop = { 0x18 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Red Hex")
            {
                Byte[] nop = { 0x19 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "SOE PaP Camo")
            {
                Byte[] nop = { 0x1A };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Black Ops III")
            {
                Byte[] nop = { 0x1B };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Cyborg")
            {
                Byte[] nop = { 0x1D };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "True Vet")
            {
                Byte[] nop = { 0x1E };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Snow Job")
            {
                Byte[] nop = { 0x1F };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "6 Speed")
            {
                Byte[] nop = { 0x20 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Take Out")
            {
                Byte[] nop = { 0x21 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Ghostex: Delta 6")
            {
                Byte[] nop = { 0x22 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Nuk3Town")
            {
                Byte[] nop = { 0x23 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 1")
            {
                Byte[] nop = { 0x24 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Burnt")
            {
                Byte[] nop = { 0x25 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 2")
            {
                Byte[] nop = { 0x26 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 3")
            {
                Byte[] nop = { 0x27 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 4")
            {
                Byte[] nop = { 0x28 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 5")
            {
                Byte[] nop = { 0x29 };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Pack-A-Punch")
            {
                Byte[] nop = { 0x2A };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Unknown 6")
            {
                Byte[] nop = { 0x2B };
                XRPC.SetMemory(0x84516459, nop);
            }
            else if (camocombo.SelectedItem.ToString() == "Weaponized 115")
            {
                Byte[] nop = { 0x1C };
                XRPC.SetMemory(0x84516459, nop);
            }
        }

        private void buttonX15_Click_1(object sender, EventArgs e)
        {
            if (Aemo == true)
            {
                Byte[] nop = { 0x91, 0x63, 0x00, 0x00 };
                XRPC.SetMemory(0x821F4E44, nop);
                Aemo = false;
                buttonX15.Text = "Infinite ammo for all: Off";
            }
            else
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x821F4E44, nop);
                Aemo = true;
                buttonX15.Text = "Infinite ammo for all: On";
            }
        }

        private void Ammo_Click_1(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x821F4E44, nop);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Byte[] amo = { 0x00, 0x00, 0x00, 0x64 };
            XRPC.SetMemory(0x84516614, amo);
            if (soe.Checked == true)
            {
                if (soecombo.SelectedItem == null)
                {
                    return;
                }
                else if (soecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x13 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x11 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x2A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x28 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x31 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x47 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x43 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x45 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x49 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x51 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x53 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x55 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x92 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x89 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x8F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                {
                    Byte[] nop = { 0xA1 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                {
                    Byte[] nop = { 0x7F };
                    XRPC.SetMemory(0x8451642B, nop);
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
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x10 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x29 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x27 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x2F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x46 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x42 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x44 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x48 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x50 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x52 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x54 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x74 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x77 };
                    XRPC.SetMemory(0x8451642B, nop);
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
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x10 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x29 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x27 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x2F };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2D };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x46 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x42 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x44 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x48 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x50 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x52 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x54 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5B };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5C };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x96 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                {
                    Byte[] nop = { 0x90 };
                    XRPC.SetMemory(0x8451642B, nop);
                }
            }
        }

        private void buttonX7_Click_1(object sender, EventArgs e)
        {
            byte[] p1 = XRPC.GetMemory(p1a, 15);
            String p1g = Encoding.ASCII.GetString(p1);
            var str1 = String.Format("setperk {0} specialty_twoprimaries", p1g);
            Byte[] nop1 = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop1);
            XRPC.SetMemory(0x826AC4F8, nop1);
            XRPC.Call(0x82631630, 0, str1);
            Byte[] amo = { 0x00, 0x00, 0x00, 0x64 };
            XRPC.SetMemory(0x84516618, amo);
            if (soe.Checked == true)
            {
                if (soecombo.SelectedItem == null)
                {
                    return;
                }
                else if (soecombo.SelectedItem.ToString() == "Vesper")
                {
                    Byte[] nop = { 0x13 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x11 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x2A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x28 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x31 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x3A };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x47 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x43 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x45 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x49 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x51 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x53 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x55 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x92 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x89 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x8F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Bootlegger")
                {
                    Byte[] nop = { 0x19 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "KN-44 (Explosive Bullets)")
                {
                    Byte[] nop = { 0xA1 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (soecombo.SelectedItem.ToString() == "Apothicon Servant")
                {
                    Byte[] nop = { 0x7F };
                    XRPC.SetMemory(0x84516453, nop);
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
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x10 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x29 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x27 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x2F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x46 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x42 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x44 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x48 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x50 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x52 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x54 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x74 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (giantcombo.SelectedItem.ToString() == "Wunderwaffe DG-2")
                {
                    Byte[] nop = { 0x77 };
                    XRPC.SetMemory(0x84516453, nop);
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
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "VMP")
                {
                    Byte[] nop = { 0x15 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Kuda")
                {
                    Byte[] nop = { 0x0E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Pharo")
                {
                    Byte[] nop = { 0x10 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Weevil")
                {
                    Byte[] nop = { 0x17 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Razorback")
                {
                    Byte[] nop = { 0x14 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "ICR-1")
                {
                    Byte[] nop = { 0x29 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KN-44")
                {
                    Byte[] nop = { 0x27 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "M8A7")
                {
                    Byte[] nop = { 0x2F };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Sheiva")
                {
                    Byte[] nop = { 0x30 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HVK-30")
                {
                    Byte[] nop = { 0x2B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Man-O-War")
                {
                    Byte[] nop = { 0x2D };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "KRM-262")
                {
                    Byte[] nop = { 0x38 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Argus")
                {
                    Byte[] nop = { 0x37 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "205 Brecci")
                {
                    Byte[] nop = { 0x39 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Haymaker 12")
                {
                    Byte[] nop = { 0x36 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "BRM")
                {
                    Byte[] nop = { 0x46 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Dingo")
                {
                    Byte[] nop = { 0x42 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "48 Dredge")
                {
                    Byte[] nop = { 0x44 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Gorgon")
                {
                    Byte[] nop = { 0x48 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Locus")
                {
                    Byte[] nop = { 0x50 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Drakon")
                {
                    Byte[] nop = { 0x52 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "SVG-100")
                {
                    Byte[] nop = { 0x54 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "RK5")
                {
                    Byte[] nop = { 0x5B };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "L-CAR 9")
                {
                    Byte[] nop = { 0x5C };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "XM-53")
                {
                    Byte[] nop = { 0x5E };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "Ray Gun")
                {
                    Byte[] nop = { 0x96 };
                    XRPC.SetMemory(0x84516453, nop);
                }
                else if (castlecombo.SelectedItem.ToString() == "HK41 (unreleased)")
                {
                    Byte[] nop = { 0x90 };
                    XRPC.SetMemory(0x84516453, nop);
                }
            }
        }

        private void buttonX17_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            if (mapcombo.SelectedItem == null)
            {
                return;
            }
            else if (mapcombo.SelectedItem.ToString() == "Shadows Of Evil")
            {
                XRPC.Call(0x82631630, 0, "map zm_zod");
            }
            else if (mapcombo.SelectedItem.ToString() == "The Giant")
            {
                XRPC.Call(0x82631630, 0, "map zm_factory");
            }
            else if (mapcombo.SelectedItem.ToString() == "Der Eisendrache")
            {
                XRPC.Call(0x82631630, 0, "map zm_castle");
            }
        }

        private void buttonX16_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            XRPC.Call(0x82631630, 0, "fast_restart");
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "g_speed 310");
                run = 2;
                buttonX3.Text = "Running Speed: 2x";
            }
            else if (run == 2)
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "g_speed 800");
                run = 4;
                buttonX3.Text = "Running Speed: 4x";
            }
            else if (run == 4)
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "g_speed 1600");
                run = 8;
                buttonX3.Text = "Running Speed: 8x";
            }
            else if (run == 8)
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "g_speed 200");
                run = 1;
                buttonX3.Text = "Running Speed: 1x";
            }
        }

        private void buttonX18_Click_1(object sender, EventArgs e)
        {
            if (god == true)
            {
                Byte[] nop = { 0x40 };
                XRPC.SetMemory(0x8241FBA8, nop);
                god = false;
                buttonX18.Text = "God mode: Off";
            }
            else
            {
                Byte[] nop = { 0x41 };
                XRPC.SetMemory(0x8241FBA8, nop);
                god = true;
                buttonX18.Text = "God mode: On";
            }
        }

        private void buttonX19_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84516614, g1);
            Byte[] g2 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x8451660C, g2);
            Byte[] g3 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84516618, g3);
        }

        private void buttonX21_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84516614, g1);
            Byte[] g2 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x8451660C, g2);
            Byte[] g3 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84516618, g3);
        }

        private void buttonX36_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84516614, g1);
            Byte[] g2 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x8451660C, g2);
            Byte[] g3 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84516618, g3);
        }

        private void buttonX35_Click(object sender, EventArgs e)
        {
            Byte[] points = { 0x00, 0x01, 0xA6, 0xA0 };
            XRPC.SetMemory(0x8451BF5C, points);
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

        private void buttonX37_Click_1(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void buttonX38_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void buttonX46_Click(object sender, EventArgs e)
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

        private void buttonX29_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x45, 0xE9, 0x9B, 0x3F, 0x43, 0xBA, 0x75, 0x7D, 0xC2, 0x3F, 0x80, 0x00 };
            XRPC.SetMemory(0x84516100, g1);
        }

        private void buttonX28_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x45, 0xE9, 0x9B, 0x3F, 0x43, 0xBA, 0x75, 0x7D, 0xC2, 0x3F, 0x80, 0x00 };
            XRPC.SetMemory(0x8451C2B8, g1);
        }

        private void buttonX23_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x45, 0xE9, 0x9B, 0x3F, 0x43, 0xBA, 0x75, 0x7D, 0xC2, 0x3F, 0x80, 0x00 };
            XRPC.SetMemory(0x84522470, g1);
        }

        private void buttonX22_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x45, 0xE9, 0x9B, 0x3F, 0x43, 0xBA, 0x75, 0x7D, 0xC2, 0x3F, 0x80, 0x00 };
            XRPC.SetMemory(0x84528628, g1);
        }

        private void buttonX34_Click(object sender, EventArgs e)
        {
            Byte[] points = { 0x00, 0x01, 0xA6, 0xA0 };
            XRPC.SetMemory(0x84522114, points);
        }

        private void buttonX20_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x8451C7CC, g1);
            Byte[] g2 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x8451C7C4, g2);
            Byte[] g3 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x8451C7D0, g3);
        }

        private void buttonX39_Click(object sender, EventArgs e)
        {
            //Byte[] lr = { 0x41, 0xB4, 0x00, 0x00 };
            Byte[] lr = XRPC.GetMemory(0x84516360, 4);
            Array.Reverse(lr);
            float lrf = System.BitConverter.ToSingle(lr, 0); //the angle of the player
            double tan = Math.Tan(DegreeToRadian(lrf));
            float tan2 = Convert.ToSingle(tan);
            float i = tan2 * 10;
            Byte[] xpos = XRPC.GetMemory(0x84516100, 4);
            Array.Reverse(xpos);
            float fxpos = System.BitConverter.ToSingle(xpos, 0);
            float nfxpos = fxpos + i;
            Byte[] aaa = BitConverter.GetBytes(nfxpos);
            Array.Reverse(aaa);
            XRPC.SetMemory(0x84516100, aaa);

            //y val

            Byte[] ypos = XRPC.GetMemory(0x84516104, 4);
            Array.Reverse(ypos);
            float fypos = System.BitConverter.ToSingle(ypos, 0);
            float nfypos = fypos - 10;
            Byte[] aaaa = BitConverter.GetBytes(nfypos);
            Array.Reverse(aaaa);
            XRPC.SetMemory(0x84516104, aaaa);
        }

        private void buttonX40_Click(object sender, EventArgs e)
        {
            Byte[] lr = { 0x01 };
            Byte[] lr2 = { 0x00 };
            Byte[] lr3 = { 0x02 };
            //*(byte*)(getPlayerState(clientIndex) + 0x4ACB) = 0x01;
            //*(byte*)(getPlayerState(clientIndex) + 0x4BB2) = 0x00;
            //*(byte*)(getPlayerState(clientIndex) + 0x4ACB) = 0x02;
            XRPC.SetMemory(0x8451AB9B, lr);
            XRPC.SetMemory(0x8451AC82, lr3);
            Thread.Sleep(5000);
            XRPC.SetMemory(0x8451AB9B, lr2);
        }

        private void cmap_Click(object sender, EventArgs e)
        {
            Byte[] lr3 = { 0x40 };
            XRPC.SetMemory(0x8232489C, lr3);
            XRPC.SetMemory(0x82322CAC, lr3);
            XRPC.SetMemory(0x823239B4, lr3);
            XRPC.SetMemory(0x823239C0, lr3);
            XRPC.SetMemory(0x823239B4, lr3);
            XRPC.SetMemory(0x8232489C, lr3);
            Byte[] lr4 = { 0x41 };
            XRPC.SetMemory(0x82323B24, lr4);
            XRPC.SetMemory(0x8232413C, lr4);
            Byte[] lr5 = { 0x01 };
            XRPC.SetMemory(0x82324187, lr5);

        }

        private void buttonX41_Click(object sender, EventArgs e)
        {
            Byte[] lr2 = { 0x0B };
            XRPC.SetMemory(0x8261359D, lr2);
            Byte[] lr3 = { 0x41 };
            XRPC.SetMemory(0x826721AC, lr3);
            XRPC.SetMemory(0x82588584, lr3);
            Byte[] lr5 = { 0x40 };
            XRPC.SetMemory(0x822F0278, lr5);
            XRPC.SetMemory(0x822F0288, lr5);
        }

        private void buttonX42_Click(object sender, EventArgs e)
        {
            Byte[] lr3 = { 0x40 };
            XRPC.SetMemory(0x823239B4, lr3);
            XRPC.SetMemory(0x823239C0, lr3);
        }

        private void buttonX43_Click(object sender, EventArgs e)
        {
            Byte[] lr5 = { 0x5E, 0x32, 0x43, 0x68, 0x61, 0x6d, 0x73, 0x20, 0x45, 0x6e, 0x61, 0x62, 0x6c, 0x65, 0x64, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x820AB58C, lr5);
            XRPC.Call(0x82631630, 0, "cg_drawFPS 1");
        }

        private void buttonX44_Click(object sender, EventArgs e)
        {
            Byte[] lr6 = { 0x5E, 0x31, 0x43, 0x68, 0x61, 0x6d, 0x73, 0x20, 0x44, 0x69, 0x73, 0x61, 0x62, 0x6c, 0x65, 0x64, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x820AB58C, lr6);
            XRPC.Call(0x82631630, 0, "cg_drawFPS 1");
        }

        private void buttonX30_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84528B3C, g1);
            Byte[] g2 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84528B34, g2);
            Byte[] g3 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84528B40, g3);
        }

        private void buttonX31_Click(object sender, EventArgs e)
        {
            Byte[] g1 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84522984, g1);
            Byte[] g2 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x8452297C, g2);
            Byte[] g3 = { 0x00, 0xff, 0xff, 0xff };
            XRPC.SetMemory(0x84522988, g3);
        }

        private void buttonX33_Click(object sender, EventArgs e)
        {
            Byte[] points = { 0x00, 0x01, 0xA6, 0xA0 };
            XRPC.SetMemory(0x845282CC, points);
        }

        private void buttonX32_Click(object sender, EventArgs e)
        {
            Byte[] points = { 0x00, 0x01, 0xA6, 0xA0 };
            XRPC.SetMemory(0x8452E484, points);

        }

        private void buttonX53_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            uint p1a = 0x8451BE80;
            uint p2a = 0x84522084;
            uint p3a = 0x845281F0;
            uint p4a = 0x8452E3A8;
            byte[] p1 = XRPC.GetMemory(p1a, 15);
            byte[] p2 = XRPC.GetMemory(p2a, 15);
            byte[] p3 = XRPC.GetMemory(p3a, 15);
            byte[] p4 = XRPC.GetMemory(p4a, 15);
            String p1g = Encoding.ASCII.GetString(p1);
            String p2g = Encoding.ASCII.GetString(p2);
            String p3g = Encoding.ASCII.GetString(p3);
            String p4g = Encoding.ASCII.GetString(p4);
            if (frate == true)
            {
                var str1 = String.Format("unsetperk {0} specialty_rof", p1g);
                var str2 = String.Format("unsetperk {0} specialty_rof", p2g);
                var str3 = String.Format("unsetperk {0} specialty_rof", p3g);
                var str4 = String.Format("unsetperk {0} specialty_rof", p4g);
                XRPC.Call(0x82631630, 0, "perk_weapRateMultiplier 1");
                XRPC.Call(0x82631630, 0, str1);
                XRPC.Call(0x82631630, 0, str2);
                XRPC.Call(0x82631630, 0, str3);
                XRPC.Call(0x82631630, 0, str4);
                frate = false;
                buttonX53.Text = "Rapidfire: Off";
            }
            else
            {
                var str1 = String.Format("setperk {0} specialty_rof", p1g);
                var str2 = String.Format("setperk {0} specialty_rof", p2g);
                var str3 = String.Format("setperk {0} specialty_rof", p3g);
                var str4 = String.Format("setperk {0} specialty_rof", p4g);
                XRPC.Call(0x82631630, 0, "perk_weapRateMultiplier 0.001");
                XRPC.Call(0x82631630, 0, str1);
                XRPC.Call(0x82631630, 0, str2);
                XRPC.Call(0x82631630, 0, str3);
                XRPC.Call(0x82631630, 0, str4);
                frate = true;
                buttonX53.Text = "Rapidfire: On";
            }
        }

        private void buttonX54_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            uint p1a = 0x8451BE80;
            uint p2a = 0x84522084;
            uint p3a = 0x845281F0;
            uint p4a = 0x8452E3A8;
            byte[] p1 = XRPC.GetMemory(p1a, 15);
            byte[] p2 = XRPC.GetMemory(p2a, 15);
            byte[] p3 = XRPC.GetMemory(p3a, 15);
            byte[] p4 = XRPC.GetMemory(p4a, 15);
            String p1g = Encoding.ASCII.GetString(p1);
            String p2g = Encoding.ASCII.GetString(p2);
            String p3g = Encoding.ASCII.GetString(p3);
            String p4g = Encoding.ASCII.GetString(p4);
            if (cmove == true)
            {
                var str1 = String.Format("unsetperk {0} specialty_fastreload", p1g);
                var str2 = String.Format("unsetperk {0} specialty_fastreload", p2g);
                var str3 = String.Format("unsetperk {0} specialty_fastreload", p3g);
                var str4 = String.Format("unsetperk {0} specialty_fastreload", p4g);
                XRPC.Call(0x82631630, 0, "perk_weapReloadMultiplier 1");
                XRPC.Call(0x82631630, 0, str1);
                XRPC.Call(0x82631630, 0, str2);
                XRPC.Call(0x82631630, 0, str3);
                XRPC.Call(0x82631630, 0, str4);
                cmove = false;
                buttonX54.Text = "Instant reload: Off";
            }
            else
            {
                var str1 = String.Format("setperk {0} specialty_fastreload", p1g);
                var str2 = String.Format("setperk {0} specialty_fastreload", p2g);
                var str3 = String.Format("setperk {0} specialty_fastreload", p3g);
                var str4 = String.Format("setperk {0} specialty_fastreload", p4g);
                XRPC.Call(0x82631630, 0, "perk_weapReloadMultiplier 0.001");
                XRPC.Call(0x82631630, 0, str1);
                XRPC.Call(0x82631630, 0, str2);
                XRPC.Call(0x82631630, 0, str3);
                XRPC.Call(0x82631630, 0, str4);
                cmove = true;
                buttonX54.Text = "Instant reload: On";
            }
        }

        private void buttonX55_Click(object sender, EventArgs e)
        {
            if (unspr == true)
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "player_sprintUnlimited 0");
                unspr = false;
                buttonX55.Text = "Unlimited sprint: Off";
            }
            else
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x826AC48C, nop);
                XRPC.SetMemory(0x826AC4F8, nop);
                XRPC.Call(0x82631630, 0, "player_sprintUnlimited 1");
                unspr = true;
                buttonX55.Text = "Unlimited sprint: On";
            }
        }

        private void buttonX56_Click(object sender, EventArgs e)
        {
            if (recoil == true)
            {
                Byte[] nop = { 0x4B, 0xF7, 0x92, 0x39 };
                XRPC.SetMemory(0x82278798, nop);
                recoil = false;
                buttonX56.Text = "No recoil: Off";
            }
            else
            {
                Byte[] nop = { 0x38, 0x60, 0x00, 0x01 };
                XRPC.SetMemory(0x82278798, nop);
                recoil = true;
                buttonX56.Text = "No recoil: On";
            }


        }

        private void buttonX52_Click(object sender, EventArgs e)
        {
            if (Aemo == true)
            {
                Byte[] nop = { 0x91, 0x63, 0x00, 0x00 };
                XRPC.SetMemory(0x821F4E44, nop);
                Aemo = false;
                buttonX15.Text = "Infinite ammo for all: Off";
            }
            else
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x821F4E44, nop);
                Aemo = true;
                buttonX15.Text = "Infinite ammo for all: On";
            }
        }

        private void buttonX52_Click_1(object sender, EventArgs e)
        {
            if (Aemo == true)
            {
                Byte[] nop = { 0x91, 0x63, 0x00, 0x00 };
                XRPC.SetMemory(0x821F4E44, nop);
                Aemo = false;
                buttonX69.Text = "Infinite ammo for all: Off";
            }
            else
            {
                Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x821F4E44, nop);
                Aemo = true;
                buttonX69.Text = "Infinite ammo for all: On";
            }
        }

        private void buttonX47_Click_1(object sender, EventArgs e)
        {
            Byte[] mex = XRPC.GetMemory(0x84516100, 4);
            Byte[] mey = XRPC.GetMemory(0x84516104, 4);
            Byte[] mez = XRPC.GetMemory(0x84516108, 4);
            Array.Reverse(mex);
            Array.Reverse(mey);
            Array.Reverse(mez);
            float i = BitConverter.ToSingle(mex, 0);
            float d = BitConverter.ToSingle(mey, 0);
            float c = BitConverter.ToSingle(mez, 0);
            String p1g = i.ToString();
            String p2g = d.ToString();
            String p3g = c.ToString();
            pos1x.Text = p1g;
            pos1y.Text = p2g;
            pos1z.Text = p3g;
        }

        private void buttonX52_Click_2(object sender, EventArgs e)
        {
            Byte[] mex = XRPC.GetMemory(0x84516100, 4);
            Byte[] mey = XRPC.GetMemory(0x84516104, 4);
            Byte[] mez = XRPC.GetMemory(0x84516108, 4);
            Array.Reverse(mex);
            Array.Reverse(mey);
            Array.Reverse(mez);
            float i = BitConverter.ToSingle(mex, 0);
            float d = BitConverter.ToSingle(mey, 0);
            float c = BitConverter.ToSingle(mez, 0);
            String p1g = i.ToString();
            String p2g = d.ToString();
            String p3g = c.ToString();
            pos2x.Text = p1g;
            pos2y.Text = p2g;
            pos2z.Text = p3g;
        }

        private void buttonX58_Click(object sender, EventArgs e)
        {
            Byte[] mex = XRPC.GetMemory(0x84516100, 4);
            Byte[] mey = XRPC.GetMemory(0x84516104, 4);
            Byte[] mez = XRPC.GetMemory(0x84516108, 4);
            Array.Reverse(mex);
            Array.Reverse(mey);
            Array.Reverse(mez);
            float i = BitConverter.ToSingle(mex, 0);
            float d = BitConverter.ToSingle(mey, 0);
            float c = BitConverter.ToSingle(mez, 0);
            String p1g = i.ToString();
            String p2g = d.ToString();
            String p3g = c.ToString();
            pos3x.Text = p1g;
            pos3y.Text = p2g;
            pos3z.Text = p3g;
        }

        private void buttonX57_Click(object sender, EventArgs e)
        {
            Byte[] mex = XRPC.GetMemory(0x84516100, 4);
            Byte[] mey = XRPC.GetMemory(0x84516104, 4);
            Byte[] mez = XRPC.GetMemory(0x84516108, 4);
            Array.Reverse(mex);
            Array.Reverse(mey);
            Array.Reverse(mez);
            float i = BitConverter.ToSingle(mex, 0);
            float d = BitConverter.ToSingle(mey, 0);
            float c = BitConverter.ToSingle(mez, 0);
            String p1g = i.ToString();
            String p2g = d.ToString();
            String p3g = c.ToString();
            pos4x.Text = p1g;
            pos4y.Text = p2g;
            pos4z.Text = p3g;
        }

        private void buttonX62_Click(object sender, EventArgs e)
        {
            float i = Convert.ToSingle(pos1x.Text);
            float d = Convert.ToSingle(pos1y.Text);
            float c = Convert.ToSingle(pos1z.Text);
            byte[] mex = BitConverter.GetBytes(i);
            byte[] mey = BitConverter.GetBytes(d);
            byte[] mez = BitConverter.GetBytes(c);
            Array.Reverse(mex);
            Array.Reverse(mey);
            Array.Reverse(mez);
            XRPC.SetMemory(0x84516100, mex);
            XRPC.SetMemory(0x84516104, mey);
            XRPC.SetMemory(0x84516108, mez);
        }

        private void buttonX61_Click(object sender, EventArgs e)
        {
            float i = Convert.ToSingle(pos2x.Text);
            float d = Convert.ToSingle(pos2y.Text);
            float c = Convert.ToSingle(pos2z.Text);
            byte[] mex = BitConverter.GetBytes(i);
            byte[] mey = BitConverter.GetBytes(d);
            byte[] mez = BitConverter.GetBytes(c);
            Array.Reverse(mex);
            Array.Reverse(mey);
            Array.Reverse(mez);
            XRPC.SetMemory(0x84516100, mex);
            XRPC.SetMemory(0x84516104, mey);
            XRPC.SetMemory(0x84516108, mez);
        }

        private void buttonX60_Click(object sender, EventArgs e)
        {
            float i = Convert.ToSingle(pos3x.Text);
            float d = Convert.ToSingle(pos3y.Text);
            float c = Convert.ToSingle(pos3z.Text);
            byte[] mex = BitConverter.GetBytes(i);
            byte[] mey = BitConverter.GetBytes(d);
            byte[] mez = BitConverter.GetBytes(c);
            Array.Reverse(mex);
            Array.Reverse(mey);
            Array.Reverse(mez);
            XRPC.SetMemory(0x84516100, mex);
            XRPC.SetMemory(0x84516104, mey);
            XRPC.SetMemory(0x84516108, mez);
        }

        private void buttonX59_Click(object sender, EventArgs e)
        {
            float i = Convert.ToSingle(pos4x.Text);
            float d = Convert.ToSingle(pos4y.Text);
            float c = Convert.ToSingle(pos4z.Text);
            byte[] mex = BitConverter.GetBytes(i);
            byte[] mey = BitConverter.GetBytes(d);
            byte[] mez = BitConverter.GetBytes(c);
            Array.Reverse(mex);
            Array.Reverse(mey);
            Array.Reverse(mez);
            XRPC.SetMemory(0x84516100, mex);
            XRPC.SetMemory(0x84516104, mey);
            XRPC.SetMemory(0x84516108, mez);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            Byte[] nop1 = { 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20, 0x4E, 0x80, 0x00, 0x20 };
            XRPC.SetMemory(0x82603C80, nop1);
            XRPC.SetMemory(0x822ADCF8, nop1);
            XRPC.Call(0x82631630, 0, "cg_drawFPS 1");
        }

        private void buttonX24_Click(object sender, EventArgs e)
        {
            if (redbox == true)
            {
                Byte[] nop1 = { 0x41, 0x82, 0x00, 0xDC };
                Byte[] nop2 = { 0x41, 0x82, 0x00, 0xB4 };
                XRPC.SetMemory(0x82607908, nop2);
                XRPC.SetMemory(0x826078E0, nop1);
                redbox = false;
                buttonX24.Text = "Redboxes: Off";
            }
            else
            {
                Byte[] nop1 = { 0x60, 0x00, 0x00, 0x00 };
                XRPC.SetMemory(0x82607908, nop1);
                XRPC.SetMemory(0x826078E0, nop1);
                redbox = true;
                buttonX24.Text = "Redboxes: On";
            }
        }

        private void buttonX48_Click_1(object sender, EventArgs e)
        {
            Byte[] nop = { 0x00, 0x00, 0x00, 0x00 };
            Byte[] nop2 = { 0xFF, 0xFF, 0xFF, 0xFF };
            XRPC.SetMemory(0x8451C238, nop);
            XRPC.SetMemory(0x8451C244, nop);
            XRPC.SetMemory(0x8451C248, nop);
            XRPC.SetMemory(0x8451BEFC, nop);
            XRPC.SetMemory(0x8451BF0C, nop);
            XRPC.SetMemory(0x8451BF08, nop2);
        }

        private void buttonX49_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x00, 0x00, 0x00, 0x00 };
            Byte[] nop2 = { 0xFF, 0xFF, 0xFF, 0xFF };
            XRPC.SetMemory(0x845223FC, nop);
            XRPC.SetMemory(0x845223F0, nop);
            XRPC.SetMemory(0x84522400, nop);
            XRPC.SetMemory(0x845220B4, nop);
            XRPC.SetMemory(0x845220C4, nop);
            XRPC.SetMemory(0x845220C0, nop2);

        }

        private void buttonX63_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x00, 0x00, 0x00, 0x00 };
            Byte[] nop2 = { 0xFF, 0xFF, 0xFF, 0xFF };
            XRPC.SetMemory(0x845285B4, nop);
            XRPC.SetMemory(0x845285A8, nop);
            XRPC.SetMemory(0x845285B8, nop);
            XRPC.SetMemory(0x8452826C, nop);
            XRPC.SetMemory(0x8452827C, nop);
            XRPC.SetMemory(0x84528278, nop2);
        }

        private void buttonX50_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x00, 0x00, 0x00, 0x00 };
            Byte[] nop2 = { 0xFF, 0xFF, 0xFF, 0xFF };
            XRPC.SetMemory(0x8452E76C, nop);
            XRPC.SetMemory(0x8452E760, nop);
            XRPC.SetMemory(0x8452E770, nop);
            XRPC.SetMemory(0x8452E424, nop);
            XRPC.SetMemory(0x8452E434, nop);
            XRPC.SetMemory(0x8452E430, nop2);
        }

        private void buttonX41_Click_1(object sender, EventArgs e)
        {
            Byte[] nop = { 0x40 };
            XRPC.SetMemory(0x823239B4, nop);
            XRPC.SetMemory(0x823239C0, nop);
        }

        private void buttonX42_Click_1(object sender, EventArgs e)
        {
            Byte[] nop = { 0x40 };
            Byte[] nop1 = { 0x41 };
            Byte[] nopr = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x823239C0, nop);
            XRPC.SetMemory(0x823239B4, nop);
            XRPC.SetMemory(0x826136BC, nopr);
            XRPC.SetMemory(0x822E9874, nopr);
            XRPC.SetMemory(0x822F02E4, nopr);
            XRPC.SetMemory(0x8258859C, nopr);
            XRPC.SetMemory(0x82642B08, nopr);
            XRPC.SetMemory(0x826724E4, nopr);
            XRPC.SetMemory(0x822FC1EC, nop1);
            XRPC.SetMemory(0x82323B24, nop1);
        }

        private void buttonX64_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            XRPC.Call(0x82631630, 0, "map zm_factory");
        }

        private void buttonX65_Click(object sender, EventArgs e)
        {
            //Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            //XRPC.SetMemory(0x826AC48C, nop);
            //XRPC.SetMemory(0x826AC4F8, nop);
            //uint funct = Convert.ToUInt32(functIn.Text, 16);
            //XRPC.Call(funct, 0, Input.Text); 
            XRPC.Call(0x824261E0, "ered", "");
        }

        private void buttonX66_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            XRPC.Call(0x82631630, 0, "partyMigrate_disabled 1");
            XRPC.Call(0x82631630, 0, "party_minplayers 1");
            XRPC.Call(0x82631630, 0, "allowAllNAT 1");
            XRPC.Call(0x82631630, 0, "party_connectToOthers 0");
        }

        private void buttonX25_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x82631630, 0, "cg_drawFPS 1");
            Byte[] lr5 = { 0x25, 0x69, 0x66, 0x70, 0x73, 0x20, 0x2F, 0x20, 0x25, 0x30, 0x32, 0x69, 0x20, 0x28, 0x25, 0x30, 0x32, 0x69, 0x2D, 0x25, 0x30, 0x32, 0x69, 0x29, 0x20, 0x73, 0x76 };
            XRPC.SetMemory(0x820AB58C, lr5);
        }

        private void giantcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void castlecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void soecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonX6_Click_1(object sender, EventArgs e)
        {
            if (redbox2 == true)
            {
                Byte[] nop1 = { 0x00 };
                XRPC.SetMemory(0x8451671D, nop1);
                redbox2 = false;
                buttonX6.Text = "Thermal: Off";
            }
            else
            {
                Byte[] nop1 = { 0x80 };
                XRPC.SetMemory(0x8451671D, nop1);
                redbox2 = true;
                buttonX6.Text = "Thermal: On";
            }
        }

        private void buttonX67_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            string data = textBoxX2.Text;
            if (textBoxX2.Text == null)
            {
                return;
            }
            var str = String.Format("< \"{0}\"", data);
            XRPC.Call(0x82665968, -1, 0, str);
        }

        private void buttonX65_Click_1(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            if (spawn == true)
            {
                XRPC.Call(0x82631630, 0, "ai_disableSpawn 0");
                spawn = false;
                buttonX65.Text = "Zombies spawn: On";
            }
            else
            {
                XRPC.Call(0x82631630, 0, "ai_disableSpawn 1");
                spawn = true;
                buttonX65.Text = "Zombies spawn: Off";
            }
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            if (checkBoxX1.Checked == true)
            {
                XRPC.Call(0x82631630, 0, "bg_gravity 1");
            }
            else
            {
                XRPC.Call(0x82631630, 0, "bg_gravity 800");
            }
        }

        private void buttonX45_Click(object sender, EventArgs e)
        {
            Byte[] pX = XRPC.GetMemory(0x84516100, 4); //30
            Byte[] pY = XRPC.GetMemory(0x84516104, 4); //34
            Byte[] pZ = XRPC.GetMemory(0x84516108, 4); //38
            Byte[] Ppitch = XRPC.GetMemory(0x8451635C, 4); //28C
            Byte[] Pyaw = XRPC.GetMemory(0x84516360, 4); //290
            Noclip(0, pX, pY, pZ, Ppitch, Pyaw);
        }

        private void buttonX25_Click_1(object sender, EventArgs e)
        {
            XRPC.Call(0x82665968, 0, 0, textBoxX4.Text);
        }

        private void buttonX26_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 }; // adding precursor stuff
            Byte[] command = { 0x62, 0x67, 0x5f, 0x67, 0x72, 0x61, 0x76, 0x69, 0x74, 0x20, 0x20, 0x31, 0x0A, 0x00 };
            Byte[] remove = { 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x38, 0x60, 0x00, 0x00, 0x3D, 0x60, 0x82, 0x0B, 0x30, 0x8B, 0xB5, 0x1C, 0x48, 0x42, 0x0D, 0xFD };
            XRPC.SetMemory(0x826AC48C, nop); //dvar cheat bypass
            XRPC.SetMemory(0x826AC4F8, nop); //see above
            XRPC.SetMemory(0x822D9214, nop); //make getint work
            XRPC.SetMemory(0x820AB51C, command); //add cbuf command
            XRPC.SetMemory(0x8221074C, remove); //clear fps code for our code
            Byte[] check = { 0x3D, 0x60, 0x83, 0x0C, 0x30, 0x8B, 0xE0, 0x00, 0x80, 0x64, 0x00, 0x00, 0x2B, 0x03, 0x00, 0x01, 0x41, 0x9A, 0x00, 0xCC, 0x38, 0x60, 0x00, 0x01, 0x90, 0x64, 0x00, 0x00 };
            XRPC.SetMemory(0x8221074C, check); //now add initial check to stop scr_add___ crashing console when spammed

            //Byte[] hack = { 0x38, 0xC0, 0x00, 0x01, 0x3D, 0x60, 0x82, 0x0D, 0x38, 0x6B, 0xE4, 0x10, 0x38, 0x8B, 0xE4, 0x10, 0x3D, 0x60, 0x7F, 0xFF, 0x61, 0x65, 0xFF, 0xFF, 0x48, 0x4A, 0x21, 0x8D };
            //XRPC.SetMemory(0x822107AC, hack);
        }

        private void buttonX27_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x822104BC, nop);
        }

        private void buttonX39_Click_1(object sender, EventArgs e)
        {
            XRPC.Call(0x82665968, 0, 0, "# MP_PRESTIGE10");
            XRPC.Call(0x82665968, 0, 0, "# MP_ALLCAREER");
            XRPC.Call(0x82665968, 0, 0, "# MP_ALLGAMEMODE");
            XRPC.Call(0x82665968, 0, 0, "# MP_ALLBOOTCAMP");
            XRPC.Call(0x82665968, 0, 0, "# MP_ALLSPECIALISTS");
            XRPC.Call(0x82665968, 0, 0, "# MP_PRESTIGE1");
            XRPC.Call(0x82665968, 0, 0, "# MP_COMMANDER");
            XRPC.Call(0x82665968, 0, 0, "# MP_10MULTIKILL");
            XRPC.Call(0x82665968, 0, 0, "# MP_10MEDALS");
            XRPC.Call(0x82665968, 0, 0, "# MP_LEVEL10");
            XRPC.Call(0x82665968, 0, 0, "# ZM_PACKING_EARLY");
            XRPC.Call(0x82665968, 0, 0, "# ZM_FARAWAY_KILL");
            XRPC.Call(0x82665968, 0, 0, "# ZM_LEGLESS_KILL");
            XRPC.Call(0x82665968, 0, 0, "# ZM_PARASITE_KILL");
            XRPC.Call(0x82665968, 0, 0, "# ZM_MARGWA_KILL");
            XRPC.Call(0x82665968, 0, 0, "# ZM_WINE_GRENADE_KILL");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CIVIL_PROTECTOR");
            XRPC.Call(0x82665968, 0, 0, "# ZM_ROCKET_SHIELD_KILL");
            XRPC.Call(0x82665968, 0, 0, "# ZM_STORE_KILL");
            XRPC.Call(0x82665968, 0, 0, "# ZM_GOBBLE_GUM");
            XRPC.Call(0x82665968, 0, 0, "# ZM_SPOT_SHADOWMAN");
            XRPC.Call(0x82665968, 0, 0, "# ZM_COMPLETE_RITUALS");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_ALL_BOWS");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_WUNDER_TOURIST");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_WUNDER_SNIPER");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_WALL_RUNNER");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_ELECTROCUTIONER");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_MECH_TRAPPER");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_UPGRADED_BOW");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_SPIKE_REVIVE");
            XRPC.Call(0x82665968, 0, 0, "# ZM_CASTLE_MINIGUN_MURDER");
        }

        private void buttonX40_Click_1(object sender, EventArgs e)
        {
            XRPC.Call(0x82665968, 1, 0, "# MP_PRESTIGE10");
            XRPC.Call(0x82665968, 1, 0, "# MP_ALLCAREER");
            XRPC.Call(0x82665968, 1, 0, "# MP_ALLGAMEMODE");
            XRPC.Call(0x82665968, 1, 0, "# MP_ALLBOOTCAMP");
            XRPC.Call(0x82665968, 1, 0, "# MP_ALLSPECIALISTS");
            XRPC.Call(0x82665968, 1, 0, "# MP_PRESTIGE1");
            XRPC.Call(0x82665968, 1, 0, "# MP_COMMANDER");
            XRPC.Call(0x82665968, 1, 0, "# MP_10MULTIKILL");
            XRPC.Call(0x82665968, 1, 0, "# MP_10MEDALS");
            XRPC.Call(0x82665968, 1, 0, "# MP_LEVEL10");
            XRPC.Call(0x82665968, 1, 0, "# ZM_PACKING_EARLY");
            XRPC.Call(0x82665968, 1, 0, "# ZM_FARAWAY_KILL");
            XRPC.Call(0x82665968, 1, 0, "# ZM_LEGLESS_KILL");
            XRPC.Call(0x82665968, 1, 0, "# ZM_PARASITE_KILL");
            XRPC.Call(0x82665968, 1, 0, "# ZM_MARGWA_KILL");
            XRPC.Call(0x82665968, 1, 0, "# ZM_WINE_GRENADE_KILL");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CIVIL_PROTECTOR");
            XRPC.Call(0x82665968, 1, 0, "# ZM_ROCKET_SHIELD_KILL");
            XRPC.Call(0x82665968, 1, 0, "# ZM_STORE_KILL");
            XRPC.Call(0x82665968, 1, 0, "# ZM_GOBBLE_GUM");
            XRPC.Call(0x82665968, 1, 0, "# ZM_SPOT_SHADOWMAN");
            XRPC.Call(0x82665968, 1, 0, "# ZM_COMPLETE_RITUALS");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_ALL_BOWS");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_WUNDER_TOURIST");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_WUNDER_SNIPER");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_WALL_RUNNER");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_ELECTROCUTIONER");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_MECH_TRAPPER");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_UPGRADED_BOW");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_SPIKE_REVIVE");
            XRPC.Call(0x82665968, 1, 0, "# ZM_CASTLE_MINIGUN_MURDER");
        }

        private void buttonX41_Click_2(object sender, EventArgs e)
        {
            XRPC.Call(0x82665968, 2, 0, "# MP_PRESTIGE10");
            XRPC.Call(0x82665968, 2, 0, "# MP_ALLCAREER");
            XRPC.Call(0x82665968, 2, 0, "# MP_ALLGAMEMODE");
            XRPC.Call(0x82665968, 2, 0, "# MP_ALLBOOTCAMP");
            XRPC.Call(0x82665968, 2, 0, "# MP_ALLSPECIALISTS");
            XRPC.Call(0x82665968, 2, 0, "# MP_PRESTIGE1");
            XRPC.Call(0x82665968, 2, 0, "# MP_COMMANDER");
            XRPC.Call(0x82665968, 2, 0, "# MP_10MULTIKILL");
            XRPC.Call(0x82665968, 2, 0, "# MP_10MEDALS");
            XRPC.Call(0x82665968, 2, 0, "# MP_LEVEL10");
            XRPC.Call(0x82665968, 2, 0, "# ZM_PACKING_EARLY");
            XRPC.Call(0x82665968, 2, 0, "# ZM_FARAWAY_KILL");
            XRPC.Call(0x82665968, 2, 0, "# ZM_LEGLESS_KILL");
            XRPC.Call(0x82665968, 2, 0, "# ZM_PARASITE_KILL");
            XRPC.Call(0x82665968, 2, 0, "# ZM_MARGWA_KILL");
            XRPC.Call(0x82665968, 2, 0, "# ZM_WINE_GRENADE_KILL");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CIVIL_PROTECTOR");
            XRPC.Call(0x82665968, 2, 0, "# ZM_ROCKET_SHIELD_KILL");
            XRPC.Call(0x82665968, 2, 0, "# ZM_STORE_KILL");
            XRPC.Call(0x82665968, 2, 0, "# ZM_GOBBLE_GUM");
            XRPC.Call(0x82665968, 2, 0, "# ZM_SPOT_SHADOWMAN");
            XRPC.Call(0x82665968, 2, 0, "# ZM_COMPLETE_RITUALS");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_ALL_BOWS");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_WUNDER_TOURIST");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_WUNDER_SNIPER");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_WALL_RUNNER");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_ELECTROCUTIONER");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_MECH_TRAPPER");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_UPGRADED_BOW");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_SPIKE_REVIVE");
            XRPC.Call(0x82665968, 2, 0, "# ZM_CASTLE_MINIGUN_MURDER");
        }

        private void buttonX42_Click_2(object sender, EventArgs e)
        {
            XRPC.Call(0x82665968, 3, 0, "# MP_PRESTIGE10");
            XRPC.Call(0x82665968, 3, 0, "# MP_ALLCAREER");
            XRPC.Call(0x82665968, 3, 0, "# MP_ALLGAMEMODE");
            XRPC.Call(0x82665968, 3, 0, "# MP_ALLBOOTCAMP");
            XRPC.Call(0x82665968, 3, 0, "# MP_ALLSPECIALISTS");
            XRPC.Call(0x82665968, 3, 0, "# MP_PRESTIGE1");
            XRPC.Call(0x82665968, 3, 0, "# MP_COMMANDER");
            XRPC.Call(0x82665968, 3, 0, "# MP_10MULTIKILL");
            XRPC.Call(0x82665968, 3, 0, "# MP_10MEDALS");
            XRPC.Call(0x82665968, 3, 0, "# MP_LEVEL10");
            XRPC.Call(0x82665968, 3, 0, "# ZM_PACKING_EARLY");
            XRPC.Call(0x82665968, 3, 0, "# ZM_FARAWAY_KILL");
            XRPC.Call(0x82665968, 3, 0, "# ZM_LEGLESS_KILL");
            XRPC.Call(0x82665968, 3, 0, "# ZM_PARASITE_KILL");
            XRPC.Call(0x82665968, 3, 0, "# ZM_MARGWA_KILL");
            XRPC.Call(0x82665968, 3, 0, "# ZM_WINE_GRENADE_KILL");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CIVIL_PROTECTOR");
            XRPC.Call(0x82665968, 3, 0, "# ZM_ROCKET_SHIELD_KILL");
            XRPC.Call(0x82665968, 3, 0, "# ZM_STORE_KILL");
            XRPC.Call(0x82665968, 3, 0, "# ZM_GOBBLE_GUM");
            XRPC.Call(0x82665968, 3, 0, "# ZM_SPOT_SHADOWMAN");
            XRPC.Call(0x82665968, 3, 0, "# ZM_COMPLETE_RITUALS");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_ALL_BOWS");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_WUNDER_TOURIST");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_WUNDER_SNIPER");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_WALL_RUNNER");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_ELECTROCUTIONER");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_MECH_TRAPPER");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_UPGRADED_BOW");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_SPIKE_REVIVE");
            XRPC.Call(0x82665968, 3, 0, "# ZM_CASTLE_MINIGUN_MURDER");
        }

        private void buttonX43_Click_1(object sender, EventArgs e)
        {
            Byte[] nop = { 0x41, 0x82, 0x06, 0x1C };
            XRPC.SetMemory(0x822104BC, nop);
        }

        private void buttonX44_Click_1(object sender, EventArgs e)
        {
            Byte[] point = XRPC.GetMemory(0x8451BF5C, 4);
            Byte[] points = { 0x00, 0x01, 0xA6, 0xA0 };
            Byte[] ff = { 0xFF };
            XRPC.SetMemory(0x8451BF5C, points);
            XRPC.SetMemory(0x8451C08F, ff);
            Byte[] orig = XRPC.GetMemory(0x84516100, 12);
            Byte[] nop = { 0x01 };
            Byte[] nop2 = { 0x00 };
            Byte[] d1 = { 0x44, 0xF5, 0x0B, 0x7E, 0xC5, 0xA7, 0x83, 0x8A, 0x43, 0x00, 0x1C, 0x26 };
            Byte[] d2 = { 0x45, 0x02, 0x20, 0xBC, 0xC5, 0x89, 0x8D, 0x21, 0x43, 0x12, 0xF5, 0xB3 };
            Byte[] d3 = { 0x44, 0xB1, 0xF1, 0x5E, 0xC5, 0x1B, 0x9C, 0xDF, 0x43, 0x89, 0x74, 0x49 };
            Byte[] d4 = { 0x44, 0x24, 0x49, 0x28, 0xC5, 0x0A, 0x8C, 0x0B, 0x43, 0xE3, 0x98, 0xA4 };
            Byte[] d5 = { 0x44, 0x8B, 0x30, 0x7E, 0xC5, 0x5D, 0x45, 0xBF, 0x43, 0xC0, 0x10, 0x00 };
            Byte[] d6 = { 0x45, 0x33, 0x01, 0x8E, 0xC5, 0xBE, 0x7A, 0xDF, 0x43, 0x20, 0x0B, 0x6F };
            Byte[] d7 = { 0x45, 0x06, 0x07, 0x57, 0xC5, 0xF2, 0x52, 0xA2, 0x3D, 0xFF, 0xFF, 0x65 };
            Byte[] d8 = { 0x44, 0xA0, 0xB4, 0x82, 0xC6, 0x0A, 0x9E, 0xE4, 0x43, 0xC0, 0x10, 0x00 };
            Byte[] d9 = { 0x44, 0xDA, 0xD3, 0x8C, 0xC6, 0x00, 0x50, 0x01, 0x43, 0xC0, 0x90, 0x00 };
            Byte[] d10 = { 0x45, 0x23, 0xCA, 0x51, 0xC5, 0xF4, 0xE5, 0xF8, 0x43, 0x80, 0x10, 0x00 };
            Byte[] d11 = { 0x45, 0x5C, 0x35, 0xBF, 0xC5, 0x9F, 0x1D, 0xD1, 0x43, 0x00, 0x20, 0x00 };
            Byte[] d12 = { 0x45, 0x8E, 0xEF, 0x00, 0xC5, 0x5E, 0xD4, 0x3A, 0x43, 0x83, 0xD0, 0x00 };
            Byte[] d13 = { 0x45, 0xBC, 0x3D, 0x5C, 0xC5, 0x2B, 0xFF, 0x03, 0x43, 0xBF, 0x90, 0x00 };
            Byte[] d14 = { 0x45, 0x9D, 0x3B, 0xE6, 0xC5, 0x27, 0x15, 0xF4, 0x43, 0xCF, 0x90, 0x00 };
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d1);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d3);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d4);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d5);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d6);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d7);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d8);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d9);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d10);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d11);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d12);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d13);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            XRPC.SetMemory(0x84516100, d14);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop);
            Thread.Sleep(350);
            XRPC.SetMemory(0x830C25C8, nop2);
            XRPC.SetMemory(0x8451C08F, nop2);
            XRPC.SetMemory(0x84516100, orig);
            XRPC.SetMemory(0x8451BF5C, point);
        }

        private void buttonX51_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            Byte[] nop1 = { 0x38, 0x60, 0x00, 0x00 };
            Byte[] nop2 = { 0x48, 0x00, 0x00, 0x10 };
            Byte[] nop3 = { 0x48, 0x00, 0x00, 0xB4 };
            XRPC.SetMemory(0x826956C8, nop);
            XRPC.SetMemory(0x82695740, nop1);
            XRPC.SetMemory(0x82695670, nop2);
            XRPC.SetMemory(0x826950D0, nop3);
        }

        private void buttonX64_Click_1(object sender, EventArgs e)
        {
            XRPC.Call(0x824015E0, 0, "Fast_restart");
        }

        private void buttonX68_Click(object sender, EventArgs e)
        {
            Byte[] command = { 0x3D, 0x60, 0x83, 0x0C, 0x3B, 0xAB, 0xE0, 0x00, 0x7C, 0x7F, 0x84, 0xAA, 0x7C, 0x7D, 0x85, 0xAA, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x48, 0x00, 0x00, 0x34 };
            //Byte[] command = { 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x48, 0x00, 0x00, 0x34 };
            XRPC.SetMemory(0x8263165C, command);
        }

        unsafe static uint CanonicalHash(string fname) //reversed sl_getcanonicalstring from xex
        {
            string x = fname + "\0";
            fixed (char* c = x)
            {
                Int64 hash = (char.ToLower(*c) ^ 0xE5770569) * 0x1000193;
                for (int z = 1; z < x.Length; z++)
                    hash = (char.ToLower(x[z]) ^ hash) * 0x1000193;
                return (uint)(hash & 0x00000000FFFFFFFF);
            }
            return 0;
        }

        private void buttonX71_Click(object sender, EventArgs e)
        {
            AdressInput.Text += CanonicalHash("sdfsdfff");
        }

        private void buttonX72_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x824015E0, 0, "partyMigrate_disabled 1");
            XRPC.Call(0x824015E0, 0, "party_minplayers 1");
            XRPC.Call(0x824015E0, 0, "allowAllNAT 1");
            XRPC.Call(0x824015E0, 0, "party_connectToOthers 0");
        }

        private void buttonX73_Click(object sender, EventArgs e)
        {
            int t = 0;
            string[] lines = System.IO.File.ReadAllLines("text.txt");
            foreach (string line in lines)
            {
                int copy = t;
                string loc = lines[copy].Substring(6, 8);
                string lft = lines[copy].Substring(17, 8);
                //string rght = lines[copy].Substring(30, 8);
                uint location = Convert.ToUInt32(loc, 16);
                Byte[] left = BitConverter.GetBytes(Convert.ToUInt32(lft, 16));
                Array.Reverse(left);
                XRPC.SetMemory(location, left);
                t = t + 1;
            }
        }

        private void buttonX74_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            Byte[] command = { 0x62, 0x67, 0x5f, 0x67, 0x72, 0x61, 0x76, 0x69, 0x74, 0x20, 0x20, 0x31, 0x0A, 0x00 };
            Byte[] remove = { 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x38, 0x60, 0x00, 0x00, 0x3D, 0x60, 0x82, 0x0B, 0x30, 0x8B, 0xB5, 0x1C, 0x48, 0x42, 0x0D, 0xFD };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            XRPC.SetMemory(0x820AB51C, command);
            XRPC.SetMemory(0x822107A0, remove);
            Byte[] hack = { 0x3D, 0x60, 0x83, 0x0C, 0x33, 0xCB, 0x28, 0xF4, 0x81, 0x3E, 0x00, 0x08, 0x38, 0x80, 0x43, 0x42, 0x89, 0x7E, 0x00, 0x17, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x2F, 0x0B, 0x00, 0x01, 0x40, 0x9A, 0x00, 0x40, 0x2F, 0x09, 0x00, 0x01, 0x60, 0x00, 0x00, 0x00, 0x41, 0x9A, 0x00, 0x34, 0x3D, 0x60, 0x84, 0x51, 0x31, 0x2B, 0x60, 0xD0, 0x90, 0x89, 0x00, 0x42, 0x38, 0x60, 0x00, 0x01, 0x90, 0x7E, 0x00, 0x08, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x89, 0x7E, 0x00, 0x17, 0x2F, 0x0B, 0x00, 0x01, 0x41, 0x9A, 0x00, 0x0C, 0x38, 0x60, 0x00, 0x00, 0x90, 0x7E, 0x00, 0x08 };
            XRPC.SetMemory(0x822107A4, hack);
            XRPC.SetMemory(0x822104BC, nop);
        }

        private void buttonX75_Click(object sender, EventArgs e)
        {
            Byte[] hack = { 60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x3C, 0x60, 0x83, 0x0C, 0x30, 0x63, 0x29, 0x4B, 0x89, 0x23, 0x00, 0x00, 0x2B, 0x09, 0x00, 0x00, 0x41, 0x9A, 0x00, 0xA8, 0x60, 0x00, 0x00, 0x00, 0x3C, 0x60, 0x84, 0x51, 0x30, 0x63, 0x60, 0xD0, 0x3C, 0x80, 0x82, 0x0A, 0x38, 0x84, 0xEE, 0xA8, 0xC1, 0xC4, 0xFF, 0xBC, 0xC0, 0xC3, 0x02, 0x8C, 0xC0, 0x04, 0x00, 0x00, 0xFC, 0xC0, 0x30, 0x50, 0xEC, 0x26, 0x00, 0x32, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x48, 0x7F, 0x17, 0x2D, 0xFC, 0x20, 0x08, 0x18, 0xC0, 0x43, 0x00, 0x38, 0xEC, 0x2E, 0x00, 0x72, 0xEC, 0x21, 0x10, 0x2A, 0xD0, 0x23, 0x00, 0x38, 0x60, 0x00, 0x00, 0x00, 0x38, 0xC0, 0x00, 0x00, 0x90, 0xC3, 0x00, 0x42, 0xC0, 0xC3, 0x02, 0x90, 0xC0, 0x04, 0x00, 0x00, 0xEC, 0x26, 0x00, 0x32, 0x48, 0x7F, 0x16, 0xFD, 0xFC, 0x20, 0x08, 0x18, 0xC0, 0x43, 0x00, 0x34, 0xEC, 0x2E, 0x00, 0x72, 0xEC, 0x21, 0x10, 0x2A, 0xD0, 0x23, 0x00, 0x34, 0xC0, 0xC3, 0x02, 0x90, 0xC0, 0x04, 0x00, 0x00, 0xEC, 0x26, 0x00, 0x32, 0x48, 0x7F, 0x17, 0xB9, 0xFC, 0x20, 0x08, 0x18, 0xC0, 0x43, 0x00, 0x30, 0xEC, 0x2E, 0x00, 0x72, 0xEC, 0x21, 0x10, 0x2A, 0xD0, 0x23, 0x00, 0x30, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x82210774, hack);
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x822104BC, nop);
        }

        private void buttonX78_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x00, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x830BE000, nop);
        }

        private void buttonX77_Click(object sender, EventArgs e)
        {
            //how to use: get final offset to be noped and take that from start loc, convert to decimal and divide by 4
            UInt32 change = 0x822104C0; //start loc
            UInt32 keep = 0x00000004; //keep this
            Byte[] hi = { 0x60, 0x00, 0x00, 0x00 };
            int t = 0;
            while (t <= 389) // length
            {
                XRPC.SetMemory(change, hi);
                t = t + 1;
                change = keep + change;
            }
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            //bytes that store r1 and r16
            Byte[] store = { 0x3D, 0x60, 0x83, 0x0C, 0x30, 0x8B, 0xDF, 0x00, 0xFA, 0x04, 0x00, 0x00, 0xF8, 0x24, 0x00, 0x08, 0x80, 0x64, 0x00, 0x10, 0x2B, 0x03, 0x00, 0x01, 0x60, 0x00, 0x00, 0x00, 0x41, 0x9A, 0x05, 0x94, 0x38, 0x60, 0x00, 0x01, 0x90, 0x64, 0x00, 0x10 };
            //bytes that load r1 and r16
            Byte[] load = { 0x3D, 0x60, 0x83, 0x0C, 0x30, 0x8B, 0xDF, 0x00, 0xEA, 0x04, 0x00, 0x00, 0xE8, 0x24, 0x00, 0x08 };
            XRPC.SetMemory(0x822104C0, store);
            XRPC.SetMemory(0x82210AC8, load);
            XRPC.SetMemory(0x822104BC, nop);
        }

        private void buttonX80_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x08 };
            XRPC.SetMemory(0x845160F2, nop);
        }

        private void buttonX83_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x08 };
            XRPC.SetMemory(0x8451C2AA, nop);
        }

        private void textBoxX4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX79_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            Byte[] ball = { 0x48, 0x00 };
            XRPC.SetMemory(0x826AC48C, nop);
            XRPC.SetMemory(0x826AC4F8, nop);
            XRPC.SetMemory(0x826135D8, ball); // free does not match alloc
            //XRPC.SetMemory(0x82645A80, ball); // version chack
            //XRPC.SetMemory(0x82323B24, ball); // bsp not found
            //XRPC.SetMemory(0x82323B80, nop); //defualt asset not loaded properly
            XRPC.Call(0x82631630, 0, "devmap zm_factory");

        }

        private void buttonX85_Click(object sender, EventArgs e)
        {
            //TU0-4 multiplication is 0x4B9ACE2F, tu5-6 is 0x811C9DEF , tu8 multiplication is 0xE5770569
            if (radioButton3.Checked == true)
            {
                Int64 mulli = Convert.ToInt64(0x4B9ACE2F);
                Int64 hi = CanonicalHash(textBoxX6.Text, mulli);
                byte[] bitbytes = BitConverter.GetBytes(hi);
                Array.Reverse(bitbytes);
                byte[] dst = new byte[bitbytes.Length - 4];
                Array.Copy(bitbytes, 4, dst, 0, dst.Length);
                string bytes = BitConverter.ToString(dst);
                textBoxX7.Text = Convert.ToString(bytes);
            }
            else if (radioButton2.Checked == true)
            {
                Int64 hi = CanonicalHash(textBoxX6.Text, 0x811C9DEF);
                byte[] bitbytes = BitConverter.GetBytes(hi);
                Array.Reverse(bitbytes);
                byte[] dst = new byte[bitbytes.Length - 4];
                Array.Copy(bitbytes, 4, dst, 0, dst.Length);
                string bytes = BitConverter.ToString(dst);
                textBoxX7.Text = Convert.ToString(bytes);
            }
            else if (radioButton1.Checked == true)
            {
                Int64 hi = CanonicalHash(textBoxX6.Text, 0xE5770569);
                byte[] bitbytes = BitConverter.GetBytes(hi);
                Array.Reverse(bitbytes);
                byte[] dst = new byte[bitbytes.Length - 4];
                Array.Copy(bitbytes, 4, dst, 0, dst.Length);
                string bytes = BitConverter.ToString(dst);
                textBoxX7.Text = Convert.ToString(bytes);
            }
        }

        private void buttonX86_Click(object sender, EventArgs e)
        {
            if (redbox3 == true)
            {
                Byte[] nop1 = { 0x00 };
                XRPC.SetMemory(0x84518F31, nop1);
                redbox3 = false;
                buttonX86.Text = "Third person: Off";
            }
            else
            {
                Byte[] nop1 = { 0x01 };
                XRPC.SetMemory(0x84518F31, nop1);
                redbox3 = true;
                buttonX86.Text = "Third person: On";
            }
        }

        private void buttonX87_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x82631630, 0, "killserver");
        }

        private void buttonX89_Click(object sender, EventArgs e)
        {
            textBox21.BackColor = System.Drawing.Color.Red;
            textBox21.Text = "Button has been pressed!";
            Byte[] reset = { 0x41, 0x82, 0x06, 0x1C };
            XRPC.SetMemory(0x822104BC, reset);
            //get final offset to be noped and take that from initial value, convert to decimal and divide by 4
            UInt32 change = 0x822104C0;
            UInt32 keep = 0x00000004;
            Byte[] hi = { 0x60, 0x00, 0x00, 0x00 };
            int t = 0;
            while (t <= 389)
            {
                XRPC.SetMemory(change, hi);
                t = t + 1;
                change = keep + change;
            }
            Byte[] nop = { 0x60, 0x00, 0x00, 0x00 };
            Byte[] store = { 0x3D, 0x60, 0x83, 0x0C, 0x30, 0x8B, 0xDF, 0x00, 0xFA, 0x04, 0x00, 0x00, 0xF8, 0x24, 0x00, 0x08, 0x80, 0x64, 0x00, 0x10, 0x2B, 0x03, 0x00, 0x01, 0x60, 0x00, 0x00, 0x00, 0x41, 0x9A, 0x05, 0x94, 0x38, 0x60, 0x00, 0x01, 0x90, 0x64, 0x00, 0x10 };
            Byte[] load = { 0x3D, 0x60, 0x83, 0x0C, 0x30, 0x8B, 0xDF, 0x00, 0xEA, 0x04, 0x00, 0x00, 0xE8, 0x24, 0x00, 0x08 };

            //sets conststring
            Byte[] conststring = { 0x3D, 0x60, 0x83, 0x0C, 0x30, 0x8B, 0xDF, 0x20, 0x80, 0x64, 0x00, 0x00, 0x2B, 0x03, 0x00, 0x01, 0x41, 0x9A, 0x00, 0x58, 0x38, 0x60, 0x00, 0x01, 0x90, 0x64, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x6B, 0x01, 0x30, 0x38, 0xA0, 0x00, 0x00, 0x38, 0x80, 0x00, 0x00, 0x48, 0x0B, 0xDB, 0x71, 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x01, 0x50, 0x90, 0x64, 0x00, 0x00 };
            Byte[] one = { 0x00, 0x00, 0x00, 0x01 };
            XRPC.SetMemory(0x82210A70, conststring);
            XRPC.SetMemory(0x830BDF20, one);
            XRPC.SetMemory(0x830BDF10, one);
            XRPC.SetMemory(0x822104C0, store);
            XRPC.SetMemory(0x82210AC8, load);
            XRPC.SetMemory(0x822D97D4, nop);
            XRPC.SetMemory(0x822D9800, nop);
            XRPC.SetMemory(0x822D98F8, nop);
            XRPC.SetMemory(0x822D9214, nop);
            XRPC.SetMemory(0x822D9D84, nop);
            XRPC.SetMemory(0x822D998C, nop);
            XRPC.SetMemory(0x822D99AC, nop);
            XRPC.SetMemory(0x822D9D84, nop);
            XRPC.SetMemory(0x822104BC, nop);
        }

        private void buttonX88_Click(object sender, EventArgs e)
        {
            string GSC = textBoxX10.Text.Insert(2, ", ");
            GSC = GSC.Insert(6, ", ");
            GSC = GSC.Insert(10, ", ");
            string[] s = GSC.Split(',');
            byte[] data = new byte[s.Length];
            for (int i = 0; i < data.Length; i++)
                data[i] = byte.Parse(s[i], System.Globalization.NumberStyles.HexNumber);
            Array.Reverse(data);
            UInt32 offset = BitConverter.ToUInt32(data, 0);
            offset = (offset - 2183202840) + 1;
            data = BitConverter.GetBytes(offset);
            Array.Reverse(data);
            Byte[] hi = { 0x48 };
            XRPC.SetMemory(0x82210818, data); //adds function jump
            XRPC.SetMemory(0x82210818, hi); //fixes branch byte to correct one
            Byte[] clear = { 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x822107FC, clear);
            XRPC.SetMemory(0x822107E4, clear);
            XRPC.SetMemory(0x822107C0, clear);
            XRPC.SetMemory(0x8221077C, clear);
            Byte[] paramss = { 0x48, 0x0C, 0x61, 0xDD };
            XRPC.SetMemory(0x82210834, paramss);
            if (textBoxX11.Text == "") // Instance
            {
                Byte[] asmint = { 0x38, 0x60, 0x00, 0x00 };
                XRPC.SetMemory(0x82210808, asmint);
                XRPC.SetMemory(0x822107F0, asmint);
                XRPC.SetMemory(0x822107CC, asmint);
                XRPC.SetMemory(0x82210788, asmint);
                XRPC.SetMemory(0x82210830, asmint);
            }
            else if (textBoxX11.Text == "0")
            {
                Byte[] asmint = { 0x38, 0x60, 0x00, 0x00 };
                XRPC.SetMemory(0x82210808, asmint);
                XRPC.SetMemory(0x822107F0, asmint);
                XRPC.SetMemory(0x822107CC, asmint);
                XRPC.SetMemory(0x82210788, asmint);
                XRPC.SetMemory(0x82210830, asmint);
            }
            else if (textBoxX11.Text == "1")
            {
                Byte[] asmint = { 0x38, 0x60, 0x00, 0x01 };
                XRPC.SetMemory(0x82210808, asmint);
                XRPC.SetMemory(0x822107F0, asmint);
                XRPC.SetMemory(0x822107CC, asmint);
                XRPC.SetMemory(0x82210788, asmint);
                XRPC.SetMemory(0x82210830, asmint);
            }
            else if (textBoxX11.Text == "2")
            {
                Byte[] asmint = { 0x38, 0x60, 0x00, 0x02 };
                XRPC.SetMemory(0x82210808, asmint);
                XRPC.SetMemory(0x822107F0, asmint);
                XRPC.SetMemory(0x822107CC, asmint);
                XRPC.SetMemory(0x82210788, asmint);
                XRPC.SetMemory(0x82210830, asmint);
            }

            if (textBoxX12.Text == "") //player
            {
                Byte[] asmint = { 0x38, 0x80, 0x00, 0x00 };
                XRPC.SetMemory(0x82210814, asmint);
            }
            else if (textBoxX12.Text == "0")
            {
                Byte[] asmint = { 0x38, 0x80, 0x00, 0x00 };
                XRPC.SetMemory(0x82210814, asmint);
            }
            else if (textBoxX12.Text == "1")
            {
                Byte[] asmint = { 0x38, 0x80, 0x00, 0x01 };
                XRPC.SetMemory(0x82210814, asmint);
            }
            else if (textBoxX12.Text == "2")
            {
                Byte[] asmint = { 0x38, 0x80, 0x00, 0x02 };
                XRPC.SetMemory(0x82210814, asmint);
            }
            else if (textBoxX12.Text == "3")
            {
                Byte[] asmint = { 0x38, 0x80, 0x00, 0x03 };
                XRPC.SetMemory(0x82210814, asmint);
            }

            //1st paramater
            if (comboBox1.Text == "Float")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9D, 0x55 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x00, 0xC0, 0x24, 0x00, 0x00 };
                Byte[] info = BitConverter.GetBytes(Convert.ToSingle(textBoxX8.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x830C0000, info);
                XRPC.SetMemory(0x822107FC, asmfloat);
                XRPC.SetMemory(0x8221080C, patch);
            }
            else if (comboBox1.Text == "Integer")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9C, 0xF5 };
                Byte[] asmint = { 0x38, 0x80 };
                Byte[] info = BitConverter.GetBytes(Convert.ToUInt16(textBoxX8.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x82210806, info);
                XRPC.SetMemory(0x82210804, asmint);
                XRPC.SetMemory(0x8221080C, patch);
            }
            else if (comboBox1.Text == "ConstString")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA0, 0x85 };
                Byte[] asmhalf = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x60, 0xA0, 0x84, 0x00, 0x00 };
                string scr = textBoxX8.Text.Insert(2, ", ");
                string[] sc = scr.Split(',');
                byte[] dataa = new byte[sc.Length];
                for (int i = 0; i < dataa.Length; i++)
                    dataa[i] = byte.Parse(sc[i], System.Globalization.NumberStyles.HexNumber);
                XRPC.SetMemory(0x830C0060, dataa);
                XRPC.SetMemory(0x822107FC, asmhalf);
                XRPC.SetMemory(0x8221080C, patch);
            }
            else if (comboBox1.Text == "String")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9F, 0x95 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x70 };
                Byte[] info = Encoding.Default.GetBytes(textBoxX8.Text);
                XRPC.SetMemory(0x830C0070, info);
                XRPC.SetMemory(0x82210800, asmfloat);
                XRPC.SetMemory(0x8221080C, patch);
            }
            else if (comboBox1.Text == "Vector")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA1, 0x15 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x04 };
                string[] vector = textBoxX8.Text.Split(',');
                Byte[] vec1 = BitConverter.GetBytes(Convert.ToSingle(vector[0]));
                Byte[] vec2 = BitConverter.GetBytes(Convert.ToSingle(vector[1]));
                Byte[] vec3 = BitConverter.GetBytes(Convert.ToSingle(vector[2]));
                Array.Reverse(vec1);
                Array.Reverse(vec2);
                Array.Reverse(vec3);
                XRPC.SetMemory(0x830C0004, vec1);
                XRPC.SetMemory(0x830C0008, vec2);
                XRPC.SetMemory(0x830C000C, vec3);
                XRPC.SetMemory(0x82210800, asmfloat);
                XRPC.SetMemory(0x8221080C, patch);
            }
            else if (comboBox1.Text == "Weapon")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9E, 0xED };
                Byte[] asmclass = { 0x38, 0xA0, 0x00, 0x00 };
                Byte[] asmweap = { 0x38, 0x80 };
                Byte[] info = BitConverter.GetBytes(Convert.ToUInt16(textBoxX8.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x82210806, info);
                XRPC.SetMemory(0x82210804, asmweap);
                XRPC.SetMemory(0x82210800, asmclass);
                XRPC.SetMemory(0x8221080C, patch);
            }

            //2nd parameter
            if (comboBox2.Text == "Float")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9D, 0x6D };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x00, 0xC0, 0x24, 0x00, 0x00 };
                Byte[] info = BitConverter.GetBytes(Convert.ToSingle(textBoxX9.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x830C0010, info);
                XRPC.SetMemory(0x822107E4, asmfloat);
                XRPC.SetMemory(0x822107F4, patch);
            }
            else if (comboBox2.Text == "Integer")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9D, 0x0D };
                Byte[] asmint = { 0x38, 0x80 };
                Byte[] info = BitConverter.GetBytes(Convert.ToUInt16(textBoxX9.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x822107EE, info);
                XRPC.SetMemory(0x822107EC, asmint);
                XRPC.SetMemory(0x822107F4, patch);
            }
            else if (comboBox2.Text == "ConstString")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA0, 0x9D };
                Byte[] asmhalf = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x60, 0xA0, 0x84, 0x00, 0x00 };
                string scr = textBoxX9.Text.Insert(2, ", ");
                string[] sc = scr.Split(',');
                byte[] dataa = new byte[sc.Length];
                for (int i = 0; i < dataa.Length; i++)
                    dataa[i] = byte.Parse(sc[i], System.Globalization.NumberStyles.HexNumber);
                XRPC.SetMemory(0x830C0062, dataa);
                XRPC.SetMemory(0x822107E4, asmhalf);
                XRPC.SetMemory(0x822107F4, patch);
            }
            else if (comboBox2.Text == "String")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9F, 0xAD };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x70 };
                Byte[] info = Encoding.Default.GetBytes(textBoxX9.Text);
                XRPC.SetMemory(0x830C0090, info);
                XRPC.SetMemory(0x822107E8, asmfloat);
                XRPC.SetMemory(0x822107F4, patch);
            }
            else if (comboBox2.Text == "Vector")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA1, 0x3D };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x04 };
                string[] vector = textBoxX9.Text.Split(',');
                Byte[] vec1 = BitConverter.GetBytes(Convert.ToSingle(vector[0]));
                Byte[] vec2 = BitConverter.GetBytes(Convert.ToSingle(vector[1]));
                Byte[] vec3 = BitConverter.GetBytes(Convert.ToSingle(vector[2]));
                Array.Reverse(vec1);
                Array.Reverse(vec2);
                Array.Reverse(vec3);
                XRPC.SetMemory(0x830C0014, vec1);
                XRPC.SetMemory(0x830C0018, vec2);
                XRPC.SetMemory(0x830C001C, vec3);
                XRPC.SetMemory(0x822107E8, asmfloat);
                XRPC.SetMemory(0x822107F4, patch);
            }
            else if (comboBox2.Text == "Weapon")
            {

            }

            //3rd paramater
            if (comboBox4.Text == "Float")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9D, 0x91 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x00, 0xC0, 0x24, 0x00, 0x00 };
                Byte[] info = BitConverter.GetBytes(Convert.ToSingle(textBoxX14.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x830C0020, info);
                XRPC.SetMemory(0x822107C0, asmfloat);
                XRPC.SetMemory(0x822107D0, patch);
            }
            else if (comboBox4.Text == "Integer")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9D, 0x31 };
                Byte[] asmint = { 0x38, 0x80 };
                Byte[] info = BitConverter.GetBytes(Convert.ToUInt16(textBoxX14.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x822107CA, info);
                XRPC.SetMemory(0x822107C8, asmint);
                XRPC.SetMemory(0x822107D0, patch);
            }
            else if (comboBox4.Text == "ConstString")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA0, 0xC1 };
                Byte[] asmhalf = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x60, 0xA0, 0x84, 0x00, 0x00 };
                string scr = textBoxX14.Text.Insert(2, ", ");
                string[] sc = scr.Split(',');
                byte[] dataa = new byte[sc.Length];
                for (int i = 0; i < dataa.Length; i++)
                    dataa[i] = byte.Parse(sc[i], System.Globalization.NumberStyles.HexNumber);
                XRPC.SetMemory(0x830C0064, dataa);
                XRPC.SetMemory(0x822107C0, asmhalf);
                XRPC.SetMemory(0x822107D0, patch);
            }
            else if (comboBox4.Text == "String")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9F, 0xD1 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x70 };
                Byte[] info = Encoding.Default.GetBytes(textBoxX14.Text);
                XRPC.SetMemory(0x830C00B0, info);
                XRPC.SetMemory(0x822107C4, asmfloat);
                XRPC.SetMemory(0x822107D0, patch);
            }
            else if (comboBox4.Text == "Vector")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA1, 0x51 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x04 };
                string[] vector = textBoxX14.Text.Split(',');
                Byte[] vec1 = BitConverter.GetBytes(Convert.ToSingle(vector[0]));
                Byte[] vec2 = BitConverter.GetBytes(Convert.ToSingle(vector[1]));
                Byte[] vec3 = BitConverter.GetBytes(Convert.ToSingle(vector[2]));
                Array.Reverse(vec1);
                Array.Reverse(vec2);
                Array.Reverse(vec3);
                XRPC.SetMemory(0x830C0024, vec1);
                XRPC.SetMemory(0x830C0028, vec2);
                XRPC.SetMemory(0x830C002C, vec3);
                XRPC.SetMemory(0x822107C4, asmfloat);
                XRPC.SetMemory(0x822107D0, patch);
            }
            else if (comboBox4.Text == "Weapon")
            {

            }

            //4th paramater
            if (comboBox3.Text == "Float")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9D, 0xD5 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x00, 0xC0, 0x24, 0x00, 0x00 };
                Byte[] info = BitConverter.GetBytes(Convert.ToSingle(textBoxX13.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x830C0030, info);
                XRPC.SetMemory(0x8221077C, asmfloat);
                XRPC.SetMemory(0x8221078C, patch);
            }
            else if (comboBox3.Text == "Integer")
            {
                Byte[] patch = { 0x48, 0x0C, 0x9D, 0x75 };
                Byte[] asmint = { 0x38, 0x80 };
                Byte[] info = BitConverter.GetBytes(Convert.ToUInt16(textBoxX13.Text));
                Array.Reverse(info);
                XRPC.SetMemory(0x82210786, info);
                XRPC.SetMemory(0x82210784, asmint);
                XRPC.SetMemory(0x8221078C, patch);
            }
            else if (comboBox3.Text == "ConstString")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA1, 0x05 };
                Byte[] asmhalf = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x60, 0xA0, 0x84, 0x00, 0x00 };
                string scr = textBoxX13.Text.Insert(2, ", ");
                string[] sc = scr.Split(',');
                byte[] dataa = new byte[sc.Length];
                for (int i = 0; i < dataa.Length; i++)
                    dataa[i] = byte.Parse(sc[i], System.Globalization.NumberStyles.HexNumber);
                XRPC.SetMemory(0x830C0066, dataa);
                XRPC.SetMemory(0x8221077C, asmhalf);
                XRPC.SetMemory(0x8221078C, patch);
            }
            else if (comboBox3.Text == "String")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA0, 0x14 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x70 };
                Byte[] info = Encoding.Default.GetBytes(textBoxX13.Text);
                XRPC.SetMemory(0x830C00D0, info);
                XRPC.SetMemory(0x82210780, asmfloat);
                XRPC.SetMemory(0x8221078C, patch);
            }
            else if (comboBox3.Text == "Vector")
            {
                Byte[] patch = { 0x48, 0x0C, 0xA1, 0x95 };
                Byte[] asmfloat = { 0x3D, 0x60, 0x83, 0x0C, 0x38, 0x8B, 0x00, 0x04 };
                string[] vector = textBoxX13.Text.Split(',');
                Byte[] vec1 = BitConverter.GetBytes(Convert.ToSingle(vector[0]));
                Byte[] vec2 = BitConverter.GetBytes(Convert.ToSingle(vector[1]));
                Byte[] vec3 = BitConverter.GetBytes(Convert.ToSingle(vector[2]));
                Array.Reverse(vec1);
                Array.Reverse(vec2);
                Array.Reverse(vec3);
                XRPC.SetMemory(0x830C0034, vec1);
                XRPC.SetMemory(0x830C0038, vec2);
                XRPC.SetMemory(0x830C003C, vec3);
                XRPC.SetMemory(0x82210780, asmfloat);
                XRPC.SetMemory(0x8221078C, patch);
            }
            else if (comboBox3.Text == "Weapon")
            {

            }
            Byte[] nop1 = { 0x00 };
            XRPC.SetMemory(0x830BDF13, nop1);
        }

        private void buttonX90_Click(object sender, EventArgs e)
        {
            int length = textBoxX16.TextLength;
            length = length + 1;
            Byte[] lgth = BitConverter.GetBytes(length);
            byte[] dst = new byte[lgth.Length - 3];
            Array.Copy(lgth, 0, dst, 0, dst.Length);
            Byte[] conststring = Encoding.Default.GetBytes(textBoxX16.Text);
            XRPC.SetMemory(0x830C0130, conststring);
            Byte[] one = { 0x00, 0x00, 0x00, 0x00 };
            XRPC.SetMemory(0x82210A9B, dst);
            XRPC.SetMemory(0x830BDF20, one);
            Thread.Sleep(500);
            Byte[] half = XRPC.GetMemory(0x830C0152, 2);
            textBoxX15.Text = BitConverter.ToString(half).Remove(2, 1);
        }

        private void buttonX91_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x00 };
            XRPC.SetMemory(0x830BDF13, nop);
        }

        private void buttonX92_Click(object sender, EventArgs e)
        {
            Byte[] nop = { 0x3D, 0x60, 0x88, 0x01, 0x39, 0x6B, 0x00, 0x00, 0x7D, 0x69, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x20 };
            XRPC.SetMemory(0x82210850, nop);
        }

        private void buttonX93_Click(object sender, EventArgs e)
        {
            int t = 0;
            string[] lines = System.IO.File.ReadAllLines(@"E:\coding\RTE tool creation\gsc\STRuCT\jbird632\scriptnames.txt");
            foreach (string line in lines)
            {
                int copy = t;
                Int64 hi = CanonicalHashtu8(line);
                byte[] bitbytes = BitConverter.GetBytes(hi);
                Array.Reverse(bitbytes);
                byte[] dst = new byte[bitbytes.Length - 4];
                Array.Copy(bitbytes, 4, dst, 0, dst.Length);
                string newstring = BitConverter.ToString(dst);
                newstring = newstring += "\n";
                File.AppendAllText(@"E:\coding\RTE tool creation\gsc\STRuCT\jbird632\hashed_scriptnames.txt", newstring);
                t = t + 1;
            }

        }
        int SearchByte(byte[] src, byte[] pattern)
        {
            int c = src.Length - pattern.Length + 1;
            int j;
            for (int i = 0; i < c; i++)
            {
                if (src[i] != pattern[0]) continue;
                for (j = pattern.Length - 1; j >= 1 && src[i + j] == pattern[j]; j--) ;
                if (j == 0) return i+12;
            }
            return -1;
        }

        private void buttonX94_Click(object sender, EventArgs e)
        {
            //how to work - get all func names into a textfile, seperated by line breaks with no spaces. use the hash functions button then open and replace the - with a space. once done, press this button.
            byte[] dst = new byte[4];
            string newstring = "";
            byte[] src = File.ReadAllBytes(@"E:\coding\RTE tool creation\gsc\STRuCT\full_bo3_SoE_dump");
            string[] lines = System.IO.File.ReadAllLines(@"E:\coding\RTE tool creation\gsc\STRuCT\zeroy\zeroy_names_hashed.txt");
            foreach (string line in lines)
            {
                byte[] pattern = line.Split( )
                                    .Select(t => byte.Parse(t, NumberStyles.AllowHexSpecifier))
                                    .ToArray();
                int loc = SearchByte(src, pattern);
                if (loc == -1)
                {
                    File.AppendAllText(@"E:\coding\RTE tool creation\gsc\STRuCT\zeroy\zeroy_gsc_locs.txt", "notfound\n");
                }
                else
                {
                    Array.Copy(src, loc, dst, 0, dst.Length);
                    newstring = BitConverter.ToString(dst);
                    File.AppendAllText(@"E:\coding\RTE tool creation\gsc\STRuCT\zeroy\zeroy_gsc_locs.txt", (newstring += "\n"));
                }
            }
        }

        private void buttonX84_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8263A6A0, 0, textBoxX1.Text);
        }

        private void buttonX95_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x82665968, 0, 1, textBoxX4.Text);
        }

        //private void buttonX96_Click(object sender, EventArgs e)
        //{
        //    uint start = 0x82CCA994;
        //
        //    int num = 0;
        //    
        //    byte[] nameArray = XRPC.GetMemory(start + 0x00, 4);
        //    byte[] compressedLenArray = XRPC.GetMemory(start + 0x04, 4);
        //    byte[] lenArray = XRPC.GetMemory(start + 0x08, 4);
        //    byte[] bytecodeLenArray = XRPC.GetMemory(start + 0x0C, 4);
        //    byte[] bufferArray = XRPC.GetMemory(start + 0x10, 4);
        //    byte[] bytecodeArray = XRPC.GetMemory(start + 0x14, 4);
        //
        //    Array.Reverse(nameArray);
        //    Array.Reverse(compressedLenArray);
        //    Array.Reverse(lenArray);
        //    Array.Reverse(bytecodeLenArray);
        //    Array.Reverse(bufferArray);
        //    Array.Reverse(bytecodeArray);
        //
        //    int name = BitConverter.ToInt32(nameArray, 0);
        //    int compressedLen = BitConverter.ToInt32(nameArray, 0);
        //    int len = BitConverter.ToInt32(nameArray, 0);
        //    int bytecodeLen = BitConverter.ToInt32(nameArray, 0);
        //    int name = BitConverter.ToInt32(nameArray, 0);
        //    int name = BitConverter.ToInt32(nameArray, 0);
        //
        //    byte[] file = new byte[name.Length + compressedLen.Length + len.Length + bytecodeLen.Length + buffer.Length + bytecode.Length];
        //
        //    Buffer.BlockCopy(name, 0, file, 0, name.Length);
        //    Buffer.BlockCopy(compressedLen, 0, file, name.Length, compressedLen.Length);
        //    Buffer.BlockCopy(len, 0, file, name.Length + compressedLen.Length, len.Length);
        //    Buffer.BlockCopy(bytecodeLen, 0, file, name.Length + compressedLen.Length + len.Length, bytecodeLen.Length);
        //    Buffer.BlockCopy(buffer, 0, file, name.Length + compressedLen.Length + len.Length + bytecodeLen.Length, buffer.Length);
        //    Buffer.BlockCopy(bytecode, 0, file, name.Length + compressedLen.Length + len.Length + bytecodeLen.Length + buffer.Length, bytecode.Length);
        //
        //    File.WriteAllBytes(@"E:\Coding\Xbox\Projects\BO3 RTE tool\RTE tool\MW3\" + num, file);
        //}

        private struct ScriptFileXAsset
        {
            public uint Name { get; set; }
            public int CompressedLen { get; set; }
            public int Len { get; set; }
            public int BytecodeLen { get; set; }
            public uint Buffer { get; set; }
            public uint Bytecode { get; set; }
        }

        private void buttonX96_Click(object sender, EventArgs e)
        {
            uint start = 0x82CCA994;

            for (int num = 0; num < 768; num++)
            {
                byte[] nameArray = XRPC.GetMemory(start + 0x00, 4);
                byte[] compressedLenArray = XRPC.GetMemory(start + 0x04, 4);
                byte[] lenArray = XRPC.GetMemory(start + 0x08, 4);
                byte[] bytecodeLenArray = XRPC.GetMemory(start + 0x0C, 4);
                byte[] bufferArray = XRPC.GetMemory(start + 0x10, 4);
                byte[] bytecodeArray = XRPC.GetMemory(start + 0x14, 4);

                Array.Reverse(nameArray);
                Array.Reverse(compressedLenArray);
                Array.Reverse(lenArray);
                Array.Reverse(bytecodeLenArray);
                Array.Reverse(bufferArray);
                Array.Reverse(bytecodeArray);

                ScriptFileXAsset header = new ScriptFileXAsset()
                {
                    Name = BitConverter.ToUInt32(nameArray, 0),
                    CompressedLen = BitConverter.ToInt32(compressedLenArray, 0),
                    Len = BitConverter.ToInt32(lenArray, 0),
                    BytecodeLen = BitConverter.ToInt32(bytecodeLenArray, 0),
                    Buffer = BitConverter.ToUInt32(bufferArray, 0),
                    Bytecode = BitConverter.ToUInt32(bytecodeArray, 0)

                };

                if (header.Buffer == 0)
                    break;

                byte[] filename = Encoding.UTF8.GetBytes(num.ToString() + char.MinValue);
                byte[] compressedLen = BitConverter.GetBytes(header.CompressedLen);
                byte[] len = BitConverter.GetBytes(header.Len);
                byte[] bytecodeLen = BitConverter.GetBytes(header.BytecodeLen);
                byte[] buffer = XRPC.GetMemory(header.Buffer, (uint)header.CompressedLen);
                byte[] bytecode = XRPC.GetMemory(header.Bytecode, (uint)header.BytecodeLen);

                byte[] file = new byte[filename.Length + compressedLen.Length + len.Length + bytecodeLen.Length + buffer.Length + bytecode.Length];

                Buffer.BlockCopy(filename, 0, file, 0, filename.Length);
                Buffer.BlockCopy(compressedLen, 0, file, filename.Length, compressedLen.Length);
                Buffer.BlockCopy(len, 0, file, filename.Length + compressedLen.Length, len.Length);
                Buffer.BlockCopy(bytecodeLen, 0, file, filename.Length + compressedLen.Length + len.Length, bytecodeLen.Length);
                Buffer.BlockCopy(buffer, 0, file, filename.Length + compressedLen.Length + len.Length + bytecodeLen.Length, buffer.Length);
                Buffer.BlockCopy(bytecode, 0, file, filename.Length + compressedLen.Length + len.Length + bytecodeLen.Length + buffer.Length, bytecode.Length);

                File.WriteAllBytes(@"E:\Coding\Xbox\Projects\BO3 RTE tool\RTE tool\MW3\" + num, file);

                start += 0x18;
            }
        }

        private void wwwbuttonX96_Click(object sender, EventArgs e) //gets all weapon names
        {
            string none = "none--------------------- ERROR\n";
            int weap = 0x00;
            int looper = 0;
            byte[] nulled = new byte[48];
            while (looper < 300)
            {
                XRPC.SetMemory(0x830C0000, nulled);
                XRPC.Call(0x821F3BE0, weap, 0x830C0000, 0x200, 1); //BG_GetWeaponForFullName(weaponNumber, outputbuffer, maxNameLength, unknown);     zm: 0x821F38F0, MP:0x821F3BE0
                byte[] buffer = XRPC.GetMemory(0x830C0000, 48);
                if (buffer[0] == 0)
                    File.AppendAllText(@"E:\coding\RTE tool creation\Projects\Research\BO3 Research\MP_weap_names.txt", none);
                else
                {
                    string str1 = System.Text.Encoding.Default.GetString(buffer);
                    str1 = str1.Remove(str1.Length - 3);
                    File.AppendAllText(@"E:\coding\RTE tool creation\Projects\Research\BO3 Research\MP_weap_names.txt", (str1 += "\n"));
                }
                weap = weap + 0x01;
                looper++;
            }
            //XRPC.Call(0x821F7428, "pistol_burst_zm", 1); - string to int
        }

        private void buttonX97_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x8266EEB0, 0, 0, textBoxX1.Text);
        }

        private void buttonX98_Click(object sender, EventArgs e)
        {
            XRPC.Call(0x82667D60);
        }
    }
}
