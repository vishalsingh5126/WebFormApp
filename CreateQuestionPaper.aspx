<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateQuestionPaper.aspx.cs" Inherits="WebFormUsingC.CreateQuestionPaper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Question:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuestion" runat="server" Height="27px" Width="644px"></asp:TextBox>
        </div>
        <br />
        <br />
        Options:<br />
        <asp:Panel ID="Panel1" runat="server" Height="115px" Width="420px">
            <asp:RadioButton ID="radOption1" runat="server" Text=" " OnCheckedChanged="radOption1_CheckedChanged" AutoPostBack="true"/>
            <asp:TextBox ID="txtOption1" runat="server" Width="377px"></asp:TextBox>
            <br />
            <asp:RadioButton ID="radOption2" runat="server" Text=" " OnCheckedChanged="radOption2_CheckedChanged" AutoPostBack="true"/>
            <asp:TextBox ID="txtOption2" runat="server" Width="378px"></asp:TextBox>
            <br />
            <asp:RadioButton ID="radOption3" runat="server" Text=" " OnCheckedChanged="radOption3_CheckedChanged" AutoPostBack="true"/>
            <asp:TextBox ID="txtOption3" runat="server" Width="375px"></asp:TextBox>
            <br />
            <asp:RadioButton ID="radOption4" runat="server" Text=" " OnCheckedChanged="radOption4_CheckedChanged" AutoPostBack="true"/>
            <asp:TextBox ID="txtOption4" runat="server" Width="379px"></asp:TextBox>
        </asp:Panel>
        &nbsp;&nbsp;&nbsp;
        <div style="margin-left: 160px">
            <asp:Button ID="btnCreateQuestion" runat="server" OnClick="btnCreateQuestion_Click" Text="Create Question" />
        </div>
        <br />

    </form>
</body>
</html>
