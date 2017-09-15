﻿using System.Security.Claims;
using Alba.Authentication;

namespace Alba
{
    public static class ScenarioExtensions
    {
        public static Scenario WithWindowsAuthentication(this Scenario scenario, ClaimsPrincipal user = null)
        {
            scenario.Context.AttachAuthenticationHandler(new StubWindowsAuthHandler(scenario.Context), user);
            return scenario;
        }
    }
}
