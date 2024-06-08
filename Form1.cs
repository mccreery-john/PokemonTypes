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


            //          SIMPLIFY HERE               FIX ME
            //Start types' ListViewItems
            ListViewItem normalItem = new ListViewItem();
            normalItem.BackColor = normalButton.BackColor;
            normalItem.ForeColor = normalButton.ForeColor;
            normalItem.Text = normalButton.Text;
            itemsArray[0] = normalItem;

            ListViewItem fightItem = new ListViewItem();
            fightItem.BackColor = fightingButton.BackColor;
            fightItem.ForeColor = fightingButton.ForeColor;
            fightItem.Text = fightingButton.Text;
            itemsArray[1] = fightItem;

            ListViewItem flyingItem = new ListViewItem();
            flyingItem.BackColor = flyingButton.BackColor;
            flyingItem.ForeColor = flyingButton.ForeColor;
            flyingItem.Text = flyingButton.Text;
            itemsArray[2] = flyingItem;

            ListViewItem poisonItem = new ListViewItem();
            poisonItem.BackColor = poisonButton.BackColor;
            poisonItem.ForeColor = poisonButton.ForeColor;
            poisonItem.Text = poisonButton.Text;
            itemsArray[3] = poisonItem;

            ListViewItem groundItem = new ListViewItem();
            groundItem.BackColor = groundButton.BackColor;
            groundItem.ForeColor = groundButton.ForeColor;
            groundItem.Text = groundButton.Text;
            itemsArray[4] = groundItem;

            ListViewItem rockItem = new ListViewItem();
            rockItem.BackColor = rockButton.BackColor;
            rockItem.ForeColor = rockButton.ForeColor;
            rockItem.Text = rockButton.Text;
            itemsArray[5] = rockItem;

            ListViewItem bugItem = new ListViewItem();
            bugItem.BackColor = bugButton.BackColor;
            bugItem.ForeColor = bugButton.ForeColor;
            bugItem.Text = bugButton.Text;
            itemsArray[6] = bugItem;

            ListViewItem ghostItem = new ListViewItem();
            ghostItem.BackColor = ghostButton.BackColor;
            ghostItem.ForeColor = ghostButton.ForeColor;
            ghostItem.Text = ghostButton.Text;
            itemsArray[7] = ghostItem;

            ListViewItem steelItem = new ListViewItem();
            steelItem.BackColor = steelButton.BackColor;
            steelItem.ForeColor = steelButton.ForeColor;
            steelItem.Text = steelButton.Text;
            itemsArray[8] = steelItem;

            ListViewItem fireItem = new ListViewItem();
            fireItem.BackColor = fireButton.BackColor;
            fireItem.ForeColor = fireButton.ForeColor;
            fireItem.Text = fireButton.Text;
            itemsArray[9] = fireItem;

            ListViewItem waterItem = new ListViewItem();
            waterItem.BackColor = waterButton.BackColor;
            waterItem.ForeColor = waterButton.ForeColor;
            waterItem.Text = waterButton.Text;
            itemsArray[10] = waterItem;

            ListViewItem grassItem = new ListViewItem();
            grassItem.BackColor = grassButton.BackColor;
            grassItem.ForeColor = grassButton.ForeColor;
            grassItem.Text = grassButton.Text;
            itemsArray[11] = grassItem;

            ListViewItem electricItem = new ListViewItem();
            electricItem.BackColor = electricButton.BackColor;
            electricItem.ForeColor = electricButton.ForeColor;
            electricItem.Text = electricButton.Text;
            itemsArray[12] = electricItem;

            ListViewItem psychicItem = new ListViewItem();
            psychicItem.BackColor = psychicButton.BackColor;
            psychicItem.ForeColor = psychicButton.ForeColor;
            psychicItem.Text = psychicButton.Text;
            itemsArray[13] = psychicItem;

            ListViewItem iceItem = new ListViewItem();
            iceItem.BackColor = iceButton.BackColor;
            iceItem.ForeColor = iceButton.ForeColor;
            iceItem.Text = iceButton.Text;
            itemsArray[14] = iceItem;

            ListViewItem dragonItem = new ListViewItem();
            dragonItem.BackColor = dragonButton.BackColor;
            dragonItem.ForeColor = dragonButton.ForeColor;
            dragonItem.Text = dragonButton.Text;
            itemsArray[15] = dragonItem;

            ListViewItem darkItem = new ListViewItem();
            darkItem.BackColor = darkButton.BackColor;
            darkItem.ForeColor = darkButton.ForeColor;
            darkItem.Text = darkButton.Text;
            itemsArray[16] = darkItem;

            ListViewItem fairyItem = new ListViewItem();
            fairyItem.BackColor = fairyButton.BackColor;
            fairyItem.ForeColor = fairyButton.ForeColor;
            fairyItem.Text = fairyButton.Text;
            itemsArray[17] = fairyItem;
            //End types' ListViewItems
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
                            //      Add error message here FIX ME
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
                    //  Add error message here      FIX ME
                    break;
            }

            if (currentTypes[0] == -1)
            {
                currentTypes[0] = typeID;
                typeTextColor(button, type1);

            }
            else if (currentTypes[1] == -1)
            {
                if (button.Text != type1.Text)
                {
                    currentTypes[1] = typeID;
                    typeTextColor(button, type2);
                }
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            currentTypes[0] = -1;
            currentTypes[1] = -1;
            type1.Text = string.Empty;
            type2.Text = string.Empty;
            refreshTypes();
        }
        //End Button Clicks ************************************************************************
    }
}
