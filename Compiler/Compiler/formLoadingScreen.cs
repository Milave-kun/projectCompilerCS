using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiler
{
    public partial class formLoadingScreen : Form
    {
        public formLoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (gunaProgressBar1.Value < 100)
            {
                gunaProgressBar1.Value += 1;

                label1.Text = gunaProgressBar1.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
                formCompiler fm2 = new formCompiler();
                fm2.Show();
                this.Hide();
            }


        }

        private void formLoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
