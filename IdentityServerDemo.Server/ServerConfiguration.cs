using System;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServerDemo.Server
{
    public static class ServerConfiguration
    {
        public static List<IdentityResource> IdentityResources
        {
            get
            {
                List<IdentityResource> idResources =
                    new List<IdentityResource>
                    {
                        new IdentityResources.OpenId(),
                        new IdentityResources.Profile(),
                        new IdentityResources.Email(),
                        new IdentityResources.Phone(),
                        new IdentityResources.Address(),
                        new IdentityResource("roles", "User roles", new List<string> { "role" })
                    };
                return idResources;
            }
        }

        public static List<ApiScope> ApiScopes {}
        public static List<ApiResource> ApiResources {}
        public static List<Client> Clients {}
        public static List<TestUser> TestUsers {}
    }
}
