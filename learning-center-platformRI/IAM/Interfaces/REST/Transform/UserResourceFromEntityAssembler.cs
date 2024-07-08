using learning_center_platformRI.IAM.Domain.Model.Aggregates;
using learning_center_platformRI.IAM.Interfaces.REST.Resources;

namespace learning_center_platformRI.IAM.Interfaces.REST.Transform;

public static class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User user)
    {
        return new UserResource(user.Id, user.Username);
    }
}