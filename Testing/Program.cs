using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace AuthApp
{
    internal class Testing
    {
        private static void Main(string[] args)
        {
            UIA3Automation _automation = new UIA3Automation();
            Application _app;

            _app = Application.Launch("C:\\Temp\\Ispp-21\\EducationProjects-master\\EducationProjects-master\\AuthApp\\bin\\Debug\\net8.0-windows\\AuthApp.exe");

            var window = _app.GetMainWindow(_automation);

            Console.WriteLine(window.Title);

            var regLoginBox = window.FindFirstDescendant(x => x.ByAutomationId("regLoginBox")).AsTextBox();
            var regPasswordBox = window.FindFirstDescendant(x => x.ByAutomationId("regPasswordBox")).AsTextBox();
            var regConfirmPasswordBox = window.FindFirstDescendant(x => x.ByAutomationId("regConfirmPasswordBox")).AsTextBox();
            var reg = window.FindFirstDescendant(x => x.ByText("Зарегистрироваться")).AsButton();
            var confirm = window.FindFirstDescendant(x => x.ByAutomationId("2")).AsButton();

            reg.Click();
            confirm.Click();
            regLoginBox.Enter("drago");

            var loginBox = window.FindFirstDescendant(x => x.ByAutomationId("loginBox")).AsTextBox();
            var PasswordBox = window.FindFirstDescendant(x => x.ByAutomationId("PasswordBox")).AsTextBox();
            var auth = window.FindFirstDescendant(x => x.ByText("Войти")).AsButton();


            loginBox.Enter("drago");


            //var inputs = window.FindAllDescendants(x => x.ByControlType(FlaUI.Core.Definitions.ControlType.Edit));
            //inputs[0].AsTextBox().Enter("Сделать домашку");
            //inputs[1].AsTextBox().Enter("Открыть тетради и закрыть тетрадь");

            //window.FindFirstDescendant(x => x.ByText("Добавить")).AsButton().Click();

            //window.FindFirstDescendant(x => x.ByText("Сделать домашку")).AsButton().Click();


            //Console.WriteLine(inputs.Count());
            //window.FindFirstDescendant(x => x.ByText("Тестирование знаний")).AsButton().Click();
            //input.Enter("Hello world!");

            Console.ReadLine();
            _app.Close();
        }
    }
}
