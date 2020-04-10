using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    /// <summary>
    /// класс, отвечающий за работу создания приложения
    /// </summary>
     class GameEngineFacade
    {
        CodeRedactor code_redactor;
        Compilation compilation;
        Render render;
        AppControl app_control;

        bool isSuccessComp = false;
        bool isSuccessFinish = true;

        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="code_redactor"> класс работы с кодом</param>
        /// <param name="compilation">класс работы компиляции кода</param>
        /// <param name="render">класс рендеринга</param>
        /// <param name="app_control">класс приложения</param>
        public GameEngineFacade(CodeRedactor code_redactor,
            Compilation compilation,
            Render render,
            AppControl app_control)
        {
            this.code_redactor = code_redactor;
            this.compilation = compilation;
            this.render = render;
            this.app_control = app_control;
        }
        /// <summary>
        /// проверка на ошибки компиляции
        /// </summary>
        public void checkState()
        {
            code_redactor.createScripts();
            code_redactor.saveScripts();
            isSuccessComp = compilation.checkForErrors();
            Console.WriteLine(isSuccessComp ? "Success" : "Errors");

        }

        /// <summary>
        /// создаем приложение, в случае отсутствия ошибок
        /// </summary>
        public void startApp()
        {
            if(isSuccessComp)
            {
                render.startRender();
                app_control.wake();
            }
        }

    /// <summary>
    /// завершаем работу приложения как от пользователя, так и программно при возникновении ошибок
    /// </summary>
        public void stopApp()
        {
            if(isSuccessComp)
            {
                isSuccessFinish = app_control.finish();
                Console.WriteLine(isSuccessFinish ? "Success finish app" : "Экстренный выход");
            }
        }

    }
}
