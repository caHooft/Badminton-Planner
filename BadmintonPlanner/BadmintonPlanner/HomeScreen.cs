using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BadmintonPlanner
{
    public partial class HomeScreen : Form
    {
        Form warning;

        public HomeScreen()
        {
            InitializeComponent();
            
        }

        private void NewBut_Click(object sender, EventArgs e)
        {
            warning = new Warning(this);
            warning.Show();
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            Stream saver;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((saver = saveFileDialog1.OpenFile()) != null)
                {
                    // hier zou dan code moeten om shit op te slaan enzo
                    saver.Close();
                }
            }
        }

        private void LoadBut_Click(object sender, EventArgs e)
        {
            Stream opener = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if ((opener = openFileDialog1.OpenFile()) != null)
                {
                    using (opener)
                    {
                        // hier code om de file aan te wjizen die opgeslagen zou moeten worden
                    }
                }
            }

        }

        private void ExportBut_Click(object sender, EventArgs e)
        {
            Stream saver;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((saver = saveFileDialog1.OpenFile()) != null)
                {
                    // hier zou dan code moeten om shit op te slaan enzo
                    saver.Close();
                }
            }
        }

        private void FormCloser(object sender, FormClosingEventArgs e)
        {
            if (warning == null)
                Application.Exit();
        }

    }
}
