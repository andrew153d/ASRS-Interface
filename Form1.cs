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
        const string Bin_ID_String = "Bin ID";
        const string Part_Name_String = "Name";
        const string Part_Value_String = "Value";
        const string Part_Package_String = "Package";
        const string Part_Quantity_String = "Quantity";
        const string Part_VRating_String = "Voltage Rating";
        const string Part_PRating_String = "Power Rating";
        const string Part_Number_String = "Supplier Part Number";
        const string Part_Supplier_String = "Supplier";
        const string Part_BinX = "Bin X";
        const string Part_BinY = "Bin Y";
        const string Part_BinZ = "Bin Z";
        const string Part_BinW = "Bin Width";
        const string Part_BinR = "Bin Rotation";
        const string Empty_String = "~";

        public List<Part> partList = new List<Part>();
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void printPartsToFile()
        {
            try
            {
                // Clear the contents of the file
                File.WriteAllText("Machine.txt", string.Empty);

                // Write "Hello" to the file
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Andre\\Documents\\ASRS\\ASRS Interface\\MachineProfile.txt"))
                {
                    string firstLine = Bin_ID_String + "|" + Part_Name_String + "|" + Part_Value_String + "|" + Part_Package_String + "|" + Part_Quantity_String + "|" + Part_VRating_String + "|" + Part_PRating_String + "|" + Part_Number_String + "|" + Part_Supplier_String + "|" + Part_BinX + "|" + Part_BinY + "|" + Part_BinZ + "|" + Part_BinW + "|" + Part_BinR;
                    writer.WriteLine(firstLine);
                    foreach(Part p in partList)
                    {
                        writer.WriteLine(p.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            partSettings.Visible = false; //disable PartSettings Window
            storeBin.Visible = false;     //disable part place window

            listBox.View = View.Details;
            listBox.FullRowSelect = true;
            listBox.AllowColumnReorder = true;
            //listBox.CheckBoxes = true; //uncomment when multiple part retreivl is possbile
            listBox.Columns.Add("Name", 100, HorizontalAlignment.Center);
            listBox.Columns.Add("Value", 100, HorizontalAlignment.Center);
            listBox.Columns.Add("Package", 100, HorizontalAlignment.Center);
            listBox.Columns.Add("Quantity", 100, HorizontalAlignment.Center);


            /*using (StreamReader sr = new StreamReader("C:\\Users\\Andre\\Documents\\ASRS\\ASRS Interface\\MachineProfile.txt"))
            {
                string firstLine = sr.ReadLine();
                string[] names = firstLine.Split('|');
                while (sr.Peek() >= 0)
                {   
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    Part part = new Part();
                    part.BinID =         names.Contains(Bin_ID_String) ? int.Parse(values[Array.IndexOf(names, Bin_ID_String)]) : 0;
                    part.Name =          names.Contains(Part_Name_String) ? values[Array.IndexOf(names, Part_Name_String)] : Empty_String;
                    part.Value =         names.Contains(Part_Value_String) ? values[Array.IndexOf(names, Part_Value_String)] : Empty_String;
                    part.Package =       names.Contains(Part_Package_String) ? values[Array.IndexOf(names, Part_Package_String)] : Empty_String;
                    part.Quantity =      names.Contains(Part_Quantity_String) ? int.Parse(values[Array.IndexOf(names, Part_Quantity_String)]) : 0;
                    part.voltageRating = names.Contains(Part_VRating_String) ? int.Parse(values[Array.IndexOf(names, Part_VRating_String)]) : 0;
                    part.powerRating =   names.Contains(Part_PRating_String) ? int.Parse(values[Array.IndexOf(names, Part_PRating_String)]) : 0;
                    part.Part_Number =   names.Contains(Part_Number_String) ? values[Array.IndexOf(names, Part_Number_String)] : Empty_String;
                    part.Supplier =      names.Contains(Part_Supplier_String) ? values[Array.IndexOf(names, Part_Supplier_String)] : Empty_String;
                    part.Bin_X =         names.Contains(Part_BinX) ? int.Parse(values[Array.IndexOf(names, Part_BinX)]) : 0;
                    part.Bin_Y =         names.Contains(Part_BinY) ? int.Parse(values[Array.IndexOf(names, Part_BinY)]) : 0;
                    part.Bin_Z =         names.Contains(Part_BinZ) ? int.Parse(values[Array.IndexOf(names, Part_BinZ)]) : 0;
                    part.Bin_Width =     names.Contains(Part_BinW) ? int.Parse(values[Array.IndexOf(names, Part_BinW)]) : 0;
                    part.Bin_R =         names.Contains(Part_BinR) ? int.Parse(values[Array.IndexOf(names, Part_BinR)]) : 0;
                    partList.Add(part);
                    
                }
            }*/

            foreach(Part p in partList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.Name;
                lvi.SubItems.Add(p.Value);
                lvi.SubItems.Add(p.Package);
                lvi.SubItems.Add(p.Quantity.ToString());
                listBox.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void Store_Click(object sender, EventArgs e)
        {
            storeBin.Visible = true;
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            partSettings.Visible = true;
            BinID_textBox.Text = "0";
            Name_textBox.Text = "0";
            Value_textBox.Text = "0";
            package_textBox.Text = "0"; 
            quantity_counter.Value = 0;
            voltageRating_textBox.Text = "0";
            powerRating_textBox.Text = "0"; 
            supplier_textBox.Text = "~";
            BinX_counter.Value = 0;
            BinY_counter.Value = 0; 
            BinZ_counter.Value = 0; 
            BinW_counter.Value = 0;
            BinR_counter.Value = 0;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            storeBin.Visible = false;
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        {
            partSettings.Visible = true;
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            partSettings.Visible = false;
            Part part = new Part();
            part.BinID = int.Parse(BinID_textBox.Text);
            part.Name = Name_textBox.Text;
            part.Value = Value_textBox.Text;
            part.Package = package_textBox.Text;
            part.Quantity = (int)quantity_counter.Value;
            part.voltageRating = int.Parse(voltageRating_textBox.Text);
            part.powerRating = int.Parse(powerRating_textBox.Text);
            part.Part_Number = partNumber_textBox.Text;
            part.Supplier = supplier_textBox.Text;
            part.Bin_X = (int)BinX_counter.Value;
            part.Bin_Y = (int) BinY_counter.Value;
            part.Bin_Z = (int)BinZ_counter.Value;
            part.Bin_Width = (int)BinW_counter.Value;
            part.Bin_R = (int)BinR_counter.Value;
            partList.Add(part);
            printPartsToFile();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancelStore_Click(object sender, EventArgs e)
        {
            storeBin.Visible = false;
        }
    }
}
