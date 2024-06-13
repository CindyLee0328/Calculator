using System.Collections;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using NCalc;


namespace Calculator
{
    public partial class Form1 : Form
    {
        float sum = 0;  //總和
        float tnum = 0; //暫存的數字
        string S, tS; //S:全計算過程 tS:暫存的計算數字(字串)
        int operators1 = -1, operators2 = -1; //0:加法 1:減法 2:乘法 3:除法

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button_add(Button s) //數字增加
        {
            if (S == null || S == "0")
            {
                S = s.Text;
                tS += s.Text;
                CalculationProcess.Text = S;
            }
            else
            {
                S += s.Text;
                tS += s.Text;
                CalculationProcess.Text = S;
            }
        }

        private void button1_Click(object sender, EventArgs e) //1
        {
            button_add(button1);
        }
        private void button2_Click(object sender, EventArgs e) //2
        {
            button_add(button2);
        }
        private void button3_Click(object sender, EventArgs e) //3
        {
            button_add(button3);
        }
        private void button4_Click(object sender, EventArgs e) //4
        {
            button_add(button4);
        }
        private void button5_Click(object sender, EventArgs e) //5
        {
            button_add(button5);
        }
        private void button6_Click(object sender, EventArgs e) //6
        {
            button_add(button6);
        }
        private void button7_Click(object sender, EventArgs e) //7
        {
            button_add(button7);
        }
        private void button8_Click(object sender, EventArgs e) //8
        {
            button_add(button8);
        }
        private void button9_Click(object sender, EventArgs e) //9
        {
            button_add(button9);
        }
        private void button0_Click(object sender, EventArgs e) //0
        {
            button_add(button1);
        }
        private void button00_Click(object sender, EventArgs e) //00
        {
            button_add(button00);
        }
        private void button14_Click(object sender, EventArgs e) //.
        {
            if (S == null || tS == null)
            {
                S += "0.";
                tS += "0.";
                CalculationProcess.Text = S;
            }
            else
            {
                S += button14.Text;
                tS += button14.Text;
                CalculationProcess.Text = S;
            }
        }

