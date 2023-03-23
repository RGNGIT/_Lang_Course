namespace _Lang_Course
{
    partial class App
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxPercentOfSpread = new TextBox();
            label2 = new Label();
            textBoxCharAmount = new TextBox();
            label1 = new Label();
            buttonAddLang = new Button();
            dataGridViewLangs = new DataGridView();
            tabControlLangs = new TabControl();
            tabPage5 = new TabPage();
            textBoxSpeakerType = new TextBox();
            label3 = new Label();
            tabPage6 = new TabPage();
            textBoxGlypthType = new TextBox();
            label4 = new Label();
            tabPage7 = new TabPage();
            textBoxDialect = new TextBox();
            label5 = new Label();
            tabPage8 = new TabPage();
            textBoxRegion = new TextBox();
            label6 = new Label();
            tabPage3 = new TabPage();
            buttonAddLevel = new Button();
            comboBoxLanguage = new ComboBox();
            label9 = new Label();
            comboBoxLevel = new ComboBox();
            dataGridViewMasterings = new DataGridView();
            label8 = new Label();
            tabPage2 = new TabPage();
            buttonDeleteListener = new Button();
            buttonAddListener = new Button();
            dataGridViewListeners = new DataGridView();
            textBoxListenerFIO = new TextBox();
            label7 = new Label();
            tabPage4 = new TabPage();
            buttonDeleteCourse = new Button();
            textBoxCoursePrice = new TextBox();
            label14 = new Label();
            buttonAddCourse = new Button();
            tabControlCourseType = new TabControl();
            tabPage9 = new TabPage();
            label12 = new Label();
            dataGridViewCourseGroupStud = new DataGridView();
            tabPage10 = new TabPage();
            comboBoxCourseStudent = new ComboBox();
            label13 = new Label();
            label11 = new Label();
            textBoxCourseName = new TextBox();
            label10 = new Label();
            dataGridViewCourse = new DataGridView();
            comboBoxCourseLevel = new ComboBox();
            tabPage12 = new TabPage();
            listBox1 = new ListBox();
            labelCurrentDay = new Label();
            buttonSwitchDay = new Button();
            tabPage11 = new TabPage();
            textBoxFilename = new TextBox();
            label15 = new Label();
            dataGridViewSaves = new DataGridView();
            buttonLoad = new Button();
            buttonSave = new Button();
            checkBoxEmptyCourse = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLangs).BeginInit();
            tabControlLangs.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasterings).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListeners).BeginInit();
            tabPage4.SuspendLayout();
            tabControlCourseType.SuspendLayout();
            tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourseGroupStud).BeginInit();
            tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourse).BeginInit();
            tabPage12.SuspendLayout();
            tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaves).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage12);
            tabControl1.Controls.Add(tabPage11);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1065, 605);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxPercentOfSpread);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBoxCharAmount);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonAddLang);
            tabPage1.Controls.Add(dataGridViewLangs);
            tabPage1.Controls.Add(tabControlLangs);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1057, 577);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Языки";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxPercentOfSpread
            // 
            textBoxPercentOfSpread.Location = new Point(10, 69);
            textBoxPercentOfSpread.Name = "textBoxPercentOfSpread";
            textBoxPercentOfSpread.Size = new Size(334, 23);
            textBoxPercentOfSpread.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(196, 15);
            label2.TabIndex = 5;
            label2.Text = "Процент распространения в мире";
            // 
            // textBoxCharAmount
            // 
            textBoxCharAmount.Location = new Point(10, 24);
            textBoxCharAmount.Name = "textBoxCharAmount";
            textBoxCharAmount.Size = new Size(334, 23);
            textBoxCharAmount.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Кол-во символов";
            // 
            // buttonAddLang
            // 
            buttonAddLang.Location = new Point(6, 548);
            buttonAddLang.Name = "buttonAddLang";
            buttonAddLang.Size = new Size(338, 23);
            buttonAddLang.TabIndex = 2;
            buttonAddLang.Text = "Добавить";
            buttonAddLang.UseVisualStyleBackColor = true;
            buttonAddLang.Click += buttonAddLang_Click;
            // 
            // dataGridViewLangs
            // 
            dataGridViewLangs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLangs.Location = new Point(354, 6);
            dataGridViewLangs.Name = "dataGridViewLangs";
            dataGridViewLangs.RowTemplate.Height = 25;
            dataGridViewLangs.Size = new Size(697, 565);
            dataGridViewLangs.TabIndex = 1;
            // 
            // tabControlLangs
            // 
            tabControlLangs.Controls.Add(tabPage5);
            tabControlLangs.Controls.Add(tabPage6);
            tabControlLangs.Controls.Add(tabPage7);
            tabControlLangs.Controls.Add(tabPage8);
            tabControlLangs.Location = new Point(6, 98);
            tabControlLangs.Name = "tabControlLangs";
            tabControlLangs.SelectedIndex = 0;
            tabControlLangs.Size = new Size(342, 444);
            tabControlLangs.TabIndex = 0;
            tabControlLangs.SelectedIndexChanged += tabControlLangs_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(textBoxSpeakerType);
            tabPage5.Controls.Add(label3);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(334, 416);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Английский";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxSpeakerType
            // 
            textBoxSpeakerType.Location = new Point(7, 21);
            textBoxSpeakerType.Name = "textBoxSpeakerType";
            textBoxSpeakerType.Size = new Size(324, 23);
            textBoxSpeakerType.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 7;
            label3.Text = "Тип носителя";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBoxGlypthType);
            tabPage6.Controls.Add(label4);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(334, 416);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Японский";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBoxGlypthType
            // 
            textBoxGlypthType.Location = new Point(7, 21);
            textBoxGlypthType.Name = "textBoxGlypthType";
            textBoxGlypthType.Size = new Size(324, 23);
            textBoxGlypthType.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 9;
            label4.Text = "Тип иероглифов";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(textBoxDialect);
            tabPage7.Controls.Add(label5);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(334, 416);
            tabPage7.TabIndex = 2;
            tabPage7.Text = "Немецкий";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // textBoxDialect
            // 
            textBoxDialect.Location = new Point(7, 21);
            textBoxDialect.Name = "textBoxDialect";
            textBoxDialect.Size = new Size(324, 23);
            textBoxDialect.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 9;
            label5.Text = "Диалект";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(textBoxRegion);
            tabPage8.Controls.Add(label6);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(334, 416);
            tabPage8.TabIndex = 3;
            tabPage8.Text = "Французский";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBoxRegion
            // 
            textBoxRegion.Location = new Point(7, 21);
            textBoxRegion.Name = "textBoxRegion";
            textBoxRegion.Size = new Size(324, 23);
            textBoxRegion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 9;
            label6.Text = "Регион";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonAddLevel);
            tabPage3.Controls.Add(comboBoxLanguage);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(comboBoxLevel);
            tabPage3.Controls.Add(dataGridViewMasterings);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1057, 577);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Уровни освоения";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAddLevel
            // 
            buttonAddLevel.Location = new Point(6, 548);
            buttonAddLevel.Name = "buttonAddLevel";
            buttonAddLevel.Size = new Size(334, 23);
            buttonAddLevel.TabIndex = 12;
            buttonAddLevel.Text = "Добавить";
            buttonAddLevel.UseVisualStyleBackColor = true;
            buttonAddLevel.Click += buttonAddLevel_Click;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(6, 69);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(342, 23);
            comboBoxLanguage.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 51);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 10;
            label9.Text = "Язык";
            // 
            // comboBoxLevel
            // 
            comboBoxLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLevel.FormattingEnabled = true;
            comboBoxLevel.Location = new Point(6, 24);
            comboBoxLevel.Name = "comboBoxLevel";
            comboBoxLevel.Size = new Size(342, 23);
            comboBoxLevel.TabIndex = 9;
            // 
            // dataGridViewMasterings
            // 
            dataGridViewMasterings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMasterings.Location = new Point(354, 6);
            dataGridViewMasterings.Name = "dataGridViewMasterings";
            dataGridViewMasterings.RowTemplate.Height = 25;
            dataGridViewMasterings.Size = new Size(697, 565);
            dataGridViewMasterings.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 6);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 6;
            label8.Text = "Уровень";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonDeleteListener);
            tabPage2.Controls.Add(buttonAddListener);
            tabPage2.Controls.Add(dataGridViewListeners);
            tabPage2.Controls.Add(textBoxListenerFIO);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1057, 577);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Слушатели";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteListener
            // 
            buttonDeleteListener.ForeColor = Color.Red;
            buttonDeleteListener.Location = new Point(6, 548);
            buttonDeleteListener.Name = "buttonDeleteListener";
            buttonDeleteListener.Size = new Size(334, 23);
            buttonDeleteListener.TabIndex = 9;
            buttonDeleteListener.Text = "Удалить выбранное";
            buttonDeleteListener.UseVisualStyleBackColor = true;
            buttonDeleteListener.Click += buttonDeleteListener_Click;
            // 
            // buttonAddListener
            // 
            buttonAddListener.Location = new Point(6, 519);
            buttonAddListener.Name = "buttonAddListener";
            buttonAddListener.Size = new Size(334, 23);
            buttonAddListener.TabIndex = 8;
            buttonAddListener.Text = "Добавить";
            buttonAddListener.UseVisualStyleBackColor = true;
            buttonAddListener.Click += buttonAddListener_Click;
            // 
            // dataGridViewListeners
            // 
            dataGridViewListeners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListeners.Location = new Point(354, 6);
            dataGridViewListeners.Name = "dataGridViewListeners";
            dataGridViewListeners.RowTemplate.Height = 25;
            dataGridViewListeners.Size = new Size(697, 565);
            dataGridViewListeners.TabIndex = 7;
            // 
            // textBoxListenerFIO
            // 
            textBoxListenerFIO.Location = new Point(14, 23);
            textBoxListenerFIO.Name = "textBoxListenerFIO";
            textBoxListenerFIO.Size = new Size(334, 23);
            textBoxListenerFIO.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 5);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 5;
            label7.Text = "ФИО";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(buttonDeleteCourse);
            tabPage4.Controls.Add(textBoxCoursePrice);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(buttonAddCourse);
            tabPage4.Controls.Add(tabControlCourseType);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(textBoxCourseName);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(dataGridViewCourse);
            tabPage4.Controls.Add(comboBoxCourseLevel);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1057, 577);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Курсы";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCourse
            // 
            buttonDeleteCourse.ForeColor = Color.Red;
            buttonDeleteCourse.Location = new Point(183, 548);
            buttonDeleteCourse.Name = "buttonDeleteCourse";
            buttonDeleteCourse.Size = new Size(157, 23);
            buttonDeleteCourse.TabIndex = 18;
            buttonDeleteCourse.Text = "Удалить выбранное";
            buttonDeleteCourse.UseVisualStyleBackColor = true;
            buttonDeleteCourse.Click += buttonDeleteCourse_Click;
            // 
            // textBoxCoursePrice
            // 
            textBoxCoursePrice.Location = new Point(10, 112);
            textBoxCoursePrice.Name = "textBoxCoursePrice";
            textBoxCoursePrice.Size = new Size(334, 23);
            textBoxCoursePrice.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 94);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 16;
            label14.Text = "Стоимость";
            // 
            // buttonAddCourse
            // 
            buttonAddCourse.Location = new Point(6, 548);
            buttonAddCourse.Name = "buttonAddCourse";
            buttonAddCourse.Size = new Size(159, 23);
            buttonAddCourse.TabIndex = 15;
            buttonAddCourse.Text = "Добавить";
            buttonAddCourse.UseVisualStyleBackColor = true;
            buttonAddCourse.Click += buttonAddCourse_Click;
            // 
            // tabControlCourseType
            // 
            tabControlCourseType.Controls.Add(tabPage9);
            tabControlCourseType.Controls.Add(tabPage10);
            tabControlCourseType.Location = new Point(10, 141);
            tabControlCourseType.Name = "tabControlCourseType";
            tabControlCourseType.SelectedIndex = 0;
            tabControlCourseType.Size = new Size(334, 401);
            tabControlCourseType.TabIndex = 14;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(checkBoxEmptyCourse);
            tabPage9.Controls.Add(label12);
            tabPage9.Controls.Add(dataGridViewCourseGroupStud);
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(326, 373);
            tabPage9.TabIndex = 0;
            tabPage9.Text = "Групповой";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 3);
            label12.Name = "label12";
            label12.Size = new Size(158, 15);
            label12.TabIndex = 16;
            label12.Text = "Выделить группу студентов";
            // 
            // dataGridViewCourseGroupStud
            // 
            dataGridViewCourseGroupStud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourseGroupStud.Location = new Point(6, 21);
            dataGridViewCourseGroupStud.Name = "dataGridViewCourseGroupStud";
            dataGridViewCourseGroupStud.RowTemplate.Height = 25;
            dataGridViewCourseGroupStud.Size = new Size(314, 346);
            dataGridViewCourseGroupStud.TabIndex = 0;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(comboBoxCourseStudent);
            tabPage10.Controls.Add(label13);
            tabPage10.Location = new Point(4, 24);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(326, 373);
            tabPage10.TabIndex = 1;
            tabPage10.Text = "Индивидуальный";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // comboBoxCourseStudent
            // 
            comboBoxCourseStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCourseStudent.FormattingEnabled = true;
            comboBoxCourseStudent.Location = new Point(6, 21);
            comboBoxCourseStudent.Name = "comboBoxCourseStudent";
            comboBoxCourseStudent.Size = new Size(314, 23);
            comboBoxCourseStudent.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 3);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 17;
            label13.Text = "Студент";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 50);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 12;
            label11.Text = "Уровень";
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new Point(10, 24);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new Size(334, 23);
            textBoxCourseName.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 6);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 10;
            label10.Text = "Название";
            // 
            // dataGridViewCourse
            // 
            dataGridViewCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourse.Location = new Point(354, 6);
            dataGridViewCourse.Name = "dataGridViewCourse";
            dataGridViewCourse.RowTemplate.Height = 25;
            dataGridViewCourse.Size = new Size(697, 565);
            dataGridViewCourse.TabIndex = 9;
            // 
            // comboBoxCourseLevel
            // 
            comboBoxCourseLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCourseLevel.FormattingEnabled = true;
            comboBoxCourseLevel.Location = new Point(10, 68);
            comboBoxCourseLevel.Name = "comboBoxCourseLevel";
            comboBoxCourseLevel.Size = new Size(334, 23);
            comboBoxCourseLevel.TabIndex = 13;
            // 
            // tabPage12
            // 
            tabPage12.Controls.Add(listBox1);
            tabPage12.Controls.Add(labelCurrentDay);
            tabPage12.Controls.Add(buttonSwitchDay);
            tabPage12.Location = new Point(4, 24);
            tabPage12.Name = "tabPage12";
            tabPage12.Padding = new Padding(3);
            tabPage12.Size = new Size(1057, 577);
            tabPage12.TabIndex = 5;
            tabPage12.Text = "Моделирование";
            tabPage12.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1045, 514);
            listBox1.TabIndex = 3;
            // 
            // labelCurrentDay
            // 
            labelCurrentDay.AutoSize = true;
            labelCurrentDay.Location = new Point(6, 3);
            labelCurrentDay.Name = "labelCurrentDay";
            labelCurrentDay.Size = new Size(44, 15);
            labelCurrentDay.TabIndex = 2;
            labelCurrentDay.Text = "label16";
            // 
            // buttonSwitchDay
            // 
            buttonSwitchDay.Location = new Point(6, 548);
            buttonSwitchDay.Name = "buttonSwitchDay";
            buttonSwitchDay.Size = new Size(1045, 23);
            buttonSwitchDay.TabIndex = 0;
            buttonSwitchDay.Text = "Следующий день";
            buttonSwitchDay.UseVisualStyleBackColor = true;
            buttonSwitchDay.Click += buttonSwitchDay_Click;
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(textBoxFilename);
            tabPage11.Controls.Add(label15);
            tabPage11.Controls.Add(dataGridViewSaves);
            tabPage11.Controls.Add(buttonLoad);
            tabPage11.Controls.Add(buttonSave);
            tabPage11.Location = new Point(4, 24);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new Padding(3);
            tabPage11.Size = new Size(1057, 577);
            tabPage11.TabIndex = 4;
            tabPage11.Text = "Менеджер сохранений";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // textBoxFilename
            // 
            textBoxFilename.Location = new Point(6, 490);
            textBoxFilename.Name = "textBoxFilename";
            textBoxFilename.Size = new Size(342, 23);
            textBoxFilename.TabIndex = 19;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 472);
            label15.Name = "label15";
            label15.Size = new Size(274, 15);
            label15.TabIndex = 18;
            label15.Text = "Файлнейм (пустое поле по дефолту \"CourseDB\")";
            // 
            // dataGridViewSaves
            // 
            dataGridViewSaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaves.Location = new Point(354, 6);
            dataGridViewSaves.Name = "dataGridViewSaves";
            dataGridViewSaves.RowTemplate.Height = 25;
            dataGridViewSaves.Size = new Size(697, 565);
            dataGridViewSaves.TabIndex = 10;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(6, 548);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(342, 23);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(6, 519);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(342, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // checkBoxEmptyCourse
            // 
            checkBoxEmptyCourse.AutoSize = true;
            checkBoxEmptyCourse.Location = new Point(249, 2);
            checkBoxEmptyCourse.Name = "checkBoxEmptyCourse";
            checkBoxEmptyCourse.Size = new Size(71, 19);
            checkBoxEmptyCourse.TabIndex = 17;
            checkBoxEmptyCourse.Text = "Пустой?";
            checkBoxEmptyCourse.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 629);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "App";
            Text = "App";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLangs).EndInit();
            tabControlLangs.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasterings).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListeners).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabControlCourseType.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourseGroupStud).EndInit();
            tabPage10.ResumeLayout(false);
            tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourse).EndInit();
            tabPage12.ResumeLayout(false);
            tabPage12.PerformLayout();
            tabPage11.ResumeLayout(false);
            tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaves).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button buttonAddLang;
        private DataGridView dataGridViewLangs;
        private TabControl tabControlLangs;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TextBox textBoxPercentOfSpread;
        private Label label2;
        private TextBox textBoxCharAmount;
        private Label label1;
        private TextBox textBoxSpeakerType;
        private Label label3;
        private TextBox textBoxGlypthType;
        private Label label4;
        private TextBox textBoxDialect;
        private Label label5;
        private TextBox textBoxRegion;
        private Label label6;
        private TextBox textBoxListenerFIO;
        private Label label7;
        private Button buttonAddListener;
        private DataGridView dataGridViewListeners;
        private ComboBox comboBoxLevel;
        private DataGridView dataGridViewMasterings;
        private Label label8;
        private Button buttonAddLevel;
        private ComboBox comboBoxLanguage;
        private Label label9;
        private DataGridView dataGridViewCourse;
        private Label label11;
        private TextBox textBoxCourseName;
        private Label label10;
        private ComboBox comboBoxCourseLevel;
        private Button buttonAddCourse;
        private TabControl tabControlCourseType;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private Label label12;
        private DataGridView dataGridViewCourseGroupStud;
        private Label label13;
        private ComboBox comboBoxCourseStudent;
        private TabPage tabPage11;
        private Button buttonLoad;
        private Button buttonSave;
        private DataGridView dataGridViewSaves;
        private TextBox textBoxCoursePrice;
        private Label label14;
        private TextBox textBoxFilename;
        private Label label15;
        private Button buttonDeleteListener;
        private Button buttonDeleteCourse;
        private TabPage tabPage12;
        private Label labelCurrentDay;
        private Button buttonSwitchDay;
        private ListBox listBox1;
        private CheckBox checkBoxEmptyCourse;
    }
}