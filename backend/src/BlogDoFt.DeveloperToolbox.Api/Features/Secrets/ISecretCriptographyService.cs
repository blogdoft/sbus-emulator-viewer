using BlogDoFt.DeveloperToolbox.Api.Features.Secrets.Models;

namespace BlogDoFt.DeveloperToolbox.Api.Features.Secrets;

public interface ISecretCriptographyService
{
    (MemoryStream Content, byte[] IV) Encrypt(SecretSaveModel model);

    Task<(string Filename, MemoryStream Content)> DecryptAsync(SecretsTable model);
}
