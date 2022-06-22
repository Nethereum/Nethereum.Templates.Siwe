﻿using Nethereum.Siwe.Core;

namespace ExampleProjectSiwe.Server.Authentication
{
    public class DefaultSiweMessage : SiweMessage
    {
        public DefaultSiweMessage()
        {
            Domain = "login.xyz";
            Statement = "Sign-In With Ethereum ExampleProject";
            Uri = "https://login.xyz";
            Version = "1";
            ChainId = "1";
        }
    }
}
