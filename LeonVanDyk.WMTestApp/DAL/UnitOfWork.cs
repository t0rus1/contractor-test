using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeonVanDyk.WMTestApp.DAL
{
    public class UnitOfWork : IDisposable
    {
        private SchoolContext context = new SchoolContext();
        private StudentRepository studentRepository;

        public StudentRepository StudentRepository
        {
            get
            {
                if (this.studentRepository == null)
                {
                    this.studentRepository = new StudentRepository(context);
                }
                return studentRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}