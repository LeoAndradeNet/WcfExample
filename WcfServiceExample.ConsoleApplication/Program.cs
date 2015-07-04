using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WcfServiceExample.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerWcfLibrary();

            ConsumerWcfApplication();
        }

        public static void ConsumerWcfLibrary()
        {
            var service = new ServiceReferenceExample.ServiceExampleClient();

            Console.WriteLine(service.GetData(42));
            
            Console.WriteLine("--------");

            Console.WriteLine(
                service.GetDataUsingDataContract(service.GetDataUsingDataContract(new ServiceReferenceExample.CompositeType { BoolValue = true }))
                    .StringValue);

            Console.ReadKey();
        }

        public static void ConsumerWcfApplication()
        {
            var service = new ServiceApplicationReference.Service1Client();

            Console.WriteLine(service.GetData(67));

            Console.WriteLine("--------");

            Console.WriteLine(
                service.GetDataUsingDataContract(service.GetDataUsingDataContract(new ServiceApplicationReference.CompositeType { BoolValue = true }))
                    .StringValue);

            Console.ReadKey();
        }
    }
}
