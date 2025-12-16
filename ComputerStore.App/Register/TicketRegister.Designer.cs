namespace ComputerStore.App.Register
{
    partial class TicketRegister
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
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            txtDate = new ReaLTaiizor.Controls.BigTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBudget = new ReaLTaiizor.Controls.BigTextBox();
            txtDescription = new ReaLTaiizor.Controls.BigTextBox();
            rbStarted = new ReaLTaiizor.Controls.AirRadioButton();
            rbFinished = new ReaLTaiizor.Controls.AirRadioButton();
            cbClient = new ReaLTaiizor.Controls.ComboBoxEdit();
            btnAddClient = new ReaLTaiizor.Controls.Button();
            rbService = new ReaLTaiizor.Controls.AirRadioButton();
            rbProduct = new ReaLTaiizor.Controls.AirRadioButton();
            cblService = new CheckedListBox();
            txtSolution = new ReaLTaiizor.Controls.BigTextBox();
            gbStatus = new GroupBox();
            groupBox1 = new GroupBox();
            btnNewService = new ReaLTaiizor.Controls.Button();
            btnAddProduct = new ReaLTaiizor.Controls.Button();
            cblProduct = new CheckedListBox();
            gbStatus.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(715, 928);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(902, 928);
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(348, 51);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(386, 57);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "Create a new Ticket";
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Transparent;
            txtDate.Font = new Font("Tahoma", 11F);
            txtDate.ForeColor = Color.DimGray;
            txtDate.Image = null;
            txtDate.Location = new Point(191, 166);
            txtDate.MaxLength = 32767;
            txtDate.Multiline = false;
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = false;
            txtDate.Size = new Size(243, 46);
            txtDate.TabIndex = 3;
            txtDate.TextAlignment = HorizontalAlignment.Left;
            txtDate.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 175);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 4;
            label1.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(568, 175);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 5;
            label2.Text = "Budget:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(96, 277);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 6;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(548, 572);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 7;
            label4.Text = "Client:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(110, 653);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 8;
            label5.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(110, 518);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 9;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(524, 664);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 10;
            label7.Text = "Solution:";
            // 
            // txtBudget
            // 
            txtBudget.BackColor = Color.Transparent;
            txtBudget.Enabled = false;
            txtBudget.Font = new Font("Tahoma", 11F);
            txtBudget.ForeColor = Color.DimGray;
            txtBudget.Image = null;
            txtBudget.Location = new Point(653, 166);
            txtBudget.MaxLength = 32767;
            txtBudget.Multiline = false;
            txtBudget.Name = "txtBudget";
            txtBudget.ReadOnly = false;
            txtBudget.Size = new Size(216, 46);
            txtBudget.TabIndex = 11;
            txtBudget.TextAlignment = HorizontalAlignment.Left;
            txtBudget.UseSystemPasswordChar = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.Transparent;
            txtDescription.Font = new Font("Tahoma", 11F);
            txtDescription.ForeColor = Color.DimGray;
            txtDescription.Image = null;
            txtDescription.Location = new Point(218, 250);
            txtDescription.MaxLength = 32767;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = false;
            txtDescription.Size = new Size(743, 245);
            txtDescription.TabIndex = 12;
            txtDescription.TextAlignment = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // rbStarted
            // 
            rbStarted.Checked = true;
            rbStarted.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            rbStarted.Field = 16;
            rbStarted.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbStarted.Image = null;
            rbStarted.Location = new Point(36, 33);
            rbStarted.Name = "rbStarted";
            rbStarted.NoRounding = false;
            rbStarted.Size = new Size(101, 16);
            rbStarted.TabIndex = 13;
            rbStarted.Text = "Started";
            rbStarted.Transparent = false;
            rbStarted.CheckedChanged += rbStarted_CheckedChanged;
            // 
            // rbFinished
            // 
            rbFinished.Checked = false;
            rbFinished.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            rbFinished.Field = 16;
            rbFinished.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbFinished.Image = null;
            rbFinished.Location = new Point(198, 33);
            rbFinished.Name = "rbFinished";
            rbFinished.NoRounding = false;
            rbFinished.Size = new Size(101, 16);
            rbFinished.TabIndex = 14;
            rbFinished.Text = "Finished";
            rbFinished.Transparent = false;
            rbFinished.CheckedChanged += rbFinished_CheckedChanged;
            // 
            // cbClient
            // 
            cbClient.BackColor = Color.FromArgb(246, 246, 246);
            cbClient.DrawMode = DrawMode.OwnerDrawFixed;
            cbClient.DropDownHeight = 100;
            cbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClient.Font = new Font("Segoe UI", 10F);
            cbClient.ForeColor = Color.FromArgb(142, 142, 142);
            cbClient.FormattingEnabled = true;
            cbClient.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            cbClient.IntegralHeight = false;
            cbClient.ItemHeight = 20;
            cbClient.Location = new Point(620, 574);
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(276, 26);
            cbClient.StartIndex = 0;
            cbClient.TabIndex = 15;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = Color.Transparent;
            btnAddClient.BorderColor = Color.FromArgb(2, 103, 115);
            btnAddClient.EnteredBorderColor = Color.FromArgb(2, 103, 115);
            btnAddClient.EnteredColor = Color.FromArgb(2, 103, 115);
            btnAddClient.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddClient.Image = Properties.Resources.Plus2;
            btnAddClient.ImageAlign = ContentAlignment.MiddleCenter;
            btnAddClient.InactiveColor = Color.FromArgb(2, 103, 115);
            btnAddClient.Location = new Point(902, 572);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.PressedBorderColor = Color.FromArgb(2, 103, 115);
            btnAddClient.PressedColor = Color.FromArgb(2, 103, 115);
            btnAddClient.Size = new Size(46, 36);
            btnAddClient.TabIndex = 16;
            btnAddClient.TextAlignment = StringAlignment.Center;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // rbService
            // 
            rbService.Checked = true;
            rbService.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            rbService.Field = 16;
            rbService.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbService.Image = null;
            rbService.Location = new Point(36, 33);
            rbService.Name = "rbService";
            rbService.NoRounding = false;
            rbService.Size = new Size(103, 16);
            rbService.TabIndex = 17;
            rbService.Text = "Service";
            rbService.Transparent = false;
            rbService.CheckedChanged += rbService_CheckedChanged;
            // 
            // rbProduct
            // 
            rbProduct.Checked = false;
            rbProduct.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            rbProduct.Field = 16;
            rbProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbProduct.Image = null;
            rbProduct.Location = new Point(198, 33);
            rbProduct.Name = "rbProduct";
            rbProduct.NoRounding = false;
            rbProduct.Size = new Size(103, 16);
            rbProduct.TabIndex = 18;
            rbProduct.Text = "Product";
            rbProduct.Transparent = false;
            rbProduct.CheckedChanged += rbProduct_CheckedChanged;
            // 
            // cblService
            // 
            cblService.FormattingEnabled = true;
            cblService.Location = new Point(71, 789);
            cblService.Name = "cblService";
            cblService.Size = new Size(151, 33);
            cblService.TabIndex = 19;
            // 
            // txtSolution
            // 
            txtSolution.BackColor = Color.Transparent;
            txtSolution.Font = new Font("Tahoma", 11F);
            txtSolution.ForeColor = Color.DimGray;
            txtSolution.Image = null;
            txtSolution.Location = new Point(620, 653);
            txtSolution.MaxLength = 32767;
            txtSolution.Multiline = true;
            txtSolution.Name = "txtSolution";
            txtSolution.ReadOnly = false;
            txtSolution.Size = new Size(436, 249);
            txtSolution.TabIndex = 20;
            txtSolution.TextAlignment = HorizontalAlignment.Left;
            txtSolution.UseSystemPasswordChar = false;
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(rbFinished);
            gbStatus.Controls.Add(rbStarted);
            gbStatus.Location = new Point(85, 549);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(326, 71);
            gbStatus.TabIndex = 21;
            gbStatus.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbProduct);
            groupBox1.Controls.Add(rbService);
            groupBox1.Location = new Point(85, 684);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 68);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // btnNewService
            // 
            btnNewService.BackColor = Color.Transparent;
            btnNewService.BorderColor = Color.FromArgb(2, 103, 115);
            btnNewService.EnteredBorderColor = Color.FromArgb(2, 103, 115);
            btnNewService.EnteredColor = Color.FromArgb(2, 103, 115);
            btnNewService.Font = new Font("Microsoft Sans Serif", 12F);
            btnNewService.Image = Properties.Resources.Plus2;
            btnNewService.ImageAlign = ContentAlignment.MiddleCenter;
            btnNewService.InactiveColor = Color.FromArgb(2, 103, 115);
            btnNewService.Location = new Point(21, 789);
            btnNewService.Name = "btnNewService";
            btnNewService.PressedBorderColor = Color.FromArgb(2, 103, 115);
            btnNewService.PressedColor = Color.FromArgb(2, 103, 115);
            btnNewService.Size = new Size(46, 36);
            btnNewService.TabIndex = 23;
            btnNewService.TextAlignment = StringAlignment.Center;
            btnNewService.Click += btnNewService_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Transparent;
            btnAddProduct.BorderColor = Color.FromArgb(2, 103, 115);
            btnAddProduct.EnteredBorderColor = Color.FromArgb(2, 103, 115);
            btnAddProduct.EnteredColor = Color.FromArgb(2, 103, 115);
            btnAddProduct.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddProduct.Image = Properties.Resources.Plus2;
            btnAddProduct.ImageAlign = ContentAlignment.MiddleCenter;
            btnAddProduct.InactiveColor = Color.FromArgb(2, 103, 115);
            btnAddProduct.Location = new Point(293, 786);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.PressedBorderColor = Color.FromArgb(2, 103, 115);
            btnAddProduct.PressedColor = Color.FromArgb(2, 103, 115);
            btnAddProduct.Size = new Size(46, 36);
            btnAddProduct.TabIndex = 24;
            btnAddProduct.TextAlignment = StringAlignment.Center;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // cblProduct
            // 
            cblProduct.FormattingEnabled = true;
            cblProduct.Location = new Point(345, 786);
            cblProduct.Name = "cblProduct";
            cblProduct.Size = new Size(180, 33);
            cblProduct.TabIndex = 25;
            // 
            // TicketRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 1022);
            Controls.Add(cblProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(btnNewService);
            Controls.Add(groupBox1);
            Controls.Add(gbStatus);
            Controls.Add(txtSolution);
            Controls.Add(cblService);
            Controls.Add(btnAddClient);
            Controls.Add(cbClient);
            Controls.Add(txtDescription);
            Controls.Add(txtBudget);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDate);
            Controls.Add(bigLabel1);
            Name = "TicketRegister";
            Text = "Ticket Register";
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnCancel, 0);
            Controls.SetChildIndex(bigLabel1, 0);
            Controls.SetChildIndex(txtDate, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtBudget, 0);
            Controls.SetChildIndex(txtDescription, 0);
            Controls.SetChildIndex(cbClient, 0);
            Controls.SetChildIndex(btnAddClient, 0);
            Controls.SetChildIndex(cblService, 0);
            Controls.SetChildIndex(txtSolution, 0);
            Controls.SetChildIndex(gbStatus, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(btnNewService, 0);
            Controls.SetChildIndex(btnAddProduct, 0);
            Controls.SetChildIndex(cblProduct, 0);
            gbStatus.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();



        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox txtDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ReaLTaiizor.Controls.BigTextBox txtBudget;
        private ReaLTaiizor.Controls.BigTextBox txtDescription;
        private ReaLTaiizor.Controls.AirRadioButton rbStarted;
        private ReaLTaiizor.Controls.AirRadioButton rbFinished;
        private ReaLTaiizor.Controls.ComboBoxEdit cbClient;
        private ReaLTaiizor.Controls.Button btnAddClient;
        private ReaLTaiizor.Controls.AirRadioButton rbService;
        private ReaLTaiizor.Controls.AirRadioButton rbProduct;
        private CheckedListBox cblService;
        private ReaLTaiizor.Controls.BigTextBox txtSolution;
        private GroupBox gbStatus;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.Button btnNewService;
        private ReaLTaiizor.Controls.Button btnAddProduct;
        private CheckedListBox cblProduct;
    }
}