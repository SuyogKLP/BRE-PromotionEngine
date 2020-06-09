using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.BusinessRuleEngine
{
   
    interface IProductBookPayment
    {
        string PackingSlip();
        string GenerateCommissionPayment();
        string LearningToSki();
    }

    //Defining families of related (child) classs
    class Product : IProductBookPayment
    {
        public string LearningToSki()
        {
            return "Added First-aid video to the packing slip (the result of court 1997)";
        }
        public string GenerateCommissionPayment()
        {
            return "Generated Commision payment to the agent!";
        }

        public string PackingSlip()
        {
            return "Packing slip for shipping is generated!";
        }
    }

    //Defining families of related (child) classs
    class Book : IProductBookPayment
    {
        public string LearningToSki()
        {
            return "Added First-aid video to the packing slip (the result of court 1997)";
        }
        public string GenerateCommissionPayment()
        {
            return "Generated Commision payment to the agent!";
        }

        public string PackingSlip()
        {
            return "Created duplicate packing slip for royalty department.";
        }
    }
}
