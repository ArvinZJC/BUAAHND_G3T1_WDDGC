﻿//2018.10.19, class (code behind) that contains control events of the main page of the web page form L5_3

#region Using Directives
using System;
using System.Web.UI;
#endregion Using Directives

namespace L5.L5_3
{
    /// <summary>
    /// Partial class <see cref="MainPage"/> contains control events of the main page of the web form page L5_3
    /// </summary>
    public partial class MainPage : Page
    {
        protected void Page_Load( object sender, EventArgs e )
        {

        } //end method Page_Load

        //pop a window containing a message "Hello World!"
        protected void btnStart_Click( object sender, EventArgs e )
        {
            Response.Write( "<script>alert( 'Hello World!');</script>" );
        } //end method btnStart_Click

        //redirect to the summary page with 2 parameters
        protected void btnOK_Click( object sender, EventArgs e )
        {
            Response.Redirect( "SummaryPage.aspx?name=" + txtName.Text + "&age=" + txtAge.Text );
        } //end method btnOK_Click

        //close the main page
        protected void btnClose_Click( object sender, EventArgs e )
        {
            Response.Write("<script>window.open('', '_self').close();</script>"); //"Response.Write("<script>window.open('about:blank', '_self').close();</script>");" acts the same
        } //end method btnClose_Click
    } //end partial class MainPage
} //end namespace L5.L5_3