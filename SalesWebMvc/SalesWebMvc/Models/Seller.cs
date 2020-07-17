using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BrithDate { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalesRecord> Sales = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime brithDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BrithDate = brithDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void AddSales (SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoverSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales( DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
