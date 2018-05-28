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
            int lastRand = 16; //rand will never output 16
            foreach(char c in userInput)
            {
                randOut = rand.Next(0,15);

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
                        if (lastRand == 7)
                        {
                            //already underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 2, c.ToString());
                            lastRand = randOut;
                            continue;
                        }
                        outputString = outputString + "__***" + c + "***__ ";
                        lastRand = randOut;
                        continue;

                    case 8:
                        //strikethrough
                        if (lastRand == 8)
                        {
                            //already underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('~') - 1, c.ToString());
                            lastRand = randOut;
                            continue;
                        }

                        outputString = outputString + "~~" + c + "~~ ";
                        lastRand = randOut;
                        continue;

                    case 9:
                        //strikethrough italics
                        if (lastRand == 9)
                        {
                            //already underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('*'), c.ToString());
                            lastRand = randOut;
                            continue;
                        }

                        outputString = outputString + "~~*" + c + "*~~ ";
                        lastRand = randOut;
                        continue;

                    case 10:
                        //strikethrough bold
                        if (lastRand == 10)
                        {
                            //already underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 1, c.ToString());
                            lastRand = randOut;
                            continue;
                        }

                        outputString = outputString + "~~**" + c + "**~~ ";
                        lastRand = randOut;
                        continue;

                    case 11:
                        //strikethrough underline
                        if (lastRand == 11)
                        {
                            //already underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('~') - 1, c.ToString());
                            lastRand = randOut;
                            continue;
                        }

                        outputString = outputString + "__~~" + c + "~~__ ";
                        lastRand = randOut;
                        continue;

                    case 12:
                        //strikethrough bold italic
                        if (lastRand == 12)
                        {
                            //already underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 2, c.ToString());
                            lastRand = randOut;
                            continue;
                        }

                        outputString = outputString + "~~***" + c + "***~~ ";
                        lastRand = randOut;
                        continue;

                    case 13:
                        //strikethrough underline italic
                        if (lastRand == 13)
                        {
                            //already underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('*'), c.ToString());
                            lastRand = randOut;
                            continue;
                        }

                        outputString = outputString + "__~~*" + c + "*~~__ ";
                        lastRand = randOut;
                        continue;

                    case 14:
                        //strikethrough underline bold
                        if (lastRand == 14)
                        {
                            //already underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 1, c.ToString());
                            lastRand = randOut;
                            continue;
                        }

                        outputString = outputString + "__~~**" + c + "**~~__ ";
                        lastRand = randOut;
                        continue;

                    case 15:
                        //strikethough underline bold italics
                        //maximum formatting
                        if (lastRand == 15)
                        {
                            //already strikethrough underline bold italics, inserts c into last block of same format
                            outputString = outputString.Insert(outputString.LastIndexOf('*') - 2, c.ToString());
                            lastRand = randOut;
                            continue;
                        }

                        outputString = outputString + "__~~***" + c + "***~~__ ";
                        lastRand = randOut;
                        continue;
                }
            }

            textBox1.Text = outputString;
        }
    }
}
