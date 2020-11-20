using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsabilityChain
{
    abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(string request);
    }


    class Manager
    {
        public void ProccesOrder()
        {
            Handler h1 = new Engineer();
            Handler h2 = new Cheif();
            Handler h3 = new Foreman();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            string[] requests = { "deisgn", "set up work for foremen", "set up work for builders", "make a report", "order pizza" };

            foreach (string request in requests)
            {
                h1.HandleRequest(request);
            }
        }
    }


    class Engineer : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "deisgn")
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }


    class Cheif : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "set up work for foremen" || request == "make a report")
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }


    class Foreman : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "set up work for builders")
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
