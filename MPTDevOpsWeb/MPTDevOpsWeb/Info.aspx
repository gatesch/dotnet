<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="MPTDevOpsWeb.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        INFO.<br />
        ======<br />

        <fieldset style="width: 500px;">
            <legend>Block 1 : Replace value </legend>
            <p>
                Replace value in web.config file.<br />
                <add key="MyTNS" value="__MyTNS__" />

                Variable key name MyTNS<br />
                And Variable value = "from release variable."


            </p>
            Output<br />
            MyTNS :
        <asp:Label ID="LblMyTNS" runat="server" Text="[MyTNS]"></asp:Label>
            <br />

        </fieldset>
        <br />
        <fieldset style="width: 500px;">
            <legend>Block 2 : Replace with Match Key name. </legend>
            <p>
                Replace value in web.config file.<br />
                <add key="STAGE" value="GROUND" />
                <add key="Location" value="DEVVALUE" />

                Variable key name STAGE at release = "CLOUD"<br />
                Variable key name Location at release = "WANGNOI"<br />
            </p>
            <hr />
            Output
            <br />
            Location :
        <asp:Label ID="LblLocation" runat="server" Text="[location]"></asp:Label>
            <br />
            STAGE :
        <asp:Label ID="LblStage" runat="server" Text="[stage]"></asp:Label>
        </fieldset>
        <br />
        <fieldset style="width: 500px;">
            <legend>Block 3 : No Replace get value from web.config by Key name. </legend>
            <p>
                Replace value in web.config file.<br />
                <add key="APPNAME" value="TestDevOps" />


                No Variable at release , read from web.config  = "TestDevOps"<br />
            </p>
            <hr />
            Output<br />
            ENV&nbsp; :
        <asp:Label ID="LblEnv" runat="server" Text="[env]"></asp:Label>
            <br />
            Host&nbsp; :
        <asp:Label ID="LblHost" runat="server" Text="[host]"></asp:Label>
            <br />

        </fieldset>
        <br />

        <br />

        
        <table style="width: 100%; vertical-align: top; border: 1px;">
            <tr>
                <td>
                    <asp:TextBox ID="TxtServerVars" runat="server" Height="246px" TextMode="MultiLine" Width="700px">[server vars]</asp:TextBox><br />
                    <br />
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Data" />
                    <div>
                    </div>

                    <asp:SqlDataSource runat="server" ID="SQLDS1" ConnectionString="<%$ ConnectionStrings:DLGTPULConnectionString %>" SelectCommand="SELECT [Title], [Price] FROM [Products]"></asp:SqlDataSource>
                    <p>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SQLDS1" ForeColor="#333333" GridLines="None" Width="617px" Visible="False">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </p>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </form>

</body>
</html>