        //加法計算
        private void button10_Click(object sender, EventArgs e)
        {
            if (operators1 != -1 && operators2 != -1)
            {
                switch (operators2)
                {
                    case 2:
                        if (operators1 == 0)
                        {
                            tnum = tnum * float.Parse(tS);
                            sum = sum + tnum;
                            label_sum.Text = sum.ToString();
                            operators1 = 0;
                            operators2 = -1;
                            button_add(button10);
                            tS = null;
                            break;
                        }
                        else
                        {
                            tnum = tnum * float.Parse(tS);
                            sum = sum - tnum;
                            label_sum.Text = sum.ToString();
                            operators1 = 0;
                            operators2 = -1;
                            button_add(button10);
                            tS = null;
                            break;
                        }
                    case 3:
                        if (operators1 == 0)
                        {
                            tnum = tnum / float.Parse(tS);
                            sum = sum + tnum;
                            label_sum.Text = sum.ToString();
                            operators1 = 0;
                            operators2 = -1;
                            button_add(button10);
                            tS = null;
                            break;
                        }
                        else
                        {
                            tnum = tnum / float.Parse(tS);
                            sum = sum - tnum;
                            label_sum.Text = sum.ToString();
                            operators1 = 0;
                            operators2 = -1;
                            button_add(button10);
                            tS = null;
                            break;
                        }
                }
            }
            else if (operators1 != -1 && operators2 == -1)
            {
                switch (operators1) //前運算子為 + -
                {
                    case 0:
                        tnum = float.Parse(tS);
                        sum = sum + tnum;
                        label_sum.Text = sum.ToString();
                        operators1 = 0;
                        button_add(button10);
                        tS = null;
                        break;
                    case 1:
                        tnum = float.Parse(tS);
                        sum = sum - tnum;
                        label_sum.Text = sum.ToString();
                        operators1 = 0;
                        button_add(button10);
                        tS = null;
                        break;
                }
            }
            else if (operators1 == -1 && operators2 != -1)
            {
                switch (operators2) //前運算子為 × ÷
                {
                    case 2:
                        tnum = float.Parse(tS);
                        sum = sum * tnum;
                        label_sum.Text = sum.ToString();
                        operators1 = 0;
                        button_add(button10);
                        tS = null;
                        operators2 = -1;
                        break;
                    case 3:
                        tnum = float.Parse(tS);
                        sum = sum / tnum;
                        label_sum.Text = sum.ToString();
                        operators1 = 0;
                        button_add(button10);
                        tS = null;
                        operators2 = -1;
                        break;
                }
            }
            else if (operators1 == -1 && operators2 == -1) //初始
            {
                sum = float.Parse(tS);
                label_sum.Text = sum.ToString();
                operators1 = 0;
                button_add(button10);
                tS = null;
            }
        }
        //減法計算
        private void button11_Click(object sender, EventArgs e)
        {
            if (operators1 != -1 && operators2 != -1)
            {
                switch (operators2)
                {
                    case 2:
                        if (operators1 == 0)
                        {
                            tnum = tnum * float.Parse(tS);
                            sum = sum + tnum;
                            label_sum.Text = sum.ToString();
                            operators1 = 1;
                            operators2 = -1;
                            button_add(button11);
                            tS = null;
                            break;
                        }
                        else
                        {
                            tnum = tnum * float.Parse(tS);
                            sum = sum - tnum;
                            label_sum.Text = sum.ToString();
                            operators1 = 1;
                            operators2 = -1;
                            button_add(button11);
                            tS = null;
                            break;
                        }
                    case 3:
                        if (operators1 == 0)
                        {
                            tnum = tnum / float.Parse(tS);
                            sum = sum + tnum;
                            label_sum.Text = sum.ToString();
                            operators1 = 1;
                            operators2 = -1;
                            button_add(button11);
                            tS = null;
                            break;
                        }
                        else
                        {
                            tnum = tnum / float.Parse(tS);
                            sum = sum - tnum;
                            label_sum.Text = sum.ToString();
                            operators1 = 1;
                            operators2 = -1;
                            button_add(button11);
                            tS = null;
                            break;
                        }
                }
            }
            else if (operators1 != -1 && operators2 == -1)
            {
                switch (operators1) //前運算子為 + -
                {
                    case 0:
                        tnum = float.Parse(tS);
                        sum = sum + tnum;
                        label_sum.Text = sum.ToString();
                        operators1 = 1;
                        button_add(button11);
                        tS = null;
                        break;
                    case 1:
                        tnum = float.Parse(tS);
                        sum = sum - tnum;
                        label_sum.Text = sum.ToString();
                        operators1 = 1;
                        button_add(button11);
                        tS = null;
                        break;
                }
            }
            else if (operators1 == -1 && operators2 != -1)
            {
                switch (operators2) //前運算子為 × ÷
                {
                    case 2:
                        tnum = float.Parse(tS);
                        sum = sum * tnum;
                        label_sum.Text = sum.ToString();
                        operators1 = 1;
                        button_add(button11);
                        tS = null;
                        operators2 = -1;
                        break;
                    case 3:
                        tnum = float.Parse(tS);
                        sum = sum / tnum;
                        label_sum.Text = sum.ToString();
                        operators1 = 1;
                        button_add(button11);
                        tS = null;
                        operators2 = -1;
                        break;
                }
            }
            else if (operators1 == -1 && operators2 == -1) //初始
            {
                sum = float.Parse(tS);
                label_sum.Text = sum.ToString();
                operators1 = 1;
                button_add(button11);
                tS = null;
            }

        }
        //乘法計算
        private void button12_Click(object sender, EventArgs e)
        {
            if (operators1 != -1 && operators2 != -1)
            {
                switch (operators2) //前運算子為 × ÷
                {
                    case 2:
                        tnum = tnum * float.Parse(tS);
                        operators2 = 2;
                        button_add(button12);
                        tS = null;
                        break;
                    case 3:
                        tnum = tnum / float.Parse(tS);
                        operators2 = 2;
                        button_add(button12);
                        tS = null;
                        break;
                }
            }
            else if (operators1 != -1 && operators2 == -1)
            {
                tnum = float.Parse(tS);
                operators2 = 2;
                button_add(button12);
                tS = null;
            }
            else if (operators1 == -1 && operators2 != -1)
            {
                switch (operators2) //前運算子為 × ÷
                {
                    case 2:
                        tnum = float.Parse(tS);
                        sum = sum * tnum;
                        label_sum.Text = sum.ToString();
                        operators2 = 2;
                        button_add(button12);
                        tS = null;
                        break;
                    case 3:
                        tnum = float.Parse(tS);
                        sum = sum / tnum;
                        label_sum.Text = sum.ToString();
                        operators2 = 2;
                        button_add(button12);
                        tS = null;
                        break;
                }
            }
            else if (operators1 == -1 && operators2 == -1) //初始
            {
                sum = float.Parse(tS);
                label_sum.Text = sum.ToString();
                operators2 = 2;
                button_add(button12);
                tS = null;
            }
        }
        //除法計算
        private void button13_Click(object sender, EventArgs e)
        {
            if (operators1 != -1 && operators2 != -1)
            {
                switch (operators2) //前運算子為 × ÷
                {
                    case 2:
                        tnum = tnum * float.Parse(tS);
                        operators2 = 3;
                        button_add(button13);
                        tS = null;
                        break;
                    case 3:
                        tnum = tnum / float.Parse(tS);
                        operators2 = 3;
                        button_add(button13);
                        tS = null;
                        break;
                }
            }
            else if (operators1 != -1 && operators2 == -1)
            {
                tnum = float.Parse(tS);
                operators2 = 3;
                button_add(button13);
                tS = null;
            }
            else if (operators1 == -1 && operators2 != -1)
            {
                switch (operators2) //前運算子為 × ÷
                {
                    case 2:
                        tnum = float.Parse(tS);
                        sum = sum * tnum;
                        label_sum.Text = sum.ToString();
                        operators2 = 3;
                        button_add(button13);
                        tS = null;
                        break;
                    case 3:
                        tnum = float.Parse(tS);
                        sum = sum / tnum;
                        label_sum.Text = sum.ToString();
                        operators2 = 3;
                        button_add(button13);
                        tS = null;
                        break;
                }
            }
            else if (operators1 == -1 && operators2 == -1) //初始
            {
                sum = float.Parse(tS);
                label_sum.Text = sum.ToString();
                operators2 = 3;
                button_add(button13);
                tS = null;
            }

        }

