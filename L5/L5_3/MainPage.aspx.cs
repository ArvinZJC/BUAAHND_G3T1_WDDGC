// class (code behind) that contains control events of the main page

#region Using Directives
using System;
using System.Web.UI;
#endregion Using Directives

namespace L5.L5_3
{
    /// <summary>
    /// The partial class <see cref="MainPage"/> contains control events of the main page.
    /// </summary>
    public partial class MainPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        } // end method Page_Load

        // pop a window containing a message "Hello World!"
        protected void BtnStart_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Hello World!');</script>");
        } // end method BtnStart_Click

        // redirect to the summary page with 2 parameters
        protected void BtnOK_Click(object sender, EventArgs e)
        {
            Response.Redirect("SummaryPage.aspx?name=" + TxtName.Text + "&age=" + TxtAge.Text);
        } // end method BtnOK_Click

        // close the main page
        protected void BtnClose_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.open('about:blank', '_self').close();</script>"); // "Response.Write("<script>window.open('', '_self').close();</script>");" acts the same (this may be influenced by browser)
        } // end method BtnClose_Click
    } // end partial class MainPage
} // end namespace L5.L5_3