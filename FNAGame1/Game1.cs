using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FNA.NET.Shapes;

namespace FNAGame1;

public class Game1 : Game
{
	public Game1()
	{
		GraphicsDeviceManager gdm = new GraphicsDeviceManager(this);

		// Typically you would load a config here...
		gdm.PreferredBackBufferWidth = 800;
		gdm.PreferredBackBufferHeight = 600;
		gdm.IsFullScreen = false;
		gdm.SynchronizeWithVerticalRetrace = true;

		IsMouseVisible = true;

		// All content loaded will be in a "Content" folder
		Content.RootDirectory = "Content";
	}

	protected override void Initialize()
	{
		/* This is a nice place to start up the engine, after
		 * loading configuration stuff in the constructor
		 */
		base.Initialize();
	}

	protected override void LoadContent()
	{
		_sb = new ShapeBatch(GraphicsDevice);

		base.LoadContent();
	}

	protected override void UnloadContent()
	{
		// Clean up after yourself!
		base.UnloadContent();
	}

	ShapeBatch _sb;


	protected override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		GraphicsDevice.Clear(Color.CornflowerBlue);

		_sb.Begin();
		_sb.BorderLine(new Vector2(100, 20), new Vector2(450, -15), 5, Color.White, 2f);

		_sb.DrawCircle(new Vector2(120, 120), 75, new Color(96, 165, 250), new Color(191, 219, 254), 4f);
		_sb.DrawCircle(new Vector2(120, 120), 30, Color.White, Color.Black, 20f);

		_sb.DrawCircle(new Vector2(370, 120), 100, new Color(96, 165, 250), new Color(191, 219, 254), 4f);
		_sb.DrawCircle(new Vector2(370, 120), 40, Color.White, Color.Black, 20f);

		_sb.DrawCircle(new Vector2(190, 270), 10, Color.Black, Color.White, 2f);
		_sb.DrawCircle(new Vector2(220, 270), 10, Color.Black, Color.White, 2f);

		_sb.FillCircle(new Vector2(235, 400), 30, new Color(220, 38, 38));
		_sb.FillRectangle(new Vector2(235, 370), new Vector2(135, 60), new Color(220, 38, 38));
		_sb.FillCircle(new Vector2(235, 400), 20, Color.White);
		_sb.FillRectangle(new Vector2(235, 380), new Vector2(125, 40), Color.White);

		_sb.DrawEllipse(new Vector2(100, 300), 10.0f, 80.0f, Color.Green, Color.Purple);

		_sb.DrawHexagon(new Vector2(300, 300), 70.0f, Color.SkyBlue, Color.Purple);

		_sb.DrawRectangle(new Vector2(200, 150), new Vector2(200, 150), Color.Transparent, Color.SandyBrown);

		_sb.End();

		base.Draw(gameTime);
	}
}
