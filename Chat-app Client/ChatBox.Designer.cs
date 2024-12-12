namespace Chat_app_Client
{
    partial class ChatBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBox));
            tblUser = new DataGridView();
            Online = new DataGridViewButtonColumn();
            tblGroup = new DataGridView();
            Group = new DataGridViewButtonColumn();
            rtbDialog = new RichTextBox();
            btnPicture = new PictureBox();
            txtMessage = new TextBox();
            btnSend = new PictureBox();
            lblWelcome = new Label();
            txtReceiver = new TextBox();
            btnCreateGroup = new Button();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tblUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // tblUser
            // 
            tblUser.AllowUserToAddRows = false;
            tblUser.AllowUserToDeleteRows = false;
            tblUser.BackgroundColor = SystemColors.Control;
            tblUser.BorderStyle = BorderStyle.None;
            tblUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblUser.Columns.AddRange(new DataGridViewColumn[] { Online });
            tblUser.Location = new Point(14, 57);
            tblUser.Margin = new Padding(3, 4, 3, 4);
            tblUser.Name = "tblUser";
            tblUser.ReadOnly = true;
            tblUser.RowHeadersWidth = 51;
            tblUser.RowTemplate.Height = 25;
            tblUser.Size = new Size(202, 268);
            tblUser.TabIndex = 4;
            tblUser.CellContentClick += tblUser_CellContentClick;
            // 
            // Online
            // 
            Online.HeaderText = "Online";
            Online.MinimumWidth = 6;
            Online.Name = "Online";
            Online.ReadOnly = true;
            Online.Resizable = DataGridViewTriState.False;
            Online.SortMode = DataGridViewColumnSortMode.Automatic;
            Online.Width = 120;
            // 
            // tblGroup
            // 
            tblGroup.AllowUserToAddRows = false;
            tblGroup.AllowUserToDeleteRows = false;
            tblGroup.BackgroundColor = SystemColors.Control;
            tblGroup.BorderStyle = BorderStyle.None;
            tblGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblGroup.Columns.AddRange(new DataGridViewColumn[] { Group });
            tblGroup.Location = new Point(14, 333);
            tblGroup.Margin = new Padding(3, 4, 3, 4);
            tblGroup.Name = "tblGroup";
            tblGroup.ReadOnly = true;
            tblGroup.RowHeadersWidth = 51;
            tblGroup.RowTemplate.Height = 25;
            tblGroup.Size = new Size(202, 268);
            tblGroup.TabIndex = 3;
            tblGroup.CellContentClick += tblGroup_CellContentClick;
            // 
            // Group
            // 
            Group.HeaderText = "Group";
            Group.MinimumWidth = 6;
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Resizable = DataGridViewTriState.False;
            Group.SortMode = DataGridViewColumnSortMode.Automatic;
            Group.Width = 120;
            // 
            // rtbDialog
            // 
            rtbDialog.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDialog.Location = new Point(222, 57);
            rtbDialog.Margin = new Padding(3, 4, 3, 4);
            rtbDialog.Name = "rtbDialog";
            rtbDialog.ReadOnly = true;
            rtbDialog.Size = new Size(678, 544);
            rtbDialog.TabIndex = 2;
            rtbDialog.Text = "";
            //rtbDialog.TextChanged += rtbDialog_TextChanged;
            // 
            // btnPicture
            // 
            btnPicture.Cursor = Cursors.Hand;
            btnPicture.Image = Properties.Resources.file;
            btnPicture.Location = new Point(202, 666);
            btnPicture.Margin = new Padding(3, 4, 3, 4);
            btnPicture.Name = "btnPicture";
            btnPicture.Size = new Size(34, 40);
            btnPicture.SizeMode = PictureBoxSizeMode.Zoom;
            btnPicture.TabIndex = 2;
            btnPicture.TabStop = false;
            btnPicture.Click += btnPicture_Click;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(243, 668);
            txtMessage.Margin = new Padding(3, 4, 3, 4);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(614, 35);
            txtMessage.TabIndex = 1;
            txtMessage.KeyPress += txtMessage_KeyPress;
            // 
            // btnSend
            // 
            btnSend.Cursor = Cursors.Hand;
            btnSend.Image = Properties.Resources.send;
            btnSend.Location = new Point(864, 666);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(34, 40);
            btnSend.SizeMode = PictureBoxSizeMode.Zoom;
            btnSend.TabIndex = 2;
            btnSend.TabStop = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.Maroon;
            lblWelcome.Location = new Point(14, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(101, 28);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome";
            // 
            // txtReceiver
            // 
            txtReceiver.BorderStyle = BorderStyle.None;
            txtReceiver.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            txtReceiver.Location = new Point(222, 13);
            txtReceiver.Margin = new Padding(3, 4, 3, 4);
            txtReceiver.Name = "txtReceiver";
            txtReceiver.ReadOnly = true;
            txtReceiver.Size = new Size(126, 27);
            txtReceiver.TabIndex = 0;
            // 
            // btnCreateGroup
            // 
            btnCreateGroup.BackColor = Color.RosyBrown;
            btnCreateGroup.FlatStyle = FlatStyle.Flat;
            btnCreateGroup.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateGroup.ForeColor = Color.Maroon;
            btnCreateGroup.Location = new Point(12, 668);
            btnCreateGroup.Margin = new Padding(3, 4, 3, 4);
            btnCreateGroup.Name = "btnCreateGroup";
            btnCreateGroup.Size = new Size(174, 39);
            btnCreateGroup.TabIndex = 5;
            btnCreateGroup.Text = "Create Group";
            btnCreateGroup.UseVisualStyleBackColor = false;
            btnCreateGroup.Click += btnCreateGroup_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightCoral;
            button1.Location = new Point(801, 8);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 39);
            button1.TabIndex = 29;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(451, 620);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            pictureBox6.Click += btnDevil_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(394, 620);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 51;
            pictureBox7.TabStop = false;
            pictureBox7.Click += btnCry_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(337, 620);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(34, 40);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 52;
            pictureBox8.TabStop = false;
            pictureBox8.Click += btnLaugh_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(280, 620);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(34, 40);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 53;
            pictureBox9.TabStop = false;
            pictureBox9.Click += btnLove_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Cursor = Cursors.Hand;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(223, 620);
            pictureBox10.Margin = new Padding(3, 4, 3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(34, 40);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 54;
            pictureBox10.TabStop = false;
            pictureBox10.Click += btnLike_Click;
            // 
            // ChatBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 716);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox10);
            Controls.Add(button1);
            Controls.Add(btnCreateGroup);
            Controls.Add(lblWelcome);
            Controls.Add(txtReceiver);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Controls.Add(btnPicture);
            Controls.Add(rtbDialog);
            Controls.Add(tblGroup);
            Controls.Add(tblUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChatBox";
            Text = "ChatBox";
            FormClosing += ChatBox_FormClosing;
            Load += ChatBox_Load;
            ((System.ComponentModel.ISupportInitialize)tblUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSend).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblUser;
        private DataGridView tblGroup;
        private RichTextBox rtbDialog;
        private PictureBox btnPicture;
        private TextBox txtMessage;
        private PictureBox btnSend;
        private Label lblWelcome;
        private TextBox txtReceiver;
        private Button btnCreateGroup;
        private Button button1;
        private DataGridViewButtonColumn Online;
        private DataGridViewButtonColumn Group;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
    }
}