namespace Restaurant.Forms
{
    partial class NewTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTable));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbxStatus = new System.Windows.Forms.CheckBox();
            this.cmbxTableNumber = new System.Windows.Forms.ComboBox();
            this.cmbxAdditiontype = new System.Windows.Forms.ComboBox();
            this.cmbxTableGroup = new System.Windows.Forms.ComboBox();
            this.txtAdditionAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chbxStatus);
            this.groupBox1.Controls.Add(this.cmbxTableNumber);
            this.groupBox1.Controls.Add(this.cmbxAdditiontype);
            this.groupBox1.Controls.Add(this.cmbxTableGroup);
            this.groupBox1.Controls.Add(this.txtAdditionAmount);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni masa əlavə edilməsi";
            // 
            // chbxStatus
            // 
            this.chbxStatus.AutoSize = true;
            this.chbxStatus.Font = new System.Drawing.Font("Gadugi", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxStatus.Location = new System.Drawing.Point(736, 72);
            this.chbxStatus.Name = "chbxStatus";
            this.chbxStatus.Size = new System.Drawing.Size(80, 26);
            this.chbxStatus.TabIndex = 7;
            this.chbxStatus.Text = "Status";
            this.chbxStatus.UseVisualStyleBackColor = true;
            // 
            // cmbxTableNumber
            // 
            this.cmbxTableNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTableNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxTableNumber.Font = new System.Drawing.Font("Gadugi", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTableNumber.FormattingEnabled = true;
            this.cmbxTableNumber.Location = new System.Drawing.Point(6, 165);
            this.cmbxTableNumber.MaxDropDownItems = 5;
            this.cmbxTableNumber.Name = "cmbxTableNumber";
            this.cmbxTableNumber.Size = new System.Drawing.Size(79, 34);
            this.cmbxTableNumber.TabIndex = 3;
            this.cmbxTableNumber.SelectedIndexChanged += new System.EventHandler(this.cmbxTableNumber_SelectedIndexChanged);
            // 
            // cmbxAdditiontype
            // 
            this.cmbxAdditiontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAdditiontype.Font = new System.Drawing.Font("Gadugi", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAdditiontype.FormattingEnabled = true;
            this.cmbxAdditiontype.Location = new System.Drawing.Point(381, 165);
            this.cmbxAdditiontype.Name = "cmbxAdditiontype";
            this.cmbxAdditiontype.Size = new System.Drawing.Size(162, 34);
            this.cmbxAdditiontype.TabIndex = 5;
            this.cmbxAdditiontype.SelectedIndexChanged += new System.EventHandler(this.cmbxAdditiontype_SelectedIndexChanged);
            // 
            // cmbxTableGroup
            // 
            this.cmbxTableGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTableGroup.Font = new System.Drawing.Font("Gadugi", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTableGroup.FormattingEnabled = true;
            this.cmbxTableGroup.Location = new System.Drawing.Point(381, 67);
            this.cmbxTableGroup.Name = "cmbxTableGroup";
            this.cmbxTableGroup.Size = new System.Drawing.Size(250, 34);
            this.cmbxTableGroup.TabIndex = 4;
            // 
            // txtAdditionAmount
            // 
            this.txtAdditionAmount.Font = new System.Drawing.Font("Gadugi", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionAmount.Location = new System.Drawing.Point(549, 162);
            this.txtAdditionAmount.Name = "txtAdditionAmount";
            this.txtAdditionAmount.Size = new System.Drawing.Size(50, 37);
            this.txtAdditionAmount.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(6, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 37);
            this.txtName.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Gadugi", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(605, 172);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(47, 22);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "AZN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Masaya Əlavə:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Masanın qrupu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Masanın nömrəsi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masanın adı:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Location = new System.Drawing.Point(643, 336);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 50);
            this.btnSave.TabIndex = 9;
            this.btnSave.Tag = "";
            this.btnSave.Text = "Yadda Saxla";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(856, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 70);
            this.btnClose.TabIndex = 11;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(934, 484);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTable";
            this.Load += new System.EventHandler(this.NewTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbxStatus;
        private System.Windows.Forms.ComboBox cmbxTableNumber;
        private System.Windows.Forms.ComboBox cmbxTableGroup;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxAdditiontype;
        private System.Windows.Forms.TextBox txtAdditionAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}