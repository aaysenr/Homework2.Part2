using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    

    public class Program
    {
        static void Main(string[] args)
        {
            

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());



        }
    }

    



    interface IPersonManager
    {
        void Add();

        

        void Update();


    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            
            Console.WriteLine("Customer Added.");

        }

        public void Update()
        {

            Console.WriteLine("Customer Updated.");

        }


    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added.");
        }
        public void Update()
        {

            Console.WriteLine("Customer Updated.");

        }

    }


    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added.");
        }
        public void Update()
        {

            Console.WriteLine("Intern Updated.");

        }

    }


    class ProjectManager
    {
        public void Add(IPersonManager _ıpersonManager)
        {
            _ıpersonManager.Add();

        }

    }



}
