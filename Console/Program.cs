using System;
using WebServiceConsole.MindBody.SaleService;
using WebServiceConsole.MindBody.SiteService;

namespace WebServiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleServiceSoapClient saleClient = new SaleServiceSoapClient();
            var result = saleClient.GetContracts(new GetContractsRequest());
            SiteServiceSoapClient siteClient = new SiteServiceSoapClient();
            //Should not be void
            siteClient.GetLocations();
            Console.WriteLine("Hello World!");
        }
    }
}