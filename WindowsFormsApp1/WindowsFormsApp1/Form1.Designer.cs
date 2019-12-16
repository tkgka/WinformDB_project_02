namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ord_btn = new System.Windows.Forms.Button();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.SampleView = new System.Windows.Forms.DataGridView();
            this.connection = new System.Windows.Forms.Label();
            this.user_btn = new System.Windows.Forms.Button();
            this.EmpGridView = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ord_btn
            // 
            this.ord_btn.BackColor = System.Drawing.Color.White;
            this.ord_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ord_btn.Location = new System.Drawing.Point(52, 424);
            this.ord_btn.Name = "ord_btn";
            this.ord_btn.Size = new System.Drawing.Size(242, 119);
            this.ord_btn.TabIndex = 3;
            this.ord_btn.Text = "주문관리";
            this.ord_btn.UseVisualStyleBackColor = false;
            this.ord_btn.Click += new System.EventHandler(this.ord_btn_Click);
            // 
            // UserGridView
            // 
            this.UserGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Location = new System.Drawing.Point(3, 3);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.RowHeadersWidth = 51;
            this.UserGridView.RowTemplate.Height = 27;
            this.UserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridView.Size = new System.Drawing.Size(738, 353);
            this.UserGridView.TabIndex = 2;
            this.UserGridView.Visible = false;
            this.UserGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserGridView_KeyDown);
            // 
            // OrderGridView
            // 
            this.OrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Location = new System.Drawing.Point(3, 3);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowHeadersWidth = 51;
            this.OrderGridView.RowTemplate.Height = 27;
            this.OrderGridView.Size = new System.Drawing.Size(738, 353);
            this.OrderGridView.TabIndex = 4;
            this.OrderGridView.Visible = false;
            // 
            // SampleView
            // 
            this.SampleView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SampleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SampleView.Location = new System.Drawing.Point(4, 3);
            this.SampleView.Name = "SampleView";
            this.SampleView.RowHeadersWidth = 51;
            this.SampleView.RowTemplate.Height = 27;
            this.SampleView.Size = new System.Drawing.Size(738, 353);
            this.SampleView.TabIndex = 5;
            this.SampleView.Visible = false;
            // 
            // connection
            // 
            this.connection.AutoSize = true;
            this.connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connection.Location = new System.Drawing.Point(823, 144);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(122, 29);
            this.connection.TabIndex = 6;
            this.connection.Text = "DB연결상태";
            // 
            // user_btn
            // 
            this.user_btn.BackColor = System.Drawing.Color.White;
            this.user_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_btn.Location = new System.Drawing.Point(52, 180);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(242, 113);
            this.user_btn.TabIndex = 1;
            this.user_btn.Text = "회원관리";
            this.user_btn.UseVisualStyleBackColor = false;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // EmpGridView
            // 
            this.EmpGridView.BackColor = System.Drawing.Color.White;
            this.EmpGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmpGridView.Location = new System.Drawing.Point(52, 299);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.Size = new System.Drawing.Size(242, 119);
            this.EmpGridView.TabIndex = 2;
            this.EmpGridView.Text = "인력관리";
            this.EmpGridView.UseVisualStyleBackColor = false;
            this.EmpGridView.Click += new System.EventHandler(this.board_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SampleView);
            this.panel1.Controls.Add(this.OrderGridView);
            this.panel1.Controls.Add(this.UserGridView);
            this.panel1.Location = new System.Drawing.Point(300, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 363);
            this.panel1.TabIndex = 7;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.White;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Update_btn.Location = new System.Drawing.Point(300, 65);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(88, 32);
            this.Update_btn.TabIndex = 9;
            this.Update_btn.Text = "업데이트";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.Color.White;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Insert_btn.Location = new System.Drawing.Point(300, 103);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(88, 32);
            this.Insert_btn.TabIndex = 11;
            this.Insert_btn.Text = "추가하기";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.White;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete_btn.Location = new System.Drawing.Point(300, 141);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(88, 32);
            this.Delete_btn.TabIndex = 12;
            this.Delete_btn.Text = "삭제하기";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(394, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "=> Esc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(394, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "=> Enter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(394, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "=> Delete";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(497, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "내보내기(엑셀)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(497, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "내보내기(텍스트)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(628, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "=> Ctrl + S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(628, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "=> Ctrl + Shift + S";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(497, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "검색하기";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(755, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "=> Ctrl + F";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(628, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(755, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 25);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(755, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 24;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(755, 69);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1055, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 47);
            this.button4.TabIndex = 26;
            this.button4.Text = "검색조건    초기화";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 565);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.ord_btn);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ord_btn;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.DataGridView SampleView;
        private System.Windows.Forms.Label connection;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Button EmpGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button4;
    }
}

