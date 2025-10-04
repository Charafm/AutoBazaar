using AutoBazaar.Common.Domain.DataTransferObjects;
using AutoBazaar.Common.Domain.Entities;
using AutoBazaar.Common.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Application.Interfaces
{
    public interface ICommunicationService
    {
        // Notification methods
        Task<bool> SendNotificationAsync(AddNotificationRequestDTO data, CancellationToken cancellationToken);
        Task<Notification> UpdateNotificationStatus(UpdateNotificationStatusRequestDTO data, CancellationToken cancellationToken);
        Task<GetAllNotificationsByCriteriaResponseDTO> GetAllNotificationsByCriteria(int? page, int? size, GetAllNotificationsByCriteriaRequestDTO criteria);
        Task CreateAndSendNotification(Guid userId, NotificationBody notificationBody, NotificationEnum target, CancellationToken cancellationToken);
        Task<bool> MarkAllNotificationsAsReadAsync(string userId, CancellationToken ct);
        // Messaging methods
        Task<bool> SendMessageAsync(MessageDTO dto, CancellationToken cancellationToken);
        Task<List<MessageDTO>> GetMessagesForUserAsync(string userId, CancellationToken cancellationToken);

        // Comment methods
        Task<bool> AddCommentAsync(CommentDTO dto, CancellationToken cancellationToken);
        Task<bool> UpdateCommentAsync(Guid commentId, CommentDTO dto, CancellationToken cancellationToken);
        Task<List<CommentDTO>> GetCommentsForEntityAsync(Guid targetEntityId, CancellationToken cancellationToken);

    }
}
