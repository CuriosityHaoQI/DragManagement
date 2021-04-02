namespace DragManagementSystem
{
    partial class frm_ProjectSelect
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
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_Info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(60, 25);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(133, 30);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "用户信息";
            // 
            // btn_Info
            // 
            this.btn_Info.Location = new System.Drawing.Point(51, 76);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(152, 51);
            this.btn_Info.TabIndex = 1;
            this.btn_Info.Text = "个人中心";
            this.btn_Info.UseVisualStyleBackColor = true;
            // 
            // frm_ProjectSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 990);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "frm_ProjectSelect";
            this.Text = "                  ";
            this.Load += new System.EventHandler(this.frm_ProjectSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_Info;
    }
}