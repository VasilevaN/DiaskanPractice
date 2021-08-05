
namespace DiascanTEST
{
    partial class User_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_New_Task = new System.Windows.Forms.Button();
            this.dataGridView_New_Task = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Done_Task_Users = new System.Windows.Forms.ComboBox();
            this.btn_Done_Task = new System.Windows.Forms.Button();
            this.dataGridView_Done_Task = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_My_Task = new System.Windows.Forms.Button();
            this.dataGridView_My_Task = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add_Task = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Add_Task_Users = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox_My_Login = new System.Windows.Forms.ComboBox();
            this.comboBox_NewTask = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_New_Task)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Done_Task)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_My_Task)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox_NewTask);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btn_New_Task);
            this.tabPage1.Controls.Add(this.dataGridView_New_Task);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Выберите пользователя";
            // 
            // btn_New_Task
            // 
            this.btn_New_Task.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_New_Task.Location = new System.Drawing.Point(8, 393);
            this.btn_New_Task.Name = "btn_New_Task";
            this.btn_New_Task.Size = new System.Drawing.Size(168, 23);
            this.btn_New_Task.TabIndex = 1;
            this.btn_New_Task.Text = "Показать новые задачи";
            this.btn_New_Task.UseVisualStyleBackColor = false;
            this.btn_New_Task.Click += new System.EventHandler(this.btn_New_Task_Click);
            // 
            // dataGridView_New_Task
            // 
            this.dataGridView_New_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_New_Task.Location = new System.Drawing.Point(8, 6);
            this.dataGridView_New_Task.Name = "dataGridView_New_Task";
            this.dataGridView_New_Task.Size = new System.Drawing.Size(471, 381);
            this.dataGridView_New_Task.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBox_Done_Task_Users);
            this.tabPage2.Controls.Add(this.btn_Done_Task);
            this.tabPage2.Controls.Add(this.dataGridView_Done_Task);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(485, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Done";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Выберите пользователя";
            // 
            // comboBox_Done_Task_Users
            // 
            this.comboBox_Done_Task_Users.FormattingEnabled = true;
            this.comboBox_Done_Task_Users.Location = new System.Drawing.Point(361, 396);
            this.comboBox_Done_Task_Users.Name = "comboBox_Done_Task_Users";
            this.comboBox_Done_Task_Users.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Done_Task_Users.TabIndex = 2;
            // 
            // btn_Done_Task
            // 
            this.btn_Done_Task.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Done_Task.Location = new System.Drawing.Point(8, 396);
            this.btn_Done_Task.Name = "btn_Done_Task";
            this.btn_Done_Task.Size = new System.Drawing.Size(192, 23);
            this.btn_Done_Task.TabIndex = 1;
            this.btn_Done_Task.Text = "Показать выполненные задачи";
            this.btn_Done_Task.UseVisualStyleBackColor = false;
            this.btn_Done_Task.Click += new System.EventHandler(this.btn_Done_Task_Click);
            // 
            // dataGridView_Done_Task
            // 
            this.dataGridView_Done_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Done_Task.Location = new System.Drawing.Point(8, 6);
            this.dataGridView_Done_Task.Name = "dataGridView_Done_Task";
            this.dataGridView_Done_Task.Size = new System.Drawing.Size(471, 384);
            this.dataGridView_Done_Task.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox_My_Login);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btn_My_Task);
            this.tabPage3.Controls.Add(this.dataGridView_My_Task);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(485, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Укажите ваш логин";
            // 
            // btn_My_Task
            // 
            this.btn_My_Task.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_My_Task.Location = new System.Drawing.Point(8, 393);
            this.btn_My_Task.Name = "btn_My_Task";
            this.btn_My_Task.Size = new System.Drawing.Size(137, 23);
            this.btn_My_Task.TabIndex = 1;
            this.btn_My_Task.Text = "Показать мои задачи";
            this.btn_My_Task.UseVisualStyleBackColor = false;
            this.btn_My_Task.Click += new System.EventHandler(this.btn_My_Task_Click);
            // 
            // dataGridView_My_Task
            // 
            this.dataGridView_My_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_My_Task.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_My_Task.Name = "dataGridView_My_Task";
            this.dataGridView_My_Task.Size = new System.Drawing.Size(471, 379);
            this.dataGridView_My_Task.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.btn_Add_Task);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.comboBox_Add_Task_Users);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(485, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Для внесения изменений в таблицу Task, заполните поля расположенные ниже";
            // 
            // btn_Add_Task
            // 
            this.btn_Add_Task.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add_Task.Location = new System.Drawing.Point(31, 189);
            this.btn_Add_Task.Name = "btn_Add_Task";
            this.btn_Add_Task.Size = new System.Drawing.Size(132, 23);
            this.btn_Add_Task.TabIndex = 8;
            this.btn_Add_Task.Text = "Добавить задание";
            this.btn_Add_Task.UseVisualStyleBackColor = true;
            this.btn_Add_Task.Click += new System.EventHandler(this.btn_Add_Task_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Исполнитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Задание";
            // 
            // comboBox_Add_Task_Users
            // 
            this.comboBox_Add_Task_Users.FormattingEnabled = true;
            this.comboBox_Add_Task_Users.Location = new System.Drawing.Point(108, 134);
            this.comboBox_Add_Task_Users.Name = "comboBox_Add_Task_Users";
            this.comboBox_Add_Task_Users.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Add_Task_Users.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Принято",
            "В работе",
            "Выполнено"});
            this.comboBox1.Location = new System.Drawing.Point(108, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 21);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox_My_Login
            // 
            this.comboBox_My_Login.FormattingEnabled = true;
            this.comboBox_My_Login.Location = new System.Drawing.Point(353, 395);
            this.comboBox_My_Login.Name = "comboBox_My_Login";
            this.comboBox_My_Login.Size = new System.Drawing.Size(121, 21);
            this.comboBox_My_Login.TabIndex = 4;
            // 
            // comboBox_NewTask
            // 
            this.comboBox_NewTask.FormattingEnabled = true;
            this.comboBox_NewTask.Location = new System.Drawing.Point(358, 393);
            this.comboBox_NewTask.Name = "comboBox_NewTask";
            this.comboBox_NewTask.Size = new System.Drawing.Size(121, 21);
            this.comboBox_NewTask.TabIndex = 4;
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "User_Form";
            this.Text = "Форма пользователя";
            this.Activated += new System.EventHandler(this.User_Form_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_New_Task)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Done_Task)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_My_Task)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView_New_Task;
        private System.Windows.Forms.DataGridView dataGridView_Done_Task;
        private System.Windows.Forms.DataGridView dataGridView_My_Task;
        private System.Windows.Forms.Button btn_New_Task;
        private System.Windows.Forms.Button btn_Done_Task;
        private System.Windows.Forms.Button btn_My_Task;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add_Task;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Add_Task_Users;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Done_Task_Users;
        private System.Windows.Forms.ComboBox comboBox_My_Login;
        private System.Windows.Forms.ComboBox comboBox_NewTask;
    }
}