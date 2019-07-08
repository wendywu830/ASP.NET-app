using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cnp.Sdk;

    class Class1
    {
[STAThread]
        public static void Main(String[] args)
        {
            CnpOnline cnp = new CnpOnline();
            sale sale = new sale();
            sale.orderId = "1";
            sale.id = "1";
            sale.amount = 10010;
            sale.orderSource = orderSourceType.ecommerce;
            contact contact = new contact();
            contact.name = "John Smith";
            contact.addressLine1 = "1 Main St.";
            contact.city = "Burlington";
            contact.state = "MA";
            contact.zip = "01803-3747";
            contact.country = countryTypeEnum.US;
            sale.billToAddress = contact;
            cardType card = new cardType();
            card.type = methodOfPaymentTypeEnum.VI;
            card.number = "4457010000000009";
            card.expDate = "0112";
            card.cardValidationNum = "349";
            sale.card = card;

            saleResponse response = cnp.Sale(sale);
            //Display Results
            Console.WriteLine("Response: " + response.response);
            Console.WriteLine("Message: " + response.message);
            Console.WriteLine("Cnp Transaction Id: " + response.cnpTxnId);
            Console.ReadLine();
        }

        public static saleResponse getSale() {
            CnpOnline cnp = new CnpOnline();
            sale sale = new sale();
            sale.orderId = "1";
            sale.id = "1";
            sale.amount = 10010;
            sale.orderSource = orderSourceType.ecommerce;
            contact contact = new contact();
            contact.name = "John Smith";
            contact.addressLine1 = "1 Main St.";
            contact.city = "Burlington";
            contact.state = "MA";
            contact.zip = "01803-3747";
            contact.country = countryTypeEnum.US;
            sale.billToAddress = contact;
            cardType card = new cardType();
            card.type = methodOfPaymentTypeEnum.VI;
            card.number = "4457010000000009";
            card.expDate = "0112";
            card.cardValidationNum = "349";
            sale.card = card;

            saleResponse response = cnp.Sale(sale);
            //Display Results
            Console.WriteLine("Response: " + response.response);
            Console.WriteLine("Message: " + response.message);
            Console.WriteLine("Cnp Transaction Id: " + response.cnpTxnId);
            Console.ReadLine();
            return response;
        }
    }