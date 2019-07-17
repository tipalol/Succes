using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DataContext dataContext = new DataContext();
            dataContext.Somethings.Add(new Somethings() { Name = "123", Cost = 10 });
            dataContext.Somethings.Add(new Somethings() { Name = "007", Cost = 20 });

            dataContext.SaveChanges();
        }
    }
}