        //計算結果
        private void button15_Click(object sender, EventArgs e)
        {
            if (tS == null)
            {
                CalculationProcess.Text = null;
                label_sum.Text = sum.ToString();
                S = null;
                tS = null;
                sum = 0;
                tnum = 0;
                operators1 = -1;
                operators1 = -1;
            }
            else
            {
                if (operators1 != -1 && operators2 == -1)
                {
                    switch (operators1)
                    {
                        case 0:
                            sum += float.Parse(tS);
                            break;
                        case 1:
                            sum -= float.Parse(tS);
                            break;
                    }
                }
                else if (operators1 != -1 && operators2 != -1)
                {
                    switch (operators2)
                    {
                        case 2:
                            if (operators1 == 0) sum = sum + tnum * float.Parse(tS);
                            else sum = sum = sum - tnum * float.Parse(tS);
                            break;
                        case 3:
                            if (operators1 == 0) sum = sum + tnum / float.Parse(tS);
                            else sum = sum = sum - tnum / float.Parse(tS);
                            break;
                    }
                }
                else if (operators1 == -1 && operators2 != -1)
                {
                    switch (operators2)
                    {
                        case 2:
                            sum *= float.Parse(tS);
                            break;
                        case 3:
                            sum /= float.Parse(tS);
                            break;
                    }
                }
                CalculationProcess.Text = null;
                label_sum.Text = sum.ToString();
                S = null;
                tS = null;
                sum = 0;
                tnum = 0;
                operators1 = -1;
                operators1 = -1;
            }
        }

        //刪除
        private void button16_Click(object sender, EventArgs e)
        {
            S = null;
            tS = null;
            CalculationProcess.Text = S;
            label_sum.Text = S;
            sum = 0;
            tnum = 0;
            operators1 = -1;
            operators1 = -1;


        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 96 || e.KeyValue == 48) button_add(button0);
            if (e.KeyValue == 97 || e.KeyValue == 49) button_add(button1);
            if (e.KeyValue == 98 || e.KeyValue == 50) button_add(button2);
            if (e.KeyValue == 99 || e.KeyValue == 51) button_add(button3);
            if (e.KeyValue == 100 || e.KeyValue == 52) button_add(button4);
            if (e.KeyValue == 101 || e.KeyValue == 53) button_add(button5);
            if (e.KeyValue == 102 || e.KeyValue == 54) button_add(button6);
            if (e.KeyValue == 103 || e.KeyValue == 55) button_add(button7);
            if (e.KeyValue == 104 || e.KeyValue == 56) button_add(button8);
            if (e.KeyValue == 105 || e.KeyValue == 57) button_add(button9);

            if (e.KeyValue == 107) button10_Click(null, null);
            if (e.KeyValue == 109) button11_Click(null, null);
            if (e.KeyValue == 106) button12_Click(null, null);
            if (e.KeyValue == 111) button13_Click(null, null);
            
        }
    }


}
