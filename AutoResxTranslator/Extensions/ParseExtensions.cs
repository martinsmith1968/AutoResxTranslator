using System.Drawing;
using System.Linq;

namespace AutoResxTranslator.Extensions
{
    internal static class ParseExtensions
    {
        internal static bool ParseSize(this string text, out Size size)
        {
            size = Size.Empty;

            var parts = (text ?? string.Empty)
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            if (parts.Length == 2 && int.TryParse(parts[0], out var width) && int.TryParse(parts[1], out var height))
            {
                size = new Size(width, height);
                return true;
            }

            return false;
        }
    }
}
