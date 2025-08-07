using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{

   


   
    public partial class MainWindow : Window
    {
        int i = 0;
        string[] num=new string [4];
        string firstMain = "";
        public MainWindow()
        {
            InitializeComponent();

            

        }

        bool clickedOnNumber = false;
        bool clickedOnOperand=false;

        public void number(Button button)
        {
                if (tbMain.Text == "0" || clickedOnOperand==true)
                {
                    clickedOnOperand = false;
                    clickedOnNumber=true;
                    tbMain.Text = button.Content.ToString();
                }
                else
                {
                    tbMain.Text += button.Content.ToString();
                }
            
        }

        public void opeerand(Button button)
        { 
            clickedOnOperand = true;
            

            if (clickedOnNumber && tbMain.Text!="0")
            {
                num = tbSide.Text.Split(" ");
                if (num[1]=="*")
                { tbMain.Text = (double.Parse(num[0]) *double.Parse(tbMain.Text)).ToString();  }
                if (num[1] == "/")
                { tbMain.Text = (double.Parse(num[0])/ double.Parse(tbMain.Text)).ToString();  }

                if (num[1] == "+")
                { tbMain.Text = (double.Parse(tbMain.Text) + double.Parse(num[0])).ToString(); }

                if (num[1] == "-")
                { tbMain.Text = (double.Parse(num[0]) - double.Parse(tbMain.Text)).ToString(); }
            }
            tbSide.Text = tbMain.Text + " " + button.Content;

            clickedOnNumber = false;
        }

        public void Equall(Button button)
        {
            
           
            num = tbSide.Text.Split(' ');
            if (i==0)
            {
                firstMain = tbMain.Text;
                i++;
            }           
            if (num.Contains("="))
            {
                
                num[0] =tbMain.Text;
            }
                if (num[1] == "*")
                {
                     tbMain.Text = (double.Parse(num[0]) * double.Parse(firstMain)).ToString(); 
                }
                if (num[1] == "/")
                { tbMain.Text = (double.Parse(num[0]) / double.Parse(firstMain)).ToString(); }

                if (num[1] == "+")
                { tbMain.Text = (double.Parse(tbMain.Text) + double.Parse(firstMain)).ToString(); }

                if (num[1] == "-")
                { tbMain.Text = (double.Parse(num[0]) - double.Parse(firstMain)).ToString(); }

                tbSide.Text = $"{num[0]} {num[1]} {firstMain} =";
            
            

        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            number(btn7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            number(btn8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            number(btn9);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            number(btn4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            number(btn5);  
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            number(btn2);  
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            number(btn3); 
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            number(btn6);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            number(btn1);
        }

        private void brnClear_Click(object sender, RoutedEventArgs e)
        {
            tbMain.Text = "";
            tbSide.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn1onX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnX2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            opeerand(btnDivide);
        }

        private void btnCross_Click(object sender, RoutedEventArgs e)
        {
            opeerand(btnCross);
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            opeerand(btnMinus);
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            opeerand(btnPlus);
           
        }

        private void btnNegation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            number(btn0);
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            Equall(btnEqual);
        }
    }
}