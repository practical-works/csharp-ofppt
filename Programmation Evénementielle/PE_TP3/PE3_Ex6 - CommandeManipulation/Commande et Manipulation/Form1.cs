using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Commande_et_Manipulation
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            listBox_stock.SetSelected(0,true);
            // Mettre à jour le contenu et la statut des contrôles en fonction des listebox (principaux contôles)
            TextBoxUpdate(listBox_stock, textBox_stock);
            TextBoxUpdate(listBox_panier, textBox_panier);
            ButtonsUpdate(listBox_stock, button_stock_up, button_stock_down, button_right, button_right_all);
            ButtonsUpdate(listBox_panier, button_panier_up, button_panier_down, button_left, button_left_all);
            ButtonsUpdate(listBox_panier, button_commander);
        }
        private void ButtonsUpdate(ListBox listBox_name, Button button_name)
        {
            if (listBox_name.Items.Count != 0)
            {
                button_name.Enabled = true;
            }
            else
            {
                button_name.Enabled = false;
            }
        }
        private void ButtonsUpdate(ListBox listBox_name, Button button_UP, Button button_DOWN, Button button_MOVE, Button button_MOVEALL)
        {
            if (listBox_name.SelectedIndex == 0)
            {
                button_UP.Enabled = false;
            }
            else
            {
                button_UP.Enabled = true;
            }
            if (listBox_name.SelectedIndex == listBox_name.Items.Count -1)
            {
                button_DOWN.Enabled = false;
            }
            else
            {
                button_DOWN.Enabled = true;
            }
            if (listBox_name.SelectedIndex == -1)
            {
                button_MOVE.Enabled = false;
            }
            else
            {
                button_MOVE.Enabled = true;
            }
            if (listBox_name.Items.Count == 0)
            {
                button_MOVEALL.Enabled = false;
            }
            else
            {
                button_MOVEALL.Enabled = true;
            }
        }
        private void TextBoxUpdate(ListBox listBox_name, TextBox textBox_name)
        {
			    textBox_name.Text = listBox_name.Items.Count.ToString();
        }
        private void MoveItem(ListBox listBox_A, ListBox listBox_B)
        {
            int tmpID = listBox_A.SelectedIndex, tmpIDlast = listBox_A.Items.Count -1; // Sauvegarde d'index avant déplacement
            if (listBox_A.SelectedIndex != -1)
            {
                listBox_B.Items.Add(listBox_A.SelectedItem);
                listBox_A.Items.Remove(listBox_A.SelectedItem);
            }
            if (tmpID != -1 && listBox_A.Items.Count != 0)  // Si l'index n'est pas sélectionné ou la liste est épuisée
            {
                if (tmpID != tmpIDlast)
                {
                    listBox_A.SetSelected(tmpID,true);
                }
                else if (tmpID == tmpIDlast)
                {
                    listBox_A.SetSelected(tmpID -1, true);
                }
            }
            TextBoxUpdate(listBox_stock, textBox_stock);
            TextBoxUpdate(listBox_panier, textBox_panier);
        }

        private void MoveAll(ListBox listBox_A, ListBox listBox_B)
        {
            listBox_B.Items.AddRange(listBox_A.Items);
            listBox_A.Items.Clear();
            TextBoxUpdate(listBox_stock, textBox_stock);
            TextBoxUpdate(listBox_panier, textBox_panier);
            ButtonsUpdate(listBox_stock, button_stock_up, button_stock_down, button_right, button_right_all);
            ButtonsUpdate(listBox_panier, button_panier_up, button_panier_down, button_left, button_left_all);
            ButtonsUpdate(listBox_panier, button_commander);
            listBox_B.SetSelected(0, true);
        }
        private void DriveItem(ListBox listBox_name, string direction)
        {
            if (listBox_name.SelectedIndex != -1)
            {
                switch (direction)
                     {   
                case "up":
                    if (listBox_name.SelectedIndex != 0)
                    {
                        var tmp = listBox_name.Items[listBox_name.SelectedIndex - 1];
                        listBox_name.Items[listBox_name.SelectedIndex - 1] = listBox_name.Items[listBox_name.SelectedIndex];
                        listBox_name.Items[listBox_name.SelectedIndex] = tmp;
                        listBox_name.SetSelected(listBox_name.SelectedIndex - 1, true);
                    }
                    break;
                case "down":
                    if (listBox_name.SelectedIndex != listBox_name.Items.Count - 1)
                    {
                        var tmp = listBox_name.Items[listBox_name.SelectedIndex + 1];
                        listBox_name.Items[listBox_name.SelectedIndex + 1] = listBox_name.Items[listBox_name.SelectedIndex];
                        listBox_name.Items[listBox_name.SelectedIndex] = tmp;
                        listBox_name.SetSelected(listBox_name.SelectedIndex + 1, true);
                    }
                    break;
                default:
                    break;
            }
            }

        }
        private void SortList(ListBox listBox_name, int sort_order)
        {
            if (listBox_name.Items.Count != 0)
            {
                if (sort_order == 1) // Croissant (A-Z)
                {
                    listBox_name.Sorted = true;
                    listBox_name.SetSelected(0, true);  // Set cursor selection at the begining of the list
                }
                else if (sort_order == -1)  // Décroissant (Z-A)
                {
                    listBox_name.Sorted = false;
                    int N = listBox_name.Items.Count;
                    // Copy the Listbox Items to a high lists manager class object & sort it
                    List<string> List_STR = new List<string>(N);
                    for (int i = 0; i < N; i++)
                    {
                        List_STR.Add(listBox_name.Items[i].ToString());
                    }
                    List_STR.Sort();
                    List_STR.Reverse();
                    // Copy back the SORTED list to the Listbox & OVERWRITE (clear) thr old list
                    listBox_name.Items.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        listBox_name.Items.Add(List_STR[i]);
                    }
                    listBox_name.SetSelected(0, true);
                }
            
            }
        }
        //---------------------------------------------------------------------------
        //---------------------------------------------------------------------------

        private void button_right_Click(object sender, EventArgs e)
        {
            MoveItem(listBox_stock, listBox_panier);
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            MoveItem(listBox_panier, listBox_stock);
        }

        private void button_right_all_Click(object sender, EventArgs e)
        {
            MoveAll(listBox_stock, listBox_panier);
        }

        private void button_left_all_Click(object sender, EventArgs e)
        {
            MoveAll(listBox_panier, listBox_stock);
        }


        private void button_stock_up_Click(object sender, EventArgs e)
        {
            DriveItem(listBox_stock,"up");
        }

        private void button_stock_down_Click(object sender, EventArgs e)
        {
            DriveItem(listBox_stock,"down");
        }

        private void button_panier_up_Click(object sender, EventArgs e)
        {
            DriveItem(listBox_panier, "up");
        }

        private void button_panier_down_Click(object sender, EventArgs e)
        {
            DriveItem(listBox_panier, "down");
        }

        private void button_commander_Click(object sender, EventArgs e)
        {
            richTextBox_commande.Text = "";
            for (int i = 0; i < listBox_panier.Items.Count; i++)
            {
                richTextBox_commande.Text += listBox_panier.Items[i] + "\n";
            }
        }

        private void button_stock_AZ_Click(object sender, EventArgs e)
        {
            SortList(listBox_stock, 1);
        }

        private void button_panier_AZ_Click(object sender, EventArgs e)
        {
            SortList(listBox_panier, 1);
        }

        private void button_stock_ZA_Click(object sender, EventArgs e)
        {
            SortList(listBox_stock, -1);
        }

        private void button_panier_ZA_Click(object sender, EventArgs e)
        {
            SortList(listBox_panier, -1);
        }

        private void listBox_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonsUpdate(listBox_stock, button_stock_up, button_stock_down, button_right, button_right_all);
            ButtonsUpdate(listBox_panier, button_commander);
        }

        private void listBox_panier_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonsUpdate(listBox_panier, button_panier_up, button_panier_down, button_left, button_left_all);
            ButtonsUpdate(listBox_panier, button_commander);
        }

    }
}
