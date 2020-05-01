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

namespace XO
{
   
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool game;
        bool firstX;//true - нечётные ходы Х, false - нечётные ходы О
        //bool stepX;
        bool[,] stat = new bool[3, 3];
        int[,] value = new int[3, 3];//0-невыбрана 1-крестик 2-нолик
        int open;//открыто полей 
        public MainWindow()
        {
            
            InitializeComponent();
            B00.Visibility = Visibility.Collapsed;
            B01.Visibility = Visibility.Collapsed;
            B02.Visibility = Visibility.Collapsed;
            B10.Visibility = Visibility.Collapsed;
            B11.Visibility = Visibility.Collapsed;
            B12.Visibility = Visibility.Collapsed;
            B20.Visibility = Visibility.Collapsed;
            B21.Visibility = Visibility.Collapsed;
            B22.Visibility = Visibility.Collapsed;

        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            game = true;//Игра идёт - true нет - false
            open = 0;
            for (int i = 0; i < 3; i++)  //Обнуляем флаги всех полей игрового поля
                for (int j = 0; j < 3; j++)
                {
                    stat[i, j] = false;
                    value[i, j] = 0;
                }
            
            B00.Visibility = Visibility.Visible;
            B01.Visibility = Visibility.Visible;
            B02.Visibility = Visibility.Visible;
            B10.Visibility = Visibility.Visible;
            B11.Visibility = Visibility.Visible;
            B12.Visibility = Visibility.Visible;
            B20.Visibility = Visibility.Visible;
            B21.Visibility = Visibility.Visible;
            B22.Visibility = Visibility.Visible;
            B00.Cursor = Cursors.Hand;
            B01.Cursor = Cursors.Hand;
            B02.Cursor = Cursors.Hand;
            B10.Cursor = Cursors.Hand;
            B11.Cursor = Cursors.Hand;
            B12.Cursor = Cursors.Hand;
            B00.Cursor = Cursors.Hand;
            B21.Cursor = Cursors.Hand;
            B22.Cursor = Cursors.Hand;
            lin0022.Visibility = Visibility.Collapsed;
            lin0002.Visibility = Visibility.Collapsed;
            lin1012.Visibility = Visibility.Collapsed;
            lin2022.Visibility = Visibility.Collapsed;
            lin0020.Visibility = Visibility.Collapsed;
            lin0121.Visibility = Visibility.Collapsed;
            lin0222.Visibility = Visibility.Collapsed;
            lin0220.Visibility = Visibility.Collapsed;
            imX00.Visibility = Visibility.Collapsed;
            imX01.Visibility = Visibility.Collapsed;
            imX02.Visibility = Visibility.Collapsed;
            imX10.Visibility = Visibility.Collapsed;
            imX11.Visibility = Visibility.Collapsed;
            imX12.Visibility = Visibility.Collapsed;
            imX20.Visibility = Visibility.Collapsed;
            imX21.Visibility = Visibility.Collapsed;
            imX22.Visibility = Visibility.Collapsed;
            imO00.Visibility = Visibility.Collapsed;
            imO01.Visibility = Visibility.Collapsed;
            imO02.Visibility = Visibility.Collapsed;
            imO10.Visibility = Visibility.Collapsed;
            imO11.Visibility = Visibility.Collapsed;
            imO12.Visibility = Visibility.Collapsed;
            imO20.Visibility = Visibility.Collapsed;
            imO21.Visibility = Visibility.Collapsed;
            imO22.Visibility = Visibility.Collapsed;
        }



        private void CheckPK(object sender, RoutedEventArgs e)
        {
            groupBoxXorO.Visibility = Visibility.Visible;
        }

        private void CheckPlay(object sender, RoutedEventArgs e)
        {
            groupBoxXorO.Visibility = Visibility.Collapsed;
            firstX = true;
        }

        private void X_Checked(object sender, RoutedEventArgs e)
        {
            if (PK.IsChecked == true) firstX = true;
        }

