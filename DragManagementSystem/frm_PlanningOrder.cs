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
            SqlCommand sqlCommand4 = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM tb_DrugType;";
            sqlCommand2.CommandText = "SELECT * FROM tb_Supplier;";
            sqlCommand3.CommandText = "SELECT * FROM tb_Payment;";
            sqlCommand4.CommandText = "SELECT * FROM tb_Drug;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter4 = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter2.SelectCommand = sqlCommand2;
            sqlDataAdapter3.SelectCommand= sqlCommand3;
            sqlDataAdapter4.SelectCommand = sqlCommand4;
            DataTable DrugTypeTable = new DataTable();
            DataTable SupplierTable = new DataTable();
            DataTable PaymentTable = new DataTable();
            DataTable DrugTable = new DataTable();
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
            sqlDataAdapter4.Fill(DrugTable);
            this.cmb_Drug.DataSource = DrugTable;
            this.cmb_Drug.DisplayMember = "Name";
            this.cmb_Drug.ValueMember = "No";
            sqlConnection.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                         
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";                     
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                    
            sqlCommand.CommandText =
                           "INSERT tb_DetailOrder(DrugNo,DrugTypeNo,SupplierNo,PaymentNo,OrderDate,IsChecked,PurchasePrice,DrugAmount,MemoryCode)VALUES(@DrugNo,@DrugTypeNo, @SupplierNo, @paymentNo, @OrderDate, 0,@PurchasePrice,@DrugAmount,@MemoryCode)";
            sqlCommand.Parameters.AddWithValue("@DrugNo", this.cmb_Drug.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@DrugTypeNo", this.cmb_Drugtype.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@SupplierNo", this.cmb_Supplier.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@PaymentNo", this.cmb_Payment.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@PurchasePrice", this.txb_Price.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@DrugAmount", this.txb_DrugAmount.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@MemoryCode", this.txb_OrderMemoryCode.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@OrderDate", (DateTime)this.dtp_Date.Value);
            sqlConnection.Open();           
            int rowAffected = sqlCommand.ExecuteNonQuery();
            if(rowAffected==1)
            {
                MessageBox.Show("提交成功！");
            }

        }

        private void btn_OrderInquire_Click(object sender, EventArgs e)
        {

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"SELECT D.Name AS DrugName,D.No AS DrugNo,DT.No AS DrugTypeNo,DT.Name AS DrugTypeName,S.No AS SupplierNo,S.Name AS SupplierName FROM dbo.tb_Drug AS D JOIN dbo.tb_DrugType AS DT ON D.DrugTypeNo=DT.No JOIN dbo.tb_Supplier AS S ON S.No=D.SupplierNo WHERE D.MemoryCode='{this.txb_DrugMemoryCode.Text}';";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.cmb_Drug.Text = sqlDataReader["DrugName"].ToString();
                this.cmb_Drug.SelectedValue = sqlDataReader["DrugNo"];
                this.cmb_Drugtype.Text = sqlDataReader["DrugTypeName"].ToString();
                this.cmb_Drugtype.SelectedValue = sqlDataReader["DrugTypeNo"];
                this.cmb_Supplier.Text = sqlDataReader["SupplierName"].ToString();
                this.cmb_Supplier.SelectedValue = sqlDataReader["SupplierNo"];
            }
            sqlDataReader.Close();
        }
    }
}
