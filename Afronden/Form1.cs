namespace Afronden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 100;
        }
        /*==========Analyse==========
1.Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
            Getal1 - double
            Getal2 - double

2.Bewerking: Welke ingebouwde methodes heb je nodig om de verschillende afrondingen te bekomen...
            Math.Round
            Math.Truncate
            Math.Ceiling
            Math.Floor

3.Uitvoer: Welke resultaten zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
            Getallen in de min en plus maar geen komma getallen - double

==========Testdata=========

4.Testdata: Verzin en noteer testgegevens, en bereken zelf de juiste oplossing. Zo weet je of je oefening klopt.
        als je -3,42 en 7,27 invoerd krijg je -24,8634, -25, -24, -24 en -25 bij normale value en 24,8634, 25, 24, 25 en 24 bij absolute value.

===========================*/
        private void button1_Click(object sender, EventArgs e)
        {
            double getal1 = Convert.ToDouble(Getal1TextBox.Text);
            double getal2 = Convert.ToDouble(Getal2TextBox.Text);
            //Normal
            double normalValue = getal1 * getal2;
            double absoluteValue = Math.Abs(normalValue);
            NormalValueTextBox.Text = Convert.ToString(normalValue);
            AbsoluteValueTextBox.Text = Convert.ToString(absoluteValue);
            //Round
            double normalValueRound = Math.Round(normalValue);
            double absoluteValueRound = Math.Round(absoluteValue);
            NormalValueRoundTextBox.Text = Convert.ToString(normalValueRound);
            AbsoluteValueRoundTextBox.Text = Convert.ToString(absoluteValueRound);
            //Truncate
            double normalValueTruncate = Math.Truncate(normalValue);
            double absoluteValueTruncate = Math.Truncate(absoluteValue);
            NormalValueTruncateTextBox.Text = Convert.ToString(normalValueTruncate);
            AbsoluteValueTruncateTextBox.Text = Convert.ToString(absoluteValueTruncate);
            //Ceiling
            double normalValueCeiling = Math.Ceiling(normalValue);
            double absoluteValueCeiling = Math.Ceiling(absoluteValue);
            NormalValueCeilingTextBox.Text = Convert.ToString(normalValueCeiling);
            AbsoluteValueCeilingTextBox.Text = Convert.ToString(absoluteValueCeiling);
            //Floor
            double normalValueFloor = Math.Floor(normalValue);
            double absoluteValueFloor = Math.Floor(absoluteValue);
            NormalValueFloorTextBox.Text = Convert.ToString(normalValueFloor);
            AbsoluteValueFloorTextBox.Text = Convert.ToString(absoluteValueFloor);
        }
    }
}
