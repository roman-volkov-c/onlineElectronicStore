using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OnlineElectronicsStore.Shared
{
    public class NavMenuRedirectBar
    {
        private class AllowedValueAttribute : ValidationAttribute
        {
            public override bool IsValid(object? value) => AllowedValues.Contains(value?.ToString());
        }

        public static string[] AllowedValues { get; set; } = Array.Empty<string>();
        public static event Action? RerenderOfNavMenuRequired;
        public static void RequestRerenderOfNavMenu() => RerenderOfNavMenuRequired?.Invoke();

        [AllowedValue]
        public string Request { get; set; } = string.Empty;
    }
}
