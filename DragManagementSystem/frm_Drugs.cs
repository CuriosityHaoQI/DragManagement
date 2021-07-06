using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DragManagementSystem
{
    public partial class frm_Drugs : Form
    {
        public frm_Drugs()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;                                        //本窗体启动位置设为屏幕中央；
            this.dgv_Drugs.AllowUserToAddRows = false;                                                //数据网格视图不允许用户添加行；
            this.dgv_Drugs.RowHeadersVisible = false;                                                 //数据网格视图的行标题不可见；
            this.dgv_Drugs.BackgroundColor = Color.White;                                             //数据网格视图的背景色设为白色；
            this.dgv_Drugs.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frm_Drugs_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);DataBase=DrugManagement;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText =                                                                    //指定SQL命令的命令文本；
              "SELECT * FROM tb_DrugType;"                                                          //该命令分别查询所有院系、专业、班级，查询结果将返回多张表；
              + "SELECT * FROM tb_DrugFuction;"
              + "SELECT * FROM tb_Drugs;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();
            DataTable TypeTable = dataSet.Tables[0];
            DataTable FunTable = dataSet.Tables[1];
            DataTable drugsTable = dataSet.Tables[2];
            DataRelation[] dataRelations =
            {
                new DataRelation                                                                      
                    ("Type_Fun"                                                                 
                    , TypeTable.Columns["No"]                                                  
                    , FunTable.Columns["DrugTypeNo"]                                      
                    , false)
                ,new DataRelation
                    ("Fun_Drugs"
                    ,FunTable.Columns["FunNo"]
                    ,drugsTable.Columns["DrugsNo"]
                    ,false)
            };
            dataSet.Relations.AddRange(dataRelations);
            this.trv_Drugs.Nodes.Clear();
            foreach(DataRow TypeRow in TypeTable.Rows)
            {
                TreeNode TypeNode = new TreeNode();
                TypeNode.Text = TypeRow["Name"].ToString();
                this.trv_Drugs.Nodes.Add(TypeNode);
                foreach(DataRow FunRow in TypeRow.GetChildRows("Type_Fun"))
                {
                    TreeNode FunNode = new TreeNode();
                    FunNode.Text = FunRow["Name"].ToString();
                    FunNode.Tag = FunRow["FunNo"];
                    TypeNode.Nodes.Add(FunNode);
                    
                }
            }
        }

        private void trv_Drugs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.trv_Drugs.SelectedNode.Level != 1)
                return;
            int funNo = (int)this.trv_Drugs.SelectedNode.Tag;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT DrugsNo,Name FROM tb_Drugs WHERE DrugFunNo=@FunNo;";
            sqlCommand.Parameters.AddWithValue("@FunNo", funNo);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable DrugsTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugsTable);
            sqlConnection.Close();
            this.dgv_Drugs.DataSource = DrugsTable;
            this.dgv_Drugs.Columns["DrugsNo"].HeaderText = "药品编号";
            this.dgv_Drugs.Columns["Name"].HeaderText = "药品名称";
            this.dgv_Drugs.Columns[this.dgv_Drugs.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;




















        }
    }
}
