using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary<T, K>
    {
        KeyValuePair<T, K>[] items; // Veri Tipimizi Oluşturduk
        
        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }
        public void Add(T _key,K _value)
        {
            if(Control(_key))
            {
                Configuration();
                items[items.Length - 1] = new KeyValuePair<T, K>(_key, _value); // Bize Gelen Değeri Diziye Aktardık

            }
            else
            {
                Console.WriteLine("Girdiniğiz Key Değeri Özel Olmalı. Daha Önce Eklemediğinizden Emin Olun.");
            }
        }

        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        private void Configuration()
        {
            KeyValuePair<T, K>[] tempArray = items; // Geçici Dizi oluşturma
            items = new KeyValuePair<T, K>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // Geçici Dizimizde ki Elemanlı Asıl Dizimize Koyduk.

            }

        }
        private bool Control (T _key)
        {
            bool control = true;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.ToString() == _key.ToString())
                {
                    control = false;
                }
            }
            return control;
        }
    }
}
