using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob.brown@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria.green@gmail.com", new DateTime(1990, 7, 6), 2500.0, d2);
            Seller s3 = new Seller(3, "Alex Grev", "alex.grev@gmail.com", new DateTime(1989, 12, 10), 1350.0, d1);
            Seller s4 = new Seller(4, "Martha Frey", "martha.frey@gmail.com", new DateTime(1994, 1, 25), 1825.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald.blue@gmail.com", new DateTime(1984, 11, 18), 3000.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 09, 10), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 08, 09), 11000.0, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 08, 10), 11000.0, SaleStatus.Pending, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 09, 19), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 07, 07), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 06, 10), 11000.0, SaleStatus.Pending, s4);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 07, 10), 11000.0, SaleStatus.Pending, s5);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 06, 25), 11000.0, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 05, 20), 11000.0, SaleStatus.Pending, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 04, 15), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 04, 16), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 03, 08), 11000.0, SaleStatus.Canceled, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 02, 11), 11000.0, SaleStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13);

            _context.SaveChanges();
        }
    }
}
