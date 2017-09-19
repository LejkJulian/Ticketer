using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Event
    {
        public Guid EventId { get; protected set; }
        public string Name { get; protected set; }
        public string Town { get; protected set; }
        public string Description { get; protected set; }
        public Ticket _ticket { get; protected set; }
        public DateTime StartdAt { get; protected set; }
        public DateTime EndAt { get; protected set; }
        protected Event(){}
        public Event(string name,string town,string description,DateTime startAt,DateTime endAt,Ticket typeOfTicket)
        {
            SetName(name);
            SetTown(town);
            Description = description;
            SetStartTime(startAt);
            SetEndTime(endAt);
            _ticket = typeOfTicket;
            
            //dla kazdego typu podać cene

        }
        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException();
            Name = name;
        }
        public void SetTown(string town)
        {
            if (string.IsNullOrWhiteSpace(town))
                throw new ArgumentNullException();
            Town = town;
        }
        // Add formatting without second
        public void SetStartTime(DateTime startAt)
        {
            StartdAt = startAt;
        }
        public void SetEndTime(DateTime endAt)
        {
            EndAt = endAt;
        }

    }
    
}
