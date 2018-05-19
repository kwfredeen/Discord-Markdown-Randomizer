using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordMarkdownRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string userInput = inputTextBox.Text;
            string outputString = "";

            int randOut;
            int lastRand = 8; //rand will never output 8
            foreach(char c in userInput)
            {
                randOut = rand.Next(0,7);

                if(c == ' ')
                {
                    //Dont do anything with spaces, just concat and continue
                    outputString = outputString + c;
                    continue;
                }

                switch (randOut)
                {
                    case 0:
                        //normal text
                        outputString = outputString + c;
                        lastRand = randOut;
                        continue;
                    case 1:
                        //italics
                        if (lastRand == 1)
                        {
                            //already italics, inserts c into last italics block
                            outputString = outputString.Insert(outputString.LastIndexOf('*'), c.ToString());
                            lastRand = randOut;
                            continue;
                        }
                        outputString = outputString + "*" + c + "* ";
                        lastRand = randOut;
                        continue;
                    case 2:
                        //bold
                        if (lastRand == 2)
                        {
                            //already bold, inserts c into last bold block
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 1, c.ToString());
                            lastRand = randOut;
                            continue;
                        }
                        outputString = outputString + "**" + c + "** ";
                        lastRand = randOut;
                        continue;
                    case 3:
                        //underline
                        if (lastRand == 3)
                        {
                            //already underline, inserts c into last underline block
                            outputString = outputString.Insert(outputString.LastIndexOf('_') - 1, c.ToString());
                            lastRand = randOut;
                            continue;
                        }
                        outputString = outputString + "__" + c + "__ ";
                        lastRand = randOut;
                        continue;
                    case 4:
                        //bold italics
                        if (lastRand == 4)
                        {
                            //already bold italics, inserts c into last bold italics block
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 2, c.ToString());
                            lastRand = randOut;
                            continue;
                        }
                        outputString = outputString + "***" + c + "*** ";
                        lastRand = randOut;
                        continue;
                    case 5:
                        //underline bold
                        if (lastRand == 5)
                        {
                            //already underline bold, inserts c into last underline bold block
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 1, c.ToString());
                            lastRand = randOut;
                            continue;
                        }
                        outputString = outputString + "__**" + c + "**__ ";
                        lastRand = randOut;
                        continue;
                    case 6:
                        //underline italics
                        if (lastRand == 6)
                        {
                            //already underline italics, inserts c into last underline italics block
                            outputString = outputString.Insert(outputString.LastIndexOf('*'), c.ToString());
                            lastRand = randOut;
                            continue;
                        }
                        outputString = outputString + "__*" + c + "*__ ";
                        lastRand = randOut;
                        continue;
                    case 7:
                        //Underline bold italics
                        if (lastRand == 1)
                        {
                            //already underline bold italics, inserts c into last underline bold italics block
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 2, c.ToString());
                            lastRand = randOut;
                            continue;
                        }
                        outputString = outputString + "__***" + c + "***__ ";
                        lastRand = randOut;
                        continue;

                }
            }

            textBox1.Text = outputString;
        }
    }
}
