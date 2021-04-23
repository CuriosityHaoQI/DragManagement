using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace DragManagementSystem
{
    public partial class frm_info : Form
    {
        public frm_info()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private string _UserNo;
        private string _UserName;
        public frm_info(string UserNo, string UserName) : this()
        {
            this._UserName = UserName;
            this._UserNo = UserNo;
        }

        private void frm_info_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM tb_User;";
            sqlCommand.Parameters.AddWithValue("@No", this._UserNo);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            byte[] photoBytes = null;
            if (sqlDataReader.Read())
            {
                this.txb_Name.Text = _UserName.ToString().Trim();
                this.txb_No.Text = _UserNo;  
                this.rdb_Boy.Checked = (bool)sqlDataReader["Gender"];
                this.rdb_Girl.Checked = !rdb_Boy.Checked;
                this.dtp_Birthday.Value = (DateTime)sqlDataReader["BirthDate"];
                photoBytes =
                    (sqlDataReader["Photo"] == DBNull.Value ? null : (byte[])sqlDataReader["Photo"]);
            }
            sqlDataReader.Close();
            if (photoBytes != null)
            {
                MemoryStream memoryStream = new MemoryStream(photoBytes);
                this.pcb_Picture.Image = Image.FromStream(memoryStream);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_ProjectSelect _ProjectSelect = new frm_ProjectSelect(this._UserNo,this._UserName);
            _ProjectSelect.Show();
            this.Hide();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog()
            {
                Title = "打开照片文件"
                ,
                Filter = "图像文件|*.bmp;*.jpg"
                ,
                InitialDirectory = GetFolderPath(SpecialFolder.MyPictures)
            };
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openPhotoDialog.FileName;
                this.pcb_Picture.Image = Image.FromFile(fileName);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            this.pcb_Picture.Image.Save(memoryStream, ImageFormat.Bmp);
            byte[] photoBytes = new byte[memoryStream.Length];
            memoryStream.Seek(0, SeekOrigin.Begin);
            memoryStream.Read(photoBytes, 0, photoBytes.Length);
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(local);Database=DrugManagement;Integrated Security=sspi";                         //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText =
                "UPDATE tb_User"
                + " SET Name=@Name,Gender=@Gender,BirthDate=@BirthDate,Photo=@Photo";
            sqlCommand.Parameters.AddWithValue("@Name", this.txb_Name.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Gender", this.rdb_Boy.Checked);
            sqlCommand.Parameters.AddWithValue("@BirthDate", this.dtp_Birthday.Value);
            sqlCommand.Parameters.AddWithValue("@Photo", photoBytes);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }

        private void frm_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_ProjectSelect _ProjectSelect = new frm_ProjectSelect(_UserNo,_UserName);
            _ProjectSelect.Show();
        }
    }
}
