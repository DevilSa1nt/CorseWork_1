namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._IdtextBox = new System.Windows.Forms.TextBox();
            this._applyButton = new System.Windows.Forms.Button();
            this._audienceEditTextBox = new System.Windows.Forms.TextBox();
            this._teacherEditTextBox = new System.Windows.Forms.TextBox();
            this._nameEditTextBox = new System.Windows.Forms.TextBox();
            this._timeEditComboBox = new System.Windows.Forms.ComboBox();
            this._dayOfWeekEditComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Audience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._errorLabel = new System.Windows.Forms.Label();
            this._dayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._timeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._audienceTextBox = new System.Windows.Forms.TextBox();
            this._teacherTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._findButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._editButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new Coursework.CrystalReport1();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 734);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._IdtextBox);
            this.tabPage1.Controls.Add(this._applyButton);
            this.tabPage1.Controls.Add(this._audienceEditTextBox);
            this.tabPage1.Controls.Add(this._teacherEditTextBox);
            this.tabPage1.Controls.Add(this._nameEditTextBox);
            this.tabPage1.Controls.Add(this._timeEditComboBox);
            this.tabPage1.Controls.Add(this._dayOfWeekEditComboBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this._errorLabel);
            this.tabPage1.Controls.Add(this._dayOfWeekComboBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this._timeComboBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this._audienceTextBox);
            this.tabPage1.Controls.Add(this._teacherTextBox);
            this.tabPage1.Controls.Add(this._nameTextBox);
            this.tabPage1.Controls.Add(this._findButton);
            this.tabPage1.Controls.Add(this._deleteButton);
            this.tabPage1.Controls.Add(this._editButton);
            this.tabPage1.Controls.Add(this._addButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(921, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _IdtextBox
            // 
            this._IdtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._IdtextBox.Location = new System.Drawing.Point(283, 423);
            this._IdtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._IdtextBox.Name = "_IdtextBox";
            this._IdtextBox.Size = new System.Drawing.Size(76, 20);
            this._IdtextBox.TabIndex = 0;
            // 
            // _applyButton
            // 
            this._applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._applyButton.Location = new System.Drawing.Point(547, 448);
            this._applyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._applyButton.Name = "_applyButton";
            this._applyButton.Size = new System.Drawing.Size(56, 19);
            this._applyButton.TabIndex = 23;
            this._applyButton.Text = "Apply";
            this._applyButton.UseVisualStyleBackColor = true;
            // 
            // _audienceEditTextBox
            // 
            this._audienceEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._audienceEditTextBox.Location = new System.Drawing.Point(737, 423);
            this._audienceEditTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._audienceEditTextBox.Name = "_audienceEditTextBox";
            this._audienceEditTextBox.Size = new System.Drawing.Size(76, 20);
            this._audienceEditTextBox.TabIndex = 22;
            // 
            // _teacherEditTextBox
            // 
            this._teacherEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._teacherEditTextBox.Location = new System.Drawing.Point(657, 423);
            this._teacherEditTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._teacherEditTextBox.Name = "_teacherEditTextBox";
            this._teacherEditTextBox.Size = new System.Drawing.Size(76, 20);
            this._teacherEditTextBox.TabIndex = 21;
            // 
            // _nameEditTextBox
            // 
            this._nameEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._nameEditTextBox.Location = new System.Drawing.Point(576, 423);
            this._nameEditTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._nameEditTextBox.Name = "_nameEditTextBox";
            this._nameEditTextBox.Size = new System.Drawing.Size(78, 20);
            this._nameEditTextBox.TabIndex = 20;
            // 
            // _timeEditComboBox
            // 
            this._timeEditComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._timeEditComboBox.FormattingEnabled = true;
            this._timeEditComboBox.Items.AddRange(new object[] {
            "09.00 - 10.35",
            "10.50 - 12.25",
            "12.40 - 14.15",
            "14.30 - 16.05",
            "16.20 - 17.55",
            "18.10 - 19.45",
            "20.00 - 21.35",
            " "});
            this._timeEditComboBox.Location = new System.Drawing.Point(481, 423);
            this._timeEditComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._timeEditComboBox.Name = "_timeEditComboBox";
            this._timeEditComboBox.Size = new System.Drawing.Size(92, 21);
            this._timeEditComboBox.TabIndex = 19;
            // 
            // _dayOfWeekEditComboBox
            // 
            this._dayOfWeekEditComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._dayOfWeekEditComboBox.FormattingEnabled = true;
            this._dayOfWeekEditComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            " "});
            this._dayOfWeekEditComboBox.Location = new System.Drawing.Point(363, 423);
            this._dayOfWeekEditComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._dayOfWeekEditComboBox.Name = "_dayOfWeekEditComboBox";
            this._dayOfWeekEditComboBox.Size = new System.Drawing.Size(114, 21);
            this._dayOfWeekEditComboBox.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DayOfWeek,
            this.Time,
            this.NamePair,
            this.Teacher,
            this.Audience});
            this.dataGridView1.Location = new System.Drawing.Point(315, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 308);
            this.dataGridView1.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.HeaderText = "Day of week";
            this.DayOfWeek.MinimumWidth = 6;
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // NamePair
            // 
            this.NamePair.HeaderText = "Name";
            this.NamePair.MinimumWidth = 6;
            this.NamePair.Name = "NamePair";
            this.NamePair.ReadOnly = true;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Teacher";
            this.Teacher.MinimumWidth = 6;
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            // 
            // Audience
            // 
            this.Audience.HeaderText = "Audience";
            this.Audience.MinimumWidth = 6;
            this.Audience.Name = "Audience";
            this.Audience.ReadOnly = true;
            // 
            // _errorLabel
            // 
            this._errorLabel.AutoSize = true;
            this._errorLabel.Location = new System.Drawing.Point(146, 415);
            this._errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._errorLabel.Name = "_errorLabel";
            this._errorLabel.Size = new System.Drawing.Size(0, 13);
            this._errorLabel.TabIndex = 16;
            // 
            // _dayOfWeekComboBox
            // 
            this._dayOfWeekComboBox.AllowDrop = true;
            this._dayOfWeekComboBox.FormattingEnabled = true;
            this._dayOfWeekComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            " "});
            this._dayOfWeekComboBox.Location = new System.Drawing.Point(71, 5);
            this._dayOfWeekComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._dayOfWeekComboBox.Name = "_dayOfWeekComboBox";
            this._dayOfWeekComboBox.Size = new System.Drawing.Size(100, 21);
            this._dayOfWeekComboBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Day of week";
            // 
            // _timeComboBox
            // 
            this._timeComboBox.FormattingEnabled = true;
            this._timeComboBox.Items.AddRange(new object[] {
            "09.00 - 10.35",
            "10.50 - 12.25",
            "12.40 - 14.15",
            "14.30 - 16.05",
            "16.20 - 17.55",
            "18.10 - 19.45",
            "20.00 - 21.35",
            " "});
            this._timeComboBox.Location = new System.Drawing.Point(71, 29);
            this._timeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._timeComboBox.Name = "_timeComboBox";
            this._timeComboBox.Size = new System.Drawing.Size(100, 21);
            this._timeComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Audience";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time";
            // 
            // _audienceTextBox
            // 
            this._audienceTextBox.Location = new System.Drawing.Point(71, 101);
            this._audienceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._audienceTextBox.Name = "_audienceTextBox";
            this._audienceTextBox.Size = new System.Drawing.Size(100, 20);
            this._audienceTextBox.TabIndex = 8;
            // 
            // _teacherTextBox
            // 
            this._teacherTextBox.Location = new System.Drawing.Point(71, 77);
            this._teacherTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._teacherTextBox.Name = "_teacherTextBox";
            this._teacherTextBox.Size = new System.Drawing.Size(100, 20);
            this._teacherTextBox.TabIndex = 7;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(71, 54);
            this._nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(100, 20);
            this._nameTextBox.TabIndex = 6;
            // 
            // _findButton
            // 
            this._findButton.Location = new System.Drawing.Point(121, 125);
            this._findButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._findButton.Name = "_findButton";
            this._findButton.Size = new System.Drawing.Size(56, 19);
            this._findButton.TabIndex = 4;
            this._findButton.Text = "Find";
            this._findButton.UseVisualStyleBackColor = true;
            // 
            // _deleteButton
            // 
            this._deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._deleteButton.Location = new System.Drawing.Point(577, 400);
            this._deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(56, 19);
            this._deleteButton.TabIndex = 3;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            // 
            // _editButton
            // 
            this._editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._editButton.Location = new System.Drawing.Point(517, 400);
            this._editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(56, 19);
            this._editButton.TabIndex = 2;
            this._editButton.Text = "Edit";
            this._editButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(61, 125);
            this._addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(56, 19);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.crystalReportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(921, 708);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 2);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(917, 706);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 756);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _audienceTextBox;
        private System.Windows.Forms.TextBox _teacherTextBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Button _findButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Button _editButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.ComboBox _timeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _dayOfWeekComboBox;
        private System.Windows.Forms.Label _errorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Audience;
        private System.Windows.Forms.TextBox _IdtextBox;
        private System.Windows.Forms.Button _applyButton;
        private System.Windows.Forms.TextBox _audienceEditTextBox;
        private System.Windows.Forms.TextBox _teacherEditTextBox;
        private System.Windows.Forms.TextBox _nameEditTextBox;
        private System.Windows.Forms.ComboBox _timeEditComboBox;
        private System.Windows.Forms.ComboBox _dayOfWeekEditComboBox;
    }
}

