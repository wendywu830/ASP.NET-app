using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;
using Cnp.Sdk;


namespace ASP.NETDemo
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [STAThread]
        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> _config = new Dictionary<string, string>
            {
                {"url", url.Text},
                {"reportGroup", "Default Report Group"},
                {"username", "DOTNET"},
                {"version", "11.0"},
                {"timeout", "5000"},
                {"merchantId", "101"},
                {"password", "TESTCASE"},
                {"printxml", "true"},
                {"proxyHost", "unetproxy"},
                {"proxyPort", "8080"},
                {"neuterAccountNums", "true"}
            };
            CnpOnline _cnp = new CnpOnline(_config);

            if (auth_checkbox.Checked)
            {
                var authorization = new authorization
                {
                    id = auth_id.Text,
                    reportGroup = auth_report_group.Text,
                    orderId = order_id.Text,
                    amount = Convert.ToInt64(auth_amount.Text),
                    orderSource = orderSourceType.ecommerce,
                    card = new cardType
                    {
                        type = methodOfPaymentTypeEnum.VI,
                        number = card_number.Text,
                        expDate = exp_date.Text
                    },
                };
                var response = _cnp.Authorize(authorization);
                auth_response.InnerHtml = response.response;
            }
            else 
            {
                auth_response.InnerHtml = "";
            }
            if (capture_checkbox.Checked)
            {
                var capture = new capture
                {
                    id = capture_id.Text,
                    cnpTxnId = Convert.ToInt64(cnp_txn_id.Text),
                    amount = Convert.ToInt64(capture_amount.Text),
                    payPalNotes = paypal_notes.Text,
                    pin = pin.Text
                };
                var response = _cnp.Capture(capture);
                capture_response.InnerHtml = response.response;
            }
            else
            {
                capture_response.InnerHtml = "";
            }
        }

     
    }
}