namespace ASRS_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.deletePart = new System.Windows.Forms.Button();
            this.ModifyPart = new System.Windows.Forms.Button();
            this.AddPart = new System.Windows.Forms.Button();
            this.Store = new System.Windows.Forms.Button();
            this.Retreive = new System.Windows.Forms.Button();
            this.storeBin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelStore = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.storeBin_Btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.resistorSearch = new System.Windows.Forms.Button();
            this.capacitorButton = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListView();
            this.BinID_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Value_textBox = new System.Windows.Forms.TextBox();
            this.package_textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.voltageRating_textBox = new System.Windows.Forms.TextBox();
            this.powerRating_textBox = new System.Windows.Forms.TextBox();
            this.supplier_textBox = new System.Windows.Forms.TextBox();
            this.partNumber_textBox = new System.Windows.Forms.TextBox();
            this.BinX_counter = new System.Windows.Forms.NumericUpDown();
            this.BinY_counter = new System.Windows.Forms.NumericUpDown();
            this.BinZ_counter = new System.Windows.Forms.NumericUpDown();
            this.BinW_counter = new System.Windows.Forms.NumericUpDown();
            this.BinR_counter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity_counter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.storeBin.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinX_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinY_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinZ_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinW_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinR_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_counter)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletePart
            // 
            this.deletePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.deletePart.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePart.Location = new System.Drawing.Point(19, 477);
            this.deletePart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(86, 89);
            this.deletePart.TabIndex = 11;
            this.deletePart.Text = "Delete Part";
            this.deletePart.UseVisualStyleBackColor = false;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // ModifyPart
            // 
            this.ModifyPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.ModifyPart.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPart.Location = new System.Drawing.Point(19, 363);
            this.ModifyPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyPart.Name = "ModifyPart";
            this.ModifyPart.Size = new System.Drawing.Size(86, 89);
            this.ModifyPart.TabIndex = 10;
            this.ModifyPart.Text = "Modify Part";
            this.ModifyPart.UseVisualStyleBackColor = false;
            this.ModifyPart.Click += new System.EventHandler(this.ModifyPart_Click);
            // 
            // AddPart
            // 
            this.AddPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.AddPart.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPart.Location = new System.Drawing.Point(19, 251);
            this.AddPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(86, 89);
            this.AddPart.TabIndex = 9;
            this.AddPart.Text = "Add Part";
            this.AddPart.UseVisualStyleBackColor = false;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // Store
            // 
            this.Store.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.Store.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Store.Location = new System.Drawing.Point(19, 136);
            this.Store.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(86, 89);
            this.Store.TabIndex = 8;
            this.Store.Text = "Store Part";
            this.Store.UseVisualStyleBackColor = false;
            this.Store.Click += new System.EventHandler(this.Store_Click);
            // 
            // Retreive
            // 
            this.Retreive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.Retreive.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retreive.Location = new System.Drawing.Point(19, 27);
            this.Retreive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Retreive.Name = "Retreive";
            this.Retreive.Size = new System.Drawing.Size(86, 89);
            this.Retreive.TabIndex = 7;
            this.Retreive.Text = "Retreive Part";
            this.Retreive.UseVisualStyleBackColor = false;
            this.Retreive.Click += new System.EventHandler(this.Retreive_Click);
            // 
            // storeBin
            // 
            this.storeBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.storeBin.Controls.Add(this.groupBox1);
            this.storeBin.Controls.Add(this.cancelStore);
            this.storeBin.Controls.Add(this.label5);
            this.storeBin.Controls.Add(this.textBox5);
            this.storeBin.Controls.Add(this.storeBin_Btn);
            this.storeBin.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBin.ForeColor = System.Drawing.SystemColors.Control;
            this.storeBin.Location = new System.Drawing.Point(429, 234);
            this.storeBin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storeBin.Name = "storeBin";
            this.storeBin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storeBin.Size = new System.Drawing.Size(210, 149);
            this.storeBin.TabIndex = 13;
            this.storeBin.TabStop = false;
            this.storeBin.Text = "Store Bin";
            this.storeBin.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(0, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(210, 113);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cancelStore
            // 
            this.cancelStore.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelStore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelStore.Location = new System.Drawing.Point(112, 98);
            this.cancelStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelStore.Name = "cancelStore";
            this.cancelStore.Size = new System.Drawing.Size(59, 19);
            this.cancelStore.TabIndex = 3;
            this.cancelStore.Text = "Cancel";
            this.cancelStore.UseVisualStyleBackColor = true;
            this.cancelStore.Click += new System.EventHandler(this.cancelStore_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter the Bin ID to Store";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(64, 62);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(86, 23);
            this.textBox5.TabIndex = 1;
            // 
            // storeBin_Btn
            // 
            this.storeBin_Btn.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBin_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.storeBin_Btn.Location = new System.Drawing.Point(34, 98);
            this.storeBin_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storeBin_Btn.Name = "storeBin_Btn";
            this.storeBin_Btn.Size = new System.Drawing.Size(56, 19);
            this.storeBin_Btn.TabIndex = 0;
            this.storeBin_Btn.Text = "Store Bin";
            this.storeBin_Btn.UseVisualStyleBackColor = true;
            this.storeBin_Btn.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(161, 483);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(814, 133);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Robot Control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ModifyPart);
            this.groupBox4.Controls.Add(this.AddPart);
            this.groupBox4.Controls.Add(this.Store);
            this.groupBox4.Controls.Add(this.Retreive);
            this.groupBox4.Controls.Add(this.deletePart);
            this.groupBox4.Location = new System.Drawing.Point(24, 25);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(123, 592);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.resistorSearch);
            this.groupBox5.Controls.Add(this.capacitorButton);
            this.groupBox5.Location = new System.Drawing.Point(986, 25);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(110, 592);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // resistorSearch
            // 
            this.resistorSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.resistorSearch.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistorSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resistorSearch.Location = new System.Drawing.Point(11, 136);
            this.resistorSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resistorSearch.Name = "resistorSearch";
            this.resistorSearch.Size = new System.Drawing.Size(86, 89);
            this.resistorSearch.TabIndex = 13;
            this.resistorSearch.Text = "Resistor";
            this.resistorSearch.UseVisualStyleBackColor = false;
            this.resistorSearch.Click += new System.EventHandler(this.resistorSearch_Click);
            // 
            // capacitorButton
            // 
            this.capacitorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.capacitorButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacitorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.capacitorButton.Location = new System.Drawing.Point(11, 27);
            this.capacitorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.capacitorButton.Name = "capacitorButton";
            this.capacitorButton.Size = new System.Drawing.Size(86, 89);
            this.capacitorButton.TabIndex = 12;
            this.capacitorButton.Text = "Capacitor";
            this.capacitorButton.UseVisualStyleBackColor = false;
            this.capacitorButton.Click += new System.EventHandler(this.capacitorButton_Click);
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.tabPage1);
            this.MainPage.Controls.Add(this.tabPage2);
            this.MainPage.Location = new System.Drawing.Point(161, 36);
            this.MainPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainPage.Name = "MainPage";
            this.MainPage.SelectedIndex = 0;
            this.MainPage.Size = new System.Drawing.Size(814, 442);
            this.MainPage.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(66)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(806, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Part Search";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(806, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Part Settings";
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(32, 41);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(694, 20);
            this.Search_textBox.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.HideSelection = false;
            this.listBox.Location = new System.Drawing.Point(32, 97);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(722, 255);
            this.listBox.TabIndex = 2;
            this.listBox.UseCompatibleStateImageBehavior = false;
            // 
            // BinID_textBox
            // 
            this.BinID_textBox.Location = new System.Drawing.Point(154, 21);
            this.BinID_textBox.Name = "BinID_textBox";
            this.BinID_textBox.Size = new System.Drawing.Size(186, 20);
            this.BinID_textBox.TabIndex = 0;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(154, 47);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(186, 20);
            this.Name_textBox.TabIndex = 1;
            // 
            // Value_textBox
            // 
            this.Value_textBox.Location = new System.Drawing.Point(154, 73);
            this.Value_textBox.Name = "Value_textBox";
            this.Value_textBox.Size = new System.Drawing.Size(186, 20);
            this.Value_textBox.TabIndex = 2;
            // 
            // package_textBox
            // 
            this.package_textBox.Location = new System.Drawing.Point(154, 99);
            this.package_textBox.Name = "package_textBox";
            this.package_textBox.Size = new System.Drawing.Size(186, 20);
            this.package_textBox.TabIndex = 3;
            this.package_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveSettingsBtn);
            this.panel1.Controls.Add(this.storeBin);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.quantity_counter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BinR_counter);
            this.panel1.Controls.Add(this.BinW_counter);
            this.panel1.Controls.Add(this.BinZ_counter);
            this.panel1.Controls.Add(this.BinY_counter);
            this.panel1.Controls.Add(this.BinX_counter);
            this.panel1.Controls.Add(this.partNumber_textBox);
            this.panel1.Controls.Add(this.supplier_textBox);
            this.panel1.Controls.Add(this.powerRating_textBox);
            this.panel1.Controls.Add(this.voltageRating_textBox);
            this.panel1.Controls.Add(this.BinID_textBox);
            this.panel1.Controls.Add(this.package_textBox);
            this.panel1.Controls.Add(this.Name_textBox);
            this.panel1.Controls.Add(this.Value_textBox);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 406);
            this.panel1.TabIndex = 4;
            // 
            // voltageRating_textBox
            // 
            this.voltageRating_textBox.Location = new System.Drawing.Point(154, 125);
            this.voltageRating_textBox.Name = "voltageRating_textBox";
            this.voltageRating_textBox.Size = new System.Drawing.Size(186, 20);
            this.voltageRating_textBox.TabIndex = 4;
            // 
            // powerRating_textBox
            // 
            this.powerRating_textBox.Location = new System.Drawing.Point(154, 151);
            this.powerRating_textBox.Name = "powerRating_textBox";
            this.powerRating_textBox.Size = new System.Drawing.Size(186, 20);
            this.powerRating_textBox.TabIndex = 5;
            // 
            // supplier_textBox
            // 
            this.supplier_textBox.Location = new System.Drawing.Point(154, 177);
            this.supplier_textBox.Name = "supplier_textBox";
            this.supplier_textBox.Size = new System.Drawing.Size(186, 20);
            this.supplier_textBox.TabIndex = 6;
            // 
            // partNumber_textBox
            // 
            this.partNumber_textBox.Location = new System.Drawing.Point(154, 203);
            this.partNumber_textBox.Name = "partNumber_textBox";
            this.partNumber_textBox.Size = new System.Drawing.Size(186, 20);
            this.partNumber_textBox.TabIndex = 7;
            // 
            // BinX_counter
            // 
            this.BinX_counter.Location = new System.Drawing.Point(485, 47);
            this.BinX_counter.Name = "BinX_counter";
            this.BinX_counter.Size = new System.Drawing.Size(113, 20);
            this.BinX_counter.TabIndex = 9;
            // 
            // BinY_counter
            // 
            this.BinY_counter.Location = new System.Drawing.Point(485, 71);
            this.BinY_counter.Name = "BinY_counter";
            this.BinY_counter.Size = new System.Drawing.Size(113, 20);
            this.BinY_counter.TabIndex = 10;
            // 
            // BinZ_counter
            // 
            this.BinZ_counter.Location = new System.Drawing.Point(485, 97);
            this.BinZ_counter.Name = "BinZ_counter";
            this.BinZ_counter.Size = new System.Drawing.Size(113, 20);
            this.BinZ_counter.TabIndex = 11;
            // 
            // BinW_counter
            // 
            this.BinW_counter.Location = new System.Drawing.Point(485, 123);
            this.BinW_counter.Name = "BinW_counter";
            this.BinW_counter.Size = new System.Drawing.Size(113, 20);
            this.BinW_counter.TabIndex = 12;
            // 
            // BinR_counter
            // 
            this.BinR_counter.Location = new System.Drawing.Point(485, 149);
            this.BinR_counter.Name = "BinR_counter";
            this.BinR_counter.Size = new System.Drawing.Size(113, 20);
            this.BinR_counter.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bin";
            // 
            // quantity_counter
            // 
            this.quantity_counter.Location = new System.Drawing.Point(485, 21);
            this.quantity_counter.Name = "quantity_counter";
            this.quantity_counter.Size = new System.Drawing.Size(113, 20);
            this.quantity_counter.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(54, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(54, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Package";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(3, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Voltage Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(20, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Power Rating";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(20, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Supplier";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(20, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Part Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(391, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(391, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Bin X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(391, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Bin Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(391, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Bin Z";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(381, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "Bin Width";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(381, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "Bin Rot";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox);
            this.panel2.Controls.Add(this.Search_textBox);
            this.panel2.Location = new System.Drawing.Point(14, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 398);
            this.panel2.TabIndex = 3;
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Location = new System.Drawing.Point(90, 313);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(139, 52);
            this.saveSettingsBtn.TabIndex = 29;
            this.saveSettingsBtn.Text = "Save";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1106, 641);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASRS Controller";
            this.storeBin.ResumeLayout(false);
            this.storeBin.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinX_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinY_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinZ_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinW_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinR_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_counter)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button ModifyPart;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button Store;
        private System.Windows.Forms.Button Retreive;
        private System.Windows.Forms.GroupBox storeBin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button storeBin_Btn;
        private System.Windows.Forms.Button cancelStore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button capacitorButton;
        private System.Windows.Forms.Button resistorSearch;
        private System.Windows.Forms.TabControl MainPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.ListView listBox;
        private System.Windows.Forms.TextBox BinID_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Value_textBox;
        private System.Windows.Forms.TextBox package_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox partNumber_textBox;
        private System.Windows.Forms.TextBox supplier_textBox;
        private System.Windows.Forms.TextBox powerRating_textBox;
        private System.Windows.Forms.TextBox voltageRating_textBox;
        private System.Windows.Forms.NumericUpDown BinR_counter;
        private System.Windows.Forms.NumericUpDown BinW_counter;
        private System.Windows.Forms.NumericUpDown BinZ_counter;
        private System.Windows.Forms.NumericUpDown BinY_counter;
        private System.Windows.Forms.NumericUpDown BinX_counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantity_counter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveSettingsBtn;
    }
}