        private void O_Checked(object sender, RoutedEventArgs e)
        {
            if (PK.IsChecked == true) firstX = false;
        }

        private void ClikB00(object sender, RoutedEventArgs e)
        {
            if (stat[0, 0] == false)
            {
                stat[0, 0] = true;

                if ((open % 2 == 0) && (firstX == true)) imX00.Visibility = Visibility.Visible;
                else imO00.Visibility = Visibility.Visible;
                value[0, 0] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B00.Cursor = Cursors.Arrow;
              
                Vin();
            }
        }

        private void ClikB01(object sender, RoutedEventArgs e)
        {
            if (stat[0, 1] == false)
            {
                stat[0, 1] = true;
                if ((open % 2 == 0) && (firstX == true)) imX01.Visibility = Visibility.Visible;
                else imO01.Visibility = Visibility.Visible;
                value[0, 1] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B01.Cursor = Cursors.Arrow;
                Vin();
            }
        }

        private void ClikB02(object sender, RoutedEventArgs e)
        {
            if (stat[0, 2] == false)
            {
                stat[0, 2] = true;
                if ((open % 2 == 0) && (firstX == true)) imX02.Visibility = Visibility.Visible;
                else imO02.Visibility = Visibility.Visible;
                value[0, 2] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B02.Cursor = Cursors.Arrow;
                Vin();
            }
        }

        private void ClikB10(object sender, RoutedEventArgs e)
        {
            if (stat[1, 0] == false)
            {
                stat[1, 0] = true;
                if ((open % 2 == 0) && (firstX == true)) imX10.Visibility = Visibility.Visible;
                else imO10.Visibility = Visibility.Visible;
                value[1, 0] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B10.Cursor = Cursors.Arrow;
                Vin();
            }
        }

        private void ClikB11(object sender, RoutedEventArgs e)
        {
            if (stat[1, 1] == false)
            {
                stat[1, 1] = true;
                if ((open % 2 == 0) && (firstX == true)) imX11.Visibility = Visibility.Visible;
                else imO11.Visibility = Visibility.Visible;
                value[1, 1] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B11.Cursor = Cursors.Arrow;
                Vin();
            }
        }

        private void ClikB12(object sender, RoutedEventArgs e)
        {
            if (stat[1, 2] == false)
            {
                stat[1, 2] = true;
                if ((open % 2 == 0) && (firstX == true)) imX12.Visibility = Visibility.Visible;
                else imO12.Visibility = Visibility.Visible;
                value[1, 2] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B12.Cursor = Cursors.Arrow;
                Vin();
            }
        }

        private void ClikB20(object sender, RoutedEventArgs e)
        {
            if (stat[2, 0] == false)
            {
                stat[2, 0] = true;
                if ((open % 2 == 0) && (firstX == true)) imX20.Visibility = Visibility.Visible;
                else imO20.Visibility = Visibility.Visible;
                value[2, 0] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B20.Cursor = Cursors.Arrow;
                Vin();
            }
        }

        private void ClikB21(object sender, RoutedEventArgs e)
        {
            if (stat[2, 1] == false)
            {
                stat[2, 1] = true;
                if ((open % 2 == 0) && (firstX == true)) imX21.Visibility = Visibility.Visible;
                else imO21.Visibility = Visibility.Visible;
                value[2, 1] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B21.Cursor = Cursors.Arrow;
                Vin();
            }
        }

