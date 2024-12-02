using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_DB_PamerYuk.Utility
{
    public class ColorUtil
    {
        private ColorUtil() { }

        public static readonly Dictionary<string, Color> palette = new Dictionary<string, Color> {
            { "soft-white", Color.FromArgb(245, 243, 240) }, // Background Color
            { "peach-cream", Color.FromArgb(226, 206, 179) }, // Primary 
            { "charcoal-gray", Color.FromArgb(40, 40, 40) }, // Secondary
            { "leaf-green", Color.FromArgb(125, 173, 76) }, // Success 
            { "coral-blush", Color.FromArgb(217, 113, 94) } // Error
        };

    }
}
