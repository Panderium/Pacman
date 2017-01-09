using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

public class Pacman : ObjetAnime
{
	public Pacman()
	{
        super(Content.Load<Texture2D>("Pacman"), new Vector2(0f, 0f), new Vector2(20f, 20f));
	}
}
