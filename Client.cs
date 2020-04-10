using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    /// <summary>
    /// пользователь
    /// </summary>
    class Client
    {
        /// <summary>
        /// "нажимаем на кнопку запуска"
        /// </summary>
        /// <param name="facade">требуемый фасад</param>
        public void createApp(GameEngineFacade facade)
        {
            facade.checkState();
            facade.startApp();
            facade.stopApp();
        }
    }
}
