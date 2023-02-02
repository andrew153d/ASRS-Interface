using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASRS_Interface
{
    public partial class Form1 : Form
    {
        public List<Part> partList = new List<Part>();
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox.View = View.Details;
            listBox.FullRowSelect = true;
            listBox.AllowColumnReorder = true;
            //listBox.CheckBoxes = true; //uncomment when multiple part retreivl is possbile
            listBox.Columns.Add("Name", 100, HorizontalAlignment.Center);
            listBox.Columns.Add("Value", 100, HorizontalAlignment.Center);
            listBox.Columns.Add("Package", 100, HorizontalAlignment.Center);
            listBox.Columns.Add("Quantity", 100, HorizontalAlignment.Center);


            using (StreamReader sr = new StreamReader("C:\\Users\\Andre\\Documents\\ASRS\\ASRS Interface\\MachineProfile.txt"))
            {
                string firstLine = sr.ReadLine();
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    Part part = new Part();
                    part.Bin = int.Parse(values[0]);
                    part.Name = values[1];
                    part.Value = values[2];
                    part.Package = values[3];
                   
                    int.TryParse(values[4], out int qt);
                    part.Quantity = qt;
                    partList.Add(part);
                    
                }
            }
            foreach(Part p in partList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.Name;
                lvi.SubItems.Add(p.Value);
                lvi.SubItems.Add(p.Package);
                lvi.SubItems.Add(p.Quantity.ToString());
                listBox.Items.Add(lvi);
            }
            //partList.Add(new Part() { Name = "Capacitor", Value = "10uf", Package = "0805"});
            
           
        }

        private void mylist_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
