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
using System.Windows.Threading;


namespace examen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      List<books> book = new List<books>();
        private protected logic LC = new logic();
        private protected bruger BG = new bruger();
      
        bool login, txt2, startup = true;
        public MainWindow()
        {

            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
           timer.Tick += update; 
            timer.Start();
      



        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
           if (string.IsNullOrEmpty(TitleTXT.Text)  || ) MessageBox.Show("skriv titel");
            else

               txt2 = true;
        }

        private void update(object sender, EventArgs e)
        {
            if (startup == true)
            {


                /* maincanvas.Children.Add(AuthorTXT);
                 maincanvas.Children.Add(TitleTXT);
                 maincanvas.Children.Add(btn1);
                 maincanvas.Children.Add(txtblock1);
                 maincanvas.Children.Add(txtblock2);
                 maincanvas.Children.Add(regtxt); */
                brugerTXT.Visibility = Visibility.Visible;
               
                txtblock1.Visibility = Visibility.Visible;
               
                regtxt.Visibility = Visibility.Visible;
                btn1.Visibility = Visibility.Visible;
                startup = false;
            }

            if (login == true && startup == false)
            {
                brugerTXT.Visibility = Visibility.Collapsed;
                TitleTXT.Visibility = Visibility.Collapsed;
                txtblock1.Visibility = Visibility.Collapsed;
                txtblock2.Visibility = Visibility.Collapsed;
                regtxt.Visibility = Visibility.Collapsed;
                btn1.Visibility = Visibility.Collapsed;
            }
          
            /* if (login == true && txt2 == true && startup == false)
                {
                    brugerTXT.Visibility = Visibility.Collapsed;
                TitleTXT.Visibility = Visibility.Collapsed;
                txtblock1.Visibility = Visibility.Collapsed;
                txtblock2.Visibility = Visibility.Collapsed;
                regtxt.Visibility = Visibility.Collapsed;
                btn1.Visibility = Visibility.Collapsed;

                //  maincanvas.Children.Clear();


                } */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(brugerTXT.Text) || brugerTXT.Text == "bruger" || brugerTXT.Text == "admin") MessageBox.Show("skriv bruger");
            else
               login = true;

           
            

        }
    }
}
