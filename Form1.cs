using System;
using System.Resources;
using System.Configuration;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(@"settings.config", textBox1.Text.ToString());
                System.Diagnostics.Process.Start("GAME.exe");
            }
            catch
            {
                try
                {
                    System.Diagnostics.Process.Start("7zfm.exe", "thefuckinggame.7zip");
                }
                catch
                {
                    MessageBox.Show("How did you manage to fuck this up???", "...oh for fucks sake");
                    MessageBox.Show("Go undo whatever you did or download 7zip and try again retard", "you know what");
                    Application.Exit();
                }
            }



        }


        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void debugInstructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string modPath;
            OpenFileDialog modChooser = new OpenFileDialog();
            if (modChooser.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    modPath = modChooser.FileName;
                    File.Move("GAME_DATA/Managed/Assembly-CSharp.dll", "MODS/previousmod.dll");
                    File.Move(modPath, "GAME_Data/Managed/Assembly-Csharp.dll");

                }
                catch
                {
                    modPath = modChooser.FileName;
                    MessageBox.Show("make sure i'm in the right folder", "ahhhh snap");
                }
              

            }

            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/wkhfusX");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = File.ReadAllText("settings.config");
            }
            catch
            {

                MessageBox.Show("the fuck did u do with the settings.config file?", "ahhhh snap");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 magik = new Form2();
            magik.ShowDialog();
            this.Show();
            

            /*

            DialogResult areYouRetarded = MessageBox.Show("YOU CAN BREAK SHIT DOING THIS.  ARE YOU SURE YOU ARE NOT FUCKING RETARDED?", "WARNING YOU COULD FUCK SHIT UP", MessageBoxButtons.YesNo);
            if (areYouRetarded == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start("notepad.exe", "settings.config");
                }
                catch
                {
                    MessageBox.Show("Hey, how about before you start fucking with shit you try the game and make sure your piece of shit computer can run it first?", "little bit ambitious are we?");
                }
            }
            else
            {
                MessageBox.Show("You probably made the right decision, give the game a go as is first", "Better play it safe for now");
            }*/

          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bye nigga!");
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            DialogResult easteregg = MessageBox.Show("the fuck did you just do????  was that on purpose???", "nice find blanco nino", MessageBoxButtons.YesNo);
            if (easteregg == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Ok good, don't do that anymore", "little bit ambitious are we?");
                return;
            }
            easteregg = MessageBox.Show("Sure you wanna see how deep the rabbit hole goes?", "Hackerman says watup fam", MessageBoxButtons.YesNo);
            if (easteregg == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start("DNspy.exe", "/Totally Gangster As Fuck Zombies and Shit yo/GAME_Data/Managed/Assembly-C-sharp.dll");
                }
                catch
                {
                    MessageBox.Show("dnspy was included for a reason and you fucked something up.  Go fix it,", "you fucked up the files somehow");
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
   /*         try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files) Console.WriteLine(file);
            }
            catch
            {
                MessageBox.Show("shit's fucked up", "what the fuck did you do?");
            }
            */

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
    
    

