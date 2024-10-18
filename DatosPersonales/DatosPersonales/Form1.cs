using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DatosPersonales
{
    public partial class Form1 : Form
    {
        List<Parent> parents = new List<Parent> { };
        public Form1()
        {
            InitializeComponent();
        }

        
        //PARENT MANAGER PANEL
        //Parent Name TextBox
        //Show components
        private void parentName_TextChanged(object sender, EventArgs e)
        {
            if (parentName.Text != "")
            {
                insertButton.Enabled = true;
                insertButton.Visible = true;
                hasChildCheckBox.Visible = true;
            } else
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
        }

        //Insert Button
        /*On click, add al Parent data and childTrackBar to Parent Grid and Resets, 
         * if ChildCheckBox is checked shows childNameLayour*/
        private void insertButton_Click(object sender, EventArgs e)
        {
            Parent parent;
            if (parentGridView.SelectedRows.Count == 0)
            {
                if (parentName.Text != "")
                {
                    parent = new Parent(parentName.Text, parentSurname.Text, parentAddress.Text, "+34 " + parentPhone.Text, childTrackBar.Value);
                    if (!parents.Contains(parent))
                    {
                        parents.Add(parent);
                        parentGridView.Rows.Add(parent.id, parent.name, parent.apellidos, parent.address, "+34 " + parent.phone,parent.childCount);
                        //Insert on family TreeView
                        TreeNode parentNode = new TreeNode(parent.name);
                        familyTreeView.Nodes.Add(parentNode);
                        if (hasChildCheckBox.Checked)
                        {
                            foreach (string child in parent.childs)
                            {
                                parentNode.Nodes.Add(parent.id.ToString(), child);
                            }
                            childNameLayout.Visible = true;
                        }
                        parentNode.ExpandAll();
                        insertButton.Enabled = false;
                    }
                    else
                    {
                        /*Future else-errorprovider*/
                    }
                    insertButton.Enabled = false;
                    

                    //Parent Manager Reset
                    parentName.Clear();
                    parentSurname.Clear();
                    parentAddress.Clear();
                    parentPhone.Clear();
                    
                }
                
            }
            else
            {
                TreeNode[] parentNode = familyTreeView.Nodes.Find(parentGridView.SelectedRows[0].Cells[0].ToString(), true);
                parentGridView.SelectedRows[0].Cells[1].Value = parentName.Text;
                parentGridView.SelectedRows[0].Cells[2].Value = parentSurname.Text;
                parentGridView.SelectedRows[0].Cells[3].Value = parentAddress.Text;
                parentGridView.SelectedRows[0].Cells[4].Value = "+34 " + parentPhone.Text;
                parentGridView.SelectedRows[0].Cells[5].Value = childTrackBar.Value;
            }
            /*Future else-errorprovider*/
            parentGridView.ClearSelection();
            parentName.Select();
        }

        //PARENT GRID PANEL

        //Delete Button
        //On click, removes selected row
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in parentGridView.SelectedRows)
            {
                parentGridView.Rows.Remove(row);
            };
            parentGridView.ClearSelection();
            deleteButton.Enabled = false;
        }

        //Parent DataGridView
        //Select enables Delete Button
        private void parentGridView_SelectionChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
            if (parentGridView.SelectedRows.Count > 0)
            {
                parentName.Text = parentGridView.SelectedRows[0].Cells[0].Value.ToString();
                parentSurname.Text = parentGridView.SelectedRows[0].Cells[1].Value.ToString();
                parentAddress.Text = parentGridView.SelectedRows[0].Cells[2].Value.ToString();
                parentPhone.Text = parentGridView.SelectedRows[0].Cells[3].Value.ToString().Substring(4);
                int childs = Convert.ToInt16(parentGridView.SelectedRows[0].Cells[4].Value.ToString());
                if (childs > 0)
                {
                    hasChildCheckBox.Checked = true;
                    childTrackBar.Value = childs;
                }
                
            }
        }


        //FAMILIA PANEL

        //Child TrackBar
        //Sets the Label below Text
        private void childTrackBar_ValueChanged(object sender, EventArgs e)
        {
            childInsertLabel.Text = childTrackBar.Value + ((childTrackBar.Value > 1) ? " hijos" : " hijo");
        }

        //Child Name TextBox
        //Enter set Selected Node name on Family treeView, and resets both Components
        private void childName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Edit Family Tree View Selected Node
                familyTreeView.SelectedNode.Text = childName.Text;
                familyTreeView.SelectedNode.ForeColor = familyTreeView.Nodes[0].ForeColor;
                //Reset
                familyTreeView.SelectedNode = null;
                childName.Text = null;
                childName.Enabled = false;
            }
        }

        //Family TreeView
        //Select child enables ChildName textBox
        private void familyTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (familyTreeView.SelectedNode.Nodes.Count == 0)
            {
                familyTreeView.SelectedNode.ForeColor = Color.Red;
                childName.Enabled = true;
                String childText = familyTreeView.SelectedNode.Text;
                childName.Text = (childText == "¿?") ? "" : childText;
                childDeleteButton.Enabled = true;
                childAddButton.Enabled = false;
            }
            else
            {
                childName.Text = null;
                childName.Enabled = false;
                childDeleteButton.Enabled = false;
                childAddButton.Enabled = true;
            }
            
        }

        //Child Delete Button
        //On click, removes the selected node if has no childs
        private void childDeleteButton_Click(object sender, EventArgs e)
        {
            if (familyTreeView.SelectedNode.Nodes.Count == 0)
            {
                familyTreeView.Nodes.Remove(familyTreeView.SelectedNode);
            }
            familyTreeView.SelectedNode = null;
            childName.Text = null;
        }

        //Child Add Button
        //On click, adds a new child to the selected node
        private void childAddButton_Click(object sender, EventArgs e)
        {                
            familyTreeView.SelectedNode.Nodes.Add("¿?");
            familyTreeView.SelectedNode.ExpandAll(); 
        }
    }
}
