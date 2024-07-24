using WinFormsApp5.Reposetory;

namespace WinFormsApp5
{
     internal partial class Form1 : Form
    {
        private string result;
        private string month;
        private IReposetory<Model> repository;
        public Form1(IReposetory<Model> repository)
        {
            InitializeComponent();
            this.repository = repository;
            AddDays();
            AddDayMonth();
            AddMonth();
            AddYears();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_Day.SelectedItem != null && comboBox_Month.SelectedItem != null &&
               comboBox_NameMonth.SelectedItem != null && comboBox_Year.SelectedItem != null)
            {
                result = $"�{comboBox_Day.SelectedItem.ToString()} ���� {daysDictionary[comboBox_Month.SelectedItem.ToString()]} ���� {comboBox_NameMonth.SelectedItem.ToString()} ���� ���� ����� �{hebrewYearsToWords[comboBox_Year.SelectedItem.ToString()]} ������ ����� ";




                repository.Add(SelectedItem());
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("�� ������ ���");
            }
        }


        private Model SelectedItem()
        {
            return new Model(
                comboBox_Day.SelectedItem.ToString(),
                comboBox_Month.SelectedItem.ToString(),
                comboBox_NameMonth.SelectedItem.ToString(),
                comboBox_Year.SelectedItem.ToString(),
                result
                );
        }









        Dictionary<string, string> daysDictionary = new Dictionary<string, string>
            {
                 { "1", "��� ���" },
                { "2", "��� ����" },
                { "3", "���� ����" },
                { "4", "����� ����" },
                { "5", "����� ����" },
                { "6", "���� ����" },
                { "7", "���� ����" },
                { "8", "����� ����" },
                { "9", "���� ����" },
                { "10", "���� ����" },
                { "11", "��� ��� ���" },
                { "12", "���� ��� ���" },
                { "13", "���� ��� ���" },
                { "14", "����� ��� ����" },
                { "15", "����� ��� ����" },
                { "16", "��� ��� ���" },
                { "17", "���� ��� ����" },
                { "18", "����� ��� ����" },
                { "19", "���� ��� ����" },
                { "20", "����� ���" },
                { "21", "����� ���� ����" },
                { "22", "����� ������ ����" },
                { "23", "����� ������ ����" },
                { "24", "����� ������ ����" },
                { "25", "����� ������ ����" },
                { "26", "����� ���� ����" },
                { "27", "����� ����� ����" },
                { "28", "����� ������ ����" },
                { "29", "����� ����� ����" },
                { "30", " ��� ������ ���� ��� ����" }
            };
        Dictionary<string, string> hebrewYearsToWords = new Dictionary<string, string>
            {
               {"���\"�", "���� ����� ���� ���� ������ �����"},
   {"���\"�", "���� ����� ���� ���� ������ ����"},
   {"���\"�", "���� ����� ���� ���� ������ ���"},
   {"���\"�", "���� ����� ���� ���� ������ ����"},
   {"���\"�", "���� ����� ���� ���� ������ ������"},
   {"���\"�", "���� ����� ���� ���� ������ ����"},
   {"��\"�", "���� ����� ������ ����"},
   {"���\"�", "���� ����� ������ ���� ����"},
   {"���\"�", "���� ����� ������ ���� ������"},
   {"���\"�", "���� ����� ����������������"}
            };


        private void AddDays()
        {
            string[] daysOfWeek = { "�����", "���", "�����", "�����", "�����", "���" };
            comboBox_Day.Items.AddRange(daysOfWeek);
        }
        private void AddDayMonth()
        {
            for (int i = 1; i <= 30; i++)
            {
                comboBox_Month.Items.Add(i);
            }
        }
        public void AddMonth()
        {
            string[] hebrewMonths = {
                "����", "�����", "����", "���", "���", "���", "��� �'",
                "����", "����", "����", "����", "��", "����"
            };

            comboBox_NameMonth.Items.AddRange(hebrewMonths);
        }
        public void AddYears()
        {
            string[] hebrewYears = {
                "���\"�", "���\"�", "���\"�", "���\"�", "���\"�", "���\"�", "��\"�",
                "���\"�", "���\"�", "���\"�"
                
            };

            comboBox_Year.Items.AddRange(hebrewYears);
        }

        
    }


}
