using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_8
{
    interface IArithmOP
    {
        int FirstNumber { get; }
        int SecondNumber { get; }

        int Sum(int x, int y);
        int Razn(int x, int y);
        int Proizv(int x, int y);
        int Delenie(int x, int y);
    }

    public class Pair : IArithmOP, IComparable
    {
        //поля класса
        private int _aFirstNumber;
        private int _aSecondNumber;
        //конструктор
        public Pair(int aFirstNumber, int aSecondNumber)
        {
            //Поля класса
            _aFirstNumber = aFirstNumber;
            _aSecondNumber = aSecondNumber;
        }
        public int FirstNumber
        {
            //Возвращаем значение
            get
            {
                return _aFirstNumber;
            }
            //Устанавливаем значение
            set
            {
                _aFirstNumber = value;
            }
        }
        //Св-ва 2-го числа
        public int SecondNumber
        {
            //Возвращаем значение
            get
            {
                return _aSecondNumber;
            }
            //Устанавливаем значение
            set
            {
                _aSecondNumber = value;
            }
        }
        //Реализация интерфейса по заданию
        public int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        public int Razn(int x, int y)
        {
            int razn = x - y;
            return razn;
        }
        public int Proizv(int x, int y)
        {
            int proizv = x * y;
            return proizv;
        }
        public int Delenie(int x, int y)
        {
            int del = x / y;
            return del;
        }
        //Сравнение
        public int CompareTo(object obj)//реализация интерфейса
        {
            Pair temp = (Pair)obj;
            if (this.FirstNumber > temp.FirstNumber && this.SecondNumber > temp.SecondNumber) return 1;
            if (this.FirstNumber < temp.FirstNumber && this.SecondNumber < temp.SecondNumber) return -1;
            return 0;
        }        
    }
}
