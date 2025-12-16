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
            btnNewTicket = new ReaLTaiizor.Controls.Button();
            btnServiceRegister = new ReaLTaiizor.Controls.Button();
            btnSupplierRegister = new ReaLTaiizor.Controls.Button();
            btnClientRegister = new ReaLTaiizor.Controls.Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            imageList1 = new ImageList(components);
            lvTickets = new ReaLTaiizor.Controls.PoisonListView();
            airTabPage1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            airTabPage1.ItemSize = new Size(50, 75);
            airTabPage1.Location = new Point(0, 32);
            airTabPage1.Margin = new Padding(3, 3, 3, 0);
            airTabPage1.Multiline = true;
            airTabPage1.Name = "airTabPage1";
            airTabPage1.NormalTextColor = Color.DimGray;
            airTabPage1.SelectedIndex = 0;
            airTabPage1.SelectedTabBackColor = Color.FromArgb(255, 239, 214);
            airTabPage1.SelectedTextColor = Color.Black;
            airTabPage1.ShowOuterBorders = false;
            airTabPage1.Size = new Size(1347, 781);
            airTabPage1.SizeMode = TabSizeMode.Fixed;
            airTabPage1.SquareColor = Color.FromArgb(78, 87, 100);
            airTabPage1.TabCursor = Cursors.Hand;
            airTabPage1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 239, 214);
            tabPage1.Controls.Add(lvTickets);
            tabPage1.Controls.Add(btnNewTicket);
            tabPage1.Controls.Add(btnServiceRegister);
            tabPage1.Controls.Add(btnSupplierRegister);
            tabPage1.Controls.Add(btnClientRegister);
            tabPage1.ImageIndex = 6;
            tabPage1.Location = new Point(79, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1264, 773);
            tabPage1.TabIndex = 0;
            // 
            // btnNewTicket
            // 
            btnNewTicket.BackColor = Color.Transparent;
            btnNewTicket.BorderColor = Color.FromArgb(32, 34, 37);
            btnNewTicket.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnNewTicket.EnteredColor = Color.FromArgb(60, 166, 166);
            btnNewTicket.Font = new Font("Microsoft Sans Serif", 12F);
            btnNewTicket.Image = null;
            btnNewTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewTicket.InactiveColor = Color.FromArgb(60, 166, 166);
            btnNewTicket.Location = new Point(486, 310);
            btnNewTicket.Name = "btnNewTicket";
            btnNewTicket.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnNewTicket.PressedColor = Color.FromArgb(165, 37, 37);
            btnNewTicket.Size = new Size(132, 57);
            btnNewTicket.TabIndex = 4;
            btnNewTicket.Text = "New Ticket";
            btnNewTicket.TextAlignment = StringAlignment.Center;
            btnNewTicket.Click += btnNewTicket_Click;
            // 
            // btnServiceRegister
            // 
            btnServiceRegister.BackColor = Color.Transparent;
            btnServiceRegister.BorderColor = Color.FromArgb(32, 34, 37);
            btnServiceRegister.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnServiceRegister.EnteredColor = Color.FromArgb(60, 166, 166);
            btnServiceRegister.Font = new Font("Microsoft Sans Serif", 12F);
            btnServiceRegister.Image = null;
            btnServiceRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnServiceRegister.InactiveColor = Color.FromArgb(60, 166, 166);
            btnServiceRegister.Location = new Point(817, 545);
            btnServiceRegister.Name = "btnServiceRegister";
            btnServiceRegister.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnServiceRegister.PressedColor = Color.FromArgb(165, 37, 37);
            btnServiceRegister.Size = new Size(132, 57);
            btnServiceRegister.TabIndex = 3;
            btnServiceRegister.Text = "New Service";
            btnServiceRegister.TextAlignment = StringAlignment.Center;
            btnServiceRegister.Click += btnServiceRegister_Click;
            // 
            // btnSupplierRegister
            // 
            btnSupplierRegister.BackColor = Color.Transparent;
            btnSupplierRegister.BorderColor = Color.FromArgb(32, 34, 37);
            btnSupplierRegister.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSupplierRegister.EnteredColor = Color.FromArgb(60, 166, 166);
            btnSupplierRegister.Font = new Font("Microsoft Sans Serif", 12F);
            btnSupplierRegister.Image = null;
            btnSupplierRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupplierRegister.InactiveColor = Color.FromArgb(60, 166, 166);
            btnSupplierRegister.Location = new Point(652, 545);
            btnSupplierRegister.Name = "btnSupplierRegister";
            btnSupplierRegister.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSupplierRegister.PressedColor = Color.FromArgb(165, 37, 37);
            btnSupplierRegister.Size = new Size(132, 57);
            btnSupplierRegister.TabIndex = 1;
            btnSupplierRegister.Text = "New Supplier";
            btnSupplierRegister.TextAlignment = StringAlignment.Center;
            btnSupplierRegister.Click += btnSupplierRegister_Click;
            // 
            // btnClientRegister
            // 
            btnClientRegister.BackColor = Color.Transparent;
            btnClientRegister.BorderColor = Color.FromArgb(32, 34, 37);
            btnClientRegister.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnClientRegister.EnteredColor = Color.FromArgb(60, 166, 166);
            btnClientRegister.Font = new Font("Microsoft Sans Serif", 12F);
            btnClientRegister.Image = null;
            btnClientRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientRegister.InactiveColor = Color.FromArgb(60, 166, 166);
            btnClientRegister.Location = new Point(1006, 545);
            btnClientRegister.Name = "btnClientRegister";
            btnClientRegister.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnClientRegister.PressedColor = Color.FromArgb(165, 37, 37);
            btnClientRegister.Size = new Size(132, 57);
            btnClientRegister.TabIndex = 0;
            btnClientRegister.Text = "New Client";
            btnClientRegister.TextAlignment = StringAlignment.Center;
            btnClientRegister.Click += btnClientRegister_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 239, 214);
            tabPage2.ImageIndex = 4;
            tabPage2.Location = new Point(79, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1264, 773);
            tabPage2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 239, 214);
            tabPage3.ImageIndex = 7;
            tabPage3.Location = new Point(79, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(994, 675);
            tabPage3.TabIndex = 2;
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
            // lvTickets
            // 
            lvTickets.Font = new Font("Segoe UI", 12F);
            lvTickets.FullRowSelect = true;
            lvTickets.HideSelection = true;
            lvTickets.Location = new Point(74, 59);
            lvTickets.Name = "lvTickets";
            lvTickets.OwnerDraw = true;
            lvTickets.Size = new Size(794, 189);
            lvTickets.TabIndex = 5;
            lvTickets.UseCompatibleStateImageBehavior = false;
            lvTickets.UseSelectable = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1352, 818);
            Controls.Add(airTabPage1);
            HeaderColor = Color.FromArgb(1, 46, 64);
            Image = Properties.Resources.ComputerStoreIcon;
            Name = "MainForm";
            ShowIcon = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Computer Store";
            WindowState = FormWindowState.Maximized;
            airTabPage1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
        private ReaLTaiizor.Controls.Button btnClientRegister;
        private ReaLTaiizor.Controls.Button btnServiceRegister;
        private ReaLTaiizor.Controls.Button btnSupplierRegister;
        private ReaLTaiizor.Controls.Button btnNewTicket;
        private ReaLTaiizor.Controls.PoisonListView lvTickets;
    }
}
