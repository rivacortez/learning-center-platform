using learning_center_platformRI.IAM.Domain.Model.Commands;
using learning_center_platformRI.IAM.Interfaces.REST.Resources;

namespace learning_center_platformRI.IAM.Interfaces.REST.Transform;

public static class SignInCommandFromResourceAssembler
{
    public static SignInCommand ToCommandFromResource(SignInResource resource)
    {
        return new SignInCommand(resource.Username, resource.Password);
    }
}