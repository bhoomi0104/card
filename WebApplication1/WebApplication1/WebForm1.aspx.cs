﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //set the Background color list
                //ont options

                Font_list.Items.Add("Times New Roman");
                Font_list.Items.Add("Arial");
                Font_list.Items.Add("Verdana");
                Font_list.Items.Add("Tahoma");

                //Add Border Styles

                ListItem item = new ListItem();
                item.Text = BorderStyle.None.ToString();
                item.Value = ((int)BorderStyle.None).ToString();
                Border_style.Items.Add(item);

                item = new ListItem();
                item.Text = BorderStyle.Double.ToString();
                item.Value = ((int)BorderStyle.Double).ToString();
                Border_style.Items.Add(item);

                item = new ListItem();
                item.Text = BorderStyle.Solid.ToString();
                item.Value = ((int)BorderStyle.Solid).ToString();
                Border_style.Items.Add(item);


                Border_style.SelectedIndex = 0;


            }
            else
            {
                imgDefault.ImageUrl = "index.jpg";

            }
        }
        protected void Update_Click(Object sender, EventArgs e)
        {
           // pnlCard.BackColor = Color.FromName(Bc_list.SelectedItem.Text);
            lblGreeting.Font.Name = Font_list.SelectedItem.Text;
            if (Int32.Parse(Font_size.Text) > 0)
            {
                lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(Font_size.Text));
            }
            int borderValue = Int32.Parse(Border_style.SelectedItem.Value);
            pnlCard.BorderStyle = (BorderStyle)borderValue;

            if (Checkbox.Checked)
            {
                imgDefault.Visible = true;

            }
            else
            {
                imgDefault.Visible = false;
            }
            lblGreeting.Text = Greeting_text.Text;
        }
    }
}