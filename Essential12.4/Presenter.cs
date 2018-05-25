using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential12._4
{
    class Presenter
    {
        MainWindow mainWindow;
        Model model;
        public Presenter(MainWindow main)
        {
            mainWindow = main;
            model = new Model();
            main.ButtonDigit0Click += () => main.CalculatedValue.Text =
            main.CalculatedValue.Text == "0" ? "0" : main.CalculatedValue.Text + "0";
            main.ButtonDigit1Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "1" : main.CalculatedValue.Text + "1";
            main.ButtonDigit2Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "2" : main.CalculatedValue.Text + "2";
            main.ButtonDigit3Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "3" : main.CalculatedValue.Text + "3";
            main.ButtonDigit4Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "4" : main.CalculatedValue.Text + "4";
            main.ButtonDigit5Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "5" : main.CalculatedValue.Text + "5";
            main.ButtonDigit6Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "6" : main.CalculatedValue.Text + "6";
            main.ButtonDigit7Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "7" : main.CalculatedValue.Text + "7";
            main.ButtonDigit8Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "8" : main.CalculatedValue.Text + "8";
            main.ButtonDigit9Click += () => main.CalculatedValue.Text =
main.CalculatedValue.Text == "0" ? "9" : main.CalculatedValue.Text + "9";
            main.ButtonPointClick += () => main.CalculatedValue.Text =
             main.CalculatedValue.Text.Contains(",") ? main.CalculatedValue.Text : main.CalculatedValue.Text + ",";
            main.ButtonClearClick += () => main.CalculatedValue.Text = "0";
            main.ButtonPlusClick += () =>
            {
                double a;
                double.TryParse(main.CalculatedValue.Text, out a);
                model.A = a;
                main.CalculatedValue.Text = "0";
                model.currentAction = (int)CalcActions.plus;
            };
            main.ButtonMinusClick += () =>
            {
                double a;
                double.TryParse(main.CalculatedValue.Text, out a);
                model.A = a;
                main.CalculatedValue.Text = "0";
                model.currentAction = (int)CalcActions.minus;
            };
            main.ButtonDivideClick += () =>
            {
                double a;
                double.TryParse(main.CalculatedValue.Text, out a);
                model.A = a;
                main.CalculatedValue.Text = "0";
                model.currentAction = (int)CalcActions.divide;
            };
            main.ButtonMultiplyClick += () =>
            {
                double a;
                double.TryParse(main.CalculatedValue.Text, out a);
                model.A = a;
                main.CalculatedValue.Text = "0";
                model.currentAction = (int)CalcActions.multiply;
            };
            main.ButtonEqualsClick += () =>
            {
                double b;
                double.TryParse(main.CalculatedValue.Text, out b);
                switch (model.currentAction)
                {
                    case (int)CalcActions.plus:
                        main.CalculatedValue.Text = model.Plus(model.A, b).ToString();
                        model.A = model.Plus(model.A, b)??0;
                        break;
                    case (int)CalcActions.minus:
                        main.CalculatedValue.Text = model.Minus(model.A, b).ToString();
                        model.A = model.Minus(model.A, b) ?? 0;
                        break;
                    case (int)CalcActions.divide:
                        main.CalculatedValue.Text = model.Divide(model.A, b)==null?"NaN": model.Divide(model.A, b).ToString();
                        model.A = model.Divide(model.A, b) ?? 0;
                        break;
                    case (int)CalcActions.multiply:
                        main.CalculatedValue.Text = model.Multiply(model.A, b).ToString();
                        model.A = model.Multiply(model.A, b);                        
                        break;
                    default:
                        break;
                }
                model.currentAction = (int)CalcActions.none;
            };
        }
    }
}
