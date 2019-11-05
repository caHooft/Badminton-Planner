using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonPlanner
{

    public partial class Warning : Form
    {

        Form form;

        public Warning(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ConBut_Click(object sender, EventArgs e)
        {
            form.Close();
            Form newform = new HomeScreen();
            newform.Show();
            this.Close();

        }


        private void CanBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Warning_Load(object sender, EventArgs e)
        {

        }
    }
}
