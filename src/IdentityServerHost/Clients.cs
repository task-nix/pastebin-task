// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using Duende.IdentityServer.Models;
using System.Collections.Generic;
using Duende.IdentityServer;

namespace IdentityServerHost
{
    public static class Clients
    {
        public static IEnumerable<Client> List =>
            new []
            {
                // MVC basic sample
                new Client
                {
                    ClientId = "web",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = { "https://localhost:8090/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:8090/signout-callback-oidc" },
                    AllowOfflineAccess = true,
                    AllowedScopes = { 
                        "openid", "profile"}
                }
            };
    } 
}