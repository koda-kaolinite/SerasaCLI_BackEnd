
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Tse_Forms;

public class FontService
{
    public FontService()
    {
        Fonts = new PrivateFontCollection();
        LoadFonts();
    }

    public PrivateFontCollection Fonts { get; }

    private void LoadFonts()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var fontStreams = assembly.GetManifestResourceNames()
            .Where(r => r.EndsWith(".ttf"));

        foreach (var resourceName in fontStreams)
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    var fontData = new byte[stream.Length];
                    stream.Read(fontData, 0, (int)stream.Length);
                    var handle = GCHandle.Alloc(fontData, GCHandleType.Pinned);
                    try
                    {
                        var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(fontData, 0);
                        Fonts.AddMemoryFont(ptr, fontData.Length);
                    }
                    finally
                    {
                        handle.Free();
                    }
                }
            }
    }

    public Font GetFont(string familyName, float size, FontStyle style)
    {
        var family = Fonts.Families.FirstOrDefault(f => f.Name == familyName);
        return family != null ? new Font(family, size, style) : new Font("Arial", size, style);
    }
}
