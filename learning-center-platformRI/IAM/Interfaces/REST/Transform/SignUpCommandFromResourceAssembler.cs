using learning_center_platformRI.IAM.Domain.Model.Commands;
using learning_center_platformRI.IAM.Interfaces.REST.Resources;

namespace learning_center_platformRI.IAM.Interfaces.REST.Transform;

public static class SignUpCommandFromResourceAssembler
{
    public static SignUpCommand ToCommandFromResource(SignUpResource resource)
    {
        return new SignUpCommand(resource.Username, resource.Password);
    }
}