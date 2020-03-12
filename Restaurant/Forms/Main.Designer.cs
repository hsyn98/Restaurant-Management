namespace Restaurant.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblMachineName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnUsers = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTables = new System.Windows.Forms.ToolStripDropDownButton();
            this.qruplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAnbar = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMachineName,
            this.lblUserName});
            this.statusBar.Location = new System.Drawing.Point(0, 831);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(1582, 24);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = false;
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(300, 19);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = false;
            this.lblUserName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(300, 19);
            // 
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolBar.Font = new System.Drawing.Font("Gadugi", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnUsers,
            this.pasteToolStripButton,
            this.tsbtnTables,
            this.toolStripButton1,
            this.tsbtnMenu,
            this.toolStripButton2,
            this.tsbtnAnbar,
            this.copyToolStripButton,
            this.helpToolStripButton});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolBar.Size = new System.Drawing.Size(1582, 140);
            this.toolBar.TabIndex = 1;
            // 
            // tsbtnUsers
            // 
            this.tsbtnUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUsers.Image")));
            this.tsbtnUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUsers.Name = "tsbtnUsers";
            this.tsbtnUsers.Size = new System.Drawing.Size(132, 137);
            this.tsbtnUsers.Tag = "1";
            this.tsbtnUsers.Click += new System.EventHandler(this.tsbtnUsers_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.AutoSize = false;
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Enabled = false;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(50, 50);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // tsbtnTables
            // 
            this.tsbtnTables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qruplarToolStripMenuItem,
            this.masalarToolStripMenuItem});
            this.tsbtnTables.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTables.Image")));
            this.tsbtnTables.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnTables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTables.Name = "tsbtnTables";
            this.tsbtnTables.Size = new System.Drawing.Size(134, 137);
            this.tsbtnTables.Tag = "2";
            // 
            // qruplarToolStripMenuItem
            // 
            this.qruplarToolStripMenuItem.Name = "qruplarToolStripMenuItem";
            this.qruplarToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.qruplarToolStripMenuItem.Text = "Qruplar";
            this.qruplarToolStripMenuItem.Click += new System.EventHandler(this.qruplarToolStripMenuItem_Click);
            // 
            // masalarToolStripMenuItem
            // 
            this.masalarToolStripMenuItem.Name = "masalarToolStripMenuItem";
            this.masalarToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.masalarToolStripMenuItem.Text = "Masalar";
            this.masalarToolStripMenuItem.Click += new System.EventHandler(this.masalarToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(50, 50);
            this.toolStripButton1.Text = "&Paste";
            // 
            // tsbtnMenu
            // 
            this.tsbtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMenu.Image")));
            this.tsbtnMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMenu.Name = "tsbtnMenu";
            this.tsbtnMenu.Size = new System.Drawing.Size(132, 137);
            this.tsbtnMenu.Tag = "3";
            this.tsbtnMenu.Click += new System.EventHandler(this.tsbtnMenu_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 50);
            this.toolStripButton2.Text = "&Paste";
            // 
            // tsbtnAnbar
            // 
            this.tsbtnAnbar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAnbar.Image")));
            this.tsbtnAnbar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAnbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAnbar.Name = "tsbtnAnbar";
            this.tsbtnAnbar.Size = new System.Drawing.Size(124, 137);
            this.tsbtnAnbar.Tag = "4";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.AutoSize = false;
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 57);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 137);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // flowLayoutTable
            // 
            this.flowLayoutTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutTable.BackColor = System.Drawing.Color.SeaShell;
            this.flowLayoutTable.Font = new System.Drawing.Font("Gadugi", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutTable.Location = new System.Drawing.Point(12, 143);
            this.flowLayoutTable.Name = "flowLayoutTable";
            this.flowLayoutTable.Size = new System.Drawing.Size(1558, 685);
            this.flowLayoutTable.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1501, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 70);
            this.btnClose.TabIndex = 12;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 855);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flowLayoutTable);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Əsas Səhifə";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton tsbtnMenu;
        private System.Windows.Forms.ToolStripButton tsbtnAnbar;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton tsbtnUsers;
        private System.Windows.Forms.ToolStripStatusLabel lblMachineName;
        private System.Windows.Forms.ToolStripStatusLabel lblUserName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTable;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnTables;
        private System.Windows.Forms.ToolStripMenuItem qruplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btnClose;
    }
}