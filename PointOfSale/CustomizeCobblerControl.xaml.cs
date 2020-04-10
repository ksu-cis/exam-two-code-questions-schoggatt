using ExamTwoCodeQuestions.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();

            Blueberry.Checked += FruitBlueberry_Checked;
            Cherry.Checked += FruitCherry_Checked;
            Peach.Checked += FruitPeach_Checked;

            Yes.Checked += Yes_Checked;
            No.Checked += No_Checked;

            Yes.Loaded += Init_Checked;
            No.Loaded += Init_Checked;
        }

        private void FruitBlueberry_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Cobbler cobbler)
            {
                cobbler.Fruit = FruitFilling.Blueberry;
            }
        }

        private void FruitCherry_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Cobbler cobbler)
            {
                cobbler.Fruit = FruitFilling.Cherry;
            }
        }

        private void FruitPeach_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Cobbler cobbler)
            {
                cobbler.Fruit = FruitFilling.Peach;
            }
        }

        private void Yes_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Cobbler cobbler)
            {
                cobbler.WithIceCream = true;
            }
        }

        private void No_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Cobbler cobbler)
            {
                cobbler.WithIceCream = false;
            }
        }

        private void Init_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Cobbler cobbler)
            {
                switch (cobbler.WithIceCream)
                {
                    case true:
                        Yes.IsChecked = true;
                        break;
                    case false:
                        No.IsChecked = true;
                        break;
                }
            }
        }
    }
}
