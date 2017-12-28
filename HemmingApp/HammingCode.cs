using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HemmingApp
{
    public class HammingCode
    {
        public static String GetHammingCode(String input, ref int k) //input - код в двоичном формате
        {
            int m = input.Length;
            k = 2;
            while (k < Math.Log(k + m + 1, 2)) { k++; }
            String hammingCode = "";
            int powTwo = 1;
            for(int i=0,j=0;i<input.Length+k;i++)
            {
                if ((i + 1) == powTwo)
                {
                    hammingCode += '0';
                    powTwo *= 2;
                }
                else 
                {
                    hammingCode += input[j];
                    j++;
                }
            }

            int[,] transformationMatrix = new int[k,m+k];
            int[] controlBits = new int[k];
            for (int i = 0; i < m+k; i++ )
            {
                String binaryNumber = toBinary(i+1,k);
                for(int j=0;j<k;j++)
                {
                    transformationMatrix[j, i] = binaryNumber[j]-'0';
                    controlBits[j] += transformationMatrix[j, i] * (hammingCode[i] - '0');
                }
            }
            for (int i = 0; i < k; i++) controlBits[i] %= 2;
            String output = "";
            powTwo = 1;
            for (int i = 0, j = 0; i < input.Length + k; i++)
            {
                if ((i + 1) == powTwo)
                {
                    output += (char)(controlBits[i-j] + (int)'0');
                    powTwo *= 2;
                }
                else
                {
                    output += input[j];
                    j++;
                }
            }
            return output;
        }

        public static int FindMistake(string hammingCode,int k)
        {
            int m = hammingCode.Length - k;
            int[,] transformationMatrix = new int[k, m+k];
            int[] syndrome = new int[k];
            for (int i = 0; i < m + k; i++)
            {
                String binaryNumber = toBinary(i + 1, k);
                for (int j = 0; j < k; j++)
                {
                    transformationMatrix[j, i] = binaryNumber[j] - '0';
                    syndrome[j] += transformationMatrix[j, i] * (hammingCode[i] - '0');
                }
            }
            for (int i = 0; i < k; i++) syndrome[i] %= 2; 
            int sum = 0;
            for(int i=0;i<k;i++)
            {
                sum += syndrome[i] * (int)Math.Pow(2,i);
            }
            return sum;
        }
        public static String toBinary(int index,int k)
        {
            String output = "";
            while(index != 0)
            {
                output += index % 2;
                index /= 2;
            }
            while(output.Length < k)
            {
                output += '0';
            }
            return output;
        }

    }
}
