using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        public class Class
        {
            public string name, team, position;
            public int age;
        }

        List<Class> invList = new List<Class>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Class character = new Class();
            
            character.name = newNameInput.Text;
            character.team = teamInput.Text;
            character.position = positionInput.Text;
            character.age = Convert.ToInt16(ageInput.Text);

            invList.Add(character);

            outputLabel.Text = "Character has been added.";
            newNameInput.Text = "";
            teamInput.Text = "";
            ageInput.Text = "";
            positionInput.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < invList.Count; i++)
            {
                removeInput.Text = "";
                if (invList[i].name == removeInput.Text)
                {
                    invList.Remove(invList[i]);
                    outputLabel.Text = "Character has been deleted.";
                }
                else { outputLabel.Text = "Could not find the Character you want to Delete."; }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = null;
            for (int i = 0; i < invList.Count; i++)
            {
                if (nameInput.Text == invList[i].name)
                {
                    outputLabel.Text += "Name: " + invList[i].name + "\nAge: "
                        + invList[i].age + "\nTeam: "
                        + invList[i].team + "\nPosition: "
                        + invList[i].position + "";
                    return;
                }
                if (nameInput.Text != invList[i].name) { outputLabel.Text = "Could not find Character."; }
            }
            nameInput.Text = "";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = null;
            for (int i = 0; i < invList.Count; i++)
            {
                outputLabel.Text += "Name: " + invList[i].name + "\nAge: "
                    + invList[i].age + "\nTeam: "
                    + invList[i].team + "\nPosition: "
                    + invList[i].position + "\n\n";
            }
        }
    }
}
