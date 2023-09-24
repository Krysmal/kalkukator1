using System.Collections;
using System.Diagnostics.Contracts;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace kalkukator1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public int OperatorNumb = 0;//defines type of operator selected for operation 0 is default, 1 means +, 2 means -, 3 means *, 4 means /
        public float Numb1 = 0; //contains number from input
        public int Index = 0;
        public string TempNumb = "";//temporary number from input
        public int ResetStatus=0;//clears textbox 
        public List<string> HistList = new List<string>();//List for logs
        public string Operator;
        private void button1_Click(object sender, EventArgs e)
        {
            if(ResetStatus==1)
            {
                textBox1.Text = "";
                ResetStatus =0;
            }
            textBox1.Text += "1";
            TempNumb += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text += "2";
            TempNumb += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text += "3";
            TempNumb += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text += "4";
            TempNumb += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text += "5";
            TempNumb += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {

            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text += "6";
            TempNumb += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {

            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text +="7";
            TempNumb += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {

            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text += "8";
            TempNumb += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {

            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text += "9";
            TempNumb += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {

            if (ResetStatus == 1)
            {
                textBox1.Text = "";
                ResetStatus = 0;
            }
            textBox1.Text += "0";
            TempNumb += "0";
        }

        
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            TempNumb = "";
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;

            if (temp.EndsWith(" "))
            {
                int StringLen = temp.Length;
                temp=temp.Remove(StringLen-2);
                temp += "+ ";
                textBox1.Text = temp;
                OperatorNumb = 1;



            }
            else
            {
                textBox1.Text += " + ";
                OperatorNumb=1;
                if (TempNumb == "")
                {
                    System.Windows.Forms.MessageBox.Show("brak liczby");
                    textBox1.Text = "";
                }
                else
                    Numb1 =float.Parse(TempNumb,CultureInfo.InvariantCulture.NumberFormat);
                TempNumb = "";

                //System.Windows.Forms.MessageBox.Show(test);
                Index++;
            }

        }

        private void buttonSUB_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;

            if (temp.EndsWith(" "))
            {
                int StringLen = temp.Length;
                temp = temp.Remove(StringLen - 2);
                temp += "- ";
                textBox1.Text = temp;
                OperatorNumb = 2;



            }
            else
            {
                textBox1.Text += " - ";
                OperatorNumb = 2;
                if(TempNumb=="")
                {
                    System.Windows.Forms.MessageBox.Show("brak liczby");
                    textBox1.Text = "";
                }
                else
                Numb1 = float.Parse(TempNumb, CultureInfo.InvariantCulture.NumberFormat);
                TempNumb = "";

                //System.Windows.Forms.MessageBox.Show(test);
                Index++;
            }
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;

            if (temp.EndsWith(" "))
            {
                int StringLen = temp.Length;
                temp = temp.Remove(StringLen - 2);
                temp += "* ";
                textBox1.Text = temp;
                OperatorNumb = 3;



            }
            else
            {
                textBox1.Text += " * ";
                OperatorNumb = 3;
                if (TempNumb == "")
                {
                    System.Windows.Forms.MessageBox.Show("brak liczby");
                    textBox1.Text = "";
                }
                else
                    Numb1 = float.Parse(TempNumb, CultureInfo.InvariantCulture.NumberFormat);
                TempNumb = "";

                //System.Windows.Forms.MessageBox.Show(test);
                Index++;
            }
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;

            if (temp.EndsWith(" "))
            {
                int StringLen = temp.Length;
                temp = temp.Remove(StringLen - 2);
                temp += "/ ";
                textBox1.Text = temp;
                OperatorNumb = 4;



            }
            else
            {
                textBox1.Text += " / ";
                OperatorNumb = 4;
                if (TempNumb == "")
                {
                    System.Windows.Forms.MessageBox.Show("brak liczby");
                    textBox1.Text = "";
                }
                else
                    Numb1 = float.Parse(TempNumb, CultureInfo.InvariantCulture.NumberFormat);
                TempNumb = "";

                //System.Windows.Forms.MessageBox.Show(test);
                Index++;
            }
        }

        private void buttonEQ_Click(object sender, EventArgs e)
        {
            float result = 0;
            if (TempNumb != "")
            {
                switch ((int)OperatorNumb)
                {

                    case 1:
                        result = Numb1 + float.Parse(TempNumb, CultureInfo.InvariantCulture.NumberFormat);
                        Operator = "+";
                        break;
                    case 2:
                        result = Numb1 - float.Parse(TempNumb, CultureInfo.InvariantCulture.NumberFormat);
                        Operator = "-";
                        break;
                    case 3:
                        result = Numb1 * float.Parse(TempNumb, CultureInfo.InvariantCulture.NumberFormat);
                        Operator = "*";
                        break;
                    case 4:
                        if (float.Parse(TempNumb, CultureInfo.InvariantCulture.NumberFormat) == 0)
                        {

                            System.Windows.Forms.MessageBox.Show("nie mo¿na dzieliæ przez 0");
                            textBox1.Text = "";
                        }
                        else
                        {
                            result = Numb1 / float.Parse(TempNumb, CultureInfo.InvariantCulture.NumberFormat);
                            Operator = "/";
                        }
                            

                        break;
                    default:
                        System.Windows.Forms.MessageBox.Show("z³y numer operacji");
                        result = Numb1;
                        break;

                }

                string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss ");
                string log = time + Numb1.ToString() + " "+Operator+" "+TempNumb+" = "+result.ToString();
                HistList.Add(log);
                //System.Windows.Forms.MessageBox.Show(HistList[0]);
                OperatorNumb = 0;
                TempNumb = result.ToString();
                
                textBox1.Text = result.ToString();
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("nie poda³eœ drugiej liczby");
            }

            
        }

        private void button_Hist_Click(object sender, EventArgs e)
        {
            historia history =new historia(HistList);
            history.Show();
        }
    }
}