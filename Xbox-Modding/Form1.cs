using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using XRPCLib;
using XboxCore.Xbox.Connection;

using Xbox_Modding.Classes;
using XDevkit;

namespace Xbox_Modding
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
               
                ZombieClass.XRPC.Connect();
                Console.WriteLine("Console Has Been Connected too!");
                ZombieClass.ginterFace.Connect(out ZombieClass.ginterFace, "default");
                ((IXboxConsole)ZombieClass.ginterFace).XNotify(JRPC.XNotiyLogo.FLASHING_XBOX_CONSOLE, "Koaxy's Tool Connected!");
                Console.WriteLine(ZombieClass.ginterFace.GetCPUKey());

                Console.WriteLine(ZombieClass.XRPC.xbConnection);
            } 
            catch( Exception E )
            {
                richTextBox1.Text = "There was an Exception " + E.Message;
            }
            
            if (ZombieClass.XRPC.activeConnection == true)
            {
                
                richTextBox1.Text = "Connected!";
            }
            else
            {
                richTextBox1.Text= "Not connected, or a fatal exception has occured while attempting to connect.";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ZombieClass.XRPC.activeConnection == true)
            {

                ZombieClass.XRPC.Notify(XRPC.XNotiyLogo.FRIEND_REQUEST_LOGO, "Test");
            }
            else
            {
                richTextBox1.Text = "Not connected!";
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string emptyStr = "";
            richTextBox1.Text = emptyStr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console_ conSole = new Console_() ;
            conSole.GetLastConsoleErr();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ZombieClass.CheckForConnection();
            try
            {
                ZombieClass.CallConsoleCommand("noclip");
            }
            catch ( Exception E )
            { 
                MessageBox.Show(E.ToString());
            };
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZombieClass.CheckForConnection();
            try
            {
                ZombieClass.CallConsoleCommand("god");
            }
            catch( Exception E )
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ZombieClass.CheckForConnection();
            try
            {
                ZombieClass.CallConsoleCommand("give thundergun_upgraded_zm");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

       

        private void button7_Click(object sender, EventArgs e)
        {

            ZombieClass.CheckForConnection();
            try
            {
                ZombieClass.CallConsoleCommand("give ammo");
                ZombieClass.CallConsoleCommand("set player_clipSizeMultiplier 999");
                ZombieClass.CallConsoleCommand("set sf_use_ignoreammo 1");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Loaded Console, and Application.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ZombieClass.CheckForConnection();
            try
            {
                ZombieClass.CallConsoleCommand("give defaultweapon_mp");
            }
            catch(Exception E)
            { 
                Console.WriteLine(E.ToString());
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ZombieClass.XRPC.activeConnection == true)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Connected!";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Not Connected";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine("Hi");
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            ZombieClass.CheckForConnection();
            if (listBox1.SelectedIndex == 0)
            {
                Console.WriteLine("Selected IDX 1");
                ZombieClass.CallConsoleCommand("give ray_gun_zm");
            }
            if (listBox1.SelectedIndex == 1)
            {
                Console.WriteLine("Selected IDX 2");
                try 
                {
                    ZombieClass.CallConsoleCommand("give thundergun_upgraded_zm"); 
                }
                catch(Exception ee)
                {
                    Console.WriteLine(ee); 
                }
               
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ZombieClass.CheckForConnection();
            ZombieClass.XRPC.Call(0x82DC33B4, 0, 10000); // This isn't functional yet.
            //Console.WriteLine(plrPoints);
        }
    }
}
