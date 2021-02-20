using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OnlineElectronicsStore.Shared
{
    public class Search
    {
        private class AllowedValueAttribute : ValidationAttribute
        {
            public override bool IsValid(object? value) => AllowedValues.Contains(value?.ToString());
        }
        
        public static string[] AllowedValues = Array.Empty<string>();
        public static bool HasNotValues => AllowedValues.Length is 0;
        public static Action? ReRenderNavMenu;

        [AllowedValue]
        public string Request { get; set; }
    }
}
