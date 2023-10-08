using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkukator1
{
    public partial class historia : Form
    {
        public List<string> HistList { get; set; }
        public List<string> ListTest = new List<string>();
        
        
        public historia()
        {
            InitializeComponent();
            this.Load += new EventHandler(DataLoad);

        }
        
        private void DataLoad(object sender, EventArgs e)
        {
            
            listBox1.DataSource = this.HistList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            
            
            listBox1.DataSource = null;
            listBox1.DataSource = this.HistList;
            
            
        }
    }
}

