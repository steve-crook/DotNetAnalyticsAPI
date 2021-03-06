
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Ecommerce
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The transaction ID for the shopping cart purchase as supplied by your ecommerce tracking method.")]
            public static DataItem transactionId = new DataItem("transactionId");
                                      
            [DescriptionAttribute("Typically used to designate a supplying company or brick and mortar location; product affiliation.")]
            public static DataItem affiliation = new DataItem("affiliation");
                                      
            [DescriptionAttribute("The number of visits between users purchases and the related campaigns that lead to the purchases.")]
            public static DataItem visitsToTransaction = new DataItem("visitsToTransaction");
                                      
            [DescriptionAttribute("The number of days between users purchases and the related campaigns that lead to the purchases.")]
            public static DataItem daysToTransaction = new DataItem("daysToTransaction");
                                      
            [DescriptionAttribute("The product sku for purchased items as you have defined them in your ecommerce tracking application.")]
            public static DataItem productSku = new DataItem("productSku");
                                      
            [DescriptionAttribute("The product name for purchased items as supplied by your ecommerce tracking application.")]
            public static DataItem productName = new DataItem("productName");
                                      
            [DescriptionAttribute("Any product variations (size, color) for purchased items as supplied by your ecommerce application.")]
            public static DataItem productCategory = new DataItem("productCategory");
                                      
            [DescriptionAttribute("The local currency code of the transaction based on ISO 4217 standard.")]
            public static DataItem currencyCode = new DataItem("currencyCode");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The total number of transactions.")]
            public static DataItem transactions = new DataItem("transactions");
                                      
            [DescriptionAttribute("The total sale revenue provided in the transaction excluding shipping and tax.")]
            public static DataItem transactionRevenue = new DataItem("transactionRevenue");
                                      
            [DescriptionAttribute("The total cost of shipping.")]
            public static DataItem transactionShipping = new DataItem("transactionShipping");
                                      
            [DescriptionAttribute("The total amount of tax.")]
            public static DataItem transactionTax = new DataItem("transactionTax");
                                      
            [DescriptionAttribute("The total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased.")]
            public static DataItem itemQuantity = new DataItem("itemQuantity");
                                      
            [DescriptionAttribute("The number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased.")]
            public static DataItem uniquePurchases = new DataItem("uniquePurchases");
                                      
            [DescriptionAttribute("The total revenue from purchased product items on your property.")]
            public static DataItem itemRevenue = new DataItem("itemRevenue");
                                      
            [DescriptionAttribute("Transaction revenue in local currency.")]
            public static DataItem localTransactionRevenue = new DataItem("localTransactionRevenue");
                                      
            [DescriptionAttribute("Transaction shipping cost in local currency.")]
            public static DataItem localTransactionShipping = new DataItem("localTransactionShipping");
                                      
            [DescriptionAttribute("Transaction tax in local currency.")]
            public static DataItem localTransactionTax = new DataItem("localTransactionTax");
                                      
            [DescriptionAttribute("Product revenue in local currency.")]
            public static DataItem localItemRevenue = new DataItem("localItemRevenue");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The average number of transactions for a visit to your property. (ga:transactions / ga:visits ) ")]
            public static DataItem transactionsPerVisit = new DataItem("transactionsPerVisit");
                                      
            [DescriptionAttribute("The average revenue for an e-commerce transaction. (ga:transactionRevenue / ga:transactions ) ")]
            public static DataItem revenuePerTransaction = new DataItem("revenuePerTransaction");
                                      
            [DescriptionAttribute("Average transaction revenue for a visit to your property. (ga:transactionRevenue / ga:visits ) ")]
            public static DataItem transactionRevenuePerVisit = new DataItem("transactionRevenuePerVisit");
                                      
            [DescriptionAttribute("Total filter for your property (including total revenue and total goal filter). ((ga:transactionRevenue + ga:goalValueAll) ) ")]
            public static DataItem totalValue = new DataItem("totalValue");
                                      
            [DescriptionAttribute("The average revenue per item. (ga:itemRevenue / ga:itemQuantity ) ")]
            public static DataItem revenuePerItem = new DataItem("revenuePerItem");
                                      
            [DescriptionAttribute("The average quantity of this item (or group of items) sold per purchase. (ga:itemQuantity / ga:uniquePurchases ) ")]
            public static DataItem itemsPerPurchase = new DataItem("itemsPerPurchase");
                                      
            }
        }
    }
}
