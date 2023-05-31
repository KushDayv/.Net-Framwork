namespace Student_Grades_calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double maths, science, english, tot, avg;
            string grade;

            maths = int.Parse(txtMaths.Text);
            science = int.Parse(txtSci.Text);
            english = int.Parse(txtEng.Text);


            tot = maths + science + english;

            txtTot.Text = tot.ToString();
            
            avg = tot / 3;
            txtAvg.Text = avg.ToString();


            if (avg > 75) 
            {
                grade = "A";
            }
            else if (avg > 65)
            {
                grade = "B";
            }
            else if (avg > 55)
            {
                grade = "C";
            }
            else if (avg > 45)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            txtGrade.Text = grade;  
        }
    }
}