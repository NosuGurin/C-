namespace DesignSIMS
{
    partial class SPSpace
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabReceipt = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExecutereceipt = new System.Windows.Forms.Button();
            this.btnShowallreceipt = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxActionreceipt = new System.Windows.Forms.ComboBox();
            this.cbxTypereceipt = new System.Windows.Forms.ComboBox();
            this.txtNamereceipt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.tabInform = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxReceiver = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnResetinform = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabReceipt.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.tabInventory.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.tabInform.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabReceipt);
            this.tabControl.Controls.Add(this.tabInventory);
            this.tabControl.Controls.Add(this.tabInform);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 538);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tabReceipt
            // 
            this.tabReceipt.Controls.Add(this.tableLayoutPanel7);
            this.tabReceipt.Location = new System.Drawing.Point(4, 29);
            this.tabReceipt.Name = "tabReceipt";
            this.tabReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceipt.Size = new System.Drawing.Size(876, 505);
            this.tabReceipt.TabIndex = 0;
            this.tabReceipt.Text = "Receipt";
            this.tabReceipt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.dgvReceipt, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(870, 499);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.Controls.Add(this.btnExecutereceipt, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnShowallreceipt, 3, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 193);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(864, 65);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // btnExecutereceipt
            // 
            this.btnExecutereceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecutereceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutereceipt.Location = new System.Drawing.Point(89, 9);
            this.btnExecutereceipt.Name = "btnExecutereceipt";
            this.btnExecutereceipt.Size = new System.Drawing.Size(253, 46);
            this.btnExecutereceipt.TabIndex = 0;
            this.btnExecutereceipt.Text = "Execute";
            this.btnExecutereceipt.UseVisualStyleBackColor = true;
            this.btnExecutereceipt.Click += new System.EventHandler(this.btnConfirmreceipt_Click);
            // 
            // btnShowallreceipt
            // 
            this.btnShowallreceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowallreceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowallreceipt.Location = new System.Drawing.Point(520, 9);
            this.btnShowallreceipt.Name = "btnShowallreceipt";
            this.btnShowallreceipt.Size = new System.Drawing.Size(253, 46);
            this.btnShowallreceipt.TabIndex = 1;
            this.btnShowallreceipt.Text = "Show all";
            this.btnShowallreceipt.UseVisualStyleBackColor = true;
            this.btnShowallreceipt.Click += new System.EventHandler(this.btnShowallreceipt_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 6;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.000234F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.33088F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22296F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22296F));
            this.tableLayoutPanel9.Controls.Add(this.cbxActionreceipt, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.cbxTypereceipt, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.txtNamereceipt, 2, 2);
            this.tableLayoutPanel9.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.lbltime, 2, 3);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(864, 184);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // cbxActionreceipt
            // 
            this.cbxActionreceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxActionreceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActionreceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActionreceipt.FormattingEnabled = true;
            this.cbxActionreceipt.Items.AddRange(new object[] {
            "Add",
            "Cancel"});
            this.cbxActionreceipt.Location = new System.Drawing.Point(290, 9);
            this.cbxActionreceipt.Name = "cbxActionreceipt";
            this.cbxActionreceipt.Size = new System.Drawing.Size(186, 28);
            this.cbxActionreceipt.TabIndex = 0;
            this.cbxActionreceipt.SelectedIndexChanged += new System.EventHandler(this.cbxActionreceipt_SelectedIndexChanged);
            // 
            // cbxTypereceipt
            // 
            this.cbxTypereceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.SetColumnSpan(this.cbxTypereceipt, 2);
            this.cbxTypereceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypereceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypereceipt.FormattingEnabled = true;
            this.cbxTypereceipt.Items.AddRange(new object[] {
            "Hóa đơn bán",
            "Hóa đơn trả hàng"});
            this.cbxTypereceipt.Location = new System.Drawing.Point(290, 55);
            this.cbxTypereceipt.Name = "cbxTypereceipt";
            this.cbxTypereceipt.Size = new System.Drawing.Size(282, 28);
            this.cbxTypereceipt.TabIndex = 1;
            // 
            // txtNamereceipt
            // 
            this.txtNamereceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.SetColumnSpan(this.txtNamereceipt, 3);
            this.txtNamereceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamereceipt.Location = new System.Drawing.Point(290, 102);
            this.txtNamereceipt.Name = "txtNamereceipt";
            this.txtNamereceipt.ReadOnly = true;
            this.txtNamereceipt.Size = new System.Drawing.Size(378, 26);
            this.txtNamereceipt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 46);
            this.label6.TabIndex = 4;
            this.label6.Text = "Action";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 46);
            this.label7.TabIndex = 5;
            this.label7.Text = "Receipt type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 46);
            this.label8.TabIndex = 6;
            this.label8.Text = "Employee";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 46);
            this.label9.TabIndex = 7;
            this.label9.Text = "Time";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltime.Location = new System.Drawing.Point(290, 138);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(186, 46);
            this.lbltime.TabIndex = 8;
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceipt.Location = new System.Drawing.Point(3, 264);
            this.dgvReceipt.MultiSelect = false;
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.Size = new System.Drawing.Size(864, 232);
            this.dgvReceipt.TabIndex = 2;
            this.dgvReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellContentClick);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.tableLayoutPanel4);
            this.tabInventory.Location = new System.Drawing.Point(4, 29);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(876, 505);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgvItem, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(870, 499);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtItem, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.cbxCategory, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(864, 168);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 48);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 48);
            this.label5.TabIndex = 1;
            this.label5.Text = "Item name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItem
            // 
            this.txtItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(261, 59);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(339, 26);
            this.txtItem.TabIndex = 3;
            // 
            // cbxCategory
            // 
            this.cbxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(261, 10);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(339, 28);
            this.cbxCategory.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel5.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Controls.Add(this.btnSearch, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnSort, 3, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(63, 99);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(537, 66);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(56, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 46);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = " Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(296, 9);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(181, 46);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.Location = new System.Drawing.Point(3, 177);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.Size = new System.Drawing.Size(864, 319);
            this.dgvItem.TabIndex = 1;
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick);
            // 
            // tabInform
            // 
            this.tabInform.Controls.Add(this.tableLayoutPanel1);
            this.tabInform.Location = new System.Drawing.Point(4, 29);
            this.tabInform.Name = "tabInform";
            this.tabInform.Size = new System.Drawing.Size(876, 505);
            this.tabInform.TabIndex = 2;
            this.tabInform.Text = "Inform";
            this.tabInform.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 505);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txtSubject, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbxReceiver, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(870, 145);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtSubject, 2);
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(263, 59);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(429, 26);
            this.txtSubject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 48);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "To:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "Content:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxReceiver
            // 
            this.cbxReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReceiver.FormattingEnabled = true;
            this.cbxReceiver.Items.AddRange(new object[] {
            "Inventory Manager",
            "Sales Manager"});
            this.cbxReceiver.Location = new System.Drawing.Point(263, 10);
            this.cbxReceiver.Name = "cbxReceiver";
            this.cbxReceiver.Size = new System.Drawing.Size(255, 28);
            this.cbxReceiver.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnSend, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnResetinform, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 436);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(870, 66);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(177, 9);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(211, 46);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnResetinform
            // 
            this.btnResetinform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetinform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetinform.Location = new System.Drawing.Point(481, 9);
            this.btnResetinform.Name = "btnResetinform";
            this.btnResetinform.Size = new System.Drawing.Size(211, 46);
            this.btnResetinform.TabIndex = 1;
            this.btnResetinform.Text = "Reset";
            this.btnResetinform.UseVisualStyleBackColor = true;
            this.btnResetinform.Click += new System.EventHandler(this.btnResetinform_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel10.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 154);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(870, 276);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(63, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(742, 270);
            this.panel1.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(5, 5);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(728, 256);
            this.txtContent.TabIndex = 5;
            this.txtContent.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SPSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SPSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Person Space";
            this.Load += new System.EventHandler(this.SPSpace_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabReceipt.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.tabInform.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabReceipt;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabInform;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnExecutereceipt;
        private System.Windows.Forms.Button btnShowallreceipt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ComboBox cbxActionreceipt;
        private System.Windows.Forms.ComboBox cbxTypereceipt;
        private System.Windows.Forms.TextBox txtNamereceipt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxReceiver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnResetinform;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
    }
}