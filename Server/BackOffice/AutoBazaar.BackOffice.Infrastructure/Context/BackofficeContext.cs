using AutoBazaar.Common.Application.Interfaces;
using AutoBazaar.Common.Application.Interfaces.Backoffice.Context;
using AutoBazaar.Common.Application.Interfaces.Storage;
using AutoBazaar.Common.Domain.Entities;
using AutoBazaar.Common.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Infrastructure.Context
{
    public class BackofficeContext : AbstractContext<BackofficeContext>, IBackofficeContext
    {
        public BackofficeContext(ITenantAccessor tenantAccessor, ICurrentUserService currentUserService, IDateTime dateTime, IStorageService storage,
            ICacheService cacheService, DbContextOptions<BackofficeContext> options)
            : base(tenantAccessor, currentUserService, dateTime, storage, cacheService, options)
        {
        }



        protected override IContextInitializer CreateContextInitializer(ModelBuilder builder)
        {


            return new BackofficeContextInitializer(builder);
        }
        public DbSet<Message> Messages => Set<Message>();

        public DbSet<MessageBody> MessageBodies => Set<MessageBody>();

        public DbSet<Comment> Comments => Set<Comment>();

        public DbSet<CommentBody> CommentBodies => Set<CommentBody>();
        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
        }
        }
    }
