namespace Restaurant.Forms
{
    partial class TableGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableGroups));
            this.dgvTableGroup = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDeactive = new System.Windows.Forms.ToolStripButton();
            this.tsbtnActive = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableGroup)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTableGroup
            // 
            this.dgvTableGroup.AllowUserToAddRows = false;
            this.dgvTableGroup.AllowUserToDeleteRows = false;
            this.dgvTableGroup.AllowUserToResizeColumns = false;
            this.dgvTableGroup.AllowUserToResizeRows = false;
            this.dgvTableGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableGroup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTableGroup.Location = new System.Drawing.Point(11, 143);
            this.dgvTableGroup.MultiSelect = false;
            this.dgvTableGroup.Name = "dgvTableGroup";
            this.dgvTableGroup.RowTemplate.Height = 24;
            this.dgvTableGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableGroup.Size = new System.Drawing.Size(1177, 545);
            this.dgvTableGroup.TabIndex = 10;
            this.dgvTableGroup.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvtablegroup_CellFormatting);
            this.dgvTableGroup.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvgtablegroup_RowPostPaint);
            this.dgvTableGroup.SelectionChanged += new System.EventHandler(this.dvgtablegroup_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Font = new System.Drawing.Font("Gadugi", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.toolStripLabel1,
            this.tsbtnEdit,
            this.toolStripLabel2,
            this.tsbtnActive,
            this.toolStripLabel3,
            this.tsbtnDeactive,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 140);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(132, 137);
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(124, 130);
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // tsbtnDeactive
            // 
            this.tsbtnDeactive.Font = new System.Drawing.Font("Gadugi", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnDeactive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDeactive.Name = "tsbtnDeactive";
            this.tsbtnDeactive.Size = new System.Drawing.Size(118, 130);
            this.tsbtnDeactive.Text = "Deaktiv et";
            this.tsbtnDeactive.Click += new System.EventHandler(this.tsbtnDeactive_Click);
            // 
            // tsbtnActive
            // 
            this.tsbtnActive.AutoSize = false;
            this.tsbtnActive.Font = new System.Drawing.Font("Gadugi", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnActive.Name = "tsbtnActive";
            this.tsbtnActive.Size = new System.Drawing.Size(130, 137);
            this.tsbtnActive.Text = "Aktiv et";
            this.tsbtnActive.Click += new System.EventHandler(this.tsbtnActive_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 50);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Enabled = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 50);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Enabled = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(50, 50);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Enabled = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(50, 50);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1119, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 70);
            this.btnClose.TabIndex = 68;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TableGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvTableGroup);
            this.Font = new System.Drawing.Font("Gadugi", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Qrupları";
            this.Load += new System.EventHandler(this.TableGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableGroup)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTableGroup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDeactive;
        private System.Windows.Forms.ToolStripButton tsbtnActive;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Button btnClose;
    }
}