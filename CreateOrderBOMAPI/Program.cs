using System;
using System.IO;
using RestSharp;
using CreateOrderBOMAPI.Classes;


namespace CreateOrderBOMAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateRootCabOrder();
        }

        public static Order CreateOrder()
        {
            //Reading Body from JSON-file
            var file = File.ReadAllText("..\\..\\Order.json");

            //Send POST-request to BOM API and get results
            var client = new RestClient("http://api.bomfusion-dev.ctechmanufacturing.com/api/orders");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", file, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            //Convert JSON to OrderClass, to read TransactionNumber and other parameters
            var order = Order.FromJson(response.Content);
            
            return order;
        }

        public static void CreateRootCabOrder()
        {
            //Reading Body from JSON-file
            var file = File.ReadAllText("..\\..\\RootCabOrder.json");
            var seed = ROOT_CAB.FromJson(File.ReadAllText("..\\..\\Seed1.json"));

            var orderModel = OrderModel.FromJson(file);
            orderModel[0].Index = "1";
            orderModel[0].ModelName = "ROOT_CAB";
            orderModel[0].ModelInstance = "ROOT_CAB_"+"1";
            orderModel[0].ModelData = seed;
            orderModel[0].Itemid = "SEED_"+"1";
            orderModel[0].ApiModelMap = "ROOT_CAB";

            var orderFile = Serialize.ToJson(orderModel);

            //Create Project (Order) in BOM
            var order = CreateOrder();
            var url = "http://api.bomfusion-dev.ctechmanufacturing.com/api/orders/"+order.Header.TransactionNumber + "/line-items";
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", orderFile, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            object OrderNumber = response.Content;
        }

    }
}
