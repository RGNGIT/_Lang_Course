﻿using _Lang_Course.CourseEngine;
using _Lang_Course.CourseEngine.Classes.Courses;
using _Lang_Course.CourseEngine.Classes.Languages;
using _Lang_Course.CourseEngine.Classes.Masterings;
using System;

#pragma warning disable CS8602

namespace _Lang_Course
{

    public enum Languages
    {
        English  = 0,
        Japanese = 1,
        German   = 2,
        French   = 3
    }

    public partial class App : Form
    {

        CourseEngineCore CourseEngine = new(new Storage());

        public App()
        {
            InitializeComponent();
            FormatLangGrid(tabControlLangs.SelectedIndex);
            dataGridViewListeners.Columns.Add("_FIO", "ФИО");
            dataGridViewListeners.Columns.Add("_isOld", "Новичок?");
            comboBoxLevel.Items.Add("Начальный");
            comboBoxLevel.Items.Add("Средний");
            comboBoxLevel.Items.Add("Продвинутый");
            dataGridViewMasterings.Columns.Add("_lang", "Язык");
            dataGridViewMasterings.Columns.Add("_level", "Уровень");
            dataGridViewCourse.Columns.Add("_name", "Название");
            dataGridViewCourse.Columns.Add("_level", "Уровень");
            dataGridViewCourse.Columns.Add("_students", "Студенты");
            dataGridViewCourseGroupStud.Columns.Add("FIO", "ФИО");
        }

        void RefreshCourseGrid()
        {
            dataGridViewCourse.Rows.Clear();
            foreach(Course? course in CourseEngine.storage.Courses)
            {
                dataGridViewCourse.Rows.Add(
                    course.Name, 
                    $"{CourseEngine.DefineLang(course.Mastering.Language)} - {CourseEngine.DefineMastering(course.Mastering)}",
                    CourseEngine.StringifyListOfListeners(course)
                    );
            }
        }

        void RefreshStudentsCourseGrid()
        {
            dataGridViewCourseGroupStud.Rows.Clear();
            comboBoxCourseStudent.Items.Clear();
            foreach(Listener? listener in CourseEngine.storage.Listeners)
            {
                dataGridViewCourseGroupStud.Rows.Add(listener.FIO);
                comboBoxCourseStudent.Items.Add(listener.FIO);
            }
        }

        void RefreshMasteringsCombo()
        {
            comboBoxCourseLevel.Items.Clear();
            foreach (var mastering in CourseEngine.storage.Masterings)
            {
                comboBoxCourseLevel.Items.Add($"{CourseEngine.DefineLang(mastering.Language)} - {CourseEngine.DefineMastering(mastering)}");
            }
        }

        void RefreshMasteringsGrid()
        {
            dataGridViewMasterings.Rows.Clear();
            foreach(var mastering in CourseEngine.storage.Masterings) 
            {
                dataGridViewMasterings.Rows.Add(CourseEngine.DefineLang(mastering.Language), CourseEngine.DefineMastering(mastering));
            }
        }

        void RefreshLangLevelCombo()
        {
            comboBoxLanguage.Items.Clear();
            foreach (Language? language in CourseEngine.storage.Languages)
            {
                comboBoxLanguage.Items.Add(CourseEngine.DefineLang(language!));
            }
        }

        void RefreshListenerGrid()
        {
            dataGridViewListeners.Rows.Clear();
            foreach(Listener? listener in CourseEngine.storage.Listeners)
            {
                dataGridViewListeners.Rows.Add(listener.FIO, !listener.isOld ? "Да" : "Нет");
            }
        }

        void FormatLangGrid(int Lang)
        {
            dataGridViewLangs.Rows.Clear();
            dataGridViewLangs.Columns.Clear();
            dataGridViewLangs.Columns.Add("_charAmount", "Кол-во символов");
            dataGridViewLangs.Columns.Add("_spreadPercent", "Процент мирового распространения");
            switch (Lang) 
            {
                case (int)Languages.English:
                    dataGridViewLangs.Columns.Add("_speakerType", "Тип носителя");
                    break;
                case (int)Languages.Japanese:
                    dataGridViewLangs.Columns.Add("_glyphType", "Тип иероглифов");
                    break;
                case (int)Languages.German:
                    dataGridViewLangs.Columns.Add("_dialect", "Диалект");
                    break;
                case (int)Languages.French:
                    dataGridViewLangs.Columns.Add("_region", "Регион");
                    break;
            }
        }

        private void tabControlLangs_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatLangGrid(tabControlLangs.SelectedIndex);
            switch (tabControlLangs.SelectedIndex)
            {
                case (int)Languages.English:
                    foreach (var language in CourseEngine.storage.Languages)
                    {
                        if (language.GetType() == typeof(English))
                            dataGridViewLangs.Rows.Add(language.CharAmount, language.PercentOfSpread, (language as English).SpeakerType);
                    }
                    break;
                case (int)Languages.Japanese:
                    foreach (var language in CourseEngine.storage.Languages)
                    {
                        if(language.GetType() == typeof(Japanese))
                            dataGridViewLangs.Rows.Add(language.CharAmount, language.PercentOfSpread, (language as Japanese).GlyphType);
                    }
                    break;
                case (int)Languages.German:
                    foreach (var language in CourseEngine.storage.Languages)
                    {
                        if (language.GetType() == typeof(German))
                            dataGridViewLangs.Rows.Add(language.CharAmount, language.PercentOfSpread, (language as German).Dialect);
                    }
                    break;
                case (int)Languages.French:
                    foreach (var language in CourseEngine.storage.Languages)
                    {
                        if (language.GetType() == typeof(French))
                            dataGridViewLangs.Rows.Add(language.CharAmount, language.PercentOfSpread, (language as French).Region);
                    }
                    break;
            }
        }

