using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FNA.NET.Shapes
{
    /// <summary>
    /// The effect used by ShapeBatch.
    /// </summary>
    public class ShapeEffect : Effect
    {
        public ShapeEffect(GraphicsDevice device)
            : base(device, Resources.ShapeEffect)
        {
        }

        protected ShapeEffect(ShapeEffect cloneSource)
            : base(cloneSource)
        {
        }

        public override Effect Clone()
        {
            return new ShapeEffect(this);
        }
    }
}
