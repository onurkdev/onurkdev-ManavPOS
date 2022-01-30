namespace onurkdev_ManavPOS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.ımageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(901, 652);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Controls.Add(this.materialListView1);
            this.tabPage1.ImageKey = "icons8-pos-terminal-60.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Satış Yap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(3, 3);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(501, 603);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Tile;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "icons8-inventory-64.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stoğum";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "icons8-paid-bill-50.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(893, 609);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Satışlar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "icons8-chart-50.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raporlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-chart-50.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-inventory-64.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-pos-terminal-60.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-paid-bill-50.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "icons8-vegetarian-mark-100.png");
            this.ımageList2.Images.SetKeyName(1, "icons8-corn-50.png");
            this.ımageList2.Images.SetKeyName(2, "icons8-collard-greens-50.png");
            this.ımageList2.Images.SetKeyName(3, "icons8-citrus-50.png");
            this.ımageList2.Images.SetKeyName(4, "icons8-chili-pepper-50.png");
            this.ımageList2.Images.SetKeyName(5, "icons8-carrot-50.png");
            this.ımageList2.Images.SetKeyName(6, "icons8-cabbage-50.png");
            this.ımageList2.Images.SetKeyName(7, "icons8-broccoli-50.png");
            this.ımageList2.Images.SetKeyName(8, "icons8-beet-50.png");
            this.ımageList2.Images.SetKeyName(9, "icons8-banana-50.png");
            this.ımageList2.Images.SetKeyName(10, "icons8-avocado-50.png");
            this.ımageList2.Images.SetKeyName(11, "icons8-apple-50.png");
            this.ımageList2.Images.SetKeyName(12, "icons8-tomato-50.png");
            this.ımageList2.Images.SetKeyName(13, "icons8-spinach-50.png");
            this.ımageList2.Images.SetKeyName(14, "icons8-pumpkin-50.png");
            this.ımageList2.Images.SetKeyName(15, "icons8-potato-50.png");
            this.ımageList2.Images.SetKeyName(16, "icons8-pineapple-50.png");
            this.ımageList2.Images.SetKeyName(17, "icons8-peas-50.png");
            this.ımageList2.Images.SetKeyName(18, "icons8-pear-50.png");
            this.ımageList2.Images.SetKeyName(19, "icons8-peach-50.png");
            this.ımageList2.Images.SetKeyName(20, "icons8-orange-50.png");
            this.ımageList2.Images.SetKeyName(21, "icons8-onion-50.png");
            this.ımageList2.Images.SetKeyName(22, "icons8-cutted-melon-50.png");
            this.ımageList2.Images.SetKeyName(23, "icons8-cutted-watermelon-50.png");
            this.ımageList2.Images.SetKeyName(24, "icons8-lettuce-50.png");
            this.ımageList2.Images.SetKeyName(25, "icons8-kiwi-50.png");
            this.ımageList2.Images.SetKeyName(26, "icons8-eggplant-50.png");
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(535, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(329, 162);
            this.materialCard1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(907, 719);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "ManavPOS";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList ımageList2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}

