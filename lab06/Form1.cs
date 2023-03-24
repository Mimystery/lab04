namespace lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            int maxLen = 1 + Math.Max(firstNumberTextBox.Text.Length, secondNumberTextBox.TextLength);
            int[] num1 = new int[maxLen];

            int[] num2 = new int[maxLen];
            int[]sum= new int[maxLen];
            int[] extra= new int[maxLen];

            int numberIdx, textIdx;

            numberIdx = maxLen - 1;
            textIdx = firstNumberTextBox.Text.Length - 1;

            while(textIdx >= 0)
            {
                num1[numberIdx] = (firstNumberTextBox.Text[textIdx] - '0');
                textIdx--;
                numberIdx--;
            }
            numberIdx = maxLen - 1;
            textIdx = secondNumberTextBox.TextLength - 1;
            while(textIdx >= 0)
            {
                num2[numberIdx] = (secondNumberTextBox.Text[textIdx] - '0');
                textIdx--;
                numberIdx--;
            }
            for(numberIdx = maxLen - 1; numberIdx > 0; numberIdx--)
            {
                sum[numberIdx] = (num1[numberIdx] + num2[numberIdx] + extra[numberIdx]) % 10;
                    extra[numberIdx - 1] = (num1[numberIdx] + num2[numberIdx] + extra[numberIdx])/10   ;
            }
            sum[0] = extra[0];

            bool isNumber = false;
            foreach(int digit in sum)
            {
                if (digit > 0)
                {
                    isNumber = true;
                    sumNumberTextBox.Text += digit;
                }
                else
                {
                    if(isNumber)
                        sumNumberTextBox.Text += digit;
                }
            }
        }
    }
}