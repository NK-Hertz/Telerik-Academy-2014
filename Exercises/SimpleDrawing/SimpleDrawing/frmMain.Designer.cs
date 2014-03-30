namespace SimpleDrawing
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnCoefficient = new System.Windows.Forms.ToolStripButton();
            this.btnStock = new System.Windows.Forms.ToolStripButton();
            this.btnRefference = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDashboard
            // 
            this.pbDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDashboard.Location = new System.Drawing.Point(0, 25);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(658, 419);
            this.pbDashboard.TabIndex = 0;
            this.pbDashboard.TabStop = false;
            this.pbDashboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDashboard_MouseMove);
            this.pbDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDashboard_MouseDown);
            this.pbDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDashboard_Paint);
            this.pbDashboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDashboard_MouseUp);
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelect,
            this.btnCoefficient,
            this.btnStock,
            this.btnRefference});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(658, 25);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "toolStrip1";
            this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMenu_ItemClicked);
            // 
            // btnSelect
            // 
            this.btnSelect.Checked = true;
            this.btnSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(40, 22);
            this.btnSelect.Text = "Select";
            // 
            // btnCoefficient
            // 
            this.btnCoefficient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCoefficient.Image = ((System.Drawing.Image)(resources.GetObject("btnCoefficient.Image")));
            this.btnCoefficient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCoefficient.Name = "btnCoefficient";
            this.btnCoefficient.Size = new System.Drawing.Size(63, 22);
            this.btnCoefficient.Text = "Coefficient";
            // 
            // btnStock
            // 
            this.btnStock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(37, 22);
            this.btnStock.Text = "Stock";
            // 
            // btnRefference
            // 
            this.btnRefference.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefference.Image = ((System.Drawing.Image)(resources.GetObject("btnRefference.Image")));
            this.btnRefference.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefference.Name = "btnRefference";
            this.btnRefference.Size = new System.Drawing.Size(65, 22);
            this.btnRefference.Text = "Refference";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 444);
            this.Controls.Add(this.pbDashboard);
            this.Controls.Add(this.tsMenu);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnStock;
        private System.Windows.Forms.ToolStripButton btnCoefficient;
        private System.Windows.Forms.ToolStripButton btnRefference;
    }
}

