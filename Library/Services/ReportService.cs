using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;
using Library.Forms;

namespace Library.Services
{
    class ReportService
    {
        private readonly LibraryContext _libraryContext;
        public ReportService()
        {
            _libraryContext = new LibraryContext();
        }
        public void Add(Report report)
        {
            _libraryContext.Reports.Add(report);
            _libraryContext.SaveChanges();
        }
        public List<Report> Reports()
        {
            return _libraryContext.Reports.Include("Book").Include("Client").ToList();
        }
        public Report Find(int id)
        {
            Report report = _libraryContext.Reports.Include("Book").FirstOrDefault(b => b.Id == id);
            return report;
        }
    }
}
