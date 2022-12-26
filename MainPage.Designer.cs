namespace BeyogluOtomotiv
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_List = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btnCarSales = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Showroom = new System.Windows.Forms.Button();
            this.btnShoeRoom = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.btn_Menu);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(250, 720);
            this.sidebar.MinimumSize = new System.Drawing.Size(75, 720);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(250, 720);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(3, 3);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(90, 64);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 144);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name-Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(70, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(3, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 268);
            this.panel4.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_List);
            this.panel7.Controls.Add(this.btnList);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 216);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(246, 52);
            this.panel7.TabIndex = 9;
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_List.FlatAppearance.BorderSize = 0;
            this.btn_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_List.Image = ((System.Drawing.Image)(resources.GetObject("btn_List.Image")));
            this.btn_List.Location = new System.Drawing.Point(0, -5);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(90, 64);
            this.btn_List.TabIndex = 2;
            this.btn_List.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnList.Location = new System.Drawing.Point(87, 0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(159, 52);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Sales);
            this.panel6.Controls.Add(this.btnCarSales);
            this.panel6.Location = new System.Drawing.Point(3, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 67);
            this.panel6.TabIndex = 9;
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Sales.FlatAppearance.BorderSize = 0;
            this.btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sales.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sales.Image")));
            this.btn_Sales.Location = new System.Drawing.Point(-3, 3);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(90, 64);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.UseVisualStyleBackColor = false;
            // 
            // btnCarSales
            // 
            this.btnCarSales.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCarSales.FlatAppearance.BorderSize = 0;
            this.btnCarSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarSales.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCarSales.Location = new System.Drawing.Point(91, 0);
            this.btnCarSales.Name = "btnCarSales";
            this.btnCarSales.Size = new System.Drawing.Size(159, 67);
            this.btnCarSales.TabIndex = 3;
            this.btnCarSales.Text = "Car Sales";
            this.btnCarSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarSales.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Dashboard);
            this.panel5.Controls.Add(this.btnDashboard);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 64);
            this.panel5.TabIndex = 9;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 1);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(90, 64);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Location = new System.Drawing.Point(87, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(159, 64);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Showroom);
            this.panel3.Controls.Add(this.btnShoeRoom);
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 64);
            this.panel3.TabIndex = 7;
            // 
            // btn_Showroom
            // 
            this.btn_Showroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Showroom.FlatAppearance.BorderSize = 0;
            this.btn_Showroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Showroom.Image = ((System.Drawing.Image)(resources.GetObject("btn_Showroom.Image")));
            this.btn_Showroom.Location = new System.Drawing.Point(0, 0);
            this.btn_Showroom.Name = "btn_Showroom";
            this.btn_Showroom.Size = new System.Drawing.Size(90, 64);
            this.btn_Showroom.TabIndex = 2;
            this.btn_Showroom.UseVisualStyleBackColor = false;
            // 
            // btnShoeRoom
            // 
            this.btnShoeRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShoeRoom.FlatAppearance.BorderSize = 0;
            this.btnShoeRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoeRoom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShoeRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShoeRoom.Location = new System.Drawing.Point(91, 0);
            this.btnShoeRoom.Name = "btnShoeRoom";
            this.btnShoeRoom.Size = new System.Drawing.Size(159, 64);
            this.btnShoeRoom.TabIndex = 2;
            this.btnShoeRoom.Text = "ShowRoom";
            this.btnShoeRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShoeRoom.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnShoeRoom;
        private Button btnCarSales;
        private Button btnList;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel3;
        private Button btn_Menu;
        private Button btn_List;
        private Button btn_Sales;
        private Button btn_Dashboard;
        private Button btn_Showroom;
    }
}