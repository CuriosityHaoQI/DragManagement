using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DragManagementSystem
{
    public partial class frm_Repertory : Form
    {
        public frm_Repertory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private string _UserNo;
        private string _UserName;
        public frm_Repertory(string UserNo, string UserName) : this()
        {
            this._UserName = UserName;
            this._UserNo = UserNo;
        }
        private DateTime validity;

        private void btn_Cardinal_Click(object sender, EventArgs e)
        {
            this.gpb_Cardinal.Text = "库存基数预警";
            this.gdb_Validity.Hide();
            this.gpb_Cardinal.Show();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT D.No AS 药品标识码,D.Name AS 药品名称,d.Specifications AS 规格,D.SKU AS 库存单位,R.Count AS 库存数,R.Cardinal AS 库存基数　FROM tb_Drug AS D JOIN tb_Repertory AS R ON D.RepertoryNo=R.No WHERE R.Cardinal>R.Count;;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable DrugCardinalTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugCardinalTable);
            sqlConnection.Close();
            this.gdv_DrugCardinal.DataSource =DrugCardinalTable;
            this.gdv_DrugCardinal.Columns["库存数"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.gdv_DrugCardinal.Columns[0].AutoSizeMode =
    DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_LowerLimit_Click(object sender, EventArgs e)
        {
            this.gpb_Cardinal.Text = "库存下限预警";
            this.gdb_Validity.Hide();
            this.gpb_Cardinal.Show();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT D.No AS 药品标识码,D.Name AS 药品名称,d.Specifications AS 规格,D.SKU AS 库存单位,R.Count AS 库存数,R.LowerLimit AS 库存下限　FROM tb_Drug AS D JOIN tb_Repertory AS R ON D.RepertoryNo=R.No WHERE R.LowerLimit<R.Count;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable DrugCardinalTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugCardinalTable);
            sqlConnection.Close();
            this.gdv_DrugCardinal.DataSource = DrugCardinalTable;
            this.gdv_DrugCardinal.Columns["库存数"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.gdv_DrugCardinal.Columns[0].AutoSizeMode =
    DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_UpperLimit_Click(object sender, EventArgs e)
        {
            this.gpb_Cardinal.Text = "库存上限预警";
            this.gdb_Validity.Hide();
            this.gpb_Cardinal.Show();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT D.No AS 药品标识码,D.Name AS 药品名称,d.Specifications AS 规格,D.SKU AS 库存单位,R.Count AS 库存数,R.UpperLimit AS 库存上限　FROM tb_Drug AS D JOIN tb_Repertory AS R ON D.RepertoryNo=R.No WHERE R.UpperLimit<R.Count;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable DrugCardinalTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugCardinalTable);
            sqlConnection.Close();
            this.gdv_DrugCardinal.DataSource = DrugCardinalTable;
            this.gdv_DrugCardinal.Columns["库存数"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.gdv_DrugCardinal.Columns[0].AutoSizeMode =
    DataGridViewAutoSizeColumnMode.Fill;
        }


        private void btn_Validity_Click(object sender, EventArgs e)
        {

            this.gdb_Validity.Show();
            this.gpb_Cardinal.Hide();
            this.dtp_Validity.Show();
            this.dtp_outbase.Hide();
            this.lbl_deadline.Text = "超过有效期的药品";
            this.dgv_Validity.DataSource = null;
            this.gdb_Validity.Text = "有效期管理";
        }

        private void frm_Repertory_Load(object sender, EventArgs e)
        {
            this.gdb_Validity.Hide();
            this.gpb_Cardinal.Show();
        }

        private void dtp_Validity_ValueChanged(object sender, EventArgs e)
        {
            this.validity = (DateTime)this.dtp_Validity.Value;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT D.No AS 标识码,D.Name AS 药品名称,d.Specifications AS 规格,D.SKU AS 单位,D.ProduceDate AS 生产日期,D.Validity AS '有效期/月',DATEADD(MONTH,D.Validity,D.ProduceDate) AS 截止日期　FROM tb_Drug AS D JOIN tb_Repertory AS R ON D.RepertoryNo=R.No WHERE DATEADD(MONTH,D.Validity,D.ProduceDate)<'{this.validity}';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable DrugCardinalTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugCardinalTable);
            sqlConnection.Close();
            this.dgv_Validity.DataSource = DrugCardinalTable;
            this.dgv_Validity.Columns["截止日期"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.dgv_Validity.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void dtp_outbase_ValueChanged(object sender, EventArgs e)
        {
            this.validity = (DateTime)this.dtp_outbase.Value;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT D.No AS 药品标识码,D.Name AS 药品名称,d.Specifications AS  规格,D.SKU AS 库存单位,D.ProduceDate AS 生产日期,R.OutDate 出库日期　FROM tb_Drug AS D JOIN tb_Repertory AS R ON D.RepertoryNo=R.No WHERE R.OutDate<'{this.validity}';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable DrugCardinalTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugCardinalTable);
            sqlConnection.Close();
            this.dgv_Validity.DataSource = DrugCardinalTable;
            this.dgv_Validity.Columns["出库日期"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.dgv_Validity.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Outbase_Click(object sender, EventArgs e)
        {
            this.gdb_Validity.Show();
            this.gpb_Cardinal.Hide();
            this.dtp_Validity.Hide();
            this.dtp_outbase.Show();
            this.lbl_deadline.Text = "尚未出库的药品";
            this.gdb_Validity.Text = "滞留药品管理";
            this.dgv_Validity.DataSource = null;
        }

        private void frm_Repertory_FormClosed(object sender, FormClosedEventArgs e)
        {

            frm_ProjectSelect _ProjectSelect = new frm_ProjectSelect(_UserNo, _UserName);
            _ProjectSelect.Show();
        }
    }
}
