using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DragManagementSystem
{
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (this.txb_UserNo.Text.Trim() == "")                                                      //若用户号文本框为空；
            {
                MessageBox.Show("用户号不能为空！");														//给出错误提示；
                this.txb_UserNo.Focus();                                                                //用户号文本框获得焦点；
                return;                                                                                 //返回；
            }
            if (this.txb_UserName.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！");
                this.txb_UserName.Focus();
                return;
            }
            if (this.txb_Password.Text.Trim() == "")                                                    
            {
                MessageBox.Show("密码不能为空！");															
                this.txb_Password.Focus();                                                              
                return;                                                                               
            }
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Connection = sqlConnection;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
                           "INSERT tb_User (No,Name,Password) VALUES(@No,@Name,HASHBYTES('MD5',@Password));";                       //指定SQL命令的命令文本；命令文本包含参数；
            sqlCommand.Parameters.AddWithValue("@No", this.txb_UserNo.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Name", this.txb_UserName.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            if (this.txb_Password.Text.Trim() == this.txb_PasswordAgain.Text.Trim())
            {
                int rowAffected = 0;                                                                        //声明整型变量，用于保存受影响行数；
                try                                                                                         //尝试；
                {
                    sqlConnection.Open();                                                                   //打开SQL连接；
                    rowAffected = sqlCommand.ExecuteNonQuery();                                             //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
                }
                catch (SqlException sqlEx)                                                                  //捕捉SQL异常；
                {
                    if (sqlEx.Number == 2627)                                                               //若SQL异常编号为2627，则违反主键/唯一约束，即插入重复值；
                    {
                        MessageBox.Show("您注册的用户号已存在，请重新输入！\n");
                        txb_UserNo.Text = "";
                        txb_UserNo.Focus();
                    }
                }
                finally                                                                                     //结束；
                {
                    sqlConnection.Close();                                                                  //关闭SQL连接；
                }
                if (rowAffected == 1)                                                                       //若成功写入1行记录；
                {
                    MessageBox.Show("注册成功。");
                    //显示正确提示；
                    frm_LogIn logIn = new frm_LogIn();
                    logIn.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("密码不一致，请重新输入！");
                this.txb_Password.Text = "";
                this.txb_PasswordAgain.Text = "";
                this.txb_Password.Focus();

            } 

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            frm_LogIn logIn = new frm_LogIn();
            logIn.ShowDialog();
            this.Hide();
        }

        private void frm_SignUp_Load(object sender, EventArgs e)
        {

        }

   
        
    }
}
