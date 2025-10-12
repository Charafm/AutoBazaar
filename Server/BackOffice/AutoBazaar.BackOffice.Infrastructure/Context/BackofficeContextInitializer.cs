using AutoBazaar.Common.Application.Interfaces;
using AutoBazaar.Common.Domain.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Infrastructure.Context
{
    public class BackofficeContextInitializer : IContextInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public BackofficeContextInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            //_modelBuilder.Entity<Contact>().HasData(GenerateContact());
        }

           }
}
