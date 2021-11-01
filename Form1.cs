using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace My_App1._2._0
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            //worker.WorkerSupportsCancellation = true;
            //worker.WorkerReportsProgress = true;
            //worker.DoWork += Worker_Dowork;
        }
        int c = 1;
        //void NewForm()
        //{
        //    FileSearch f = new FileSearch();
        //    f.Text = "FileSearch " + c;
        //    f.Show();
        //    c += 1;
        //}
        //private void Worker_Dowork(object sender, DoWorkEventArgs e)
        //{
        //    NewForm();
        //} 
        private void button1_Click(object sender, EventArgs e)
        {
            FileSearch f = new FileSearch();
            f.Text = "FileSearch " + c;
            f.Show();
             
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void version12oToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
