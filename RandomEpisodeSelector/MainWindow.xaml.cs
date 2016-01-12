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
using Xceed.Wpf.Toolkit;
using Hardcodet.Wpf.TaskbarNotification;
using System.Diagnostics;
using System.Windows.Threading;
using System.Timers;
using System.Text.RegularExpressions;

namespace RandomEpisodeSelector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Varibles
        string tvShow;
        int tvSeason;
        int tvEpisode;
        int Duration;
        bool timerFirst = true;
        Random resRandom = new Random();
        DispatcherTimer resTimer = new DispatcherTimer();
        #endregion
          public MainWindow()
        {
            InitializeComponent();
            resIcon.Icon = Properties.Resources.resIcon;
            resIcon.Visibility = Visibility.Collapsed;
            resCombo.HorizontalContentAlignment = HorizontalAlignment.Center;
            resTimer.Tick += resTimer_Tick;
            resTimer.Interval = new TimeSpan(0, 0, 1);
            timerDuration.MaxLength = 5;
            shutdownLabel.VerticalContentAlignment = VerticalAlignment.Top;
           
        }

        #region RandomEpisodeStuff
        private void randomButton_Click(object sender, RoutedEventArgs e)   //Code behind for Random Episode Button, Generates season and episode number and then launches page
        {

            if (resCombo.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show("You need to select a  tv show");
            }


            if (resCombo.Text == "American Dad")  //American Dad
            {
                tvShow = "american_dad";
                tvSeason = resRandom.Next(1, 10);
                switch (tvSeason)
                {
                    case 1:
                        tvEpisode = resRandom.Next(1, 24);
                        break;
                    case 2:
                    case 3:
                    case 6:
                    case 7:
                    case 8:
                        tvEpisode = resRandom.Next(1, 20);
                        break;
                    case 4:
                    case 5:
                    case 9:
                        tvEpisode = resRandom.Next(1, 21);
                        break;
                }
            }

            if (resCombo.Text == "Baby Daddy") //Baby Daddy
            {
                tvShow = "baby_daddy";
                tvSeason = resRandom.Next(1, 5);
                switch (tvSeason)
                {
                    case 1:
                        tvEpisode = resRandom.Next(1, 11);
                        break;
                    case 2:
                        tvEpisode = resRandom.Next(1, 20);
                        break;
                    case 3:
                        tvEpisode = resRandom.Next(1, 22);
                        break;
                    case 4:
                        tvEpisode = resRandom.Next(1, 23);
                        break;
                }
            }

            if (resCombo.Text == "Bob's Burgers") //Bob's Burgers
            {
                tvShow = "bobs_burgers";
                tvSeason = resRandom.Next(1, 6);
                switch (tvSeason)
                {
                    case 1:
                        tvEpisode = resRandom.Next(1, 14);
                        break;
                    case 2:
                        tvEpisode = resRandom.Next(1, 10);
                        break;
                    case 3:
                    case 5:
                        tvEpisode = resRandom.Next(1, 24);
                        break;
                    case 4:
                        tvEpisode = resRandom.Next(1, 23);
                        break;
                }
            }

            if (resCombo.Text == "Brooklyn Nine-Nine")  //Brooklyn Nine-Nine
            {
                tvShow = "Brooklyn_Nine-Nine";
                tvSeason = resRandom.Next(1, 3);
                switch (tvSeason)
                {
                    case 1:
                        tvEpisode = resRandom.Next(1, 23);
                        break;
                    case 2:
                        tvEpisode = resRandom.Next(1, 24);
                        break;
                }

            }

            if (resCombo.Text == "Community") //Community 
            {
                tvShow = "community";
                tvSeason = resRandom.Next(1, 7);
                switch (tvSeason)
                {
                    case 1:
                        tvEpisode = resRandom.Next(1, 26);
                        break;
                    case 2:
                        tvEpisode = resRandom.Next(1, 25);
                        break;
                    case 3:
                        tvEpisode = resRandom.Next(1, 23);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        tvEpisode = resRandom.Next(1, 14);
                        break;
                }
            }

            if (resCombo.Text == "Family Guy") //Family Guy
            {
                tvShow = "family_guy";
                tvSeason = resRandom.Next(1, 14);
                switch (tvSeason)
                {
                    case 1:
                        tvEpisode = resRandom.Next(1, 8);
                        break;
                    case 2:
                    case 8:
                    case 12:
                        tvEpisode = resRandom.Next(1, 22);
                        break;
                    case 3:
                    case 11:
                        tvEpisode = resRandom.Next(1, 23);
                        break;
                    case 4:
                        tvEpisode = resRandom.Next(1, 31);
                        break;
                    case 5:
                    case 9:
                    case 13:
                        tvEpisode = resRandom.Next(1, 19);
                        break;
                    case 6:
                        tvEpisode = resRandom.Next(1, 13);
                        break;
                    case 7:
                        tvEpisode = resRandom.Next(1, 17);
                        break;
                    case 10:
                        resRandom.Next(1, 24);
                        break;

                }
            }

            if (resCombo.Text == "New Girl")   //New Girl
            {
                tvShow = "new_girl";
                tvSeason = resRandom.Next(1, 5); 
                switch(tvSeason)
                {
                    case 1:
                        tvEpisode = resRandom.Next(1, 25);
                        break;
                    case 2:
                        tvEpisode = resRandom.Next(1, 26);
                        break;
                    case 3:
                        tvEpisode = resRandom.Next(1, 24);
                        break;
                    case 4:
                        tvEpisode = resRandom.Next(1, 23);
                        break;
                }
            }

            if(tvShow != "" && tvEpisode != 0 && tvSeason != 0)
            {
                Process.Start("http://thewatchseries.to/episode/"+tvShow+"_s"+tvSeason+"_e"+tvEpisode+".html");

            }
        }  
        #endregion

        #region Shutdown Timer 
        private void resTimer_Tick(object sender, EventArgs e)   //Shutdown Timer tick if decreases the duration(inseconds) by 1 each time if it reaches 0 it shuts down
        {
            Duration--;
            timerDuration.Text = TimeSpan.FromSeconds(Duration).ToString();

            if (Duration <= 0)
            {
                ProcessStartInfo psi = new ProcessStartInfo("Shutdown", "-s -t 0");
                psi.CreateNoWindow = true;
                Process.Start(psi);
            }
        }

        private void startButton_Click(object sender, RoutedEventArgs e)  //Timer startButton 
        {


            if (timerDuration.Text != "" && timerFirst) //checks whether the textbox(set duration field) is empty and if this is the first time it has been run(needs to set duration)
            {
                Duration = int.Parse(timerDuration.Text);
                timerDuration.IsEnabled = false;
                resTimer.Start();
                stopButton.IsEnabled = true;
                startButton.IsEnabled = false;
                timerFirst = false;
            }

            if (timerDuration.Text == "")   //if textbox is indeed empty then inform user they need to enter a duration into the textbox
                System.Windows.MessageBox.Show("You need to type a duration in seconds into the textbox");

            if(!timerFirst)   //if not the first time running the timer or been reset(ie doesnt need to set the duration) 
            {
                resTimer.Start();
                startButton.IsEnabled = false;
                stopButton.IsEnabled = true;
            }
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)   //Stop button
        {

            if (System.Windows.MessageBox.Show("Do you wish to reset the timer?", "Reset Timer?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)       //Self explantory
            {
                resTimer.Stop();
                startButton.IsEnabled = true;
                stopButton.IsEnabled = false;
                timerDuration.IsEnabled = true;
                timerDuration.Text = "";
                Duration = 0;
                timerFirst = true;

            }
            else       //
            {
                resTimer.Stop();
                startButton.IsEnabled = true;
                stopButton.IsEnabled = false;

            }
        }
        #endregion

        #region MISC 
        private void resWindow_StateChanged(object sender, EventArgs e) //Minimze to tray functionalitly-Connor Youngs
        {
            if (WindowState == System.Windows.WindowState.Minimized)
            {
                Hide();
                resIcon.Visibility = Visibility.Visible;
            }

        }

        private void resIcon_TrayLeftMouseDown(object sender, RoutedEventArgs e)  //Restore from tray functionality-Connor Youngs
        {
            Show();
            WindowState = System.Windows.WindowState.Normal;
            resIcon.Visibility = Visibility.Collapsed;
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
        #endregion

        private void resIcon_TrayRightMouseDown(object sender, RoutedEventArgs e)
        {
            
         
            
        }
    }    
   }