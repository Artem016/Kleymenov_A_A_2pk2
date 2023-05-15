using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RepairRequests2
{   /*
     приложение для регистрации всех заявок на ремонт мелкой бытовой техники.
функции:
- добавление/удаление/редактирование заявки
- отображение всего списка заявок в хронологическом порядке
- отображение только выполненных заявок (стоит отметка о выполнении)
- отображение только невыполненных заявок (нет отметки о выполнении)

сущность заявки хранит сведения о:
- клиенте (ФИО, паспортные данные)
- типе бытовой технике
- производителе техники
- модели техники
- описании неисправности
- отметка о выполнении заявки (была ли техника отремонтирована)
реализовать хранение заявок в списке структур.

приложение содержит 2 окна:
-основное со списком заявок и кнопками добавления/удаления

-модальное для редактирования/добавления заявки
дополнительно реализовать хранение массива структур в json или xml файл с
помощью сериализации
     */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }//Стандартаная команда появления главного окна

        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {
            //С помощья Cntr + Shift + A мы создаем новое окно для программы.
            AddRequestWindow addRequestWindow = new AddRequestWindow();
            //Создаем обьект данного окна, при нажатии на кнопку, чтобы можно было показать его пользователю.
            addRequestWindow.Show();//показываем пользователю окно
            addRequestWindow.Owner = this;//иницаализация окна MainWindow как владельца окна AddRequestWindow, то есть при закрытии галвног окна, закрывается и дочернее, но не наоборот.
        }
    }
}
