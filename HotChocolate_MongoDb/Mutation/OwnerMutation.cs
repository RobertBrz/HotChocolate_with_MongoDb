using HotChocolate_MongoDb.Models;
using HotChocolate_MongoDb.Models.Interfaces;
using HotChocolate_MongoDb.Services.Interfaces;

namespace HotChocolate_MongoDb.Mutation
{

    [ExtendObjectType(typeof(Mutation))]
    public class OwnerMutation
    {
        IOwnerService _ownerService;
        public OwnerMutation(IOwnerService  ownerService)
        {
            _ownerService = ownerService;
        }

        public Owner AddOwner (Owner  owner )
        {
            return _ownerService.AddOwner(owner);
        }
    }


    //public class AddOwnerResponse : ObjectType<Owner>
    //{

    //    protected override void Configure(IObjectTypeDescriptor<Owner> descriptor)
    //    {

    //        descriptor.Field(x=>x.).Ignore();

    //    }
    //}
}
