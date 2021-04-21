namespace DragManagementSystem
{
    partial class frm_LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_UserNo = new System.Windows.Forms.TextBox();
            this.lbl_LogIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(397, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 73);
            this.label1.TabIndex = 13;
            this.label1.Text = "药物管理系统";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("华文行楷", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SignUp.Location = new System.Drawing.Point(647, 536);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(171, 68);
            this.btn_SignUp.TabIndex = 12;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("华文行楷", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LogIn.Location = new System.Drawing.Point(410, 536);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(155, 68);
            this.btn_LogIn.TabIndex = 11;
            this.btn_LogIn.Text = "登陆";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_Password.Location = new System.Drawing.Point(306, 389);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(182, 53);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "密码：";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Password.Location = new System.Drawing.Point(516, 374);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(376, 68);
            this.txb_Password.TabIndex = 9;
            // 
            // txb_UserNo
            // 
            this.txb_UserNo.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_UserNo.Location = new System.Drawing.Point(516, 244);
            this.txb_UserNo.Name = "txb_UserNo";
            this.txb_UserNo.Size = new System.Drawing.Size(376, 68);
            this.txb_UserNo.TabIndex = 8;
            this.txb_UserNo.TextChanged += new System.EventHandler(this.txb_UserNo_TextChanged);
            // 
            // lbl_LogIn
            // 
            this.lbl_LogIn.AutoSize = true;
            this.lbl_LogIn.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_LogIn.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_LogIn.Location = new System.Drawing.Point(306, 247);
            this.lbl_LogIn.Name = "lbl_LogIn";
            this.lbl_LogIn.Size = new System.Drawing.Size(182, 53);
            this.lbl_LogIn.TabIndex = 7;
            this.lbl_LogIn.Text = "账号：";
            // 
            // frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 723);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_UserNo);
            this.Controls.Add(this.lbl_LogIn);
            this.Name = "frm_LogIn";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.frm_LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_UserNo;
        private System.Windows.Forms.Label lbl_LogIn;
    }
}