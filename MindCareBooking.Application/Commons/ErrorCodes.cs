using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindCareBooking.Application.Commons
{
    public class ErrorCodes
    {
        // Auth ErrorCodes
        public const string EmailAlreadyExists = "EMAIL_ALREADY_EXISTS";
        public const string InvalidCredentials = "INVALID_CREDENTIALS";
        public const string WeakPassword = "WEAK_PASSWORD";
        // Booking ErrorCodes
        public const string PastDate = "PAST_DATE";
        public const string Overlap = "OVERLAP";
        public const string NotFound = "NOT_FOUND";
        public const string Forbidden = "FORBIDDEN";
    }
}
