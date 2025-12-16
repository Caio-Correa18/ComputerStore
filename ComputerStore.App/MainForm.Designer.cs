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
            btnDelete = new ReaLTaiizor.Controls.Button();
            btnEditFinished = new ReaLTaiizor.Controls.Button();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            lvTicketsFinished = new ReaLTaiizor.Controls.PoisonListView();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnEdit = new ReaLTaiizor.Controls.Button();
            lvTickets = new ReaLTaiizor.Controls.PoisonListView();
            btnNewTicket = new ReaLTaiizor.Controls.Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            imageList1 = new ImageList(components);
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
            airTabPage1.Size = new Size(1390, 828);
            airTabPage1.SizeMode = TabSizeMode.Fixed;
            airTabPage1.SquareColor = Color.FromArgb(78, 87, 100);
            airTabPage1.TabCursor = Cursors.Hand;
            airTabPage1.TabIndex = 0;
            airTabPage1.SelectedIndexChanged += tabPageMain_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 239, 214);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnEditFinished);
            tabPage1.Controls.Add(bigLabel2);
            tabPage1.Controls.Add(lvTicketsFinished);
            tabPage1.Controls.Add(bigLabel1);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Controls.Add(lvTickets);
            tabPage1.Controls.Add(btnNewTicket);
            tabPage1.ImageIndex = 6;
            tabPage1.Location = new Point(79, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1307, 820);
            tabPage1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderColor = Color.FromArgb(32, 34, 37);
            btnDelete.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnDelete.EnteredColor = Color.FromArgb(60, 166, 166);
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Image = null;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.InactiveColor = Color.FromArgb(60, 166, 166);
            btnDelete.Location = new Point(1162, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnDelete.PressedColor = Color.FromArgb(165, 37, 37);
            btnDelete.Size = new Size(132, 57);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEditFinished
            // 
            btnEditFinished.BackColor = Color.Transparent;
            btnEditFinished.BorderColor = Color.FromArgb(32, 34, 37);
            btnEditFinished.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnEditFinished.EnteredColor = Color.FromArgb(60, 166, 166);
            btnEditFinished.Font = new Font("Microsoft Sans Serif", 12F);
            btnEditFinished.Image = null;
            btnEditFinished.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditFinished.InactiveColor = Color.FromArgb(60, 166, 166);
            btnEditFinished.Location = new Point(1039, 712);
            btnEditFinished.Name = "btnEditFinished";
            btnEditFinished.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnEditFinished.PressedColor = Color.FromArgb(165, 37, 37);
            btnEditFinished.Size = new Size(132, 57);
            btnEditFinished.TabIndex = 10;
            btnEditFinished.Text = "Edit";
            btnEditFinished.TextAlignment = StringAlignment.Center;
            btnEditFinished.Click += btnEditFinished_Click;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(122, 409);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(309, 57);
            bigLabel2.TabIndex = 9;
            bigLabel2.Text = "Tickets finished";
            // 
            // lvTicketsFinished
            // 
            lvTicketsFinished.Font = new Font("Segoe UI", 12F);
            lvTicketsFinished.FullRowSelect = true;
            lvTicketsFinished.GridLines = true;
            lvTicketsFinished.HideSelection = true;
            lvTicketsFinished.Location = new Point(122, 484);
            lvTicketsFinished.Name = "lvTicketsFinished";
            lvTicketsFinished.OwnerDraw = true;
            lvTicketsFinished.Size = new Size(1071, 208);
            lvTicketsFinished.TabIndex = 8;
            lvTicketsFinished.UseCompatibleStateImageBehavior = false;
            lvTicketsFinished.UseSelectable = true;
            lvTicketsFinished.View = View.Details;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(127, 25);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(471, 57);
            bigLabel1.TabIndex = 7;
            bigLabel1.Text = "Tickets to be completed";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BorderColor = Color.FromArgb(32, 34, 37);
            btnEdit.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnEdit.EnteredColor = Color.FromArgb(60, 166, 166);
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F);
            btnEdit.Image = null;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.InactiveColor = Color.FromArgb(60, 166, 166);
            btnEdit.Location = new Point(1009, 355);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnEdit.PressedColor = Color.FromArgb(165, 37, 37);
            btnEdit.Size = new Size(132, 57);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.Click += btnEdit_Click;
            // 
            // lvTickets
            // 
            lvTickets.Font = new Font("Segoe UI", 12F);
            lvTickets.FullRowSelect = true;
            lvTickets.GridLines = true;
            lvTickets.HideSelection = true;
            lvTickets.Location = new Point(127, 94);
            lvTickets.Name = "lvTickets";
            lvTickets.OwnerDraw = true;
            lvTickets.Size = new Size(1107, 238);
            lvTickets.TabIndex = 5;
            lvTickets.UseCompatibleStateImageBehavior = false;
            lvTickets.UseSelectable = true;
            lvTickets.View = View.Details;
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
            btnNewTicket.Location = new Point(857, 355);
            btnNewTicket.Name = "btnNewTicket";
            btnNewTicket.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnNewTicket.PressedColor = Color.FromArgb(165, 37, 37);
            btnNewTicket.Size = new Size(132, 57);
            btnNewTicket.TabIndex = 4;
            btnNewTicket.Text = "New Ticket";
            btnNewTicket.TextAlignment = StringAlignment.Center;
            btnNewTicket.Click += btnNewTicket_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 239, 214);
            tabPage2.ImageIndex = 4;
            tabPage2.Location = new Point(79, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1307, 820);
            tabPage2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 239, 214);
            tabPage3.ImageIndex = 7;
            tabPage3.Location = new Point(79, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1307, 820);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1395, 865);
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
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
        private ReaLTaiizor.Controls.Button btnNewTicket;
        private ReaLTaiizor.Controls.PoisonListView lvTickets;
        private ReaLTaiizor.Controls.Button btnEdit;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.PoisonListView lvTicketsFinished;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.Button btnEditFinished;
        private ReaLTaiizor.Controls.Button btnDelete;
    }
}
