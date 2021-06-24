using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace lab6_Mykhailenko
{
    public partial class MainWindow : Window
    {
        private int timeCounter = 0;
        private DispatcherTimer timer = new DispatcherTimer();
        private Random rand = new Random();
        private Point mouse;
        private const sbyte buttonSpead = 3;
        private const double buttonMinimization = 0.15;
        private const sbyte buttonDistance = 60;
        private double left;
        private double top;
        private bool horizontalLimitation;
        private bool verticalLimitation;
        private bool leftPart;
        private bool rightPart;
        private bool totPart;
        private bool bottomPart;
        private readonly string Start_message = "Натисніть кнопку \"Ок\"!!!";
        private readonly string Fail = "Кнопка \"Ок\" не може бути натиснута";
        private readonly string Win_message = "Молодець";

        public MainWindow()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Win_message);
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = e.GetPosition(this);
            left = Canvas.GetLeft(ButtonOK);
            top = Canvas.GetTop(ButtonOK);;
            horizontalLimitation = ((top - mouse.Y) <= 0 && ((top + ButtonOK.Height) - mouse.Y) >= 0);
            verticalLimitation = ((left - mouse.X) <= 0 && ((left + ButtonOK.Width) - mouse.X) >= 0);
            leftPart = mouse.X - (left - buttonDistance) >= 0 && mouse.X - left <= 0;
            rightPart = (left + ButtonOK.Width + buttonDistance) - mouse.X >= 0 && (left + ButtonOK.Width) - mouse.X <= 0;
            totPart = ((top - buttonDistance) - mouse.Y) <= 0 && (top - mouse.Y) >= 0;
            bottomPart = (top + ButtonOK.Height + buttonDistance) - mouse.Y >= 0 && (top + ButtonOK.Height) - mouse.Y <= 0;
            if (ButtonOK.Height - buttonMinimization < 0)
                ButtonOK.Height = 0;

            if (horizontalLimitation)
            {
               if(leftPart)
               {
                   Canvas.SetLeft(ButtonOK, left + buttonSpead);
                   if (ButtonOK.Height != 0)
                        ButtonOK.Height = Math.Round(ButtonOK.Height, 2) - buttonMinimization;
                }
               if (rightPart)
                {
                   Canvas.SetLeft(ButtonOK, left - buttonSpead);
                    if (ButtonOK.Height != 0)
                        ButtonOK.Height = Math.Round(ButtonOK.Height, 2) - buttonMinimization;
                }
            }
            if (verticalLimitation)
            {
                if (totPart)
                {
                    Canvas.SetTop(ButtonOK, top + buttonSpead);
                    if (ButtonOK.Height != 0)
                        ButtonOK.Height = Math.Round(ButtonOK.Height, 2) - buttonMinimization;
                }
                if (bottomPart)
                {
                    Canvas.SetTop(ButtonOK, top - buttonSpead);
                    if (ButtonOK.Height != 0)
                        ButtonOK.Height = Math.Round(ButtonOK.Height, 2) - buttonMinimization;
                }
            }
            if (leftPart)
            {
                if (totPart)
                {
                    Canvas.SetLeft(ButtonOK, left + buttonSpead);
                    Canvas.SetTop(ButtonOK, top + buttonSpead);
                    if (ButtonOK.Height != 0)
                        ButtonOK.Height = Math.Round(ButtonOK.Height, 2) - buttonMinimization;
                }
                if (bottomPart)
                {
                    Canvas.SetLeft(ButtonOK, left + buttonSpead);
                    Canvas.SetTop(ButtonOK, top - buttonSpead);
                    if (ButtonOK.Height != 0)
                        ButtonOK.Height = Math.Round(ButtonOK.Height, 2) - buttonMinimization;
                }
            }

            if (rightPart)
            {
                if (totPart)
                {
                    Canvas.SetLeft(ButtonOK, left - buttonSpead);
                    Canvas.SetTop(ButtonOK, top + buttonSpead);
                    if (ButtonOK.Height != 0)
                        ButtonOK.Height = Math.Round(ButtonOK.Height, 2) - buttonMinimization;
                }
                if (bottomPart)
                {
                    Canvas.SetLeft(ButtonOK, left - buttonSpead);
                    Canvas.SetTop(ButtonOK, top - buttonSpead);
                    if (ButtonOK.Height != 0)
                        ButtonOK.Height = Math.Round(ButtonOK.Height, 2) - buttonMinimization;
                }
            }

            if ((left + ButtonOK.Width) >= Width
                || left <= 0
                || (top + ButtonOK.Height*1.9) >= Height
                || top <= 0)
            {
                Canvas.SetTop(ButtonOK, rand.Next((int)Height / 2));
                Canvas.SetLeft(ButtonOK, rand.Next((int)Width / 2));
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeCounter <= 16)
            {
                if (timeCounter % 2 != 0 && timeCounter <= 16)
                    this.Title = Start_message;
                else if (timeCounter == 16)
                    this.Title = Start_message;
                else
                    this.Title = "";
            }

            if (ButtonOK.Height == 0)
            {
                if (timeCounter % 2 != 0)
                    this.Title = Fail;
                else
                    this.Title = "";
            }

            timeCounter++;
        }

        private void ButtonOK_MouseEnter(object sender, MouseEventArgs e)
        {
            Canvas.SetTop(ButtonOK, rand.Next((int)Height / 2));
            Canvas.SetLeft(ButtonOK, rand.Next((int)Width / 2));
        }
    }
}
