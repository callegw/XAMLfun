using System;
using System.Windows;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace XAMLfun
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }


        private void Test_OnClick(object sender, RoutedEventArgs e)
        {
            RandomColor();
        }

        public void RandomColor()
        {
            var rand = new Random();
            var colorBytes1 = new byte[3];
            rand.NextBytes(colorBytes1);
            var colorBytes2 = new byte[3];
            rand.NextBytes(colorBytes2);
            var colorBytes3 = new byte[3];
            rand.NextBytes(colorBytes3);
            var colorBytes4 = new byte[3];
            rand.NextBytes(colorBytes4);
            var colorBytes5 = new byte[3];
            rand.NextBytes(colorBytes5);
            var colorBytes6 = new byte[3];
            rand.NextBytes(colorBytes6);
            var colorBytes7 = new byte[3];
            rand.NextBytes(colorBytes7);
            var colorBytes8 = new byte[3];
            rand.NextBytes(colorBytes8);
            var colorBytes9 = new byte[3];
            rand.NextBytes(colorBytes9);

            Color randomColor1 = Color.FromArgb(255, colorBytes1[0], colorBytes1[1], colorBytes1[2]);
            Color randomColor2 = Color.FromArgb(255, colorBytes2[0], colorBytes2[1], colorBytes2[2]);
            Color randomColor3 = Color.FromArgb(255, colorBytes3[0], colorBytes3[1], colorBytes3[2]);
            Color randomColor4 = Color.FromArgb(255, colorBytes4[0], colorBytes4[1], colorBytes4[2]);
            Color randomColor5 = Color.FromArgb(255, colorBytes5[0], colorBytes5[1], colorBytes5[2]);
            Color randomColor6 = Color.FromArgb(255, colorBytes6[0], colorBytes6[1], colorBytes6[2]);
            Color randomColor7 = Color.FromArgb(255, colorBytes7[0], colorBytes7[1], colorBytes7[2]);
            Color randomColor8 = Color.FromArgb(255, colorBytes8[0], colorBytes8[1], colorBytes8[2]);
            Color randomColor9 = Color.FromArgb(255, colorBytes9[0], colorBytes9[1], colorBytes9[2]);

            Rectangle1.Fill = new SolidColorBrush(randomColor1);
            Rectangle2.Fill = new SolidColorBrush(randomColor2);
            Rectangle3.Fill = new SolidColorBrush(randomColor3);
            Rectangle4.Fill = new SolidColorBrush(randomColor4);
            Rectangle5.Fill = new SolidColorBrush(randomColor5);
            Rectangle6.Fill = new SolidColorBrush(randomColor6);
            Rectangle7.Fill = new SolidColorBrush(randomColor7);
            Rectangle8.Fill = new SolidColorBrush(randomColor8);
            Rectangle9.Fill = new SolidColorBrush(randomColor9);
        }
    }
}