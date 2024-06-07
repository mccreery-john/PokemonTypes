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
        ListViewItem[] itemsArray = new ListViewItem[18];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentTypes[0] = -1;
            currentTypes[1] = -1;

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
                //FIX ME


                for (int i = 0; i < 18; i++)
                {
                    double currentValue = 1.0;
                    for (int j = 0; j < currentTypes.Length - 1; j++)
                    {

                        if (currentTypes[j] != -1)
                        {
                            currentValue *= typeValues[currentTypes[j], i];
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
                            //
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


        //Button Clicks ************************************************************************

        private void typeButton_Click(object sender, EventArgs e)
        {
            int typeID;
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

                default :
                    break;
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

        private void normalButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (currentTypes[0] == -1)
            {
                currentTypes[0] = 0;
                typeTextColor(button, type1);

            }
            else if (currentTypes[1] == -1)
            {
                currentTypes[1] = 0;
                typeTextColor(button, type2);
            }


        }

        private void fightingButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (currentTypes[0] == -1)
            {

                currentTypes[0] = 1;
                typeTextColor(button, type1);

            }
            else if (currentTypes[1] == -1)
            {
                currentTypes[1] = 1;
                typeTextColor(button, type2);
            }
        }

        private void flyingButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (currentTypes[0] == -1)
            {

                currentTypes[0] = 2;
                typeTextColor(button, type1);

            }
            else if (currentTypes[1] == -1)
            {
                currentTypes[1] = 2;
                typeTextColor(button, type2);
            }
        }

        private void poisonButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (currentTypes[0] == -1)
            {

                currentTypes[0] = 3;
                typeTextColor(button, type1);

            }
            else if (currentTypes[1] == -1)
            {
                currentTypes[1] = 3;
                typeTextColor(button, type2);
            }
        }

        private void groundButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (currentTypes[0] != -1)
            {
                
                currentTypes[0] = 4;
                type1.Text = button.Text;
                type1.BackColor = button.BackColor;
                type1.ForeColor = button.ForeColor;
                refreshTypes();

            }
            else if (currentTypes[1] != -1)
            {
                currentTypes[1] = 4;
                type2.Text = groundButton.Text;
                type2.BackColor = groundButton.BackColor;
                type2.ForeColor = groundButton.ForeColor;
                refreshTypes();
            }
        }




        //End Button Clicks ************************************************************************
    }
}
