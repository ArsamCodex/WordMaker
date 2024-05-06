using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace WordMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string names;
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            names = $"{textBox1.Text} {textBox2.Text} {textBox3.Text} {textBox4.Text} {textBox5.Text} {textBox6.Text} {textBox7.Text} {textBox8.Text} {textBox9.Text} {textBox10.Text} {textBox11.Text} {textBox12.Text}";
            List<string> differentOrders = GenerateDifferentOrders(names, 1000);
            for (int i = 0; i < 10; i++)
            {
                richTextBox1.AppendText(differentOrders[i]);

            }
            //   richTextBox1.AppendText(ShuffleWords(names));

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public static List<string> GenerateDifferentOrders(string input, int numberOfOrders)
        {
            List<string> orders = new List<string>();

            for (int i = 0; i < numberOfOrders; i++)
            {
                // Split the input string into an array of words
                string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Shuffle the array
                Random rng = new Random();
                words = words.OrderBy(w => rng.Next()).ToArray();

                // Insert comma after every 12th word
                for (int j = 11; j < words.Length; j += 12)
                {
                    if (j < words.Length)
                    {
                        words[j] += ",";
                    }
                }

                // Join the shuffled words back into a string
                string shuffledString = string.Join(" ", words);

                // Add the shuffled string to the list
                orders.Add(shuffledString);
            }

            return orders;
        }


    }



}