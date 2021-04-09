namespace DragManagementSystem
{
    partial class frm_Repertory
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
            this.gpb_Repertory = new System.Windows.Forms.GroupBox();
            this.btn_Cardinal = new System.Windows.Forms.Button();
            this.gpb_Repertory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Repertory
            // 
            this.gpb_Repertory.Controls.Add(this.btn_Cardinal);
            this.gpb_Repertory.Location = new System.Drawing.Point(39, 33);
            this.gpb_Repertory.Name = "gpb_Repertory";
            this.gpb_Repertory.Size = new System.Drawing.Size(242, 634);
            this.gpb_Repertory.TabIndex = 0;
            this.gpb_Repertory.TabStop = false;
            this.gpb_Repertory.Text = "库存查询";
            // 
            // btn_Cardinal
            // 
            this.btn_Cardinal.Location = new System.Drawing.Point(6, 41);
            this.btn_Cardinal.Name = "btn_Cardinal";
            this.btn_Cardinal.Size = new System.Drawing.Size(230, 72);
            this.btn_Cardinal.TabIndex = 0;
            this.btn_Cardinal.Text = "库存基数预警";
            this.btn_Cardinal.UseVisualStyleBackColor = true;
            this.btn_Cardinal.Click += new System.EventHandler(this.btn_Cardinal_Click);
            // 
            // frm_Repertory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 690);
            this.Controls.Add(this.gpb_Repertory);
            this.Name = "frm_Repertory";
            this.Text = "库存查询";
            this.gpb_Repertory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Repertory;
        private System.Windows.Forms.Button btn_Cardinal;
    }
}