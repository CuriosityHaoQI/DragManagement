using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragManagementSystem
{
    public partial class frm_PlanningOrder : Form
    {
        public frm_PlanningOrder()
        {
            InitializeComponent();
        }

        private string _UserNo;
        private string _UserName;
        public frm_PlanningOrder(string UserNo, string UserName) : this()
        {
            this._UserName = UserName;
            this._UserNo = UserNo;
        }

        private void btn_MakingOrder_Click(object sender, EventArgs e)
        {

        }

        private void frm_PlanningOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_ProjectSelect _ProjectSelect = new frm_ProjectSelect(_UserNo,_UserName);
            _ProjectSelect.Show();
        }

        private void frm_PlanningOrder_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM tb_DrugType;";
            sqlCommand2.CommandText = "SELECT * FROM tb_Supplier;";
            sqlCommand3.CommandText = "SELECT * FROM tb_Payment;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter2.SelectCommand = sqlCommand2;
            sqlDataAdapter3.SelectCommand= sqlCommand3;
            DataTable DrugTypeTable = new DataTable();
            DataTable SupplierTable = new DataTable();
            DataTable PaymentTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugTypeTable);
            this.cmb_Drugtype.DataSource =DrugTypeTable;
            this.cmb_Drugtype.DisplayMember = "Name";
            this.cmb_Drugtype.ValueMember = "No";
            sqlDataAdapter2.Fill(SupplierTable);
            this.cmb_Supplier.DataSource = SupplierTable;
            this.cmb_Supplier.DisplayMember = "Name";
            this.cmb_Supplier.ValueMember = "No";
            sqlDataAdapter3.Fill(PaymentTable);
            this.cmb_Payment.DataSource =PaymentTable;
            this.cmb_Payment.DisplayMember = "Name";
            this.cmb_Payment.ValueMember = "No";
            sqlConnection.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                         
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";                     
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                    
            sqlCommand.CommandText =
                           "INSERT tb_DetailOrder(DrugNo,SupplierNo,PaymentNo,OrderDate,IsChecked,PurchasePrice,DrugAmount,MemoryCode)VALUES(@DrugNo, @SupplierNo, @paymentNo, @OrderDate, 0,@PurchasePrice,@DrugAmount,@MemoryCode)";                     
            sqlCommand.Parameters.AddWithValue("@DrugNo", this.cmb_Drugtype.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@SupplierNo", this.cmb_Supplier.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@PaymentNo", this.cmb_Payment.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@PurchasePrice", this.txb_Price.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@DrugAmount", this.txb_DrugAmount.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@MemoryCode", this.txb_MemoryCode.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@OrderDate", (DateTime)this.dtp_Date.Value);
            sqlConnection.Open();           
            int rowAffected = sqlCommand.ExecuteNonQuery();
            if(rowAffected==1)
            {
                MessageBox.Show("提交成功！");
            }

        }


    }
}
