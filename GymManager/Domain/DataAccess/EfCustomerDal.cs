﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.Domain.Entities;

namespace GymManager.Domain.DataAccess
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, GymContext>, ICustomerDal
    {
    }
}
