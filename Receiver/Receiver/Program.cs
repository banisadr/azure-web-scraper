using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            string eventHubConnectionString = "Endpoint=sb://babanisa-webscrape-11152016.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=2FLuXODdMsDrKAM0mpUzKvsXxIjUiWW+sWfCtgMAswA=";
            string eventHubName = "web-scraper-eh";
            string storageAccountName = "scraper116016";
            string storageAccountKey = "zQr+lGFltTIkLiLQHFIlql3sKLGM2wsiOXv0iCavu9BIZS7PzkLh7NrjxOlLRdNAeUr1xtZLPR5qKhE/AGeoqg==";
            string storageConnectionString = string.Format("DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}", storageAccountName, storageAccountKey);

            string eventProcessorHostName = Guid.NewGuid().ToString();
            EventProcessorHost eventProcessorHost = new EventProcessorHost(eventProcessorHostName, eventHubName, EventHubConsumerGroup.DefaultGroupName)
        }
    }
}
