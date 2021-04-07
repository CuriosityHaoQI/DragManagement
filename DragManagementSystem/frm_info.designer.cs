namespace DragManagementSystem
{
    partial class frm_info
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
            this.pcb_Picture = new System.Windows.Forms.PictureBox();
            this.lbl_pic = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.rdb_Boy = new System.Windows.Forms.RadioButton();
            this.rdb_Girl = new System.Windows.Forms.RadioButton();
            this.dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_Picture
            // 
            this.pcb_Picture.Location = new System.Drawing.Point(73, 60);
            this.pcb_Picture.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pcb_Picture.Name = "pcb_Picture";
            this.pcb_Picture.Size = new System.Drawing.Size(600, 600);
            this.pcb_Picture.TabIndex = 0;
            this.pcb_Picture.TabStop = false;
            // 
            // lbl_pic
            // 
            this.lbl_pic.AutoSize = true;
            this.lbl_pic.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pic.Location = new System.Drawing.Point(271, 689);
            this.lbl_pic.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_pic.Name = "lbl_pic";
            this.lbl_pic.Size = new System.Drawing.Size(226, 50);
            this.lbl_pic.TabIndex = 1;
            this.lbl_pic.Text = "个人照片";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(730, 122);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(175, 50);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "姓名：";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_No.Location = new System.Drawing.Point(730, 232);
            this.lbl_No.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(175, 50);
            this.lbl_No.TabIndex = 3;
            this.lbl_No.Text = "编号：";
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Name.Location = new System.Drawing.Point(925, 122);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(416, 65);
            this.txb_Name.TabIndex = 4;
            // 
            // txb_No
            // 
            this.txb_No.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_No.Location = new System.Drawing.Point(925, 225);
            this.txb_No.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(416, 65);
            this.txb_No.TabIndex = 5;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Gender.Location = new System.Drawing.Point(730, 350);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(175, 50);
            this.lbl_Gender.TabIndex = 6;
            this.lbl_Gender.Text = "性别：";
            // 
            // rdb_Boy
            // 
            this.rdb_Boy.AutoSize = true;
            this.rdb_Boy.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Boy.Location = new System.Drawing.Point(925, 350);
            this.rdb_Boy.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rdb_Boy.Name = "rdb_Boy";
            this.rdb_Boy.Size = new System.Drawing.Size(109, 54);
            this.rdb_Boy.TabIndex = 7;
            this.rdb_Boy.TabStop = true;
            this.rdb_Boy.Text = "男";
            this.rdb_Boy.UseVisualStyleBackColor = true;
            // 
            // rdb_Girl
            // 
            this.rdb_Girl.AutoSize = true;
            this.rdb_Girl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Girl.Location = new System.Drawing.Point(1092, 350);
            this.rdb_Girl.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rdb_Girl.Name = "rdb_Girl";
            this.rdb_Girl.Size = new System.Drawing.Size(109, 54);
            this.rdb_Girl.TabIndex = 8;
            this.rdb_Girl.TabStop = true;
            this.rdb_Girl.Text = "女";
            this.rdb_Girl.UseVisualStyleBackColor = true;
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_Birthday.Location = new System.Drawing.Point(925, 452);
            this.dtp_Birthday.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(416, 67);
            this.dtp_Birthday.TabIndex = 9;
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Birthday.Location = new System.Drawing.Point(730, 472);
            this.lbl_Birthday.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(175, 50);
            this.lbl_Birthday.TabIndex = 10;
            this.lbl_Birthday.Text = "生日：";
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Update.Location = new System.Drawing.Point(819, 599);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(215, 84);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Back.Location = new System.Drawing.Point(1092, 599);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(194, 84);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "返回";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Upload.Location = new System.Drawing.Point(215, 776);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(318, 84);
            this.btn_Upload.TabIndex = 13;
            this.btn_Upload.Text = "上传个人照片";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // frm_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 1125);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.dtp_Birthday);
            this.Controls.Add(this.rdb_Girl);
            this.Controls.Add(this.rdb_Boy);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.txb_No);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_pic);
            this.Controls.Add(this.pcb_Picture);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "frm_info";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.frm_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Picture;
        private System.Windows.Forms.Label lbl_pic;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.RadioButton rdb_Boy;
        private System.Windows.Forms.RadioButton rdb_Girl;
        private System.Windows.Forms.DateTimePicker dtp_Birthday;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Upload;
    }
}