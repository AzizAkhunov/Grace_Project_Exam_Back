﻿using MediatR;

namespace Grace_Project.Application.UseCases.Ochniy_Kurs.Commands
{
    public class CreateOchniyKursCommand : IRequest<bool>
    {
        public int QushilganlarSoni { get; set; }
        public decimal Narxi { get; set; }
        public int VideoSoni { get; set; }
    }
}