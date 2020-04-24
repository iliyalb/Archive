<%-- ~/Global.asax --%>

<%-- ~/Web.Config:
    <customErrors mode="RemoteOnly" defaultRedirect="~/Error.aspx">
        <error statusCode="404" redirect="~/Error404.aspx" />
    </customErrors>
 --%>

<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
    }
    
    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
    }

    void Application_Error(object sender, EventArgs e)
    {
        Exception exception = Server.GetLastError().GetBaseException();
        
        System.IO.StreamWriter writer = null;
        try
        {
            writer = new System.IO.StreamWriter(Server.MapPath("~/App_Data/Log.txt"), true);
            writer.WriteLine("Message: " + exception.Message + " Time: " + System.DateTime.Now + " Path: " + Request.PhysicalPath + " User IP: " + Request.UserHostAddress);
        }
        catch (Exception)
        {
            // Optional
        }
        finally
        {
            if (writer != null)
            {
                writer.Dispose();
            }
        }
        //Server.ClearError();
    }
    
    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown
    }

</script>