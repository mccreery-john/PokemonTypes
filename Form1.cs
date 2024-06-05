using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonTypes
{
    public partial class MainWindow : Form
    {
        string[] currentTypes = new string[2];
        double[,] typeValues =
            {
                { 1, 2, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },                               //Normal
                { 1, 1, 2, 1, 1, 0.5, 0.5, 1, 1, 1, 1, 1, 1, 2, 1, 1, 0.5, 1 },                         //Fighting
                {1, 0.5, 1, 1, 0, 2, 0.5, 1, 1, 1, 1, 0.5, 2, 1, 2, 1, 1, 1},                           //Flying
                {1, 0.5, 1, 0.5, 2, 1, 0.5, 1, 1, 1, 1, 0.5, 1, 2, 1, 1, 1, 0.5 },                      //Poison
                {1, 1, 1, 0.5, 1, 0.5, 1, 1, 1, 1, 2, 2, 0, 1, 2, 1, 1, 1},                             //Ground
                {0.5, 2, 0.5, 0.5, 2, 1, 1, 1, 2, 0.5, 2, 2, 1, 1, 1, 1, 1, 1, },                       //Rock
                {1, 0.5, 2, 1, 0.5, 2, 1, 1, 1, 2, 1, 0.5, 1, 1, 1, 1, 1, 1 },                          //Bug 
                {0, 0, 1, 0.5, 1, 1, 0.5, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1 },                            //Ghost
                {0.5, 2, 0.5, 0, 2, 0.5, 0.5, 1, 0.5, 2, 1, 0.5, 1, 0.5, 0.5, 0.5, 1, 0.5 },            //Steel
                {1, 1, 1, 1, 2, 2, 0.5, 1, 0.5, 0.5, 2, 0.5, 1, 1, 0.5, 1, 1, 0.5 },                    //Fire
                {1, 1, 1, 1, 1, 1, 1, 1, 0.5, 0.5, 0.5, 2, 2, 1, 0.5, 1, 1, 1 },                        //Water
                {1, 1, 2, 2, 0.5, 1, 2, 1, 1, 2, 0.5, 0.5, 0.5, 1, 2, 1, 1, 1 },                        //Grass
                {1, 1, 0.5, 1, 2, 1, 1, 1, 0.5, 1, 1, 1, 0.5, 1, 1, 1, 1, 1 },                          //Electric
                {1, 0.5, 1, 1, 1, 1, 2, 2, 1, 1, 1, 1, 1, 0.5, 1, 1, 2, 1 },                            //Psychic
                {1, 2, 1, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 1, 0.5, 1, 1, 1 },                              //Ice
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 0.5, 0.5, 0.5, 0.5, 1, 2, 2, 1, 2 },                        //Dragon
                {1, 2, 1, 1, 1, 1, 2, 0.5, 1, 1, 1, 1, 1, 0, 1, 1, 0.5, 2 },                            //Dark
                {1, 0.5, 1, 2, 1, 1, 0.5, 1, 2, 1, 1, 1, 1, 1, 1, 0, 0.5, 1}                            //Fairy
            };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void refreshTypes()
        {
            
            fourX.Items.Clear();
            twoX.Items.Clear();
            oneX.Items.Clear();
            halfX.Items.Clear();
            fourthX.Items.Clear();
            zeroX.Items.Clear();

            //Start types' ListViewItems
            ListViewItem normalItem = new ListViewItem();
            normalItem.BackColor = normalButton.BackColor;
            normalItem.ForeColor = normalButton.ForeColor;
            normalItem.Text = normalButton.Text;
            ListViewItem fightItem = new ListViewItem();
            fightItem.BackColor = fightingButton.BackColor;
            fightItem.ForeColor = fightingButton.ForeColor;
            fightItem.Text = fightingButton.Text;
            
                    //FIX ME

            ListViewItem darkItem = new ListViewItem();
            darkItem.BackColor = darkButton.BackColor;
            darkItem.ForeColor = darkButton.ForeColor;
            darkItem.Text = darkButton.Text;
            ListViewItem fairyItem = new ListViewItem();
            fairyItem.BackColor = fairyButton.BackColor;
            fairyItem.ForeColor = fairyButton.ForeColor;
            fairyItem.Text = fairyButton.Text;
            //End types' ListViewItems



            type1.Text = currentTypes[0];   //FIX ME  ---- Put color with the types
            type2.Text = currentTypes[1];



            if (currentTypes != null)
            {
                //FIX ME


                for (int i = 0; i < 18; i++)
                {
                    double currentValue = 1.0;
                    for (int j = 0; j < currentTypes.Length - 1; j++)
                    {

                        switch (currentTypes[j])
                        {
                            case "Normal":
                                typeValues[0, i] *= currentValue;
                                break;

                                //FIX ME

                            default:
                                currentValue *= 1;
                                break;

                        }
                    }
                }
            }


        }




        //Button Clicks ************************************************************************


        private void clearButton_Click(object sender, EventArgs e)
        {
            currentTypes[0] = null;
            currentTypes[1] = null;
            refreshTypes();
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            if (currentTypes[0] == null)
            {
                currentTypes[0] = "Normal";
                refreshTypes();

            }else if (currentTypes[1] == null)
            {
                currentTypes[1] = "Normal";
                refreshTypes();
            }


        }


        //End Button Clicks ************************************************************************
    }
}
