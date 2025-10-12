using AutoBazaar.Common.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces.Backoffice.Context
{
    public interface IBackofficeReadOnlyContext : IReadOnlyContext
    {
        
        DbSet<Message> Messages { get; }
        DbSet<MessageBody> MessageBodies { get; }
        DbSet<Comment> Comments { get; }
        DbSet<CommentBody> CommentBodies { get; }
           }
}
