using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP_4365_002_Spring_2024_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        openFileDialog_TickerChooser.ShowDialog();
        }

        private void openFileDialog_ticker_FileOk(object sender, CancelEventArgs e)
        {
            string filename = openFileDialog_TickerChooser.FileName;
            this.Text = filename;
            //read the filename
            goReadFile(filename);
        }

        private void goReadFile(string filename)
        {
            throw new NotImplementedException();
            //read the file implementation
        }
    }
}
