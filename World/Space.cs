using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using StarWarsForPoor.Objects.InSpace;
using StarWarsForPoor.Objects.Parts;
using StarWarsForPoor.Factories;


namespace StarWarsForPoor
{
	public delegate void GetStatus(ShipScore shipScore);

	public class Space
	{
		public event GetStatus ShipDead;
		bool GameOver = true;
		public int Score;
		List<Asteroid> Asteroids;
		List<Bullet> Bullets;
		public static Ship ShipInSpace;
		public static Bitmap SpaceField = new Bitmap(@"img\Space.jpg");
		Factory astrFactory = new Factory();
		public Space(int amountAstr = 0)
		{
			this.Score = 0;
			this.Asteroids = new List<Asteroid>();
			this.Bullets = new List<Bullet>();
			Space.ShipInSpace = new Ship(
		  new Hull(1, new Bitmap(@"img\Hull.png"), 29, 10)
		, new Weapon(1, new Bitmap(@"img\Weapon.png"), 1, new Bitmap(@"img\Bullet1.png")));

			for (int i = 0; i < amountAstr; i++)
			{
				Asteroids.Add((Asteroid)astrFactory.Create());
			}
			this.GameOver = false;
		}
		public Bitmap DrawFrame()
		{
			if (GameOver)
			{
				return new Bitmap(@"img\Space.jpg");
			}
			Space.SpaceField = new Bitmap(@"img\Space.jpg");
			Space.SpaceField = Space.ShipInSpace.Draw(Space.SpaceField);
			foreach (Asteroid item in this.Asteroids)
			{
				Space.SpaceField = item.Draw(Space.SpaceField);
				item.Coordinates.Offset(item.Vector);
				item.CheckCoordinates(SpaceField);
			}
			foreach (Bullet item in this.Bullets)
			{
				Space.SpaceField = item.Draw(Space.SpaceField);
				item.Coordinates.Offset(item.Vector);
				item.CheckCoordinates(SpaceField);

			}
			this.CheckBullets();
			this.CheckAsteroids();
			this.CheckAstrPunchAstrAndShip();
			this.CheckBulletsPunchAstr();
			Space.ShipInSpace.CheckCoordinates(Space.SpaceField);
			this.CheckShip();
			return Space.SpaceField;
		}
		public void CheckAstrPunchAstrAndShip()
		{
			foreach (Asteroid astrOne in this.Asteroids)
			{
				foreach (Asteroid astrTwo in this.Asteroids)
				{
					if (astrOne == astrTwo)
					{
						continue;
					}
					else
					{
						if (astrOne.IsPunch(astrTwo))
						{
							astrOne.Punch(astrTwo);
						}
					}
				}
				if (ShipInSpace.IsPunch(astrOne))
				{
					((IShipMod)astrOne).Modificate(Space.ShipInSpace);

				}
			}
		}
		public void CheckBulletsPunchAstr()
		{
			foreach (Asteroid asteroid in this.Asteroids)
			{
				foreach (Bullet bullet in this.Bullets)
				{

					if (bullet.IsPunch(asteroid))
					{
						this.Score++;
						bullet.Punch(asteroid);

					}

				}
			}
		}
		public void ShipMove(Point coordinates)
		{
			Space.ShipInSpace.MoveShip(coordinates);
		}
		public void ShipFire()
		{
			Bullet shipBullet = ShipInSpace.Fire();
			if (shipBullet != null)
			{
				this.Bullets.Add(shipBullet);
			}
		}
		public void CheckBullets()
		{
			Bullet delItem = null;
			bool IsDel = false;

			foreach (Bullet item in this.Bullets)
			{
				if (item.Lives <= 0)
				{
					delItem = item;
					IsDel = true;
					break;
				}
			}

			if (IsDel)
			{
				Bullets.Remove(delItem);
			}
		}
		public void CheckShip()
		{
			if (Space.ShipInSpace.Lives <= 0)
			{
				ShipScore dat;
				dat.ReturnedShip = Space.ShipInSpace;
				dat.Score = this.Score;
				this.GameOver = true;
				Space.ShipInSpace = null;
				ShipDead(dat);
			}
		}
		public void CheckAsteroids()
		{
			Asteroid delItem = null;
			bool IsDel = false;

			foreach (Asteroid item in this.Asteroids)
			{
				if (item.Lives <= 0)
				{
					delItem = item;
					IsDel = true;
					break;
				}
			}

			if (IsDel)
			{
				Asteroids.Remove(delItem);
				Asteroids.Add((Asteroid)astrFactory.Create());
			}

		}
		public void GetShip(Ship selected)
		{
			Space.ShipInSpace = selected;
			Bullets.Clear();
			GameOver = false;
			this.Score = 0;
		}
	}
	public struct ShipScore
	{
		public int Score;
		public Ship ReturnedShip;
	}
}
