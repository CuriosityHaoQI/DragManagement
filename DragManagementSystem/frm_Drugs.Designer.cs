namespace DragManagementSystem
{
    partial class frm_Drugs
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
            this.trv_Drugs = new System.Windows.Forms.TreeView();
            this.dgv_Drugs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drugs)).BeginInit();
            this.SuspendLayout();
            // 
            // trv_Drugs
            // 
            this.trv_Drugs.Location = new System.Drawing.Point(110, 184);
            this.trv_Drugs.Name = "trv_Drugs";
            this.trv_Drugs.Size = new System.Drawing.Size(508, 597);
            this.trv_Drugs.TabIndex = 0;
            this.trv_Drugs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_Drugs_AfterSelect);
            // 
            // dgv_Drugs
            // 
            this.dgv_Drugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drugs.Location = new System.Drawing.Point(702, 184);
            this.dgv_Drugs.Name = "dgv_Drugs";
            this.dgv_Drugs.RowTemplate.Height = 44;
            this.dgv_Drugs.Size = new System.Drawing.Size(557, 603);
            this.dgv_Drugs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(475, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "药品查询";
            // 
            // frm_Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 932);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Drugs);
            this.Controls.Add(this.trv_Drugs);
            this.Name = "frm_Drugs";
            this.Text = "药品查询";
            this.Load += new System.EventHandler(this.frm_Drugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trv_Drugs;
        private System.Windows.Forms.DataGridView dgv_Drugs;
        private System.Windows.Forms.Label label1;
    }
}