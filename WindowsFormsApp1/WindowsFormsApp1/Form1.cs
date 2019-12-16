using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter, dataAdapter2, dataAdapter3;
        DataSet dataSet, dataSet2, dataSet3;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=igalaxy;uid=root;pwd=root");

            dataSet = new DataSet();
            dataSet2 = new DataSet();
            dataSet3 = new DataSet();

            dataAdapter = new MySqlDataAdapter("SELECT * from user", conn);
            dataAdapter.Fill(dataSet, "user");
            UserGridView.DataSource = dataSet.Tables["user"];

            dataAdapter2 = new MySqlDataAdapter("SELECT * from product", conn);
            dataAdapter2.Fill(dataSet2, "product");
            SampleView.DataSource = dataSet2.Tables["product"];

            dataAdapter3 = new MySqlDataAdapter("SELECT * from igalaxy.order", conn);
            dataAdapter3.Fill(dataSet3, "order");
            OrderGridView.DataSource = dataSet3.Tables["order"];

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    connection.Text = "👏 검색할 수 있어요 👏";
                    connection.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            string[] userdata = {  "user_id", "user_name","user_grade","ph_num","user_position"};
            

            comboBox1.Items.AddRange(userdata);
            comboBox1.Visible = false;
            textBox1.Visible = false;
            comboBox3.Visible = false;
            comboBox2.Visible = false;
            label6.Visible = false;
            button4.Visible = false;
            SetSearchComboBox();
            SetSearchComboBox1();
        }


        private void SetSearchComboBox()
        {
            
            string sql = "SELECT user_position FROM user";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // CountryCode 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    if (!comboBox2.Items.Contains(reader.GetString("user_position"))) {
                        comboBox2.Items.Add(reader.GetString("user_position"));
                    }
                    
                }
                reader.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }


        private void SetSearchComboBox1()
        {

            string sql = "SELECT user_grade FROM user";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // CountryCode 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    if (!comboBox3.Items.Contains(reader.GetString("user_grade")))
                    {
                        comboBox3.Items.Add(reader.GetString("user_grade"));
                    }
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }


        private void SaveText(string fileName)
        {
            // SaveFileDialog에서 지정한 파일경로에 Stream 생성 -> 저장
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                // Column 이름들 저장
                foreach (DataColumn col in dataSet.Tables["user"].Columns)
                {
                    sw.Write($"{col.ColumnName}\t");
                }
                sw.WriteLine();

                // DataSet의 Row들 저장
                foreach (DataRow row in dataSet.Tables["user"].Rows)
                {
                    string rowString = "";
                    foreach (var item in row.ItemArray)
                    {
                        rowString += $"{item.ToString()}\t";
                    }
                    sw.WriteLine(rowString);
                }
            }
        }

        private void data_dont_exist(string select, string a)
        {
            
            dataSet.Clear();
            dataAdapter = new MySqlDataAdapter(select, conn);
            dataAdapter.Fill(dataSet, a);
            UserGridView.DataSource = dataSet.Tables[a];
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            textBox1.Visible = false;
        }
        private void searchData(string a)
        {
            
            dataAdapter.SelectCommand.Parameters.AddWithValue(a, textBox1.Text);
            try
            {
                conn.Open();
                //select 결과를 dataSet에 city라는 이름의 테이블로 만들어라.
                if (dataAdapter.Fill(dataSet, "user") > 0) // 검색된 데이터의 행숫자 반환
                    UserGridView.DataSource = dataSet.Tables["user"];

                else
                {
                    MessageBox.Show("데이터가 검색되지 않았습니다");
                    data_dont_exist("SELECT * FROM user","user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                textBox1.Text = "";

            }
        }

        private void searchData1(string a)
        {

            dataAdapter.SelectCommand.Parameters.AddWithValue(a, comboBox2.Text);
            try
            {
                conn.Open();
                //select 결과를 dataSet에 city라는 이름의 테이블로 만들어라.
                if (dataAdapter.Fill(dataSet, "user") > 0) // 검색된 데이터의 행숫자 반환
                    UserGridView.DataSource = dataSet.Tables["user"];

                else
                {
                    MessageBox.Show("데이터가 검색되지 않았습니다");
                    data_dont_exist("SELECT * FROM user", "user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void searchData2(string a)
        {

            dataAdapter.SelectCommand.Parameters.AddWithValue(a, comboBox3.Text);
            try
            {
                conn.Open();
                //select 결과를 dataSet에 city라는 이름의 테이블로 만들어라.
                if (dataAdapter.Fill(dataSet, "user") > 0) // 검색된 데이터의 행숫자 반환
                    UserGridView.DataSource = dataSet.Tables["user"];

                else
                {
                    MessageBox.Show("데이터가 검색되지 않았습니다");
                    data_dont_exist("SELECT * FROM user", "user"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void SaveExcel(string fileName)
        {
            // 1. 엑셀 사용에 필요한 객체들 생성
            Excel.Application eApp;             // 엑셀 프로그램
            Excel.Workbook eWorkbook;    // 엑셀 시트를 여러개 포함하는 단위
            Excel.Worksheet eWorkSheet;  // 엑셀 워크시트

            eApp = new Excel.Application();
            eWorkbook = eApp.Workbooks.Add();       // eApp에 워크북 추가
            eWorkSheet = eWorkbook.Sheets[1];         // 엑셀 워크시트는 index가 1부터 시작한다.

            // 2. 엑셀에 저장할 데이터를 2차원 배열 형태로 준비
            string[,] dataArr;
            int colCount = dataSet.Tables["user"].Columns.Count + 1;
            int rowCount = dataSet.Tables["user"].Rows.Count + 1;
            dataArr = new string[rowCount, colCount];

            // 2 - 1 Column 이름 저장
            for (int i = 0; i < dataSet.Tables["user"].Columns.Count; i++)
            {
                dataArr[0, i] = dataSet.Tables["user"].Columns[i].ColumnName;   // 첫 행에 컬럼이름 저장
            }

            // 2 - 2 행 데이터 저장
            for (int i = 0; i < dataSet.Tables["user"].Rows.Count; i++)
            {
                for (int j = 0; j < dataSet.Tables["user"].Columns.Count; j++)
                {
                    dataArr[i + 1, j] = dataSet.Tables["user"].Rows[i].ItemArray[j].ToString();
                }
            }

            // 3. 준비된 데이터를 엑셀파일에 저장
            string endCell = $"H{rowCount}";         // 데이터가 저장이 끝나는 셀의 주소
            eWorkSheet.get_Range("A1:" + endCell).Value = dataArr;      // 데이터가 저장될 셀의 범위

            eWorkbook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);

            eWorkbook.Close(false, Type.Missing, Type.Missing);
            eApp.Quit();
        }

        private void Select_All()
        {
            string query = "select * from user";
            dataAdapter2.SelectCommand = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                dataSet2.Clear();
                if (dataAdapter2.Fill(dataSet2, "user") > 0) // 검색한 데이터의 행 수 반환
                    UserGridView.DataSource = dataSet2.Tables["user"];
                else
                    MessageBox.Show("검색된 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Select_All();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "user_grade")
            {
                comboBox3.Visible = true;
                comboBox2.Visible = false;
                textBox1.Visible = false;
            }
            else if(comboBox1.Text == "user_position"){
                comboBox2.Visible = true;
                textBox1.Visible = false;
                comboBox3.Visible = false;
            }
            else
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            if (UserGridView.Visible == false && SampleView.Visible == false && OrderGridView.Visible == false)
            {
                MessageBox.Show("테이블을 선택 후 다시 시도하세요");
            }
            else
            {
                DialogResult result = MessageBox.Show("추가 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string query = "insert into user(user_id, user_pw, user_name, user_grade, ph_num, user_email, user_position)" +
               "values(@user_id, @user_pw, @user_name, @user_grade, @ph_num, @user_email, @user_position)";
                dataAdapter.InsertCommand = new MySqlCommand(query, conn);
                try
                {
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@user_id", UserGridView.SelectedRows[0].Cells["user_id"].Value.ToString());
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@user_pw", UserGridView.SelectedRows[0].Cells["user_pw"].Value.ToString());
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@user_name", UserGridView.SelectedRows[0].Cells["user_name"].Value.ToString());
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@user_grade", UserGridView.SelectedRows[0].Cells["user_grade"].Value.ToString());
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@ph_num", UserGridView.SelectedRows[0].Cells["ph_num"].Value.ToString());
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@user_email", UserGridView.SelectedRows[0].Cells["user_email"].Value.ToString());
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@user_position", UserGridView.SelectedRows[0].Cells["user_position"].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("error");
                }
                try
                {
                    if (dataAdapter.Update(dataSet, "user") > 0)
                    {
                        conn.Open();
                        dataSet.Clear();
                        dataAdapter.Fill(dataSet, "user");
                        UserGridView.DataSource = dataSet.Tables["user"];
                        MessageBox.Show("INSERT COMPLETE!");
                    }
                    else
                        MessageBox.Show("검색된 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (UserGridView.Visible == false && SampleView.Visible == false && OrderGridView.Visible == false)
            {
                MessageBox.Show("테이블을 선택 후 시도하세요");
            }
            else
            {
                saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveText(saveFileDialog1.FileName);
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (UserGridView.Visible == false && SampleView.Visible == false && OrderGridView.Visible == false) {
                MessageBox.Show("테이블을 선택 후 시도하십시오");
                
            }
            else
            {
                saveFileDialog1.Filter = "엑셀 파일(*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveExcel(saveFileDialog1.FileName);
                }
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (UserGridView.Visible == false && SampleView.Visible == false && OrderGridView.Visible == false)
            {
                MessageBox.Show("테이블을 선택 후 다시 시도하세요");
            }
            else
            {
                DialogResult result = MessageBox.Show("정말 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    int target = (int)UserGridView.SelectedRows[0].Cells["user_idx"].Value;
                
                string query = "delete from user where user_idx=@user_idx";
                dataAdapter.DeleteCommand = new MySqlCommand(query, conn);
                dataAdapter.DeleteCommand.Parameters.Add("@user_idx", MySqlDbType.Int32);
                dataAdapter.DeleteCommand.Parameters["@user_idx"].Value = target;

                DataRow[] findRows = dataSet.Tables["user"].Select($"user_idx={target}");
                findRows[0].Delete();
                }
                catch
                {
                    MessageBox.Show("error");
                }
                try
                {
                    dataAdapter.Update(dataSet, "user");
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (UserGridView.Visible == false && SampleView.Visible == false && OrderGridView.Visible == false)
            {
                MessageBox.Show("테이블을 선택 후 다시 시도하세요");
            }
            else { 

            DialogResult result = MessageBox.Show("업데이트 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string query = "update user set user_id=@user_id, user_pw=@user_pw, user_name=@user_name, user_grade=@user_grade, " +
"ph_num=@ph_num, user_email=@user_email, user_position=@user_position where user_idx = @user_idx";

            dataAdapter.UpdateCommand = new MySqlCommand(query, conn);
                try
                {
                    dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_idx", UserGridView.SelectedRows[0].Cells["user_idx"].Value.ToString());
                    dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_id", UserGridView.SelectedRows[0].Cells["user_id"].Value.ToString());
                    dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_pw", UserGridView.SelectedRows[0].Cells["user_pw"].Value.ToString());
                    dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_name", UserGridView.SelectedRows[0].Cells["user_name"].Value.ToString());
                    dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_grade", UserGridView.SelectedRows[0].Cells["user_grade"].Value.ToString());
                    dataAdapter.UpdateCommand.Parameters.AddWithValue("@ph_num", UserGridView.SelectedRows[0].Cells["ph_num"].Value.ToString());
                    dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_email", UserGridView.SelectedRows[0].Cells["user_email"].Value.ToString());
                    dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_position", UserGridView.SelectedRows[0].Cells["user_position"].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("error");
                }
            try
            {
                conn.Open();
                if (dataAdapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "user");
                    UserGridView.DataSource = dataSet.Tables["user"];
                    MessageBox.Show("UPDATE COMPLETE!");
                }
                else
                    MessageBox.Show("검색된 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            


            if(comboBox1.Text == "user_id")
            {
                dataSet.Clear();
                string sql = "SELECT * FROM user where user_id = @user_id";
                dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                searchData("user_id");
            }else if(comboBox1.Text == "user_name")
            {
                dataSet.Clear();
                string sql = "SELECT * FROM user where user_name = @user_name";
                dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                searchData("user_name");
            }
            else if (comboBox1.Text == "user_grade")
            {
                dataSet.Clear();
                string sql = "SELECT * FROM user where user_grade = @user_grade";
                dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                searchData2("user_grade");
            }
            else if (comboBox1.Text == "user_position")
            {
                dataSet.Clear();
                string sql = "SELECT * FROM user where user_position = @user_position";
                dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                searchData1("user_position");
            }
            else if (comboBox1.Text == "ph_num")
            {
                dataSet.Clear();
                string sql = "SELECT * FROM user where ph_num = @ph_num";
                dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                searchData("ph_num");
            }

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (UserGridView.Visible == true)
            {
                data_dont_exist("select * from user", "user");
                SetSearchComboBox();
                SetSearchComboBox1();

            }
            else if (SampleView.Visible == true)
            {
                data_dont_exist("select * from product", "user");
                SetSearchComboBox();
                SetSearchComboBox1();
            }
            else if (OrderGridView.Visible == true)
            {
                data_dont_exist("select * from igalaxy.order", "user");
                SetSearchComboBox();
                SetSearchComboBox1();
            }


        }

        private void UserGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.Shift == true && e.KeyCode == Keys.S)
            {
                saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveText(saveFileDialog1.FileName);
                }
            }
            if (e.Control == true && e.KeyCode == Keys.F)
            {
                 if (comboBox1.Text == "user_position")
                {
                    dataSet.Clear();
                    string sql = "SELECT * FROM user where user_position = @user_position";
                    dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                    searchData1("user_position");
                }
                else if (comboBox1.Text == "user_id")
                {
                    dataSet.Clear();
                    string sql = "SELECT * FROM user where user_id = @user_id";
                    dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                    searchData("user_id");
                }
                else if (comboBox1.Text == "user_name")
                {
                    dataSet.Clear();
                    string sql = "SELECT * FROM user where user_name = @user_name";
                    dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                    searchData("user_name");
                }
                else if (comboBox1.Text == "user_grade")
                {
                    dataSet.Clear();
                    string sql = "SELECT * FROM user where user_grade = @user_grade";
                    dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                    searchData2("user_grade");
                }
                else if (comboBox1.Text == "ph_num")
                {
                    dataSet.Clear();
                    string sql = "SELECT * FROM user where ph_num = @ph_num";
                    dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
                    searchData("ph_num");
                }
            }

            if (e.Control == true && e.Shift == false && e.KeyCode == Keys.S)
            {
             saveFileDialog1.Filter = "엑셀 파일(*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveExcel(saveFileDialog1.FileName);
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                DialogResult result = MessageBox.Show("추가 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string query = "insert into user(user_id, user_pw, user_name, user_grade, ph_num, user_email, user_position)" +
               "values(@user_id, @user_pw, @user_name, @user_grade, @ph_num, @user_email, @user_position)";
                dataAdapter.InsertCommand = new MySqlCommand(query, conn);

                dataAdapter.InsertCommand.Parameters.AddWithValue("@user_id", UserGridView.SelectedRows[0].Cells["user_id"].Value.ToString());
                dataAdapter.InsertCommand.Parameters.AddWithValue("@user_pw", UserGridView.SelectedRows[0].Cells["user_pw"].Value.ToString());
                dataAdapter.InsertCommand.Parameters.AddWithValue("@user_name", UserGridView.SelectedRows[0].Cells["user_name"].Value.ToString());
                dataAdapter.InsertCommand.Parameters.AddWithValue("@user_grade", UserGridView.SelectedRows[0].Cells["user_grade"].Value.ToString());
                dataAdapter.InsertCommand.Parameters.AddWithValue("@ph_num", UserGridView.SelectedRows[0].Cells["ph_num"].Value.ToString());
                dataAdapter.InsertCommand.Parameters.AddWithValue("@user_email", UserGridView.SelectedRows[0].Cells["user_email"].Value.ToString());
                dataAdapter.InsertCommand.Parameters.AddWithValue("@user_position", UserGridView.SelectedRows[0].Cells["user_position"].Value.ToString());

                try
                {
                    if (dataAdapter.Update(dataSet, "user") > 0)
                    {
                        conn.Open();
                        dataSet.Clear();
                        dataAdapter.Fill(dataSet, "user");
                        UserGridView.DataSource = dataSet.Tables["user"];
                        MessageBox.Show("INSERT COMPLETE!");
                    }
                    else
                        MessageBox.Show("검색된 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                DialogResult result = MessageBox.Show("정말 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                int target = (int)UserGridView.SelectedRows[0].Cells["user_idx"].Value;

                string query = "delete from user where user_idx=@user_idx";
                dataAdapter.DeleteCommand = new MySqlCommand(query, conn);
                dataAdapter.DeleteCommand.Parameters.Add("@user_idx", MySqlDbType.Int32);
                dataAdapter.DeleteCommand.Parameters["@user_idx"].Value = target;

                DataRow[] findRows = dataSet.Tables["user"].Select($"user_idx={target}");
                findRows[0].Delete();

                dataAdapter.Update(dataSet, "user");
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("업데이트 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string query = "update user set user_id=@user_id, user_pw=@user_pw, user_name=@user_name, user_grade=@user_grade, " +
"ph_num=@ph_num, user_email=@user_email, user_position=@user_position where user_idx = @user_idx";

                dataAdapter.UpdateCommand = new MySqlCommand(query, conn);

                dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_idx", UserGridView.SelectedRows[0].Cells["user_idx"].Value.ToString());
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_id", UserGridView.SelectedRows[0].Cells["user_id"].Value.ToString());
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_pw", UserGridView.SelectedRows[0].Cells["user_pw"].Value.ToString());
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_name", UserGridView.SelectedRows[0].Cells["user_name"].Value.ToString());
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_grade", UserGridView.SelectedRows[0].Cells["user_grade"].Value.ToString());
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@ph_num", UserGridView.SelectedRows[0].Cells["ph_num"].Value.ToString());
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_email", UserGridView.SelectedRows[0].Cells["user_email"].Value.ToString());
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@user_position", UserGridView.SelectedRows[0].Cells["user_position"].Value.ToString());

                try
                {
                    conn.Open();
                    if (dataAdapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        dataSet.Clear();
                        dataAdapter.Fill(dataSet, "user");
                        UserGridView.DataSource = dataSet.Tables["user"];
                        MessageBox.Show("UPDATE COMPLETE!");
                    }
                    else
                        MessageBox.Show("검색된 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            UserGridView.Visible = true;
            SampleView.Visible = false;
            OrderGridView.Visible = false;
            comboBox1.Visible = true;
            label6.Visible = true;
            button4.Visible = true;
        }

        private void ord_btn_Click(object sender, EventArgs e)
        {
            UserGridView.Visible = false;
            SampleView.Visible = false;
            OrderGridView.Visible = true;
            comboBox1.Visible = false;
            textBox1.Visible = false;
        }

        private void board_btn_Click(object sender, EventArgs e)
        {
            UserGridView.Visible = false;
            SampleView.Visible = true;
            OrderGridView.Visible = false;
            comboBox1.Visible = false;
            textBox1.Visible = false;
        }

    }
}