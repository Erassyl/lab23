using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsRead = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fsRead);
            FileStream fsWrite = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fsWrite);
            string s = sr.ReadToEnd();
            
            string[] number = s.Split(); //вводим числа через пробел
            for (int i = 0; i < number.Length; i++)
            {
                int min = int.Parse(number[0]);
                int cnt = 0; //создаем счетчик который будет считать число делителей
                int a = int.Parse(number[i]); //каждый элемент строки записываем как тип int
            
                for (int j = 1; j <= a; j++)     //пробегаемся по циклу с 1 до а числа                    
                {
                    if (a % j == 0)
                    {
                        cnt++; //прибавляем счетчику один
                    }
                }
                if (cnt < 3)//если число делителей меньше 3 то это простое число 
                {
                    if (a < min)
                    {
                        min = a;
                    }

                    sw.Write(min);
                    sw.Close();
                    fsRead.Close();
                    fsWrite.Close();
                }
            }
        }
    }
}
