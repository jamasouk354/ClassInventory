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

        // TODO - create a List to store all inventory objects
        List<Class> invList = new List<Class>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Class character = new Class();
            // TODO - gather all information from screen 
            character.name = newNameInput.Text;
            character.team = teamInput.Text;
            character.position = positionInput.Text;
            character.age = Convert.ToInt16(ageInput.Text);

            // TODO - create object with gathered information

            // TODO - add object to global list
            invList.Add(character);

            outputLabel.Text = "Character has been added.";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // TODO - if object is in list remove it

            // TODO - display message to indicate deletion made
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // TODO - if object entered exists in list show it
            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = null;
            for (int i = 0; i < invList.Count; i++)
            {
                outputLabel.Text += invList[i].name + "\n"
                    + invList[i].age + "\n"
                    + invList[i].team + "\n"
                    + invList[i].position + "";
            }
        }
    }
}
