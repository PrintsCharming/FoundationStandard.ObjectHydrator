﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationStandard.ObjectHydrator.Tests.POCOs
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Address()
        {
            City = "Test City";
        }

    }
}
