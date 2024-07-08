using learning_center_platformRI.IAM.Domain.Model.Aggregates;
using learning_center_platformRI.IAM.Interfaces.REST.Resources;

namespace learning_center_platformRI.IAM.Interfaces.REST.Transform;


public static class AuthenticatedUserResourceFromEntityAssembler
{
    public static AuthenticatedUserResource ToResourceFromEntity(
        User user, string token)
    {
        return new AuthenticatedUserResource(user.Id, user.Username, token);
    }
}