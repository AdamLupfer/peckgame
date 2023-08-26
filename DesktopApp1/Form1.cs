using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        StreamReader strReader = null;

        
        int mistakecount = 0;
        int counter = 0;
        string[] displayword;
        string newdisplayword;
        string newlabel = "";
        string strLine = "";
        string[] strWordlist = new string[0];
        int score = 0;

        
        //Start game function
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                FileStream file = new FileStream(Application.StartupPath + @"\Populated_wordlist.txt", FileMode.OpenOrCreate, FileAccess.Read);

                strReader = new StreamReader(file);
                int readlinecount = 0;

                while(strReader.Peek() != -1)
                {
                    Array.Resize(ref strWordlist, strWordlist.Length + 1);
                    strWordlist[readlinecount] = strReader.ReadLine();
                    readlinecount++;
                }
            }
            catch (Exception E)
            {
                //MessageBox stuff
            }
            finally
            {
                strReader.Close();
            }

            scoreLabel.Visible = true;
            scoreLabel.Text = "Score: " + score.ToString();
            Startbutn.Visible = false;

            Wordlbl.Visible = true;
            Wordlbl.Text = strWordlist[0];

            Countlbl.Visible = true;
            mistakelbl.Visible = true;

            textBox1.Visible = true;
            textBox1.Focus();

            newdisplayword = Wordlbl.Text;
            
            displayword = Wordlbl.Text.Select(x => x.ToString()).ToArray();

        }
        
        //Text change function
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            if (textBox1.Text == newdisplayword)
            {
                
                if (textBox1.Text == strWordlist[counter])
                {
                    if (counter == (strWordlist.Length - 1))
                    {
                        //Win conditions
                        MessageBox.Show("You won!", "Winner! Youre final Score: " + score.ToString(), MessageBoxButtons.OK);

                        Startbutn.Visible = true;

                        Wordlbl.Text = strWordlist[0];
                        
                        //resetting game screen
                        counter = 0;
                        newlabel = "";

                        Wordlbl.Visible = false;

                        Countlbl.Text = "Words Pecked: ";
                        Countlbl.Visible = false;
                        mistakelbl.Text = "Mistakes: ";
                        mistakelbl.Visible = false;

                        textBox1.Visible = false;
                        textBox1.Clear();
                        scoreLabel.Visible = false;
                        scoreLabel.Text = "Score: ";

                        newdisplayword = Wordlbl.Text;
                        
                        displayword = Wordlbl.Text.Select(x => x.ToString()).ToArray();
                        
                    }
                    else
                    {
                        // Valid input conditions
                        Wordlbl.Text = strWordlist[(counter + 1)];
                        counter++;
                        textBox1.Clear();
                        textBox1.Focus();
                        Countlbl.Text = "Words Pecked: " + counter.ToString();
                        newdisplayword = Wordlbl.Text;
                        newlabel = "";

                        //score calculator
                        score += 25;
                        scoreLabel.Text = "Score: " + score.ToString();

                        displayword = Wordlbl.Text.Select(x => x.ToString()).ToArray();
                    }
                }

            }
            
        }

        //Void incorrect Keypress function
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            var entrytext = textBox1.Text.Select(x => x.ToString()).ToArray();

            int entryindex = (entrytext.Length - 1);
            
                {
                    if (entrytext.Length <= displayword.Length)
                    {

                        if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), displayword[(entrytext.Length)]))
                        {
                            // Stop the character from being entered into the control since it is illegal.
                            e.Handled = false;

                            displayword[(entrytext.Length)] = "_";
                        
                            for (int n = 0; n < newdisplayword.Length; n++)
                            {
                                newlabel += displayword[n].ToString();
                            }

                        Wordlbl.Text = newlabel;

                        newlabel = "";

                        }
                        else
                        {
                            e.Handled = true;
                            mistakecount++;
                            mistakelbl.Text = "Mistakes: " + mistakecount;
                            if (score > 0)
                            {
                                score -= 1;
                                scoreLabel.Text = "Score: " + score.ToString();
                            }
                            
                        }
                        
                    }
                }

        }
    }
}
