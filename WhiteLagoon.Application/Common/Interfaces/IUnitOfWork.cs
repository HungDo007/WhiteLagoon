﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IVillaRepository Villa { get; }
        public IVillaNumberRepository VillaNumber { get; }
        public IAmenityRepository Amenity { get; }
        void Save();
    }
}
