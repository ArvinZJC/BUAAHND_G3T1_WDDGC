// class (code behind) that contains control events of the summary page

#region Using Directives
using System;
using System.Web;
using System.Web.UI;
#endregion Using Directives

namespace L5.L5_3
{
    /// <summary>
    /// The partial class <see cref="SummaryPage"/> contains control events of the summary page.
    /// </summary>
    public partial class SummaryPage : Page
    {
        // print summary on the summary page
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpBrowserCapabilities browserCapabilities = Request.Browser; // get the browser capabilities

            Response.Write("<div style='text-align: center'><b>(●ˇ∀ˇ●)</b></div>");
            Response.Write("<hr />");
            Response.Write("<b>As you stated, your name is " + Request["name"] + ", and your age is " + Request["age"] + "</b><br />"); // "Request.Params["(key)"]" and "Request.QueryString["(key)"]" act the same as "Request["(key)"]
            Response.Write("<p></p>");
            Response.Write("<b>Your browser capabilities:</b><br />");
            Response.Write("Type: " + browserCapabilities.Type + "<br />");
            Response.Write("Browser: " + browserCapabilities.Browser + "<br />");
            Response.Write("Version: " + browserCapabilities.Version + "<br />");
            Response.Write("Platform: " + browserCapabilities.Platform + "<br />");
            Response.Write("Frame supported: " + browserCapabilities.Frames + "<br />");
            Response.Write("Table supported: " + browserCapabilities.Tables + "<br />");
            Response.Write("Cookie supported: " + browserCapabilities.Cookies + "<br />");
        } // end method Page_Load

        // redirect to the main page
        protected void BtnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        } // end method BtnReturn_Click
    } // end partial class SummaryPage
} // end namespace L5.L5_3