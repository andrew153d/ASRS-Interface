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

        private Part partToModify = new Part();
        private bool ModifyPartflag = false;

        //public List<Part> partList = new List<Part>();
        public PartCollection partList = new PartCollection();
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
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
            
            listBox.Columns.Add(Bin_ID_String, 100,      HorizontalAlignment.Center);
            listBox.Columns.Add(Part_Name_String, 100,  HorizontalAlignment.Center);
            listBox.Columns.Add(Part_Value_String, 100, HorizontalAlignment.Center);
            listBox.Columns.Add(Part_Package_String, 100, HorizontalAlignment.Center);
            listBox.Columns.Add(Part_Quantity_String, 100, HorizontalAlignment.Center);
            listBox.Columns.Add(Part_VRating_String, 100, HorizontalAlignment.Center);
            listBox.Columns.Add(Part_PRating_String, 100, HorizontalAlignment.Center);
            listBox.Columns.Add(Part_Supplier_String, 100, HorizontalAlignment.Center);

            using (StreamReader sr = new StreamReader("C:\\Users\\Andre\\Documents\\ASRS\\ASRS Interface\\MachineProfile.txt"))
            {
                string firstLine = sr.ReadLine();
                string[] names = firstLine.Split('|');
                while (sr.Peek() >= 0)
                {   
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    Part part = new Part();
                    part.BinID =         names.Contains(Bin_ID_String) ? values[Array.IndexOf(names, Bin_ID_String)] : Empty_String;
                    part.Name =          names.Contains(Part_Name_String) ? values[Array.IndexOf(names, Part_Name_String)] : Empty_String;
                    part.Value =         names.Contains(Part_Value_String) ? values[Array.IndexOf(names, Part_Value_String)] : Empty_String;
                    part.Package =       names.Contains(Part_Package_String) ? values[Array.IndexOf(names, Part_Package_String)] : Empty_String;
                    part.Quantity =      names.Contains(Part_Quantity_String) ? int.Parse(values[Array.IndexOf(names, Part_Quantity_String)]) : 0;
                    part.voltageRating = names.Contains(Part_VRating_String) ? values[Array.IndexOf(names, Part_VRating_String)] : "";
                    part.powerRating =   names.Contains(Part_PRating_String) ? values[Array.IndexOf(names, Part_PRating_String)] : "";
                    part.Part_Number =   names.Contains(Part_Number_String) ? values[Array.IndexOf(names, Part_Number_String)] : Empty_String;
                    part.Supplier =      names.Contains(Part_Supplier_String) ? values[Array.IndexOf(names, Part_Supplier_String)] : Empty_String;
                    part.Bin_X =         names.Contains(Part_BinX) ? int.Parse(values[Array.IndexOf(names, Part_BinX)]) : 0;
                    part.Bin_Y =         names.Contains(Part_BinY) ? int.Parse(values[Array.IndexOf(names, Part_BinY)]) : 0;
                    part.Bin_Z =         names.Contains(Part_BinZ) ? int.Parse(values[Array.IndexOf(names, Part_BinZ)]) : 0;
                    part.Bin_Width =     names.Contains(Part_BinW) ? int.Parse(values[Array.IndexOf(names, Part_BinW)]) : 0;
                    part.Bin_R =         names.Contains(Part_BinR) ? int.Parse(values[Array.IndexOf(names, Part_BinR)]) : 0;
                    partList.Add(part);
                    
                }
            }

            refreshListBox();
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
            BinID_textBox.Text = "";
            Name_textBox.Text = "";
            Value_textBox.Text = "";
            package_textBox.Text = ""; 
            //quantity_counter.Value = 0;
            voltageRating_textBox.Text = "";
            powerRating_textBox.Text = ""; 
            supplier_textBox.Text = "";
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

        private void loadPartSettings(ref Part p)
        {
           
            BinID_textBox.Text = p.BinID;
            Name_textBox.Text = p.Name;
            Value_textBox.Text = p.Value;
            package_textBox.Text = p.Package;
            quantity_counter.Value = p.Quantity;
            voltageRating_textBox.Text = p.voltageRating;
            powerRating_textBox.Text = p.powerRating;
            supplier_textBox.Text = p.Supplier;
            BinX_counter.Value = p.Bin_X;
            BinY_counter.Value = p.Bin_Y;
            BinZ_counter.Value = p.Bin_Z;
            BinW_counter.Value = p.Bin_Width;
            BinR_counter.Value = p.Bin_R;
        }

        private void ModifyPart_Click(object sender, EventArgs e)
        {
            

            try
            {
                ListViewItem lvi = listBox.SelectedItems[0];
                Console.WriteLine(lvi.Text);
                partSettings.Visible = true;
                Part p = partList.getPartByBinID(lvi.Text);
                ModifyPartflag = true;
                partToModify = p;
                loadPartSettings(ref p);
            }
            catch (Exception ex) {
                return;
            }
        
        }
        private void refreshListBox()
        {
            listBox.Items.Clear();
            foreach (Part p in partList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.BinID.ToString();
                lvi.SubItems.Add(p.Name);
                lvi.SubItems.Add(p.Value);
                lvi.SubItems.Add(p.Package);
                lvi.SubItems.Add(p.Quantity.ToString());
                lvi.SubItems.Add(p.voltageRating.ToString());
                lvi.SubItems.Add(p.powerRating.ToString());
                lvi.SubItems.Add(p.Supplier);
                listBox.Items.Add(lvi);
            }
        }
        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Part part;
                if (ModifyPartflag)
                {
                    part = partToModify;
                    
                }
                else
                {
                    part = new Part();
                }
                part.BinID = BinID_textBox.Text;
                part.Name = Name_textBox.Text;
                part.Value = Value_textBox.Text;
                part.Package = package_textBox.Text;
                part.Quantity = (int)quantity_counter.Value;
                part.voltageRating = voltageRating_textBox.Text;
                part.powerRating = powerRating_textBox.Text;
                part.Part_Number = partNumber_textBox.Text;
                part.Supplier = supplier_textBox.Text;
                part.Bin_X = (int)BinX_counter.Value;
                part.Bin_Y = (int)BinY_counter.Value;
                part.Bin_Z = (int)BinZ_counter.Value;
                part.Bin_Width = (int)BinW_counter.Value;
                part.Bin_R = (int)BinR_counter.Value;
                if (!ModifyPartflag)
                {
                    partList.Add(part);
                }
                else
                {
                    ModifyPartflag = false;
                }
                
            }
            catch(Exception ex)
            {

                return;
            }
            
            partSettings.Visible = false;
            printPartsToFile();
            refreshListBox();
        }
        

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancelStore_Click(object sender, EventArgs e)
        {
            storeBin.Visible = false;
        }

        private void partSettings_close_Click(object sender, EventArgs e)
        {
            partSettings.Visible = false;
        }
    }
}
