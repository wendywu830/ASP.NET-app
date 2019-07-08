<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPage.aspx.cs" Inherits="ASP.NETDemo.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
  <h3>Configuration</h3>
  URL:<br />
 <asp:TextBox ID="url" runat="server" style="width:224px">
 </asp:TextBox>
  <br />Proxy:<br />
  <asp:TextBox ID="proxy" runat="server" style="width:224px">
  </asp:TextBox>
  <br />User:<br />
  <asp:TextBox ID="user" runat="server" style="width:224px">
  </asp:TextBox>
  <br />Password:<br />
  <asp:TextBox ID="password" runat="server" style="width:224px">
  </asp:TextBox>
  <br />Merchant ID:<br />
  <asp:TextBox ID="merchant_id" runat="server" style="width:224px">
  </asp:TextBox>
  <br />
        <div>
        <style type="text/css">
        td {
            vertical-align: top;
        }
        </style>
        <table width="70%">
            <tr>
                <td width="35%">
                    <h3>Simple Auth <asp:CheckBox ID="auth_checkbox" runat="server"/></h3>  
                    Report Group:<br />
                    <asp:TextBox ID="auth_report_group" runat="server" style="width:224px">
                    </asp:TextBox>
                    <br />Order ID:<br />
                    <asp:TextBox ID="order_id" runat="server" style="width:224px">
                    </asp:TextBox>
                    <br />Amount:<br />
                    <asp:TextBox ID="auth_amount" runat="server" style="width:224px">
                    </asp:TextBox>
                    <br />Order Source<br />
                    <asp:TextBox ID="auth_order_source" runat="server" style="width:224px">
                    </asp:TextBox>
                    <br />ID:<br />
                    <asp:TextBox ID="auth_id" runat="server" style="width:224px">
                    </asp:TextBox>
                    <br /><br />
                    <br />Card Number<br />
                    <asp:TextBox ID="card_number" runat="server" style="width:224px">
                    </asp:TextBox>
                    <br />Expiration Date<br />
                    <asp:TextBox ID="exp_date" runat="server" style="width:224px">
                    </asp:TextBox>
                    <br />Card Type<br />
                    <asp:TextBox ID="card_type" runat="server" style="width:224px">
                    </asp:TextBox>
                    <br />
                </td>
                <td width="35%">
                    <h3>Simple Capture <asp:CheckBox ID="capture_checkbox" runat="server"/></h3>  
                      Report Group:<br />
                       <asp:TextBox ID="capture_report_group" runat="server" style="width:224px">
                       </asp:TextBox>
                      <br />CNP Txn ID:<br />
                      <asp:TextBox ID="cnp_txn_id" runat="server" style="width:224px">
                       </asp:TextBox>
                      <br />Amount:<br />
                      <asp:TextBox ID="capture_amount" runat="server" style="width:224px">
                       </asp:TextBox>
                      <br />Paypal Notes:<br />
                      <asp:TextBox ID="paypal_notes" runat="server" style="width:224px">
                       </asp:TextBox>
                      <br />Order Source<br />
                      <asp:TextBox ID="capture_order_source" runat="server" style="width:224px">
                       </asp:TextBox>
                      <br />Pin:<br />
                      <asp:TextBox ID="pin" runat="server" style="width:224px">
                       </asp:TextBox>
                      <br />ID:<br />
                      <asp:TextBox ID="capture_id" runat="server" style="width:224px">
                       </asp:TextBox>
                      <br />
                </td>
            </tr>
            <tr>
                <td>
                    <h3>Auth Response</h3>
                    <span runat="server" id="auth_response" />
                </td>
                <td>
                    <h3>Capture Response</h3>
                    <span runat="server" id="capture_response" />
                </td>
            </tr>
        </table>
        </div>
  
  <asp:Button ID="submit" runat="server" Text="Submit" style="width:85px" onclick="Button1_Click" />

</form>

</body>
</html>
