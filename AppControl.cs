using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    /// <summary>
    /// приложение
    /// </summary>
    class AppControl
    {
        /// <summary>
        /// запуск
        /// </summary>
        public void wake()
        {
            Console.WriteLine("выполняем приложение");
        }
        /// <summary>
        /// остановка
        /// </summary>
        /// <returns>true, если не было ошибок</returns>
        public bool finish()
        {
            Console.WriteLine("завершаем приложение " +
                "выводим сообщение об ошибке, если был сбой");
            return true;
        }
    }
}
