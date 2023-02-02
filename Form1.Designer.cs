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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.button6.Location = new System.Drawing.Point(43, 667);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 109);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ModifyPart
            // 
            this.ModifyPart.Location = new System.Drawing.Point(43, 513);
            this.ModifyPart.Name = "ModifyPart";
            this.ModifyPart.Size = new System.Drawing.Size(114, 109);
            this.ModifyPart.TabIndex = 10;
            this.ModifyPart.Text = "Modify Part";
            this.ModifyPart.UseVisualStyleBackColor = true;
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(43, 365);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(114, 109);
            this.AddPart.TabIndex = 9;
            this.AddPart.Text = "Add Part";
            this.AddPart.UseVisualStyleBackColor = true;
            // 
            // Store
            // 
            this.Store.Location = new System.Drawing.Point(43, 208);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(114, 109);
            this.Store.TabIndex = 8;
            this.Store.Text = "Store Part";
            this.Store.UseVisualStyleBackColor = true;
            // 
            // Retreive
            // 
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(244, 636);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(152, 121);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1492, 821);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
    }
}

