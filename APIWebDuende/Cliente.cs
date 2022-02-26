namespace APIWebDuende
{
    using Duende.IdentityServer;
    using Duende.IdentityServer.Models;

    public class Cliente
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client()
                {
                    ClientId = "mtwdm2022",
                    ClientName = "Ejemplo de implementación de autenticación con Duende Identity Server",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> { new Secret("superpassword".Sha256()) },
                    AllowedScopes = new List<string> { "ApiWebDuende" }
                },
            };
        }
    }
}
