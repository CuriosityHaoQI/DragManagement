using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace DragManagementSystem
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private string UserName;
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                "SELECT COUNT(1) FROM tb_User WHERE No=@No AND Password=HASHBYTES('MD5',@Password);";   //指定SQL命令的命令文本；命令文本包含参数； 
            #region SQL参数用法1
            SqlParameter sqlParameter = new SqlParameter();                                             //声明并实例化SQL参数；
            sqlParameter.ParameterName = "@No";                                                         //设置SQL参数的名称；
            sqlParameter.Value = this.txb_UserNo.Text.Trim();                                           //设置SQL参数的长度；
            sqlParameter.SqlDbType = SqlDbType.Char;                                                    //设置SQL参数对应的SQL Server数据类型；
            sqlParameter.Size = 10;                                                                     //设置SQL参数的长度；
            sqlCommand.Parameters.Add(sqlParameter);                                                    //向SQL命令的参数集合添加SQL参数；
            #endregion
            #region SQL参数用法2
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());             //直接调用方法AddWithValue向SQL命令的参数集合添加参数的名称、值；SQL参数能自动识别类型，但若SQL参数被用作某函数的输入参数，则使用函数定义的参数类型作为SQL参数类型；
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;                           //通过参数名称访问SQL参数，并将密码参数的类型设为变长字符串；由于HASHBYTES函数的参数为NVARCHAR，则SQL参数类型自动设为NVARCHAR；对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
            #endregion
            sqlConnection.Open();                                                                       //打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();                                             //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
                                                       //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
            if (rowCount == 1)
            {
                MessageBox.Show("登录成功。");
                SqlCommand sqlCommand2 = new SqlCommand();
                sqlCommand2.Connection = sqlConnection;
                sqlCommand2.CommandText = "SELECT Name FROM tb_User WHERE No=@No;";
                sqlCommand2.Parameters.AddWithValue("@No", this.txb_UserNo.Text.Trim());
                SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
                if (sqlDataReader.Read())
                {
                this.UserName = sqlDataReader["Name"].ToString();
                }

                frm_ProjectSelect _ProjectSelect = new frm_ProjectSelect(this.txb_UserNo.Text.Trim(), this.UserName);
                _ProjectSelect.ShowDialog();
                this.Hide();
                sqlConnection.Close();  
            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.txb_Password.Focus();                                                  //密码文本框获得焦点；
                this.txb_Password.SelectAll();                                              //密码文本框内所有文本被选中；
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_SignUp signUpForm = new frm_SignUp();
            signUpForm.ShowDialog();
        }

        private void txb_UserNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //检验是否含有除数字以外的字符 
                Regex expression = new Regex(@"[^0-9]");
                if (expression.IsMatch(txb_UserNo.Text) == true)
                {
                    throw new ApplicationException("只能输入数字！");
                }
                else return;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_LogIn_Load(object sender, EventArgs e)
        {
            this.txb_UserNo.Text = "3190707003";
            this.txb_Password.Text = "7003";
        
        }
    }
}
