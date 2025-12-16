using System.Drawing;
using System.IO;

namespace McDo.Database.Tables
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public string? Description { get; set; }
        public double Price { get; set; }
        public byte[] Icon { get; set; } = [];
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public Image? IconImage { get { if (Icon == null || Icon.Length == 0) return null; try { using var ms = new MemoryStream(Icon); return Image.FromStream(ms); } catch { return null; } } }
    }
}
