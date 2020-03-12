namespace Restaurant.Forms
{
    partial class TableGroup
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
            this.dgvTableGroup = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDeactive = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnActive = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.dgvTableGroup.Location = new System.Drawing.Point(0, 51);
            this.dgvTableGroup.MultiSelect = false;
            this.dgvTableGroup.Name = "dgvTableGroup";
            this.dgvTableGroup.RowTemplate.Height = 24;
            this.dgvTableGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableGroup.Size = new System.Drawing.Size(804, 444);
            this.dgvTableGroup.TabIndex = 10;
            this.dgvTableGroup.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvtablegroup_CellFormatting);
            this.dgvTableGroup.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvgtablegroup_RowPostPaint);
            this.dgvTableGroup.SelectionChanged += new System.EventHandler(this.dvgtablegroup_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.toolStripSeparator2,
            this.tsbtnEdit,
            this.toolStripSeparator3,
            this.tsbtnDeactive,
            this.toolStripSeparator,
            this.tsbtnActive,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 48);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(40, 45);
            this.tsbtnNew.Text = "&Yeni";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(67, 45);
            this.tsbtnEdit.Text = "&Redaktə";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbtnDeactive
            // 
            this.tsbtnDeactive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDeactive.Name = "tsbtnDeactive";
            this.tsbtnDeactive.Size = new System.Drawing.Size(77, 45);
            this.tsbtnDeactive.Text = "&Deaktiv et";
            this.tsbtnDeactive.Click += new System.EventHandler(this.tsbtnDeactive_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbtnActive
            // 
            this.tsbtnActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnActive.Name = "tsbtnActive";
            this.tsbtnActive.Size = new System.Drawing.Size(59, 45);
            this.tsbtnActive.Text = "&Aktiv et";
            this.tsbtnActive.Click += new System.EventHandler(this.tsbtnActive_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // TableGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(804, 507);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvTableGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableGroup";
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnDeactive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbtnActive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}