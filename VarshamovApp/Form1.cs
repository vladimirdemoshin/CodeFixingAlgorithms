using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarshamovApp
{
    public partial class Form1 : Form
    {
        public static String[] allCodesGlobal;
        public static String[] GenerateCode(int n)
        {
            int l = n + 1;
            String[] allCodes = new String[(int)Math.Pow(2, n)];
            for (int i = 0; i < allCodes.Length; i++)
                allCodes[i] = "";
            int step = (int)Math.Pow(2, n - 1);
            for (int i = 0; i < n; i++)
            {
                char current = '0';
                for (int j = 1; j <= allCodes.Length; j++)
                {
                    allCodes[j - 1] += current;
                    if (j % step == 0)
                    {
                        if (current == '0') current = '1';
                        else current = '0';
                    }
                }
                step = step / 2;
            }
            String[] tempCode = new String[allCodes.Length];
            int k = 0;
            for (int i = 0; i < allCodes.Length; i++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                    s += allCodes[i][j] * (j + 1);
                if (s % l == 0)
                    tempCode[k++] = allCodes[i];
            }
            String[] output = new String[k];
            for (int i = 0; i < k; i++)
                output[i] = tempCode[i];
            return output;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox1.Text);
            allCodesGlobal = GenerateCode(n);
            Random rand = new Random();
            int randomCodeNumber = rand.Next(0, allCodesGlobal.Length);
            String code = allCodesGlobal[randomCodeNumber];
            textBox2.Text = code;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox1.Text);
            String brokenCode = textBox3.Text;
            String code = FixCode(brokenCode, n);
            MessageBox.Show(code);
        }

        public static String FixCode(String code, int n)
        {
            if(code.Length == n)
            {
                for(int i=0;i<allCodesGlobal.Length;i++)
                {
                    int w = 0;
                    for(int j=0;j<n;j++)
                    {
                        if (code[j] != allCodesGlobal[i][j]) w++;
                    }
                    if (w <= 1) return allCodesGlobal[i];
                }
                return code;
            }
            int l = n + 1;
            int s = 0, W = 0;
            for(int i=0;i<code.Length;i++)
            {
                s += (code[i] - '0') * (i + 1);
                W += code[i] - '0';
            }
            int k = s % l;
            String output = "";
            if(k==0) //отбрасываем последний символ
            {
                for (int i = 0; i < code.Length - 1; i++) output += code[i]; 
            }
            else if(k<W) //выбрасываем нулевой символ, после которого правее k единиц
            {
                bool flag = false;
                for(int i=0;i<code.Length;i++)
                {
                    if (code[i] == '0' && !flag)
                    {
                        int sum = 0;
                        for (int j = i + 1; j < code.Length; j++) sum += code[j]-'0';
                        if (sum == k) flag = true;
                        else output += code[i];
                    }
                    else output += code[i];
                }
            }
            else if(k==W)  //отбрасываем первый символ
            {
                for(int i = 1; i < code.Length; i++) output += code[i]; 
            }
            else //отбрасываем любой единичный символ, проавее которого идут n+1-k нулей
            {
                bool flag = false;
                for (int i = 0; i < code.Length; i++)
                {
                    if (code[i] == '1' && !flag)
                    {
                        int sum = 0, sumAll = 0;
                        for (int j = i + 1; j < code.Length; j++) { sum += code[j]-'0'; sumAll++; }
                        if (sumAll - sum == n+1-k) flag = true;
                        else output += code[i];
                    }
                    else output += code[i];
                }
            }
            return output;
        }
    }
}
