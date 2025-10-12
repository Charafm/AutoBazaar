using AutoBazaar.Common.Application.Interfaces;
using AutoBazaar.Common.Application.Interfaces.Backoffice.Context;
using AutoBazaar.Common.Domain.Entities;
using AutoBazaar.Common.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.BackOffice.Infrastructure.Context
{
    public class BackofficeReadOnlyContext : AbstractReadOnlyContext<BackofficeReadOnlyContext>, IBackofficeReadOnlyContext
    {
        public BackofficeReadOnlyContext(ITenantAccessor tenantAccessor, ICurrentUserService currentUserService,
            ICacheService cacheService, DbContextOptions<BackofficeReadOnlyContext> options)
            : base(tenantAccessor, currentUserService, cacheService, options)
        {
        }
        public DbSet<Message> Messages => Set<Message>();
        public DbSet<MessageBody> MessageBodies => Set<MessageBody>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<CommentBody> CommentBodies => Set<CommentBody>();
        public DbSet<Notification> Notifications => Set<Notification>();
        public DbSet<NotificationBody> NotificationBodies => Set<NotificationBody>();
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

        }
    }
}
