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
            tabPage3 = new TabPage();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            panel2 = new Panel();
            panel3 = new Panel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            lbGain = new ReaLTaiizor.Controls.BigLabel();
            lbTicketsRemaning = new ReaLTaiizor.Controls.BigLabel();
            lbTicketsFinished = new ReaLTaiizor.Controls.BigLabel();
            airTabPage1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // airTabPage1
            // 
            airTabPage1.Alignment = TabAlignment.Left;
            airTabPage1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            airTabPage1.BaseColor = Color.FromArgb(2, 103, 115);
            airTabPage1.Controls.Add(tabPage1);
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
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(255, 239, 214);
            tabPage3.Controls.Add(panel3);
            tabPage3.Controls.Add(panel2);
            tabPage3.Controls.Add(bigLabel3);
            tabPage3.Controls.Add(panel1);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 166, 166);
            panel1.Controls.Add(lbTicketsRemaning);
            panel1.Controls.Add(bigLabel4);
            panel1.Location = new Point(116, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 213);
            panel1.TabIndex = 0;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Segoe UI", 25F);
            bigLabel3.ForeColor = Color.Black;
            bigLabel3.Location = new Point(135, 21);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(228, 57);
            bigLabel3.TabIndex = 1;
            bigLabel3.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 166, 166);
            panel2.Controls.Add(lbTicketsFinished);
            panel2.Controls.Add(bigLabel5);
            panel2.Location = new Point(888, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 213);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(60, 166, 166);
            panel3.Controls.Add(lbGain);
            panel3.Controls.Add(bigLabel6);
            panel3.Location = new Point(508, 476);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 213);
            panel3.TabIndex = 1;
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Segoe UI", 25F);
            bigLabel4.ForeColor = Color.White;
            bigLabel4.Location = new Point(19, 14);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(359, 57);
            bigLabel4.TabIndex = 0;
            bigLabel4.Text = "Tickets Remaining";
            // 
            // bigLabel5
            // 
            bigLabel5.AutoSize = true;
            bigLabel5.BackColor = Color.Transparent;
            bigLabel5.Font = new Font("Segoe UI", 25F);
            bigLabel5.ForeColor = Color.White;
            bigLabel5.Location = new Point(40, 14);
            bigLabel5.Name = "bigLabel5";
            bigLabel5.Size = new Size(317, 57);
            bigLabel5.TabIndex = 1;
            bigLabel5.Text = "Tickets Finished";
            // 
            // bigLabel6
            // 
            bigLabel6.AutoSize = true;
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.Font = new Font("Segoe UI", 25F);
            bigLabel6.ForeColor = Color.White;
            bigLabel6.Location = new Point(87, 10);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(204, 57);
            bigLabel6.TabIndex = 2;
            bigLabel6.Text = "Gain (R$):";
            // 
            // lbGain
            // 
            lbGain.AutoSize = true;
            lbGain.BackColor = Color.Transparent;
            lbGain.Font = new Font("Segoe UI", 25F);
            lbGain.ForeColor = Color.White;
            lbGain.Location = new Point(161, 91);
            lbGain.Name = "lbGain";
            lbGain.Size = new Size(48, 57);
            lbGain.TabIndex = 3;
            lbGain.Text = "0";
            // 
            // lbTicketsRemaning
            // 
            lbTicketsRemaning.AutoSize = true;
            lbTicketsRemaning.BackColor = Color.Transparent;
            lbTicketsRemaning.Font = new Font("Segoe UI", 25F);
            lbTicketsRemaning.ForeColor = Color.White;
            lbTicketsRemaning.Location = new Point(161, 91);
            lbTicketsRemaning.Name = "lbTicketsRemaning";
            lbTicketsRemaning.Size = new Size(48, 57);
            lbTicketsRemaning.TabIndex = 4;
            lbTicketsRemaning.Text = "0";
            
            // 
            // lbTicketsFinished
            // 
            lbTicketsFinished.AutoSize = true;
            lbTicketsFinished.BackColor = Color.Transparent;
            lbTicketsFinished.Font = new Font("Segoe UI", 25F);
            lbTicketsFinished.ForeColor = Color.White;
            lbTicketsFinished.Location = new Point(168, 91);
            lbTicketsFinished.Name = "lbTicketsFinished";
            lbTicketsFinished.Size = new Size(48, 57);
            lbTicketsFinished.TabIndex = 5;
            lbTicketsFinished.Text = "0";
            lbTicketsFinished.Click += bigLabel10_Click;
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private TabPage tabPage1;
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
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel lbGain;
        private ReaLTaiizor.Controls.BigLabel lbTicketsFinished;
        private ReaLTaiizor.Controls.BigLabel lbTicketsRemaning;
    }
}
