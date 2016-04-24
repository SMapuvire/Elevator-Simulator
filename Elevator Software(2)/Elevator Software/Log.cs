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


namespace Elevator_Software
{
    public partial class Log : Form
    {
        private DataGridView songsDataGridView = new DataGridView();
   
        public Log()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Log_Load);

        }

        public string FillRichText(string aPath)
        {
            string content = File.ReadAllText(aPath);   
            richTextBox1.Text = content;
            return content;  
            
        }
        public string FillRichText2(string aPath)
        {
            string content = File.ReadAllText(aPath);
            richTextBox2.Text = content;
            return content;

        }
        private void Log_Load(object sender, EventArgs e)
        {
            FillRichText(@"WriteLines.txt");
            FillRichText2(@"WriteLines2.txt");
        }

  

      
    }
}
