//а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен постараться получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы. - done
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7
{
    class Udvoitel
    {
        int finish;
        int current;
        List<int> _listOfValue;
        public List<int> ListOfValue => _listOfValue;
        public Udvoitel(int min, int max)
        {
            Random rnd = new Random();
            this.finish = rnd.Next(min, max + 1);
            current = 1;
            _listOfValue = new List<int>() { 1 };
        }

        public void Plus()
        {
            current++;
            _listOfValue.Add(current);
        }

        public void Multi()
        {
            current *= 2;
            _listOfValue.Add(current);
        }

        public void Reset()
        {
            current = 1;
            _listOfValue.Add(current);
        }

        public void Back()
        {
            if (_listOfValue != null && _listOfValue.Count > 1)
            {
                var temp = _listOfValue[_listOfValue.Count - 2];
                _listOfValue.Remove(current);
                current = temp;
            }
            if (_listOfValue.Count == 1)
            {
                current = 0;
            }
        }

        public int Current
        {
            get { return current; }
        }

        public int Finish
        {
            get { return finish; }
        }


        //1=>25 +1 x2
    }
}
