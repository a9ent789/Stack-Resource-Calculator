using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Results_Load(object sender, EventArgs e)
        {

        }
        public void listData(List<string> names, List<string> stacks, List<string> singles)
        {


            if (names[0] != "0") { label1.Text = names[0]; } else { label1.Text = string.Empty; }
            if (names[1] != "0") { label2.Text = names[1]; } else { label2.Text = string.Empty; }
            if (names[2] != "0") { label3.Text = names[2]; } else { label3.Text = string.Empty; }
            if (names[3] != "0") { label4.Text = names[3]; } else { label4.Text = string.Empty; }
            if (names[4] != "0") { label5.Text = names[4]; } else { label5.Text = string.Empty; }
            if (names[5] != "0") { label6.Text = names[5]; } else { label6.Text = string.Empty; }
            if (stacks[0] != "0") { label7.Text = stacks[0]; } else { label7.Text = string.Empty; }
            if (stacks[1] != "0") { label8.Text = stacks[1]; } else { label8.Text = string.Empty; }
            if (stacks[2] != "0") { label9.Text = stacks[2]; } else { label9.Text = string.Empty; }
            if (stacks[3] != "0") { label10.Text = stacks[3]; } else { label10.Text = string.Empty; }
            if (stacks[4] != "0") { label11.Text = stacks[4]; } else { label11.Text = string.Empty; }
            if (stacks[5] != "0") { label12.Text = stacks[5]; } else { label12.Text = string.Empty; }
            if (singles[0] != "0") { label13.Text = singles[0]; } else { label13.Text = string.Empty; }
            if (singles[1] != "0") { label14.Text = singles[1]; } else { label14.Text = string.Empty; }
            if (singles[2] != "0") { label15.Text = singles[2]; } else { label15.Text = string.Empty; }
            if (singles[3] != "0") { label16.Text = singles[3]; } else { label16.Text= string.Empty; }
            if (singles[4] != "0") { label17.Text = singles[4]; } else { label17.Text= string.Empty; }
            if (singles[5] != "0") { label18.Text = singles[5]; } else { label18.Text= string.Empty; }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
