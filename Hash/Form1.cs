using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable hashTable = new Hashtable(5);
            hashTable.Add("John", "8~SP_ZK4nR*(5e\\~");
            hashTable.Add("Jack", "2?T6C[5neAZb6\\NE");
            hashTable.Add("Mike", "~%qG:gv+AQ@t2K4N");
            hashTable.Add("Sam", "W9<]EZ5`W9YB/gN?");
            hashTable.Add("Tom", "pV!n#Fpf{B&7<;.n");

            string ans = textBox1.Text;
            string password = (string) hashTable[ans];

            textBox2.Text = password;
        }
    }
}
