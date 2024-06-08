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
        int[] currentTypes = new int[2];
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
        //Referenece of these values is the table found on https://bulbapedia.bulbagarden.net/wiki/Type under the type chart sub-section 
   
        ListViewItem[] itemsArray = new ListViewItem[18];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentTypes[0] = -1;
            currentTypes[1] = -1;
            Button[] buttonArray = { normalButton, fightingButton, flyingButton, poisonButton, groundButton, rockButton, bugButton, ghostButton, steelButton, fireButton, waterButton, grassButton, electricButton, psychicButton, iceButton, dragonButton, darkButton, fairyButton };

            for (int index = 0; index < 18; index++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = buttonArray[index].Text;
                item.ForeColor = buttonArray[index].ForeColor;
                item.BackColor = buttonArray[index].BackColor;
                itemsArray[index] = item;
            }
           
        }

        //Helper Functions                      **********************************************
        private void refreshTypes()
        {
            
            fourX.Items.Clear();
            twoX.Items.Clear();
            oneX.Items.Clear();
            halfX.Items.Clear();
            fourthX.Items.Clear();
            zeroX.Items.Clear();



            if (currentTypes[0] != -1)
            {

                for (int i = 0; i < 18; i++)
                {
                    int error = 0;
                    double currentValue = 1.0;
                    for (int j = 0; j < currentTypes.Length; j++)
                    {

                        if (currentTypes[j] != -1)
                        {
                            currentValue = typeValues[currentTypes[j], i] * currentValue;
                        }
                    }

                    switch (currentValue)   //Put type into correct listView
                    {
                        case 1.0:
                            oneX.Items.Add(itemsArray[i]);
                            break;
                        case 2.0:
                            twoX.Items.Add(itemsArray[i]);
                            break;
                        case 4.0:
                            fourX.Items.Add(itemsArray[i]);
                            break;
                        case 0:
                            zeroX.Items.Add(itemsArray[i]);
                            break;
                        case 0.5:
                            halfX.Items.Add(itemsArray[i]);
                            break;
                        case 0.25:
                            fourthX.Items.Add(itemsArray[i]);
                            break;
                        default:
                            //Error
                            MessageBox.Show("Error: type matchup not found", "Error: Weakness", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearTypes();
                            error = 1;
                            break;

                    }

                    if (error != 0)
                    {
                        break;
                    }

                }
            }


        }

        private void typeTextColor(Button button, Label lab)
        {
            lab.Text = button.Text;
            lab.Text = button.Text;
            lab.BackColor = button.BackColor;
            lab.ForeColor = button.ForeColor;
            refreshTypes();
        } 

        private void clearTypes()
        {
            currentTypes[0] = -1;
            currentTypes[1] = -1;
            type1.Text = string.Empty;
            type2.Text = string.Empty;
            refreshTypes();
        }
        //End Helper Functions                  ***********************************************



        //Button Clicks ************************************************************************
        private void typeButton_Click(object sender, EventArgs e)
        {
            int typeID = -1;
            Button button = sender as Button;

            switch (button.Text)
            {
                case "Normal":
                    typeID = 0;
                    break;
                case "Fighting":
                    typeID = 1;
                    break;
                case "Flying":
                    typeID = 2;
                    break;
                case "Poison":
                    typeID = 3;
                    break;
                case "Ground":
                    typeID = 4;
                    break;
                case "Rock":
                    typeID = 5;
                    break;
                case "Bug":
                    typeID = 6;
                    break;
                case "Ghost":
                    typeID = 7;
                    break;
                case "Steel":
                    typeID = 8;
                    break;
                case "Fire":
                    typeID = 9;
                    break;
                case "Water":
                    typeID = 10;
                    break;
                case "Grass":
                    typeID = 11;
                    break;
                case "Electric":
                    typeID = 12;
                    break;
                case "Psychic":
                    typeID = 13;
                    break;
                case "Ice":
                    typeID = 14;
                    break;
                case "Dragon":
                    typeID = 15;
                    break;
                case "Dark":
                    typeID = 16;
                    break;
                case "Fairy":
                    typeID = 17;
                    break;

                default :
                    //  Add error message given later
                    break;
            }
            if (typeID == -1) //Type not found error
            {
                MessageBox.Show("Error: type not found", "Error: Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (currentTypes[0] == -1)
            {
                currentTypes[0] = typeID;
                typeTextColor(button, type1);

            }
            else if (currentTypes[1] == -1)
            {
                if (button.Text != type1.Text)      //disallow double of the same type
                {
                    currentTypes[1] = typeID;
                    typeTextColor(button, type2);
                }
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearTypes();
        }
        //End Button Clicks ************************************************************************
    }
}
