﻿using System;
using System.Collections.Generic;
using Wilson.Scheduler.Core.Entities;
using Wilson.Web.Events.Interfaces;

namespace Wilson.Web.Events
{
    public class PaycheckCreated : IDomainEvent
    {
        public PaycheckCreated(Paycheck paycheck)
        {
            this.Paycheck = paycheck;
            this.DateOccurred = DateTime.Now;
        }

        public PaycheckCreated(IEnumerable<Paycheck> paychecks)
        {
            this.Paychecks = paychecks;
            this.DateOccurred = DateTime.Now;
        }        

        public DateTime DateOccurred { get; private set; }

        public Paycheck Paycheck { get; set; }

        public IEnumerable<Paycheck> Paychecks { get; set; }
    }
}
