﻿using LLC.Application.Requests.Mail;
using System.Threading.Tasks;

namespace LLC.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}