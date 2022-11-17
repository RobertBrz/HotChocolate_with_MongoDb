namespace HotChocolate_MongoDb.Mutation
{

    [ExtendObjectType(typeof(Mutation))]
    public class OwnerMutation
    {

        public string anything(string c)
        {
            return c;   
        }
    }
}
