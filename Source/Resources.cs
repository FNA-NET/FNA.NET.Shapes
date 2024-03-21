using System.IO;

namespace FNA.NET.Shapes
{
	internal class Resources
	{
		#region Public Static Properties

		public static byte[] ShapeEffect
		{
			get
			{
				if (spriteEffect == null)
				{
					spriteEffect = GetResource("apos-shapes");
				}
				return spriteEffect;
			}
		}

		#endregion

		#region Private Static Variables

		private static byte[] spriteEffect;

		#endregion

		#region Private Static Methods

		private static byte[] GetResource(string name)
		{
			Stream stream = typeof(Resources).Assembly.GetManifestResourceStream(
				"FNA.NET.Resources." + name + ".fxb"
			);
			using (MemoryStream ms = new MemoryStream())
			{
				stream.CopyTo(ms);
				return ms.ToArray();
			}
		}

		#endregion
	}
}
