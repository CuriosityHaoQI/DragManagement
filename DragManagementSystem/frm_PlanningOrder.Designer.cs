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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Sort = new System.Windows.Forms.Label();
            this.cmb_Drugtype = new System.Windows.Forms.ComboBox();
            this.btn_MakingOrder = new System.Windows.Forms.Button();
            this.gpb_MakingOrder = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_DrugMemoryCode = new System.Windows.Forms.TextBox();
            this.cmb_Drug = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txb_OrderMemoryCode = new System.Windows.Forms.TextBox();
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
            this.gpb_Orderinquire = new System.Windows.Forms.GroupBox();
            this.btn_OrderChangeSubmit = new System.Windows.Forms.Button();
            this.btn_UnEnterRepertory = new System.Windows.Forms.Button();
            this.btn_HasEnterRepertory = new System.Windows.Forms.Button();
            this.lbl_HasEnter = new System.Windows.Forms.Label();
            this.dgv_HasEnter = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gpb_MakingOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpb_Orderinquire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HasEnter)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Sort
            // 
            this.lbl_Sort.AutoSize = true;
            this.lbl_Sort.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Sort.Location = new System.Drawing.Point(16, 191);
            this.lbl_Sort.Name = "lbl_Sort";
            this.lbl_Sort.Size = new System.Drawing.Size(266, 53);
            this.lbl_Sort.TabIndex = 0;
            this.lbl_Sort.Text = "药品类别:";
            // 
            // cmb_Drugtype
            // 
            this.cmb_Drugtype.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Drugtype.FormattingEnabled = true;
            this.cmb_Drugtype.Location = new System.Drawing.Point(299, 191);
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
            this.gpb_MakingOrder.Controls.Add(this.groupBox1);
            this.gpb_MakingOrder.Controls.Add(this.cmb_Drug);
            this.gpb_MakingOrder.Controls.Add(this.btn_Submit);
            this.gpb_MakingOrder.Controls.Add(this.txb_OrderMemoryCode);
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
            this.gpb_MakingOrder.Size = new System.Drawing.Size(2072, 625);
            this.gpb_MakingOrder.TabIndex = 3;
            this.gpb_MakingOrder.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Find);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_DrugMemoryCode);
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1809, 93);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Find.Location = new System.Drawing.Point(683, 40);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(161, 47);
            this.btn_Find.TabIndex = 21;
            this.btn_Find.Text = "查找";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(-9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 53);
            this.label2.TabIndex = 19;
            this.label2.Text = "药品助记码:";
            // 
            // txb_DrugMemoryCode
            // 
            this.txb_DrugMemoryCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_DrugMemoryCode.Location = new System.Drawing.Point(325, 40);
            this.txb_DrugMemoryCode.Name = "txb_DrugMemoryCode";
            this.txb_DrugMemoryCode.Size = new System.Drawing.Size(307, 47);
            this.txb_DrugMemoryCode.TabIndex = 20;
            this.txb_DrugMemoryCode.Text = " ";
            // 
            // cmb_Drug
            // 
            this.cmb_Drug.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Drug.FormattingEnabled = true;
            this.cmb_Drug.Location = new System.Drawing.Point(764, 191);
            this.cmb_Drug.Name = "cmb_Drug";
            this.cmb_Drug.Size = new System.Drawing.Size(341, 43);
            this.cmb_Drug.TabIndex = 21;
            this.cmb_Drug.Text = " ";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(859, 505);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(367, 102);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txb_OrderMemoryCode
            // 
            this.txb_OrderMemoryCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_OrderMemoryCode.Location = new System.Drawing.Point(1495, 304);
            this.txb_OrderMemoryCode.Name = "txb_OrderMemoryCode";
            this.txb_OrderMemoryCode.Size = new System.Drawing.Size(367, 47);
            this.txb_OrderMemoryCode.TabIndex = 16;
            this.txb_OrderMemoryCode.Text = " ";
            // 
            // lbl_MemoryCode
            // 
            this.lbl_MemoryCode.AutoSize = true;
            this.lbl_MemoryCode.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MemoryCode.Location = new System.Drawing.Point(1181, 297);
            this.lbl_MemoryCode.Name = "lbl_MemoryCode";
            this.lbl_MemoryCode.Size = new System.Drawing.Size(320, 53);
            this.lbl_MemoryCode.TabIndex = 15;
            this.lbl_MemoryCode.Text = "订单助记码:";
            // 
            // cmb_Payment
            // 
            this.cmb_Payment.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Payment.FormattingEnabled = true;
            this.cmb_Payment.Location = new System.Drawing.Point(299, 304);
            this.cmb_Payment.Name = "cmb_Payment";
            this.cmb_Payment.Size = new System.Drawing.Size(150, 43);
            this.cmb_Payment.TabIndex = 14;
            this.cmb_Payment.Text = " ";
            // 
            // lbl_Payment
            // 
            this.lbl_Payment.AutoSize = true;
            this.lbl_Payment.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Payment.Location = new System.Drawing.Point(16, 304);
            this.lbl_Payment.Name = "lbl_Payment";
            this.lbl_Payment.Size = new System.Drawing.Size(266, 53);
            this.lbl_Payment.TabIndex = 13;
            this.lbl_Payment.Text = "支付方式:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_date.Location = new System.Drawing.Point(502, 422);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(266, 53);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "订单日期:";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(764, 416);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(341, 65);
            this.dtp_Date.TabIndex = 11;
            // 
            // txb_DrugAmount
            // 
            this.txb_DrugAmount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_DrugAmount.Location = new System.Drawing.Point(764, 310);
            this.txb_DrugAmount.Name = "txb_DrugAmount";
            this.txb_DrugAmount.Size = new System.Drawing.Size(341, 47);
            this.txb_DrugAmount.TabIndex = 10;
            // 
            // txb_Price
            // 
            this.txb_Price.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Price.Location = new System.Drawing.Point(299, 428);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(150, 47);
            this.txb_Price.TabIndex = 9;
            // 
            // lbl_PurchasePrice
            // 
            this.lbl_PurchasePrice.AutoSize = true;
            this.lbl_PurchasePrice.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PurchasePrice.Location = new System.Drawing.Point(16, 428);
            this.lbl_PurchasePrice.Name = "lbl_PurchasePrice";
            this.lbl_PurchasePrice.Size = new System.Drawing.Size(266, 53);
            this.lbl_PurchasePrice.TabIndex = 8;
            this.lbl_PurchasePrice.Text = "药品单价:";
            // 
            // lbl_DrugAmount
            // 
            this.lbl_DrugAmount.AutoSize = true;
            this.lbl_DrugAmount.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DrugAmount.Location = new System.Drawing.Point(502, 304);
            this.lbl_DrugAmount.Name = "lbl_DrugAmount";
            this.lbl_DrugAmount.Size = new System.Drawing.Size(266, 53);
            this.lbl_DrugAmount.TabIndex = 6;
            this.lbl_DrugAmount.Text = "药品数量:";
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(1389, 201);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(473, 43);
            this.cmb_Supplier.TabIndex = 4;
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Supplier.Location = new System.Drawing.Point(1181, 191);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(212, 53);
            this.lbl_Supplier.TabIndex = 3;
            this.lbl_Supplier.Text = "供应商:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(502, 191);
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
            this.btn_OrderInquire.Click += new System.EventHandler(this.btn_OrderInquire_Click);
            // 
            // gpb_Orderinquire
            // 
            this.gpb_Orderinquire.Controls.Add(this.button1);
            this.gpb_Orderinquire.Controls.Add(this.btn_OrderChangeSubmit);
            this.gpb_Orderinquire.Controls.Add(this.btn_UnEnterRepertory);
            this.gpb_Orderinquire.Controls.Add(this.btn_HasEnterRepertory);
            this.gpb_Orderinquire.Controls.Add(this.lbl_HasEnter);
            this.gpb_Orderinquire.Controls.Add(this.dgv_HasEnter);
            this.gpb_Orderinquire.Location = new System.Drawing.Point(38, 131);
            this.gpb_Orderinquire.Name = "gpb_Orderinquire";
            this.gpb_Orderinquire.Size = new System.Drawing.Size(1978, 942);
            this.gpb_Orderinquire.TabIndex = 5;
            this.gpb_Orderinquire.TabStop = false;
            this.gpb_Orderinquire.Text = " ";
            // 
            // btn_OrderChangeSubmit
            // 
            this.btn_OrderChangeSubmit.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OrderChangeSubmit.ForeColor = System.Drawing.Color.Red;
            this.btn_OrderChangeSubmit.Location = new System.Drawing.Point(653, 858);
            this.btn_OrderChangeSubmit.Name = "btn_OrderChangeSubmit";
            this.btn_OrderChangeSubmit.Size = new System.Drawing.Size(313, 68);
            this.btn_OrderChangeSubmit.TabIndex = 5;
            this.btn_OrderChangeSubmit.Text = "确认提交";
            this.btn_OrderChangeSubmit.UseVisualStyleBackColor = true;
            this.btn_OrderChangeSubmit.Click += new System.EventHandler(this.btn_OrderChangeSubmit_Click);
            // 
            // btn_UnEnterRepertory
            // 
            this.btn_UnEnterRepertory.Location = new System.Drawing.Point(237, 76);
            this.btn_UnEnterRepertory.Name = "btn_UnEnterRepertory";
            this.btn_UnEnterRepertory.Size = new System.Drawing.Size(198, 75);
            this.btn_UnEnterRepertory.TabIndex = 4;
            this.btn_UnEnterRepertory.Text = "未入库订单";
            this.btn_UnEnterRepertory.UseVisualStyleBackColor = true;
            this.btn_UnEnterRepertory.Click += new System.EventHandler(this.btn_UnEnterRepertory_Click);
            // 
            // btn_HasEnterRepertory
            // 
            this.btn_HasEnterRepertory.Location = new System.Drawing.Point(42, 76);
            this.btn_HasEnterRepertory.Name = "btn_HasEnterRepertory";
            this.btn_HasEnterRepertory.Size = new System.Drawing.Size(198, 75);
            this.btn_HasEnterRepertory.TabIndex = 3;
            this.btn_HasEnterRepertory.Text = "已入库订单";
            this.btn_HasEnterRepertory.UseVisualStyleBackColor = true;
            this.btn_HasEnterRepertory.Click += new System.EventHandler(this.btn_HasEnterRepertory_Click);
            // 
            // lbl_HasEnter
            // 
            this.lbl_HasEnter.AutoSize = true;
            this.lbl_HasEnter.Font = new System.Drawing.Font("隶书", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_HasEnter.Location = new System.Drawing.Point(33, 178);
            this.lbl_HasEnter.Name = "lbl_HasEnter";
            this.lbl_HasEnter.Size = new System.Drawing.Size(671, 53);
            this.lbl_HasEnter.TabIndex = 2;
            this.lbl_HasEnter.Text = "已入库，该订单不可修改！";
            // 
            // dgv_HasEnter
            // 
            this.dgv_HasEnter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HasEnter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HasEnter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HasEnter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HasEnter.Location = new System.Drawing.Point(42, 250);
            this.dgv_HasEnter.Name = "dgv_HasEnter";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HasEnter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_HasEnter.RowTemplate.Height = 44;
            this.dgv_HasEnter.Size = new System.Drawing.Size(1880, 546);
            this.dgv_HasEnter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(990, 858);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "审核通过";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_PlanningOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2313, 1104);
            this.Controls.Add(this.gpb_Orderinquire);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpb_Orderinquire.ResumeLayout(false);
            this.gpb_Orderinquire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HasEnter)).EndInit();
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
        private System.Windows.Forms.TextBox txb_OrderMemoryCode;
        private System.Windows.Forms.Label lbl_MemoryCode;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_OrderInquire;
        private System.Windows.Forms.TextBox txb_DrugMemoryCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Drug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.GroupBox gpb_Orderinquire;
        private System.Windows.Forms.Label lbl_HasEnter;
        private System.Windows.Forms.DataGridView dgv_HasEnter;
        private System.Windows.Forms.Button btn_UnEnterRepertory;
        private System.Windows.Forms.Button btn_HasEnterRepertory;
        private System.Windows.Forms.Button btn_OrderChangeSubmit;
        private System.Windows.Forms.Button button1;
    }
}