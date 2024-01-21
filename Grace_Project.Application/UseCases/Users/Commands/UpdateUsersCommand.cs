﻿using MediatR;

namespace Grace_Project.Application.UseCases.Users.Commands
{
    public class UpdateUsersCommand : IRequest<bool>
    {
        public string Name { get; set;}
        public string PhoneNumber { get; set; }
        public int OnlaynKursId { get; set; }
        public int OchniyKursId { get; set; }
        public int BepulKursId { get; set; }
    }
}