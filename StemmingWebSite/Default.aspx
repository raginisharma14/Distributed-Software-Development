<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 400px">
            STEMMING SERVICE</p>
        <p>
            This service returns Stem Words For a given set of Strings or a String</p>
        <p>
            Service URL: <a href="http://localhost:53849/Service1.svc?wdl">http://localhost:53849/Service1.svc?wdl</a></p>
        <p>
            Method: GetStemWord</p>
        <p>
            Input: Single String or Set Of Strings</p>
        <p>
            Output: Set of Stem Words or Single Stem Word</p>
        <p>
            Example:</p>
        <p>
            Input: Goodness,Formative,Informative,Restful,Hopeful,Realize</p>
        <p>
            Output:Good,Form,Inform,Rest,Hope,Real</p>
        <p>
            Input Strings or a String to get the respective Stem Word:</p>
        <asp:TextBox ID="TextBox1" runat="server" Height="41px" OnTextChanged="TextBox1_TextChanged" Width="190px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click to Output Stem Word" />
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Height="38px" Width="191px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
