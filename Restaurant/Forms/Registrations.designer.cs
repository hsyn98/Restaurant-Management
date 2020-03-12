namespace Restaurant.Forms
{
    partial class Registrations
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
            this.TXT_DATE = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.License = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TSerial = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.TextBox();
            this.ProductKey = new System.Windows.Forms.TextBox();
            this.Branches = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_DATE
            // 
            this.TXT_DATE.Location = new System.Drawing.Point(329, 251);
            this.TXT_DATE.Name = "TXT_DATE";
            this.TXT_DATE.Size = new System.Drawing.Size(136, 22);
            this.TXT_DATE.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 30);
            this.button2.TabIndex = 42;
            this.button2.Text = "Return Licence date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "License";
            // 
            // License
            // 
            this.License.Location = new System.Drawing.Point(103, 139);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(362, 22);
            this.License.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Seial";
            // 
            // TSerial
            // 
            this.TSerial.Location = new System.Drawing.Point(103, 51);
            this.TSerial.Name = "TSerial";
            this.TSerial.Size = new System.Drawing.Size(362, 22);
            this.TSerial.TabIndex = 38;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(76, 26);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(21, 17);
            this.Id.TabIndex = 37;
            this.Id.Text = "ID";
            // 
            // PID
            // 
            this.PID.Location = new System.Drawing.Point(103, 23);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(362, 22);
            this.PID.TabIndex = 36;
            // 
            // ProductKey
            // 
            this.ProductKey.Location = new System.Drawing.Point(103, 110);
            this.ProductKey.Margin = new System.Windows.Forms.Padding(4);
            this.ProductKey.Name = "ProductKey";
            this.ProductKey.Size = new System.Drawing.Size(362, 22);
            this.ProductKey.TabIndex = 35;
            // 
            // Branches
            // 
            this.Branches.Location = new System.Drawing.Point(103, 80);
            this.Branches.Margin = new System.Windows.Forms.Padding(4);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(362, 22);
            this.Branches.TabIndex = 34;
            this.Branches.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Product -ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Şöbə";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Qeydiyyat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 311);
            this.Controls.Add(this.TXT_DATE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.License);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TSerial);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.ProductKey);
            this.Controls.Add(this.Branches);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_DATE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox License;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TSerial;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox PID;
        private System.Windows.Forms.TextBox ProductKey;
        private System.Windows.Forms.TextBox Branches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}