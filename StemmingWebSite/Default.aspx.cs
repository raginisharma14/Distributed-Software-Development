﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        String stemword = client.GetStemWord(TextBox1.Text);
        TextBox2.Text = stemword;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}