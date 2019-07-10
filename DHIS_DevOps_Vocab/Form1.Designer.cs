namespace DHIS_DevOps_Vocab
{
    partial class form1
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbConnStr = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbSQLCode = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblConnStr = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbDBType = new System.Windows.Forms.ComboBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbCatalog = new System.Windows.Forms.TextBox();
            this.lblCatalog = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBuildAPI = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(483, 43);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(189, 20);
            this.tbUserName.TabIndex = 4;
            // 
            // tbConnStr
            // 
            this.tbConnStr.Location = new System.Drawing.Point(109, 108);
            this.tbConnStr.Multiline = true;
            this.tbConnStr.Name = "tbConnStr";
            this.tbConnStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConnStr.Size = new System.Drawing.Size(563, 75);
            this.tbConnStr.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 189);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 273);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbSQLCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbSQLCode
            // 
            this.tbSQLCode.Location = new System.Drawing.Point(0, 0);
            this.tbSQLCode.Multiline = true;
            this.tbSQLCode.Name = "tbSQLCode";
            this.tbSQLCode.Size = new System.Drawing.Size(656, 251);
            this.tbSQLCode.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblConnStr
            // 
            this.lblConnStr.AutoSize = true;
            this.lblConnStr.Location = new System.Drawing.Point(9, 123);
            this.lblConnStr.Name = "lblConnStr";
            this.lblConnStr.Size = new System.Drawing.Size(94, 13);
            this.lblConnStr.TabIndex = 4;
            this.lblConnStr.Text = "Connection String:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(701, 160);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Build";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(701, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbDBType
            // 
            this.cbDBType.FormattingEnabled = true;
            this.cbDBType.Items.AddRange(new object[] {
            "SQL Server",
            "My SQL",
            "PostgreSQL",
            "Mongo"});
            this.cbDBType.Location = new System.Drawing.Point(109, 20);
            this.cbDBType.Name = "cbDBType";
            this.cbDBType.Size = new System.Drawing.Size(292, 21);
            this.cbDBType.TabIndex = 1;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(19, 25);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(83, 13);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Database Type:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(419, 46);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(419, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(483, 69);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(189, 20);
            this.tbPwd.TabIndex = 5;
            // 
            // tbCatalog
            // 
            this.tbCatalog.Location = new System.Drawing.Point(109, 73);
            this.tbCatalog.Name = "tbCatalog";
            this.tbCatalog.Size = new System.Drawing.Size(292, 20);
            this.tbCatalog.TabIndex = 3;
            // 
            // lblCatalog
            // 
            this.lblCatalog.AutoSize = true;
            this.lblCatalog.Location = new System.Drawing.Point(19, 76);
            this.lblCatalog.Name = "lblCatalog";
            this.lblCatalog.Size = new System.Drawing.Size(84, 13);
            this.lblCatalog.TabIndex = 13;
            this.lblCatalog.Text = "Table / Catalog:";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(109, 47);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(292, 20);
            this.tbServer.TabIndex = 2;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(62, 50);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 15;
            this.lblServer.Text = "Server:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(701, 406);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBuildAPI
            // 
            this.btnBuildAPI.Location = new System.Drawing.Point(701, 211);
            this.btnBuildAPI.Name = "btnBuildAPI";
            this.btnBuildAPI.Size = new System.Drawing.Size(75, 23);
            this.btnBuildAPI.TabIndex = 8;
            this.btnBuildAPI.Text = "Build API";
            this.btnBuildAPI.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnBuildAPI);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.lblCatalog);
            this.Controls.Add(this.tbCatalog);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.cbDBType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblConnStr);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbConnStr);
            this.Controls.Add(this.tbUserName);
            this.Name = "form1";
            this.Text = "DHIS DevOps Vocab";
            this.Load += new System.EventHandler(this.form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbConnStr;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbSQLCode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblConnStr;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbDBType;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbCatalog;
        private System.Windows.Forms.Label lblCatalog;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBuildAPI;
    }
}

