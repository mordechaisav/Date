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
                result = $"ב{comboBox_Day.SelectedItem.ToString()} בשבת {daysDictionary[comboBox_Month.SelectedItem.ToString()]} לירח {comboBox_NameMonth.SelectedItem.ToString()} לשנת חמשת אלפים ו{hebrewYearsToWords[comboBox_Year.SelectedItem.ToString()]} לבריאת העולם ";




                repository.Add(SelectedItem());
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("נא למלאות הכל");
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
                 { "1", "יום אחד" },
                { "2", "שני ימים" },
                { "3", "שלשה ימים" },
                { "4", "ארבעה ימים" },
                { "5", "חמישה ימים" },
                { "6", "שישה ימים" },
                { "7", "שבעה ימים" },
                { "8", "שמונה ימים" },
                { "9", "תשעה ימים" },
                { "10", "עשרה ימים" },
                { "11", "אחד עשר יום" },
                { "12", "שנים עשר יום" },
                { "13", "שלשה עשר יום" },
                { "14", "ארבעה עשר ימים" },
                { "15", "חמישה עשר ימים" },
                { "16", "ששה עשר יום" },
                { "17", "שבעה עשר ימים" },
                { "18", "שמונה עשר ימים" },
                { "19", "תשעה עשר ימים" },
                { "20", "עשרים יום" },
                { "21", "עשרים ואחד ימים" },
                { "22", "עשרים ושתיים ימים" },
                { "23", "עשרים ושלושה ימים" },
                { "24", "עשרים וארבעה ימים" },
                { "25", "עשרים וחמישה ימים" },
                { "26", "עשרים וששה ימים" },
                { "27", "עשרים ושבעה ימים" },
                { "28", "עשרים ושמונה ימים" },
                { "29", "עשרים ותשעה ימים" },
                { "30", " יום שלושים שהוא ראש חודש" }
            };
        Dictionary<string, string> hebrewYearsToWords = new Dictionary<string, string>
            {
               {"תשפ\"ד", "חמשת אלפים ושבע מאות שמונים וארבע"},
   {"תשפ\"ה", "חמשת אלפים ושבע מאות שמונים וחמש"},
   {"תשפ\"ו", "חמשת אלפים ושבע מאות שמונים ושש"},
   {"תשפ\"ז", "חמשת אלפים ושבע מאות שמונים ושבע"},
   {"תשפ\"ח", "חמשת אלפים ושבע מאות שמונים ושמונה"},
   {"תשפ\"ט", "חמשת אלפים ושבע מאות שמונים ותשע"},
   {"תש\"צ", "חמשת אלפים ושמונה מאות"},
   {"תשצ\"א", "חמשת אלפים ושמונה מאות ואחת"},
   {"תשצ\"ב", "חמשת אלפים ושמונה מאות ושתיים"},
   {"תשצ\"ג", "חמשת אלפים ושמונה מאות ושלוש"}
            };


        private void AddDays()
        {
            string[] daysOfWeek = { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" };
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
                "תשרי", "חשוון", "כסלו", "טבת", "שבט", "אדר", "אדר ב'",
                "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול"
            };

            comboBox_NameMonth.Items.AddRange(hebrewMonths);
        }
        public void AddYears()
        {
            string[] hebrewYears = {
                "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ",
                "תשצ\"א", "תשצ\"ב", "תשצ\"ג"
                
            };

            comboBox_Year.Items.AddRange(hebrewYears);
        }

        
    }


}
