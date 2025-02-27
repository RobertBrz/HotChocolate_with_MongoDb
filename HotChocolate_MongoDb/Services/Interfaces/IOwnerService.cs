﻿using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;

namespace HotChocolate_MongoDb.Services.Interfaces
{
    public interface IOwnerService
    {
        public List<Owner> GetAllOwners();
        Owner  AddOwner(Owner owner);
    }
}
