using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace DragManagementSystem
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $"SELECT COUNT(1) FROM tb_User"
                + $" WHERE No='{this.txb_UserNo.Text.Trim()}'"
                + $" AND Password=HASHBYTES('MD5','{this.txb_Password.Text.Trim()}');";
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();                                 //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
                                                                                            //执行标量的返回结果类型为object，可通过强制类型转换，转为整型；
            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("登录成功。");
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
    }
}
