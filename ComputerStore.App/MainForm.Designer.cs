namespace ComputerStore.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            airTabPage1 = new ReaLTaiizor.Controls.AirTabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            imageList1 = new ImageList(components);
            tabPage3 = new TabPage();
            airTabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // airTabPage1
            // 
            airTabPage1.Alignment = TabAlignment.Left;
            airTabPage1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            airTabPage1.BaseColor = Color.FromArgb(2, 103, 115);
            airTabPage1.Controls.Add(tabPage1);
            airTabPage1.Controls.Add(tabPage2);
            airTabPage1.Controls.Add(tabPage3);
            airTabPage1.ImageList = imageList1;
            airTabPage1.ItemSize = new Size(30, 75);
            airTabPage1.Location = new Point(0, 32);
            airTabPage1.Margin = new Padding(3, 3, 3, 0);
            airTabPage1.Multiline = true;
            airTabPage1.Name = "airTabPage1";
            airTabPage1.NormalTextColor = Color.DimGray;
            airTabPage1.SelectedIndex = 0;
            airTabPage1.SelectedTabBackColor = Color.FromArgb(255, 239, 214);
            airTabPage1.SelectedTextColor = Color.Black;
            airTabPage1.ShowOuterBorders = false;
            airTabPage1.Size = new Size(795, 413);
            airTabPage1.SizeMode = TabSizeMode.Fixed;
            airTabPage1.SquareColor = Color.FromArgb(78, 87, 100);
            airTabPage1.TabCursor = Cursors.Hand;
            airTabPage1.TabIndex = 0;
            airTabPage1.SelectedIndexChanged += airTabPage1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 239, 214);
            tabPage1.ImageIndex = 6;
            tabPage1.Location = new Point(79, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(712, 405);
            tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 239, 214);
            tabPage2.ImageIndex = 4;
            tabPage2.Location = new Point(79, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(712, 405);
            tabPage2.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Aba.png");
            imageList1.Images.SetKeyName(1, "baseline_fingerprint_black_24dp.png");
            imageList1.Images.SetKeyName(2, "ComputerStoreIcon.png");
            imageList1.Images.SetKeyName(3, "form.png");
            imageList1.Images.SetKeyName(4, "Search.png");
            imageList1.Images.SetKeyName(5, "plus.png");
            imageList1.Images.SetKeyName(6, "plus.png");
            imageList1.Images.SetKeyName(7, "imac.png");
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 239, 214);
            tabPage3.ImageIndex = 7;
            tabPage3.Location = new Point(79, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(712, 405);
            tabPage3.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(airTabPage1);
            HeaderColor = Color.FromArgb(1, 46, 64);
            Image = Properties.Resources.ComputerStoreIcon;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Computer Store";
            WindowState = FormWindowState.Maximized;
            airTabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
    }
}
