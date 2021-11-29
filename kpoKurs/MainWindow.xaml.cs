using System;
using System.Windows;


namespace kpoKurs
{
    public partial class MainWindow : Window
    {
        Conductor r1 = new Conductor();
        Conductor r2 = new Conductor();
        Conductor r3 = new Conductor();
        bool flagR1 = false;
        bool flagR2 = false;
        bool flagR3 = false;
        double Robch = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            r1.R = 1;
            r2.R = 1;
            r3.R = 1;

        }
        private void closeButton_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void checkedR1_CheckedChange(object sender, RoutedEventArgs e)
        {
            flagR1 = (checkR1.IsChecked == true);
            changeImage();
        }
        private void checkedR2_CheckedChange(object sender, RoutedEventArgs e)
        {
            flagR2 = (checkR2.IsChecked == true);
            changeImage();
        }
        private void checkedR3_CheckedChange(object sender, RoutedEventArgs e)
        {
            flagR3 = (checkR3.IsChecked == true);
            changeImage();
        }


        private void sliderR1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Robch = 0;
            if (flagR1)
                r1.R = sliderR1.Value;
          
        }

        private void sliderR2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (flagR2)
                r2.R = sliderR2.Value;
            CountRobch();
        }
        private void sliderR3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (flagR3)
                r3.R = sliderR3.Value;
            CountRobch();
        }

        private void sliderI_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CountRobch();
            updateU(Robch, sliderI.Value);
        }
        private void updateU(double R, double I)
        {
            double U = R * I;
            AnswerU.Text = Convert.ToString(U);
            WithLight.Opacity = U / 100;
        }

        private void CalculateU_Click(object sender, RoutedEventArgs e)
        {
            CountRobch();
            updateU(Robch, sliderI.Value);
        }
        private void CountRobch()
        {
            if (flagR1 && !flagR2 && !flagR3)
            {
                Robch = r1.R;
            }
            else
            if (!flagR1 && flagR2 && !flagR3)
            {
                Robch = r2.R;
            }
            else
            if (!flagR1 && !flagR2 && flagR3)
            {
                Robch = r3.R;
            }
            else
            if (flagR1 && flagR2 && !flagR3)
                Robch = r1.R * r2.R / (r1.R + r2.R);
            else
            if (flagR1 && !flagR2 && flagR3)
                Robch = r1.R + r3.R;
            else
            if (!flagR1 && flagR2 && flagR3)
                Robch = r2.R + r3.R;
            else
            if (flagR1 && flagR2 && flagR3)
            {
                Robch = r1.R * r2.R / (r1.R + r2.R) + r3.R;
            }
        }
        private void changeImage()
        {
            if (flagR1 && !flagR2 && !flagR3)
            {
                ChainR1.Opacity = 1;
                ChainR2.Opacity = 0;
                ChainR3.Opacity = 0;
                ChainR1R2.Opacity = 0;
                ChainR1R3.Opacity = 0;
                ChainR2R3.Opacity = 0;
                fullChain.Opacity = 0;
            }
            else
            if (!flagR1 && flagR2 && !flagR3)
            {
                ChainR1.Opacity = 0;
                ChainR2.Opacity = 1;
                ChainR3.Opacity = 0;
                ChainR1R2.Opacity = 0;
                ChainR1R3.Opacity = 0;
                ChainR2R3.Opacity = 0;
                fullChain.Opacity = 0;
            }
            else
            if (!flagR1 && !flagR2 && flagR3)
            {
                ChainR1.Opacity = 0;
                ChainR2.Opacity = 0;
                ChainR3.Opacity = 1;
                ChainR1R2.Opacity = 0;
                ChainR1R3.Opacity = 0;
                ChainR2R3.Opacity = 0;
                fullChain.Opacity = 0;
            }
            else
            if (flagR1 && flagR2 && !flagR3)
            {
                ChainR1.Opacity = 0;
                ChainR2.Opacity = 0;
                ChainR3.Opacity = 0;
                ChainR1R2.Opacity = 1;
                ChainR1R3.Opacity = 0;
                ChainR2R3.Opacity = 0;
                fullChain.Opacity = 0;
            }
            else
            if (flagR1 && !flagR2 && flagR3)
            {
                ChainR1.Opacity = 0;
                ChainR2.Opacity = 0;
                ChainR3.Opacity = 0;
                ChainR1R2.Opacity = 0;
                ChainR1R3.Opacity = 1;
                ChainR2R3.Opacity = 0;
                fullChain.Opacity = 0;
            }
            else
            if (!flagR1 && flagR2 && flagR3)
            {
                ChainR1.Opacity = 0;
                ChainR2.Opacity = 0;
                ChainR3.Opacity = 0;
                ChainR1R2.Opacity = 0;
                ChainR1R3.Opacity = 0;
                ChainR2R3.Opacity = 1;
                fullChain.Opacity = 0;
            }
            else
            if (flagR1 && flagR2 && flagR3)
            {
                ChainR1.Opacity = 0;
                ChainR2.Opacity = 0;
                ChainR3.Opacity = 0;
                ChainR1R2.Opacity = 0;
                ChainR1R3.Opacity = 0;
                ChainR2R3.Opacity = 0;
                fullChain.Opacity = 1;
            }
            else
                if(!flagR1 && !flagR2 && !flagR3)
            {
                ChainR1.Opacity = 0;
                ChainR2.Opacity = 0;
                ChainR3.Opacity = 0;
                ChainR1R2.Opacity = 0;
                ChainR1R3.Opacity = 0;
                ChainR2R3.Opacity = 0;
                fullChain.Opacity = 0;
            }
        }
    }
}
