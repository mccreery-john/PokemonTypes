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
        string[] currentTypes;
        double[,] typeValues;           //FIX ME

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

            if (currentTypes != null)
            {
                //FIX ME


                for (int i = 0; i < 18; i++)
                {
                    double currentValue = 1.0;
                    for (int j = 0; j < currentTypes.Length; j++)
                    {

                        switch (currentTypes[i])
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            currentTypes = null;
            refreshTypes();
        }
    }
}
