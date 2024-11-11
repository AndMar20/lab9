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

            #region	Проверить что после нажатия на регистрацию выводится сообщение о необходимости заполнить все поля
            reg.Click();
            window.FindFirstDescendant(x => x.ByAutomationId("2")).Click();
            #endregion

            regLoginBox.Enter("drago");

            #region Ввести простой пароль, не содержащий один и более из этих элементов: большие и маленькие буквы, спец. символы, цифры, или состоящий не из восьми символов
            regPasswordBox.Enter("drago");
            reg.Click();
            window.FindFirstDescendant(x => x.ByAutomationId("2")).Click();
            #endregion

            #region Ввести разные пароли при регистрации
            regPasswordBox.Enter("Dragon12!");
            regConfirmPasswordBox.Enter("drago13!");
            reg.Click();
            window.FindFirstDescendant(x => x.ByAutomationId("2")).Click();
            #endregion

            #region Ввести пароль, соответствующий всем требованиям
            regPasswordBox.Enter("Dragon12!");
            regConfirmPasswordBox.Enter("Dragon12!");
            reg.Click();
            #endregion



            var loginBox = window.FindFirstDescendant(x => x.ByAutomationId("loginBox")).AsTextBox();
            var passwordBox = window.FindFirstDescendant(x => x.ByAutomationId("passwordBox")).AsTextBox();
            var auth = window.FindFirstDescendant(x => x.ByText("Войти")).AsButton();


            loginBox.Enter("drago");
            passwordBox.Enter("12132112");


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
