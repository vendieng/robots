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

namespace Robotsssss
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Robot myRobot;

        public MainWindow()
        //skriv funktion för att skapa line and then call it
        //for loop to create lines, use i for coordinates


        {
            InitializeComponent();
            DrawLines();

            Random randomGenerator = new Random();
            int x = randomGenerator.Next(8);
            int y = randomGenerator.Next(8);



            myRobot = new Robot(x, y, 7);
            DrawRobot();

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.Key == Key.Up)
            {
                myRobot.MoveUp();
            }

            else if (e.Key == Key.Down)
                {
                    myRobot.MoveDown();
                }

            else if (e.Key == Key.Right)
            { 
                myRobot.MoveRight();
            }

            else if (e.Key == Key.Left)
            {
                myRobot.MoveLeft();
            }
            //add else

            DrawRobot();

        }

            private void DrawRobot()

            {
                
                Canvas.SetLeft(robotimg, myRobot.X * 50);
                Canvas.SetTop(robotimg, myRobot.Y * 50);

            }




        private void DrawLines()
        //function to draw lines


        {
            for (int y = 0; y <= 400; y += 50)
            {
                Line line = new Line();
                //creates new lines - line is a class, we've created a variable called line that has a new object of this class
                line.X1 = 0;
                line.Y1 = y;
                line.X2 = 400;
                line.Y2 = y;
                line.Stroke = Brushes.Black;

                //setting the starting point for the line

                canvas.Children.Add(line);
                //canvas is the name for the canvas, it has a child line, and then you add the line you made above
            }

            for (int x = 0; x <= 400; x += 50)
            {
                Line line = new Line();
                //creates new lines - line is a class, we've created a variable called line that has a new object of this class
                line.X1 = x;
                line.Y1 = 0;
                line.X2 = x;
                line.Y2 = 400;
                line.Stroke = Brushes.Black;

                //setting the starting point for the line

                canvas.Children.Add(line);
                //canvas is the name for the canvas, it has a child line, and then you add the line you made above
            }

        }
    }

        
    }