        private void ClikB22(object sender, RoutedEventArgs e)
        {
            if (stat[2, 2] == false)
            {
                stat[2, 2] = true;
                if ((open % 2 == 0) && (firstX == true)) imX22.Visibility = Visibility.Visible;
                else imO22.Visibility = Visibility.Visible;
                value[2, 2] = (open % 2 == 0) && (firstX == true) ? 1 : 2;
                open++;
                B22.Cursor = Cursors.Arrow;
                Vin();
            }
        }
        public void Vin()
        {
            if ((value[0, 0] == value[0, 1]) && (value[0, 1] == value[0, 2]) && (value[0, 0] == 1))
            {
                lin0002.Visibility = Visibility.Visible;
                MessageBox.Show("Победили Х");
                game = false;
            }
            if ((value[1, 0] == value[1, 1]) && (value[1, 1] == value[1, 2]) && (value[1, 0] == 1))
            {
                lin1012.Visibility = Visibility.Visible;
                MessageBox.Show("Победили Х");
                game = false;
            }
            if ((value[2, 0] == value[2, 1]) && (value[2, 1] == value[2, 2]) && (value[2, 0] == 1))
            {
                lin2022.Visibility = Visibility.Visible;
                MessageBox.Show("Победили Х");
                game = false;
            }
            if ((value[0, 0] == value[1, 0]) && (value[1, 0] == value[2, 0]) && (value[0, 0] == 1))
            {
                lin0020.Visibility = Visibility.Visible;
                MessageBox.Show("Победили Х");
                game = false;
            }
            if ((value[0, 1] == value[1, 1]) && (value[1, 1] == value[2, 1]) && (value[0, 1] == 1))
            {
                lin0121.Visibility = Visibility.Visible;
                MessageBox.Show("Победили Х");
                game = false;
            }
            if ((value[0, 2] == value[1, 2]) && (value[1, 2] == value[2, 2]) && (value[0, 2] == 1))
            {
                lin0222.Visibility = Visibility.Visible;
                MessageBox.Show("Победили Х");
                game = false;
            }
            if ((value[0, 0] == value[1, 1]) && (value[1, 1] == value[2, 2]) && (value[0, 0] == 1))
            {
                lin0022.Visibility = Visibility.Visible;
                MessageBox.Show("Победили Х");
                game = false;
            }
            if ((value[0, 2] == value[1, 1]) && (value[1, 1] == value[2, 0]) && (value[0, 2] == 1))
            {
                lin0220.Visibility = Visibility.Visible;
                MessageBox.Show("Победили Х");
                game = false;

            }
            if ((value[0, 0] == value[0, 1]) && (value[0, 1] == value[0, 2]) && (value[0, 0] == 2))
            {
                lin0002.Visibility = Visibility.Visible;
                MessageBox.Show("Победили 0");
                game = false;
            }
            if ((value[1, 0] == value[1, 1]) && (value[1, 1] == value[1, 2]) && (value[1, 0] == 2))
            {
                lin1012.Visibility = Visibility.Visible;
                MessageBox.Show("Победили 0");
                game = false;
            }
            if ((value[2, 0] == value[2, 1]) && (value[2, 1] == value[2, 2]) && (value[2, 0] == 2))
            {
                lin2022.Visibility = Visibility.Visible;
                MessageBox.Show("Победили 0");
                game = false;
            }
            if ((value[0, 0] == value[1, 0]) && (value[1, 0] == value[2, 0]) && (value[0, 0] == 2))
            {
                lin0020.Visibility = Visibility.Visible;
                MessageBox.Show("Победили 0");
                game = false;
            }
            if ((value[0, 1] == value[1, 1]) && (value[1, 1] == value[2, 1]) && (value[0, 1] == 2))
            {
                lin0121.Visibility = Visibility.Visible;
                MessageBox.Show("Победили 0");
                game = false;
            }
            if ((value[0, 2] == value[1, 2]) && (value[1, 2] == value[2, 2]) && (value[0, 2] == 2))
            {
                lin0222.Visibility = Visibility.Visible;
                MessageBox.Show("Победили 0");
                game = false;
            }
            if ((value[0, 0] == value[1, 1]) && (value[1, 1] == value[2, 2]) && (value[0, 0] == 2))
            {
                lin0022.Visibility = Visibility.Visible;
                MessageBox.Show("Победили 0");
                game = false;
            }
            if ((value[0, 2] == value[1, 1]) && (value[1, 1] == value[2, 0]) && (value[0, 2] == 2))
            {
                lin0220.Visibility = Visibility.Visible;
                MessageBox.Show("Победили 0");
                game = false;

            }

        }
    
    }
}