        private void buttonAddLang_Click(object sender, EventArgs e)
        {
            Language language = null!;
            TextBox[] reference = new TextBox[] 
            {
                textBoxSpeakerType,
                textBoxGlypthType,
                textBoxDialect,
                textBoxRegion,
                textBoxCharAmount,
                textBoxPercentOfSpread
            };
            switch (tabControlLangs.SelectedIndex)
            {
                case (int)Languages.English:
                    language = CourseEngine.RegisterNewLanguage(new English(Convert.ToInt32(reference[4].Text), Convert.ToSingle(reference[5].Text), reference[0].Text));
                    dataGridViewLangs.Rows.Add(language.CharAmount, language.PercentOfSpread, (language as English).SpeakerType);
                    break;
                case (int)Languages.Japanese:
                    language = CourseEngine.RegisterNewLanguage(new Japanese(Convert.ToInt32(reference[4].Text), Convert.ToSingle(reference[5].Text), reference[1].Text));
                    dataGridViewLangs.Rows.Add(language.CharAmount, language.PercentOfSpread, (language as Japanese).GlyphType);
                    break;
                case (int)Languages.German:
                    language = CourseEngine.RegisterNewLanguage(new German(Convert.ToInt32(reference[4].Text), Convert.ToSingle(reference[5].Text), reference[2].Text));
                    dataGridViewLangs.Rows.Add(language.CharAmount, language.PercentOfSpread, (language as German).Dialect);
                    break;
                case (int)Languages.French:
                    language = CourseEngine.RegisterNewLanguage(new French(Convert.ToInt32(reference[4].Text), Convert.ToSingle(reference[5].Text), reference[3].Text));
                    dataGridViewLangs.Rows.Add(language.CharAmount, language.PercentOfSpread, (language as French).Region);
                    break;
            }
        }

        private void buttonAddListener_Click(object sender, EventArgs e)
        {
            Listener listener = new(textBoxListenerFIO.Text);
            CourseEngine.storage.Listeners.Add(listener);
            dataGridViewListeners.Rows.Add(listener.FIO, !listener.isOld ? "Да" : "Нет");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex) 
            {
                case 1:
                    RefreshListenerGrid();
                    break;
                case 2:
                    RefreshLangLevelCombo();
                    RefreshMasteringsGrid();
                    break;
                case 3:
                    RefreshMasteringsCombo();
                    RefreshStudentsCourseGrid();
                    RefreshCourseGrid();
                    break;
            }
        }

        private void buttonAddLevel_Click(object sender, EventArgs e)
        {
            dynamic buffer = null!;
            switch(comboBoxLevel.SelectedItem.ToString())
            {
                case "Начальный":
                    Beginner beginner = new(CourseEngine.storage.Languages[comboBoxLanguage.SelectedIndex]!);
                    buffer = beginner;
                    break;
                case "Средний":
                    Middle middle = new(CourseEngine.storage.Languages[comboBoxLanguage.SelectedIndex]!);
                    buffer = middle;
                    break;
                case "Продвинутый": 
                    Expert expert = new(CourseEngine.storage.Languages[comboBoxLanguage.SelectedIndex]!);
                    buffer = expert;
                    break;

            }
            CourseEngine.storage.Masterings.Add(buffer);
            RefreshMasteringsGrid();
        }

        int[] FetchIndexArray(DataGridViewRowCollection collection)
        {
            List<int> index = new List<int>();
            for (int i = 0; i < collection.Count; i++) 
            {
                if (collection[i].Selected)
                {
                    index.Add(i);
                }
            }
            return index.ToArray();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            switch(tabControlCourseType.SelectedIndex)
            {
                case 0:
                    CourseEngine.storage.Courses.Add(new Group(
                        textBoxCourseName.Text,
                        CourseEngine.storage.Masterings[comboBoxCourseLevel.SelectedIndex]!,
                        CourseEngine.CompileListeners(FetchIndexArray(dataGridViewCourseGroupStud.Rows))
                        ));
                    break;
                case 1:
                    CourseEngine.storage.Courses.Add(new Individual(
                        textBoxCourseName.Text,
                        CourseEngine.storage.Masterings[comboBoxCourseLevel.SelectedIndex]!,
                        CourseEngine.storage.Listeners[comboBoxCourseStudent.SelectedIndex]!
                        ));
                    break;
            }
            RefreshCourseGrid();
        }

        void RefreshAll()
        {
            RefreshCourseGrid();
            RefreshStudentsCourseGrid();
            RefreshMasteringsCombo();
            RefreshMasteringsGrid();
            RefreshLangLevelCombo();
            RefreshListenerGrid();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CourseEngine.Write();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            CourseEngine.Read();
            RefreshAll();
        }
    }
}
