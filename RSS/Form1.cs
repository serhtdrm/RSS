using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string v;
            v = textBox1.Text;
            Rsslist(v);
          
        }
        protected void Rsslist(string v)
        {
            XmlTextReader reader = new XmlTextReader(v);
            try
            {
                while (reader.Read())
                {
                    if (reader.LocalName == "title")
                    {
                        listBox1.Items.Add(item: reader.ReadString());
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(text: "SİTE İLE BAĞLANTI KURULAMADI.LÜTFEN GİRDİĞİNİZ SİTEYİ KONTROL EDİN", caption: "BAĞLANTI HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listBox1.ClearSelected();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
