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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpb_Repertory = new System.Windows.Forms.GroupBox();
            this.btn_Validity = new System.Windows.Forms.Button();
            this.btn_UpperLimit = new System.Windows.Forms.Button();
            this.btn_LowerLimit = new System.Windows.Forms.Button();
            this.btn_Cardinal = new System.Windows.Forms.Button();
            this.gpb_Cardinal = new System.Windows.Forms.GroupBox();
            this.gdv_DrugCardinal = new System.Windows.Forms.DataGridView();
            this.gdb_Validity = new System.Windows.Forms.GroupBox();
            this.lbl_deadline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Validity = new System.Windows.Forms.DateTimePicker();
            this.dgv_Validity = new System.Windows.Forms.DataGridView();
            this.btn_Outbase = new System.Windows.Forms.Button();
            this.dtp_outbase = new System.Windows.Forms.DateTimePicker();
            this.gpb_Repertory.SuspendLayout();
            this.gpb_Cardinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_DrugCardinal)).BeginInit();
            this.gdb_Validity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Validity)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_Repertory
            // 
            this.gpb_Repertory.Controls.Add(this.btn_Outbase);
            this.gpb_Repertory.Controls.Add(this.btn_Validity);
            this.gpb_Repertory.Controls.Add(this.btn_UpperLimit);
            this.gpb_Repertory.Controls.Add(this.btn_LowerLimit);
            this.gpb_Repertory.Controls.Add(this.btn_Cardinal);
            this.gpb_Repertory.Location = new System.Drawing.Point(40, 32);
            this.gpb_Repertory.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_Repertory.Name = "gpb_Repertory";
            this.gpb_Repertory.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_Repertory.Size = new System.Drawing.Size(242, 635);
            this.gpb_Repertory.TabIndex = 0;
            this.gpb_Repertory.TabStop = false;
            this.gpb_Repertory.Text = "库存查询";
            // 
            // btn_Validity
            // 
            this.btn_Validity.Location = new System.Drawing.Point(5, 320);
            this.btn_Validity.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Validity.Name = "btn_Validity";
            this.btn_Validity.Size = new System.Drawing.Size(230, 72);
            this.btn_Validity.TabIndex = 3;
            this.btn_Validity.Text = "有效期管理";
            this.btn_Validity.UseVisualStyleBackColor = true;
            this.btn_Validity.Click += new System.EventHandler(this.btn_Validity_Click);
            // 
            // btn_UpperLimit
            // 
            this.btn_UpperLimit.Location = new System.Drawing.Point(5, 222);
            this.btn_UpperLimit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpperLimit.Name = "btn_UpperLimit";
            this.btn_UpperLimit.Size = new System.Drawing.Size(230, 72);
            this.btn_UpperLimit.TabIndex = 2;
            this.btn_UpperLimit.Text = "库存上限预警";
            this.btn_UpperLimit.UseVisualStyleBackColor = true;
            this.btn_UpperLimit.Click += new System.EventHandler(this.btn_UpperLimit_Click);
            // 
            // btn_LowerLimit
            // 
            this.btn_LowerLimit.Location = new System.Drawing.Point(4, 129);
            this.btn_LowerLimit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LowerLimit.Name = "btn_LowerLimit";
            this.btn_LowerLimit.Size = new System.Drawing.Size(230, 72);
            this.btn_LowerLimit.TabIndex = 1;
            this.btn_LowerLimit.Text = "库存下限预警";
            this.btn_LowerLimit.UseVisualStyleBackColor = true;
            this.btn_LowerLimit.Click += new System.EventHandler(this.btn_LowerLimit_Click);
            // 
            // btn_Cardinal
            // 
            this.btn_Cardinal.Location = new System.Drawing.Point(5, 40);
            this.btn_Cardinal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cardinal.Name = "btn_Cardinal";
            this.btn_Cardinal.Size = new System.Drawing.Size(230, 72);
            this.btn_Cardinal.TabIndex = 0;
            this.btn_Cardinal.Text = "库存基数预警";
            this.btn_Cardinal.UseVisualStyleBackColor = true;
            this.btn_Cardinal.Click += new System.EventHandler(this.btn_Cardinal_Click);
            // 
            // gpb_Cardinal
            // 
            this.gpb_Cardinal.Controls.Add(this.gdv_DrugCardinal);
            this.gpb_Cardinal.Location = new System.Drawing.Point(308, 72);
            this.gpb_Cardinal.Margin = new System.Windows.Forms.Padding(8);
            this.gpb_Cardinal.Name = "gpb_Cardinal";
            this.gpb_Cardinal.Padding = new System.Windows.Forms.Padding(8);
            this.gpb_Cardinal.Size = new System.Drawing.Size(1447, 588);
            this.gpb_Cardinal.TabIndex = 1;
            this.gpb_Cardinal.TabStop = false;
            this.gpb_Cardinal.Text = "库存预警";
            // 
            // gdv_DrugCardinal
            // 
            this.gdv_DrugCardinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdv_DrugCardinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gdv_DrugCardinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdv_DrugCardinal.DefaultCellStyle = dataGridViewCellStyle6;
            this.gdv_DrugCardinal.Location = new System.Drawing.Point(15, 71);
            this.gdv_DrugCardinal.Margin = new System.Windows.Forms.Padding(8);
            this.gdv_DrugCardinal.Name = "gdv_DrugCardinal";
            this.gdv_DrugCardinal.RowTemplate.Height = 23;
            this.gdv_DrugCardinal.Size = new System.Drawing.Size(1392, 501);
            this.gdv_DrugCardinal.TabIndex = 0;
            // 
            // gdb_Validity
            // 
            this.gdb_Validity.Controls.Add(this.dtp_outbase);
            this.gdb_Validity.Controls.Add(this.dgv_Validity);
            this.gdb_Validity.Controls.Add(this.lbl_deadline);
            this.gdb_Validity.Controls.Add(this.label1);
            this.gdb_Validity.Controls.Add(this.dtp_Validity);
            this.gdb_Validity.Location = new System.Drawing.Point(319, 32);
            this.gdb_Validity.Name = "gdb_Validity";
            this.gdb_Validity.Size = new System.Drawing.Size(1484, 669);
            this.gdb_Validity.TabIndex = 1;
            this.gdb_Validity.TabStop = false;
            this.gdb_Validity.Text = "有效期管理";
            // 
            // lbl_deadline
            // 
            this.lbl_deadline.AutoSize = true;
            this.lbl_deadline.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_deadline.Location = new System.Drawing.Point(841, 57);
            this.lbl_deadline.Name = "lbl_deadline";
            this.lbl_deadline.Size = new System.Drawing.Size(422, 50);
            this.lbl_deadline.TabIndex = 2;
            this.lbl_deadline.Text = "超过有效期的药品";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(250, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "截止到";
            // 
            // dtp_Validity
            // 
            this.dtp_Validity.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_Validity.Location = new System.Drawing.Point(443, 53);
            this.dtp_Validity.Name = "dtp_Validity";
            this.dtp_Validity.Size = new System.Drawing.Size(375, 68);
            this.dtp_Validity.TabIndex = 0;
            this.dtp_Validity.ValueChanged += new System.EventHandler(this.dtp_Validity_ValueChanged);
            // 
            // dgv_Validity
            // 
            this.dgv_Validity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Validity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Validity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Validity.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Validity.Location = new System.Drawing.Point(24, 138);
            this.dgv_Validity.Name = "dgv_Validity";
            this.dgv_Validity.RowTemplate.Height = 44;
            this.dgv_Validity.Size = new System.Drawing.Size(1442, 507);
            this.dgv_Validity.TabIndex = 3;
            // 
            // btn_Outbase
            // 
            this.btn_Outbase.Location = new System.Drawing.Point(4, 424);
            this.btn_Outbase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Outbase.Name = "btn_Outbase";
            this.btn_Outbase.Size = new System.Drawing.Size(230, 72);
            this.btn_Outbase.TabIndex = 4;
            this.btn_Outbase.Text = "滞留药品管理";
            this.btn_Outbase.UseVisualStyleBackColor = true;
            this.btn_Outbase.Click += new System.EventHandler(this.btn_Outbase_Click);
            // 
            // dtp_outbase
            // 
            this.dtp_outbase.Font = new System.Drawing.Font("宋体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_outbase.Location = new System.Drawing.Point(443, 53);
            this.dtp_outbase.Name = "dtp_outbase";
            this.dtp_outbase.Size = new System.Drawing.Size(375, 68);
            this.dtp_outbase.TabIndex = 4;
            this.dtp_outbase.ValueChanged += new System.EventHandler(this.dtp_outbase_ValueChanged);
            // 
            // frm_Repertory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1948, 702);
            this.Controls.Add(this.gdb_Validity);
            this.Controls.Add(this.gpb_Cardinal);
            this.Controls.Add(this.gpb_Repertory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Repertory";
            this.Text = "库存查询";
            this.Load += new System.EventHandler(this.frm_Repertory_Load);
            this.gpb_Repertory.ResumeLayout(false);
            this.gpb_Cardinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_DrugCardinal)).EndInit();
            this.gdb_Validity.ResumeLayout(false);
            this.gdb_Validity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Validity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Repertory;
        private System.Windows.Forms.Button btn_Cardinal;
        private System.Windows.Forms.GroupBox gpb_Cardinal;
        private System.Windows.Forms.DataGridView gdv_DrugCardinal;
        private System.Windows.Forms.Button btn_LowerLimit;
        private System.Windows.Forms.Button btn_UpperLimit;
        private System.Windows.Forms.GroupBox gdb_Validity;
        private System.Windows.Forms.Label lbl_deadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Validity;
        private System.Windows.Forms.Button btn_Validity;
        private System.Windows.Forms.DataGridView dgv_Validity;
        private System.Windows.Forms.Button btn_Outbase;
        private System.Windows.Forms.DateTimePicker dtp_outbase;
    }
}