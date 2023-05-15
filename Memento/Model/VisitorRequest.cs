using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Model
{
    public class VisitorRequest
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public int Id { get; set; }
        public string RequestTypeName { get; set; }
        public string RequestStatusName { get; set; }
        public DateTime? DesiredStartDate { get; set; }
        public DateTime? DesiredExpirationDate { get; set; }
        public string VisitPurposeName { get; set; }

        public VisitorRequest(string lastName, string firstName, string patronymic, 
                              int id, string requestTypeName, string requestStatusName,
                              DateTime? desiredStartDate, DateTime? desiredExpirationDate, string visitPurposeName)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Id = id;
            RequestTypeName = requestTypeName;
            RequestStatusName = requestStatusName;
            DesiredStartDate = desiredStartDate;
            DesiredExpirationDate = desiredExpirationDate;
            VisitPurposeName = visitPurposeName;
    }
    }
}
