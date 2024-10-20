﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace DatosPersonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            childProgressBar.Maximum = childTrackBar.Maximum;
            childProgressBar.Value = childTrackBar.Value;
        }


        ////////// PARENT MANAGER PANEL //////////
        //Parent Name TextBox
        //Show components
        private void parentName_TextChanged(object sender, EventArgs e)
        {
            if (parentName.Text != "")
            {
                insertButton.Enabled = true;
                insertButton.Visible = true;
                hasChildCheckBox.Visible = true;
            }
            else
            {
                insertButton.Visible = false;
                hasChildCheckBox.Visible = false;
                hasChildCheckBox.Checked = false;
            }
        }

        //Parent Phone TextBox
        //Only Numbers and "Back" key
        private void parentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        //Has Child CheckBox
        //Show Familia Panel options
        private void hasChildCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            childLayout.Visible = hasChildCheckBox.Checked;
            if (parentGridView.SelectedRows.Count == 0)
            {
                childTrackBar.Enabled = true;
            }
        }

        //Insert Button
        /*On click, add al Parent data and childTrackBar to Parent Grid and Resets, 
         if ChildCheckBox is checked shows childNameLayour
         if a row is selected on Parent GridView, edits the selected parent instead*/
        private void insertButton_Click(object sender, EventArgs e)
        {

            //If row is not selected creates a parent, is it is selected edit the parent instead 
            if (parentGridView.SelectedRows.Count == 0)
            {
                //Check if theres a Name, minimum value require
                if (parentName.Text != "")
                {
                    Parent parent;
                    //Checks if there is a parent with that name
                    int index = 0;
                    Boolean nameExists = false;
                    Console.WriteLine(nameExists.ToString());
                    while (!nameExists && index < parentGridView.Rows.Count)
                    {
                        nameExists = parentGridView.Rows[index].Cells[1].Value.Equals(parentName.Text);
                        index++;
                        Console.WriteLine(nameExists.ToString());
                    }
                    //If the name doesnt exists, creates the parent, if it does edit it instead
                    if (!nameExists)
                    {
                        //Create a parent object
                        int parentChildCount = (hasChildCheckBox.Checked) ? childTrackBar.Value : 0;
                        parent = new Parent(parentName.Text, parentSurname.Text, parentAddress.Text, "+34 " + parentPhone.Text, parentChildCount);

                        //Add parent to Parent GridView
                        parentGridView.Rows.Add(parent.id, parent.name, parent.apellidos, parent.address, parent.phone, parent.childCount);

                        //Insert on family TreeView
                        familyTreeView.Nodes.Add(parent.id.ToString(), parent.name);
                        TreeNode parentNode = familyTreeView.Nodes[parent.id.ToString()];
                        if (hasChildCheckBox.Checked)
                        {
                            foreach (string child in parent.childs)
                            {
                                familyTreeView.Nodes[parent.id.ToString()].Nodes.Add(parent.id.ToString() + ".", child);
                            }
                            childNameLayout.Visible = true;
                        }
                        parentNode.ExpandAll();
                    }

                    //Parent Manager Reset
                    parentName.Clear();
                    parentSurname.Clear();
                    parentAddress.Clear();
                    parentPhone.Clear();

                }
                /*else
                {
                    Future else-errorprovider
                }*/
                insertButton.Enabled = false;
            }
            //If row is selected, edit the selected row
            else
            {
                //Edit the parent name on Family TreeView
                familyTreeView.Nodes.Find(parentGridView.SelectedRows[0].Cells[0].Value.ToString(), false).First().Text = parentName.Text;

                //Edit the selected row Values
                parentGridView.SelectedRows[0].Cells[1].Value = parentName.Text;
                parentGridView.SelectedRows[0].Cells[2].Value = parentSurname.Text;
                parentGridView.SelectedRows[0].Cells[3].Value = parentAddress.Text;
                parentGridView.SelectedRows[0].Cells[4].Value = "+34 " + parentPhone.Text;
                parentGridView.SelectedRows[0].Cells[5].Value = childTrackBar.Value;

            }
            //Reset selection
            parentGridView.ClearSelection();
            parentName.Select();
        }

        ////////// PARENT GRID PANEL //////////
        //Delete Button
        //On click, removes selected row and the respective node
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in parentGridView.SelectedRows)
            {
                parentGridView.Rows.Remove(row);
                familyTreeView.Nodes.Find(row.Cells[0].Value.ToString(), false).First().Remove();
            };
            parentGridView.ClearSelection();
            deleteButton.Enabled = false;
        }

        //Parent DataGridView
        //Select enables Delete Button and shows data on Parent Panel
        private void parentGridView_SelectionChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;

            if (parentGridView.SelectedRows.Count > 0)
            {
                //Show parent info on Parent Panel
                parentName.Text = parentGridView.SelectedRows[0].Cells[1].Value.ToString();
                parentSurname.Text = parentGridView.SelectedRows[0].Cells[2].Value.ToString();
                parentAddress.Text = parentGridView.SelectedRows[0].Cells[3].Value.ToString();
                parentPhone.Text = parentGridView.SelectedRows[0].Cells[4].Value.ToString().Substring(4);
                int childs = Convert.ToInt16(parentGridView.SelectedRows[0].Cells[5].Value.ToString());
                if (childs > 0)
                {
                    hasChildCheckBox.Checked = true;
                    childTrackBar.Value = childs;
                    childTrackBar.Enabled = false;
                }
            }
            else
            {
                //Parent Manager Reset
                parentName.Clear();
                parentSurname.Clear();
                parentAddress.Clear();
                parentPhone.Clear();
            }
        }


        ////////// FAMILIA PANEL  //////////
        //Child TrackBar
        //Sets the Label below Text
        private void childTrackBar_ValueChanged(object sender, EventArgs e)
        {
            childInsertLabel.Text = childTrackBar.Value + ((childTrackBar.Value > 1) ? " hijos" : " hijo");
            childProgressBar.Value = childTrackBar.Value;
        }

        //Child Name TextBox
        //Enter Key sets Selected Node name on Family treeView, and resets both Components
        private void childName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Edit Family Tree View Selected Node
                familyTreeView.SelectedNode.Text = childName.Text;
                //Reset
                familyTreeView.SelectedNode = null;
                childName.Text = null;
                childName.Enabled = false;
            }
        }

        //Family TreeView
        //Before Select, remove format of the child selected before
        private void familyTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (familyTreeView.SelectedNode != null && familyTreeView.SelectedNode.Text.StartsWith("["))
            {
                familyTreeView.SelectedNode.Text = familyTreeView.SelectedNode.Text.Substring(2, familyTreeView.SelectedNode.Text.Length - 4);
            }
        }

        /*After Select, formats to show selection, if is a child enables ChildName textBox and remove (child) button,  
        if its a parent enables add (child) button*/
        private void familyTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            parentGridView.ClearSelection();
            //If its a child, enable remove button and prepare ChildName textbox to edit
            if (familyTreeView.SelectedNode.Parent != null)
            {
                int rowIndex = parentGridView.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[1].Value.ToString().Equals(familyTreeView.SelectedNode.Parent.Text)).First().Index;
                parentGridView.Rows[rowIndex].Selected = true;
                childName.Enabled = true;
                String childText = familyTreeView.SelectedNode.Text;
                childName.Text = (childText == "¿?") ? "" : childText;
                childDeleteButton.Enabled = true;
                childAddButton.Enabled = false;

            }
            //If its a parent, enable add child button and selects parent on Paren GridView
            else
            {
                int rowIndex = parentGridView.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[1].Value.ToString().Equals(familyTreeView.SelectedNode.Text)).First().Index;
                parentGridView.Rows[rowIndex].Selected = true;
                childName.Text = null;
                childName.Enabled = false;
                childDeleteButton.Enabled = false;
                childAddButton.Enabled = true;
            }
            familyTreeView.SelectedNode.Text = "[ " + familyTreeView.SelectedNode.Text + " ]";
        }

        //Child Delete Button
        //On click, removes the selected node if has no childs and adjust respective Child count on GridView
        private void childDeleteButton_Click(object sender, EventArgs e)
        {

            if (familyTreeView.SelectedNode.Nodes.Count == 0)
            {
                //Remove the child node
                familyTreeView.Nodes.Remove(familyTreeView.SelectedNode);

                //Change the Child count on trackbar and Parent GridView
                if (parentGridView.SelectedRows.Count > 0)
                {
                    if (childTrackBar.Value == 1)
                    {
                        //If childs are reduce to 0, uncheck HasChild button
                        hasChildCheckBox.Checked = false;
                        parentGridView.SelectedRows[0].Cells[5].Value = 0;
                    }
                    else
                    {
                        childTrackBar.Value--;
                        parentGridView.SelectedRows[0].Cells[5].Value = childTrackBar.Value;
                    }
                }
            }
        }

        //Child Add Button
        //On click, adds a new child to the selected node and adjust respective Child count on GridView
        private void childAddButton_Click(object sender, EventArgs e)
        {
            //Add child
            familyTreeView.SelectedNode.Nodes.Add("¿?");
            familyTreeView.SelectedNode.ExpandAll();
            //Change the Child count on trackbar and Parent GridView
            if (parentGridView.SelectedRows.Count > 0)
            {
                if ((int)parentGridView.SelectedRows[0].Cells[5].Value == 0)
                {
                    //If child was 0 (and now 1) check HasChild CheckBox
                    hasChildCheckBox.Checked = true;
                }
                parentGridView.SelectedRows[0].Cells[5].Value = ((int)parentGridView.SelectedRows[0].Cells[5].Value) + 1;
                childTrackBar.Value = (int)parentGridView.SelectedRows[0].Cells[5].Value;
            }
        }


        //private int loadData(List<Parent> lista)
    }
}