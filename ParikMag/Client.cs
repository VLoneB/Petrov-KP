using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParikMag
{
    public class Клиент
    {
        private int Код_клиента;
        private int Имя;
        private int Фамилия;
        private int Телефон;

        public void GetClient()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Корзина
    {
        private int Код_пользователя;
        private int Код_корзины;
        private int Бренд;
        private int Код_товара;
        private int Количество_товара;

        public void GetKorzina()
        {
            throw new System.NotImplementedException();
        }

        public void SetKorzina()
        {
            throw new System.NotImplementedException();
        }
    }
}