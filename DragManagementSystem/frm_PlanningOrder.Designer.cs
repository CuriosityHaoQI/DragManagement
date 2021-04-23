namespace DragManagementSystem
{
    partial class frm_PlanningOrder
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
            this.lbl_Sort = new System.Windows.Forms.Label();
            this.cmb_Drugtype = new System.Windows.Forms.ComboBox();
            this.btn_MakingOrder = new System.Windows.Forms.Button();
            this.gpb_MakingOrder = new System.Windows.Forms.GroupBox();
            this.txb_DrugName = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txb_MemoryCode = new System.Windows.Forms.TextBox();
            this.lbl_MemoryCode = new System.Windows.Forms.Label();
            this.cmb_Payment = new System.Windows.Forms.ComboBox();
            this.lbl_Payment = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txb_DrugAmount = new System.Windows.Forms.TextBox();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.lbl_PurchasePrice = new System.Windows.Forms.Label();
            this.lbl_DrugAmount = new System.Windows.Forms.Label();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OrderInquire = new System.Windows.Forms.Button();
            this.gpb_MakingOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Sort
            // 
            this.lbl_Sort.AutoSize = true;
            this.lbl_Sort.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Sort.Location = new System.Drawing.Point(27, 64);
            this.lbl_Sort.Name = "lbl_Sort";
            this.lbl_Sort.Size = new System.Drawing.Size(266, 53);
            this.lbl_Sort.TabIndex = 0;
            this.lbl_Sort.Text = "药品类别:";
            // 
            // cmb_Drugtype
            // 
            this.cmb_Drugtype.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Drugtype.FormattingEnabled = true;
            this.cmb_Drugtype.Location = new System.Drawing.Point(299, 74);
            this.cmb_Drugtype.Name = "cmb_Drugtype";
            this.cmb_Drugtype.Size = new System.Drawing.Size(150, 43);
            this.cmb_Drugtype.TabIndex = 1;
            this.cmb_Drugtype.Text = " ";
            // 
            // btn_MakingOrder
            // 
            this.btn_MakingOrder.Font = new System.Drawing.Font("楷体", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MakingOrder.Location = new System.Drawing.Point(38, 12);
            this.btn_MakingOrder.Name = "btn_MakingOrder";
            this.btn_MakingOrder.Size = new System.Drawing.Size(257, 96);
            this.btn_MakingOrder.TabIndex = 2;
            this.btn_MakingOrder.Text = "计划订单";
            this.btn_MakingOrder.UseVisualStyleBackColor = true;
            this.btn_MakingOrder.Click += new System.EventHandler(this.btn_MakingOrder_Click);
            // 
            // gpb_MakingOrder
            // 
            this.gpb_MakingOrder.Controls.Add(this.txb_DrugName);
            this.gpb_MakingOrder.Controls.Add(this.btn_Submit);
            this.gpb_MakingOrder.Controls.Add(this.txb_MemoryCode);
            this.gpb_MakingOrder.Controls.Add(this.lbl_MemoryCode);
            this.gpb_MakingOrder.Controls.Add(this.cmb_Payment);
            this.gpb_MakingOrder.Controls.Add(this.lbl_Payment);
            this.gpb_MakingOrder.Controls.Add(this.lbl_date);
            this.gpb_MakingOrder.Controls.Add(this.dtp_Date);
            this.gpb_MakingOrder.Controls.Add(this.txb_DrugAmount);
            this.gpb_MakingOrder.Controls.Add(this.txb_Price);
            this.gpb_MakingOrder.Controls.Add(this.lbl_PurchasePrice);
            this.gpb_MakingOrder.Controls.Add(this.lbl_DrugAmount);
            this.gpb_MakingOrder.Controls.Add(this.cmb_Supplier);
            this.gpb_MakingOrder.Controls.Add(this.lbl_Supplier);
            this.gpb_MakingOrder.Controls.Add(this.label1);
            this.gpb_MakingOrder.Controls.Add(this.lbl_Sort);
            this.gpb_MakingOrder.Controls.Add(this.cmb_Drugtype);
            this.gpb_MakingOrder.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpb_MakingOrder.Location = new System.Drawing.Point(38, 131);
            this.gpb_MakingOrder.Name = "gpb_MakingOrder";
            this.gpb_MakingOrder.Size = new System.Drawing.Size(1894, 625);
            this.gpb_MakingOrder.TabIndex = 3;
            this.gpb_MakingOrder.TabStop = false;
            // 
            // txb_DrugName
            // 
            this.txb_DrugName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_DrugName.Location = new System.Drawing.Point(764, 70);
            this.txb_DrugName.Name = "txb_DrugName";
            this.txb_DrugName.Size = new System.Drawing.Size(289, 47);
            this.txb_DrugName.TabIndex = 18;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(746, 428);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(257, 61);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txb_MemoryCode
            // 
            this.txb_MemoryCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_MemoryCode.Location = new System.Drawing.Point(245, 272);
            this.txb_MemoryCode.Name = "txb_MemoryCode";
            this.txb_MemoryCode.Size = new System.Drawing.Size(204, 47);
            this.txb_MemoryCode.TabIndex = 16;
            this.txb_MemoryCode.Text = " ";
            // 
            // lbl_MemoryCode
            // 
            this.lbl_MemoryCode.AutoSize = true;
            this.lbl_MemoryCode.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MemoryCode.Location = new System.Drawing.Point(27, 266);
            this.lbl_MemoryCode.Name = "lbl_MemoryCode";
            this.lbl_MemoryCode.Size = new System.Drawing.Size(212, 53);
            this.lbl_MemoryCode.TabIndex = 15;
            this.lbl_MemoryCode.Text = "助记码:";
            // 
            // cmb_Payment
            // 
            this.cmb_Payment.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Payment.FormattingEnabled = true;
            this.cmb_Payment.Location = new System.Drawing.Point(299, 176);
            this.cmb_Payment.Name = "cmb_Payment";
            this.cmb_Payment.Size = new System.Drawing.Size(150, 43);
            this.cmb_Payment.TabIndex = 14;
            this.cmb_Payment.Text = " ";
            // 
            // lbl_Payment
            // 
            this.lbl_Payment.AutoSize = true;
            this.lbl_Payment.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Payment.Location = new System.Drawing.Point(27, 163);
            this.lbl_Payment.Name = "lbl_Payment";
            this.lbl_Payment.Size = new System.Drawing.Size(266, 53);
            this.lbl_Payment.TabIndex = 13;
            this.lbl_Payment.Text = "支付方式:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_date.Location = new System.Drawing.Point(492, 266);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(266, 53);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "订单日期:";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(764, 274);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(341, 65);
            this.dtp_Date.TabIndex = 11;
            // 
            // txb_DrugAmount
            // 
            this.txb_DrugAmount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_DrugAmount.Location = new System.Drawing.Point(764, 166);
            this.txb_DrugAmount.Name = "txb_DrugAmount";
            this.txb_DrugAmount.Size = new System.Drawing.Size(289, 47);
            this.txb_DrugAmount.TabIndex = 10;
            // 
            // txb_Price
            // 
            this.txb_Price.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Price.Location = new System.Drawing.Point(1301, 80);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(144, 47);
            this.txb_Price.TabIndex = 9;
            // 
            // lbl_PurchasePrice
            // 
            this.lbl_PurchasePrice.AutoSize = true;
            this.lbl_PurchasePrice.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PurchasePrice.Location = new System.Drawing.Point(1137, 74);
            this.lbl_PurchasePrice.Name = "lbl_PurchasePrice";
            this.lbl_PurchasePrice.Size = new System.Drawing.Size(158, 53);
            this.lbl_PurchasePrice.TabIndex = 8;
            this.lbl_PurchasePrice.Text = "单价:";
            // 
            // lbl_DrugAmount
            // 
            this.lbl_DrugAmount.AutoSize = true;
            this.lbl_DrugAmount.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DrugAmount.Location = new System.Drawing.Point(492, 163);
            this.lbl_DrugAmount.Name = "lbl_DrugAmount";
            this.lbl_DrugAmount.Size = new System.Drawing.Size(266, 53);
            this.lbl_DrugAmount.TabIndex = 6;
            this.lbl_DrugAmount.Text = "药品数量:";
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(1301, 163);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(473, 43);
            this.cmb_Supplier.TabIndex = 4;
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Supplier.Location = new System.Drawing.Point(1094, 153);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(212, 53);
            this.lbl_Supplier.TabIndex = 3;
            this.lbl_Supplier.Text = "供应商:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(492, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "药品名称:";
            // 
            // btn_OrderInquire
            // 
            this.btn_OrderInquire.Font = new System.Drawing.Font("楷体", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OrderInquire.Location = new System.Drawing.Point(322, 12);
            this.btn_OrderInquire.Name = "btn_OrderInquire";
            this.btn_OrderInquire.Size = new System.Drawing.Size(257, 96);
            this.btn_OrderInquire.TabIndex = 4;
            this.btn_OrderInquire.Text = "订单查询";
            this.btn_OrderInquire.UseVisualStyleBackColor = true;
            // 
            // frm_PlanningOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1944, 857);
            this.Controls.Add(this.btn_OrderInquire);
            this.Controls.Add(this.gpb_MakingOrder);
            this.Controls.Add(this.btn_MakingOrder);
            this.Name = "frm_PlanningOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计划订单";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_PlanningOrder_FormClosed);
            this.Load += new System.EventHandler(this.frm_PlanningOrder_Load);
            this.gpb_MakingOrder.ResumeLayout(false);
            this.gpb_MakingOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sort;
        private System.Windows.Forms.ComboBox cmb_Drugtype;
        private System.Windows.Forms.Button btn_MakingOrder;
        private System.Windows.Forms.GroupBox gpb_MakingOrder;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox txb_DrugAmount;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Label lbl_PurchasePrice;
        private System.Windows.Forms.Label lbl_DrugAmount;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Payment;
        private System.Windows.Forms.Label lbl_Payment;
        private System.Windows.Forms.TextBox txb_MemoryCode;
        private System.Windows.Forms.Label lbl_MemoryCode;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_OrderInquire;
        private System.Windows.Forms.TextBox txb_DrugName;
    }
}