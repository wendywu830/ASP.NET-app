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
    public partial class _Default : Page
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
                {"username", user.Text},
                {"version", "11.0"},
                {"timeout", "5000"},
                {"merchantId", merchant_id.Text},
                {"password", password.Text},
                {"printxml", "true"},
                {"proxyHost", proxyHost.Text},
                {"proxyPort", proxyPort.Text},
                {"neuterAccountNums", "true"}
            };
            CnpOnline _cnp = new CnpOnline(_config);

            if (auth_checkbox.Checked)
            {
                orderSourceType auth_order_source = null;
                switch (auth_order_source_list.SelectedValue) //not all - only sample of available order sources
                {
                    case "AndroidPay":
                        auth_order_source = orderSourceType.androidpay;
                        break;
                    case "ApplePay":
                        auth_order_source = orderSourceType.applepay;
                        break;
                    case "Ecommerce":
                        auth_order_source = orderSourceType.ecommerce;
                        break;
                    case "Echeckppd":
                        auth_order_source = orderSourceType.echeckppd;
                        break;
                }
                methodOfPaymentTypeEnum card_type = methodOfPaymentTypeEnum.VI;
                switch (card_type_list.SelectedValue) //not all - only sample of available card types
                {
                    case "VI":
                        card_type = methodOfPaymentTypeEnum.VI;
                        break;
                    case "MC":
                        card_type = methodOfPaymentTypeEnum.MC;
                        break;
                    case "AX":
                        card_type = methodOfPaymentTypeEnum.AX;
                        break;
                    case "DC":
                        card_type = methodOfPaymentTypeEnum.DC;
                        break;
                    case "DI":
                        card_type = methodOfPaymentTypeEnum.DI;
                        break;
                }

                var authorization = new authorization
                {
                    id = auth_id.Text,
                    reportGroup = auth_report_group.Text,
                    orderId = order_id.Text,
                    amount = Convert.ToInt64(auth_amount.Text),
                    orderSource = auth_order_source,
                    card = new cardType
                    {
                        type = card_type,
                        number = card_number.Text,
                        expDate = exp_date.Text
                    },
                };
                var response = _cnp.Authorize(authorization);
                auth_response.InnerHtml = "Response: " + response.response + "<br>Message: " + response.message + "<br>Response Time: "
                    + response.responseTime;
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
                    reportGroup = capture_report_group.Text,
                    cnpTxnId = Convert.ToInt64(cnp_txn_id.Text),
                    amount = Convert.ToInt64(capture_amount.Text),
                    payPalNotes = paypal_notes.Text,
                    pin = pin.Text
                };
                var response = _cnp.Capture(capture);
                capture_response.InnerHtml = "Response: " + response.response + "<br>Message: " + response.message + "<br>Response Time: "
                    + response.responseTime;
            }
            else
            {
                capture_response.InnerHtml = "";
            }
        }


    }
}