using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Value = int.Parse(System.IO.File.ReadAllText("maxzombies.dll"));
            }
            catch
            {
                MessageBox.Show("how did you fuck this up", "what in the hell");
            }


            if (numericUpDown1.Value > 255)
            {
                MessageBox.Show("not gonna work homey, stop trying to ruin shit", "stop fucking with dlls");
                return;
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

}

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 10;

            try
            {
                System.IO.File.WriteAllText("maxzombies.dll", numericUpDown1.Value.ToString());
            }
            catch
            {
                MessageBox.Show("how did you fuck this up", "what in the hell");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 255)
            {
                MessageBox.Show("no u", "basil i swear to god stop fucking breaking shit");
                return;
            }


            try
            {
                System.IO.File.WriteAllText("maxzombies.dll", numericUpDown1.Value.ToString());
            }
            catch
            {
                MessageBox.Show("how did you fuck this up", "what in the hell");
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_VisibleChanged(object sender, EventArgs e)
        {
    
        }
    }
}
