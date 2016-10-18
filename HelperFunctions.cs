using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectTrojan
{
    partial class Calculator
    {
        Button number0;
        Button number1;
        Button number2;
        Button number3;
        Button number4;
        Button number5;
        Button number6;
        Button number7;
        Button number8;
        Button number9;
        Button addition;
        Button substraction;
        Button multiplication;
        Button division;
        Button equals;
        Button comma;
        Button del;
        Button clear;
        Button shift;
        Button square;
        Button sqrt;
        Button factorial;
        Button ln;
        Button sinus;
        Button sinusHyp;
        Button cosinus;
        Button cosinusHyp;
        Button tangens;
        Button unitOfAngle;
        Button outputPrecisionButton;
        Button memoryButton;
        Button memoryAddSubstButton;
        Button pi;
        Button e;

        void InitializeCalculatorAndUIComponents ()
        {
            SetWindowProperties (390, 500);
            CreateUIComponents ();
            SetUIButtonsTexts ();
            SetUIButtonsSizes ();
            AddControlsToUIComponents ();
            CreateButtonsEventHandlers ();
            SetUIComponentsColors ();
            SetIOBoxProperties ();
            SetUIComponentsPositions ();
        }

        void SetWindowProperties (int width, int height)
        {
            Size = new Size (width, height);
            Text = "Project Trojan";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        void CreateUIComponents ()
        {
            number0 = new Button ();
            number1 = new Button ();
            number2 = new Button ();
            number3 = new Button ();
            number4 = new Button ();
            number5 = new Button ();
            number6 = new Button ();
            number7 = new Button ();
            number8 = new Button ();
            number9 = new Button ();
            addition = new Button ();
            substraction = new Button ();
            multiplication = new Button ();
            division = new Button ();
            equals = new Button ();
            comma = new Button ();
            del = new Button ();
            clear = new Button ();
            shift = new Button ();
            square = new Button ();
            sqrt = new Button ();
            factorial = new Button ();
            ln = new Button ();
            sinus = new Button ();
            sinusHyp = new Button ();
            cosinus = new Button ();
            cosinusHyp = new Button ();
            tangens = new Button ();
            unitOfAngle = new Button ();
            outputPrecisionButton = new Button ();
            memoryButton = new Button ();
            memoryAddSubstButton = new Button ();
            pi = new Button ();
            e = new Button ();

            inputOutputBox = new TextBox ();
        }

        void SetUIButtonsTexts ()
        {
            number0.Text = "0";
            number1.Text = "1";
            number2.Text = "2";
            number3.Text = "3";
            number4.Text = "4";
            number5.Text = "5";
            number6.Text = "6";
            number7.Text = "7";
            number8.Text = "8";
            number9.Text = "9";
            addition.Text = "+";
            substraction.Text = "-";
            multiplication.Text = "*";
            division.Text = "/";
            equals.Text = "=";
            comma.Text = ",";
            del.Text = "Del";
            clear.Text = "AC";
            shift.Text = "Shift";
            square.Text = "x²";
            sqrt.Text = "√¯x";
            factorial.Text = "x!";
            ln.Text = "ln x";
            sinus.Text = "sin";
            sinusHyp.Text = "sinH";
            cosinus.Text = "cos";
            cosinusHyp.Text = "cosH";
            tangens.Text = "tan";
            unitOfAngle.Text = "Rad";
            outputPrecisionButton.Text = "4 Dgts";
            memoryButton.Text = "M";
            memoryAddSubstButton.Text = "M+";
            pi.Text = "Pi";
            e.Text = "e";
        }

        void SetUIButtonsSizes ()
        {
            SetButtonSize (number0, 50, 50);
            SetButtonSize (number1, 50, 50);
            SetButtonSize (number2, 50, 50);
            SetButtonSize (number3, 50, 50);
            SetButtonSize (number4, 50, 50);
            SetButtonSize (number5, 50, 50);
            SetButtonSize (number6, 50, 50);
            SetButtonSize (number7, 50, 50);
            SetButtonSize (number8, 50, 50);
            SetButtonSize (number9, 50, 50);
            SetButtonSize (addition, 50, 50);
            SetButtonSize (substraction, 50, 50);
            SetButtonSize (multiplication, 50, 50);
            SetButtonSize (division, 50, 50);
            SetButtonSize (equals, 50, 50);
            SetButtonSize (comma, 50, 50);
            SetButtonSize (del, 50, 50);
            SetButtonSize (clear, 50, 50);
            SetButtonSize (shift, 50, 50);
            SetButtonSize (square, 50, 50);
            SetButtonSize (sqrt, 50, 50);
            SetButtonSize (factorial, 50, 50);
            SetButtonSize (ln, 50, 50);
            SetButtonSize (sinus, 50, 50);
            SetButtonSize (sinusHyp, 50, 50);
            SetButtonSize (cosinus, 50, 50);
            SetButtonSize (cosinusHyp, 50, 50);
            SetButtonSize (tangens, 50, 50);
            SetButtonSize (unitOfAngle, 50, 50);
            SetButtonSize (outputPrecisionButton, 50, 50);
            SetButtonSize (memoryButton, 50, 50);
            SetButtonSize (memoryAddSubstButton, 50, 50);
            SetButtonSize (pi, 50, 50);
            SetButtonSize (e, 50, 50);
        }

        void SetButtonSize (Button button, int width, int height)
        {
            button.Width = width;
            button.Height = height;
        }

        void AddControlsToUIComponents ()
        {
            Controls.Add (number0);
            Controls.Add (number1);
            Controls.Add (number2);
            Controls.Add (number3);
            Controls.Add (number4);
            Controls.Add (number5);
            Controls.Add (number6);
            Controls.Add (number7);
            Controls.Add (number8);
            Controls.Add (number9);
            Controls.Add (addition);
            Controls.Add (substraction);
            Controls.Add (multiplication);
            Controls.Add (division);
            Controls.Add (equals);
            Controls.Add (comma);
            Controls.Add (del);
            Controls.Add (clear);
            Controls.Add (shift);
            Controls.Add (square);
            Controls.Add (sqrt);
            Controls.Add (factorial);
            Controls.Add (ln);
            Controls.Add (sinus);
            Controls.Add (sinusHyp);
            Controls.Add (cosinus);
            Controls.Add (cosinusHyp);
            Controls.Add (tangens);
            Controls.Add (unitOfAngle);
            Controls.Add (outputPrecisionButton);
            Controls.Add (memoryButton);
            Controls.Add (memoryAddSubstButton);
            Controls.Add (pi);
            Controls.Add (e);

            Controls.Add (inputOutputBox);
        }

        void CreateButtonsEventHandlers ()
        {
            number0.Click += Number0ButtonClick;
            number1.Click += Number1ButtonClick;
            number2.Click += Number2ButtonClick;
            number3.Click += Number3ButtonClick;
            number4.Click += Number4ButtonClick;
            number5.Click += Number5ButtonClick;
            number6.Click += Number6ButtonClick;
            number7.Click += Number7ButtonClick;
            number8.Click += Number8ButtonClick;
            number9.Click += Number9ButtonClick;
            addition.Click += AddButtonClick;
            substraction.Click += SubstButtonClick;
            multiplication.Click += MultButtonClick;
            division.Click += DivButtonClick;
            equals.Click += EqualsButtonClick;
            comma.Click += CommaButtonClick;
            del.Click += DelButtonClick;
            clear.Click += ClearButtonClick;
            shift.Click += ShiftButtonClick;
            square.Click += SquareButtonClick;
            sqrt.Click += SqrtButtonClick;
            factorial.Click += FactorialButtonClick;
            ln.Click += LnButtonClick;
            sinus.Click += SinusButtonClick;
            sinusHyp.Click += SinusHypButtonClick;
            cosinus.Click += CosinusButtonClick;
            cosinusHyp.Click += CosinusHypButtonClick;
            tangens.Click += TangensButtonClick;
            unitOfAngle.Click += UnitOfAngleButtonClick;
            outputPrecisionButton.Click += OutputPrecisionButtonClick;
            memoryButton.Click += MemoryButtonClick;
            memoryAddSubstButton.Click += MemoryAddButtonClick;
            pi.Click += PiButtonClick;
            e.Click += EButtonClick;
        }

        void SetUIComponentsColors ()
        {
            number0.BackColor = Color.LightGray;
            number1.BackColor = Color.LightGray;
            number2.BackColor = Color.LightGray;
            number3.BackColor = Color.LightGray;
            number4.BackColor = Color.LightGray;
            number5.BackColor = Color.LightGray;
            number6.BackColor = Color.LightGray;
            number7.BackColor = Color.LightGray;
            number8.BackColor = Color.LightGray;
            number9.BackColor = Color.LightGray;
            addition.BackColor = Color.Orange;
            substraction.BackColor = Color.Orange;
            multiplication.BackColor = Color.Orange;
            division.BackColor = Color.Orange;
            equals.BackColor = Color.Orange;
            del.BackColor = Color.Red;
            clear.BackColor = Color.Red;
            square.BackColor = Color.Gray;
            sqrt.BackColor = Color.Gray;
            factorial.BackColor = Color.Gray;
            ln.BackColor = Color.Gray;
            sinus.BackColor = Color.Gray;
            sinusHyp.BackColor = Color.Gray;
            cosinus.BackColor = Color.Gray;
            cosinusHyp.BackColor = Color.Gray;
            tangens.BackColor = Color.Gray;
            unitOfAngle.BackColor = Color.Gray;
            memoryButton.BackColor = Color.Gray;
            memoryAddSubstButton.BackColor = Color.Gray;
            pi.BackColor = Color.Gray;
            e.BackColor = Color.Gray;

            inputOutputBox.ForeColor = Color.WhiteSmoke;
            inputOutputBox.BackColor = Color.Black;
        }

        void SetIOBoxProperties ()
        {
            inputOutputBox.Width = 320;
            inputOutputBox.Font = new Font ("ArialBlack", 30, FontStyle.Bold);
            inputOutputBox.ReadOnly = true;
            inputOutputBox.TextAlign = HorizontalAlignment.Right;
            inputOutputBox.Text = "0";
        }

        void SetUIComponentsPositions ()
        {
            inputOutputBox.Location = new Point (5, 5);

            sinus.Location = new Point (inputOutputBox.Left, inputOutputBox.Top + inputOutputBox.Height + 10);
            cosinus.Location = new Point (sinus.Left + sinus.Width, sinus.Top);
            tangens.Location = new Point (cosinus.Left + cosinus.Width, cosinus.Top);
            unitOfAngle.Location = new Point (tangens.Left + tangens.Width + 10 + ln.Width + e.Width + 10, tangens.Top);

            sinusHyp.Location = new Point (sinus.Left, sinus.Top + sinus.Height);
            cosinusHyp.Location = new Point (cosinus.Left, cosinus.Top + cosinus.Height);
            pi.Location = new Point (tangens.Left, tangens.Top + tangens.Height);
            shift.Location = new Point (pi.Left + pi.Width + 10 + ln.Width + e.Width + 10, pi.Top);

            square.Location = new Point (sinusHyp.Left, sinusHyp.Top + sinusHyp.Height + 10);
            sqrt.Location = new Point (square.Left + square.Width, square.Top);
            factorial.Location = new Point (sqrt.Left + sqrt.Width, sqrt.Top);
            ln.Location = new Point (factorial.Left + factorial.Width + 10, factorial.Top);
            e.Location = new Point (ln.Left + ln.Width, ln.Top);
            outputPrecisionButton.Location = new Point (e.Left + e.Width + 10, e.Top);

            number7.Location = new Point (square.Left, square.Top + square.Height + 20);
            number8.Location = new Point (number7.Left + number8.Width, number7.Top);
            number9.Location = new Point (number8.Left + number9.Width, number7.Top);
            del.Location = new Point (number9.Left + number9.Width + 10, number9.Top);
            clear.Location = new Point (del.Left + del.Width, del.Top);

            number4.Location = new Point (number7.Left, number7.Top + number7.Height);
            number5.Location = new Point (number4.Left + number4.Width, number4.Top);
            number6.Location = new Point (number5.Left + number5.Width, number5.Top);
            multiplication.Location = new Point (number6.Left + number6.Width + 10, number6.Top);
            division.Location = new Point (multiplication.Left + multiplication.Width, multiplication.Top);

            number1.Location = new Point (number4.Left, number4.Top + number4.Height);
            number2.Location = new Point (number5.Left, number5.Top + number5.Height);
            number3.Location = new Point (number6.Left, number6.Top + number6.Height);
            addition.Location = new Point (number3.Left + number3.Width + 10, number3.Top);
            substraction.Location = new Point (addition.Left + addition.Width, addition.Top);

            number0.Location = new Point (number1.Left, number1.Top + number1.Height);
            comma.Location = new Point (number2.Left, number2.Top + number2.Height);
            memoryButton.Location = new Point (comma.Left + comma.Width, comma.Top);
            memoryAddSubstButton.Location = new Point (memoryButton.Left + memoryButton.Width + 10, memoryButton.Top);
            equals.Location = new Point (memoryAddSubstButton.Left + memoryAddSubstButton.Width, memoryAddSubstButton.Top);
        }

        void SetCurrentLanguage ()
        {
            systemLanguage =
                System.Globalization.CultureInfo.CurrentCulture.ToString ().Substring (0, 2);
        }

        void AddNumber (int number)
        {
            if (inputOutputBox.Text == "0" && number == 0)
                return;
            else
                if (newOperand || inputOutputBox.Text == "∞" || inputOutputBox.Text == "Error")
                    inputOutputBox.Text = number.ToString ();
                else
                    inputOutputBox.Text += number.ToString ();
            newOperand = false;
        }

        void AddComma ()
        {
            if (systemLanguage == "de" && !inputOutputBox.Text.Contains (","))
                inputOutputBox.Text += ",";
            else
                if (!inputOutputBox.Text.Contains ("."))
                    inputOutputBox.Text += ".";
        }

        void ResetIOToZero ()
        {
            inputOutputBox.Text = "0";
            newOperand = true;
        }

        void ErrorMessage ()
        {
            inputOutputBox.Text = "Error";
            operand1 = 0;
            newOperand = true;
        }

        bool InputContainsErrorOrInfinity ()
        {
            if (inputOutputBox.Text == "Error" || inputOutputBox.Text == "∞" || inputOutputBox.Text == "NaN")
                return true;
            else
                return false;
        }

        void PerformCurrentOperation ()
        {
            switch (currentOperation)
            {
            case "addition":
                operand1 = (operand1 + double.Parse (inputOutputBox.Text));
                break;
            case "substraction":
                operand1 = (operand1 - double.Parse (inputOutputBox.Text));
                break;
            case "multiplication":
                operand1 = (operand1 * double.Parse (inputOutputBox.Text));
                break;
            case "division":
                operand1 = (operand1 / double.Parse (inputOutputBox.Text));
                break;
            case "pow":
                operand1 = (Math.Pow (operand1, double.Parse (inputOutputBox.Text)));
                break;
            case "binominal":
                CalculateBinomialCoefficient (operand1, double.Parse (inputOutputBox.Text));
                break;
            case "none":
                operand1 = double.Parse (inputOutputBox.Text);
                return;
            }
            inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
        }

        void SetNewOperation (string newOperation)
        {
            newOperand = true;
            currentOperation = newOperation;
        }

        void ToggleShift ()
        {
            if (!alternativeFunctionsActive)
            {
                SetButtonEventHandlersToShiftCase ();
                SetButtonTextsToShiftCase ();
                alternativeFunctionsActive = true;
                shift.BackColor = Color.Red;
            }
            else
            {
                SetButtonEventHandlersToNonShiftCase ();
                SetButtonEventHandlersToNonShiftCase ();
                alternativeFunctionsActive = false;
                shift.BackColor = SystemColors.Control;
            }
        }

        void SetButtonEventHandlersToShiftCase ()
        {
            sinus.Click -= SinusButtonClick;
            sinus.Click += ArcSinusButtonClick;
            cosinus.Click -= CosinusButtonClick;
            cosinus.Click += ArcCosinusButtonClick;
            tangens.Click -= TangensButtonClick;
            tangens.Click += ArcTangensButtonClick;
            memoryButton.Click -= MemoryButtonClick;
            memoryButton.Click += MemoryClearButtonClick;
            memoryAddSubstButton.Click += MemoryAddButtonClick;
            memoryAddSubstButton.Click += MemorySubstractButtonClick;
            factorial.Click -= FactorialButtonClick;
            factorial.Click += ReciprocalButtonClick;
            square.Click -= SquareButtonClick;
            square.Click += ExponentButtonClick;
            division.Click -= DivButtonClick;
            division.Click += BinomialCoefficientButtonClick;
        }

        void SetButtonEventHandlersToNonShiftCase ()
        {
            sinus.Click += SinusButtonClick;
            sinus.Click -= ArcSinusButtonClick;
            cosinus.Click += CosinusButtonClick;
            cosinus.Click -= ArcCosinusButtonClick;
            tangens.Click += TangensButtonClick;
            tangens.Click -= ArcTangensButtonClick;
            memoryButton.Click += MemoryButtonClick;
            memoryButton.Click -= MemoryClearButtonClick;
            memoryAddSubstButton.Click += MemoryAddButtonClick;
            memoryAddSubstButton.Click -= MemorySubstractButtonClick;
            factorial.Click += FactorialButtonClick;
            factorial.Click -= ReciprocalButtonClick;
            square.Click += SquareButtonClick;
            square.Click -= ExponentButtonClick;
            division.Click += DivButtonClick;
            division.Click -= BinomialCoefficientButtonClick;
        }

        void SetButtonTextsToShiftCase ()
        {
            sinus.Text = "arcsin";
            cosinus.Text = "arccos";
            tangens.Text = "arctan";
            factorial.Text = "1/x";
            square.Text = "x^n";
            memoryButton.Text = "MC";
            memoryAddSubstButton.Text = "M-";
            division.Text = "nPr"; 
        }

        void SetButtonTextsToNonShiftCase ()
        {
            sinus.Text = "sin";
            cosinus.Text = "cos";
            tangens.Text = "tan";
            factorial.Text = "x!";
            square.Text = "x²";
            memoryButton.Text = "M";
            memoryAddSubstButton.Text = "M+";
            division.Text = " / ";
        }

        void SetButtonsToInitState ()
        {
            inputOutputBox.Text = "0";
            sinus.Text = "sin";
            cosinus.Text = "cos";
            tangens.Text = "tan";
            memoryButton.Text = "M";
            memoryAddSubstButton.Text = "M+";
            shift.BackColor = SystemColors.Control;
        }

        delegate double AngularFunction (double value);

        void CalculateAngularFunction (AngularFunction angularFunction, double boxValue)
        {
            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (angularFunction (boxValue));
                inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
            }
            else
            if (unitOfAngle.Text == "Grad")
            {
                var temp = boxValue;
                temp *= (Math.PI / 180);
                operand1 = angularFunction (temp);
                inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
            }
            else
                ErrorMessage ();
        }

        void CalculateArcAngularFunction (AngularFunction angularFunction, double boxValue)
        {
            if (unitOfAngle.Text == "Rad")
            {
                operand1 = (angularFunction (boxValue));
                inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
            }
            else
            if (unitOfAngle.Text == "Grad")
            {
                operand1 = angularFunction (boxValue) * 180 / Math.PI;
                inputOutputBox.Text = operand1.ToString (outputPrecision.GetCurrentPrecision ());
            }
            else
                ErrorMessage ();
        }

        void CalculateBinomialCoefficient (double n, double k)
        {
            double binom = 1;

            if (n < k && Math.Abs (n) < Math.Abs (k) && (n % 1) + (k % 1) < EPSILON && n > 0)
            {
                for (int i = 1; i <= n; i++)
                    binom = binom * (k - i + 1) / i;
                operand1 = binom;
            }
            else
                ErrorMessage ();
        }
    }
}