using System;
using System.Collections.Generic;
using System.Text;

namespace PackageTracker.Models
{
    class Package
    {
        public string Id { get; set; }
        public string Sender { get; set; }
        public string Destination { get; set; }
        public string CurrentLocation { get; set; }
        public string CourierId { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentState { get; set; }
        public string Time { get; set; }
    }
}
