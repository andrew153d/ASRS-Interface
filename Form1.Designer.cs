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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ModifyPart = new System.Windows.Forms.Button();
            this.AddPart = new System.Windows.Forms.Button();
            this.Store = new System.Windows.Forms.Button();
            this.Retreive = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListView();
            this.partSettings = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.storeBin = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.storeBin_Btn = new System.Windows.Forms.Button();
            this.partSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.storeBin.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1070, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1327, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 109);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1327, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 109);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1327, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 109);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1327, 513);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 109);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1327, 667);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 109);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(43, 667);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 109);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ModifyPart
            // 
            this.ModifyPart.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPart.Location = new System.Drawing.Point(43, 513);
            this.ModifyPart.Name = "ModifyPart";
            this.ModifyPart.Size = new System.Drawing.Size(114, 109);
            this.ModifyPart.TabIndex = 10;
            this.ModifyPart.Text = "Modify Part";
            this.ModifyPart.UseVisualStyleBackColor = true;
            this.ModifyPart.Click += new System.EventHandler(this.ModifyPart_Click);
            // 
            // AddPart
            // 
            this.AddPart.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPart.Location = new System.Drawing.Point(43, 365);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(114, 109);
            this.AddPart.TabIndex = 9;
            this.AddPart.Text = "Add Part";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // Store
            // 
            this.Store.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Store.Location = new System.Drawing.Point(43, 208);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(114, 109);
            this.Store.TabIndex = 8;
            this.Store.Text = "Store Part";
            this.Store.UseVisualStyleBackColor = true;
            this.Store.Click += new System.EventHandler(this.Store_Click);
            // 
            // Retreive
            // 
            this.Retreive.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retreive.Location = new System.Drawing.Point(43, 56);
            this.Retreive.Name = "Retreive";
            this.Retreive.Size = new System.Drawing.Size(114, 109);
            this.Retreive.TabIndex = 7;
            this.Retreive.Text = "Retreive Part";
            this.Retreive.UseVisualStyleBackColor = true;
            this.Retreive.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(43)))), ((int)(((byte)(25)))));
            this.listBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.listBox.HideSelection = false;
            this.listBox.Location = new System.Drawing.Point(209, 149);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1070, 420);
            this.listBox.TabIndex = 12;
            this.listBox.UseCompatibleStateImageBehavior = false;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // partSettings
            // 
            this.partSettings.BackColor = System.Drawing.SystemColors.Desktop;
            this.partSettings.Controls.Add(this.numericUpDown1);
            this.partSettings.Controls.Add(this.saveSettingsBtn);
            this.partSettings.Controls.Add(this.label4);
            this.partSettings.Controls.Add(this.label3);
            this.partSettings.Controls.Add(this.label2);
            this.partSettings.Controls.Add(this.label1);
            this.partSettings.Controls.Add(this.textBox4);
            this.partSettings.Controls.Add(this.textBox3);
            this.partSettings.Controls.Add(this.textBox2);
            this.partSettings.Location = new System.Drawing.Point(462, 84);
            this.partSettings.Name = "partSettings";
            this.partSettings.Size = new System.Drawing.Size(511, 615);
            this.partSettings.TabIndex = 0;
            this.partSettings.TabStop = false;
            this.partSettings.Text = "Part Settings";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(161, 240);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(174, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Location = new System.Drawing.Point(161, 424);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(196, 61);
            this.saveSettingsBtn.TabIndex = 8;
            this.saveSettingsBtn.Text = "Save Settings";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(270, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 22);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 22);
            this.textBox2.TabIndex = 0;
            // 
            // storeBin
            // 
            this.storeBin.Controls.Add(this.label5);
            this.storeBin.Controls.Add(this.textBox5);
            this.storeBin.Controls.Add(this.storeBin_Btn);
            this.storeBin.Location = new System.Drawing.Point(163, 175);
            this.storeBin.Name = "storeBin";
            this.storeBin.Size = new System.Drawing.Size(280, 183);
            this.storeBin.TabIndex = 13;
            this.storeBin.TabStop = false;
            this.storeBin.Text = "Store Bin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter the Bin ID to Store";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 76);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 1;
            // 
            // storeBin_Btn
            // 
            this.storeBin_Btn.Location = new System.Drawing.Point(100, 119);
            this.storeBin_Btn.Name = "storeBin_Btn";
            this.storeBin_Btn.Size = new System.Drawing.Size(75, 23);
            this.storeBin_Btn.TabIndex = 0;
            this.storeBin_Btn.Text = "Store Bin";
            this.storeBin_Btn.UseVisualStyleBackColor = true;
            this.storeBin_Btn.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1476, 810);
            this.Controls.Add(this.storeBin);
            this.Controls.Add(this.partSettings);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ModifyPart);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.Store);
            this.Controls.Add(this.Retreive);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.partSettings.ResumeLayout(false);
            this.partSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.storeBin.ResumeLayout(false);
            this.storeBin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ModifyPart;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button Store;
        private System.Windows.Forms.Button Retreive;
        private System.Windows.Forms.ListView listBox;
        private System.Windows.Forms.GroupBox partSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox storeBin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button storeBin_Btn;
    }
}

