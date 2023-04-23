using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarWarsForPoor.Objects.InSpace;
using StarWarsForPoor.Objects.Parts;
using System.Xml.Serialization;
using System.IO;
using StarWarsForPoor.Helpers;

namespace StarWarsForPoor
{
	public partial class ArmouryForm : Form
	{
		Armoury h1 = new Armoury();
		//XmlSerializer formatter = new XmlSerializer(typeof(Money));
		private SpaceWinForm sf = new SpaceWinForm();
		private static int money = 1000;
		string message = "SORRY!!! Not enough money :-( ";
		public int Money
		{
			get
			{
				return money;
			}

			set
			{
				MoneyLabel.Text = $"Money: {value.ToString()}";
				money = value;
			}
		}
		public ArmouryForm()
		{
			InitializeComponent();
			//this.sf = sf;
			h1.Save();
			h1.GetList();
			sf.CurentSpace.ShipDead += GameOver;
			MoneyLabel.Text = $"Money: {money.ToString()}";

		}

		private void HangarForm_Load(object sender, EventArgs e)
		{
			ShipPreview.Image = h1.Draw();
			Hull.PerformClick();
			Weapon1.PerformClick();
			Money m = new Money();
			Money = m.GetMoneyFromXml();
		}

		private void HangarForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			sf.Close();
			Money m = new Money(money);
			m.WriteMoneyToXml(m);
		}

		private void Hull1_Click(object sender, EventArgs e)
		{
			h1.HullImg = new Bitmap(@"img\Hull1n.png");
			h1.ChosenHull = new Hull(cost: 100, health: 20, ammo: 50);

			ShipPreview.Image = h1.Draw();
		}

		private void Hull_Click(object sender, EventArgs e)
		{
			h1.HullImg = new Bitmap(@"img\Hull.png");
			h1.ChosenHull = new Hull(cost: 150, health: 30, ammo: 25);

			ShipPreview.Image = h1.Draw();
		}

		private void Hull2_Click(object sender, EventArgs e)
		{
			h1.HullImg = new Bitmap(@"img\Hull2.png");
			h1.ChosenHull = new Hull(cost: 125, health: 15, ammo: 100);

			ShipPreview.Image = h1.Draw();
		}

		private void Weapon1_Click(object sender, EventArgs e)
		{
			h1.WeaponImg = new Bitmap(@"img\Weapon.png");
			h1.BulletImg = new Bitmap(@"img\Bullet1n.png");
			h1.ChosenWeapon = new Weapon(cost: 10, damage: 1);
			ShipPreview.Image = h1.Draw();
		}

		private void Weapon2_Click(object sender, EventArgs e)
		{
			h1.WeaponImg = new Bitmap(@"img\Weapon1.png");
			h1.BulletImg = new Bitmap(@"img\Bullet2n.png");
			h1.ChosenWeapon = new Weapon(cost: 15, damage: 2);
			ShipPreview.Image = h1.Draw();
		}

		private void Weapon3_Click(object sender, EventArgs e)
		{
			h1.WeaponImg = new Bitmap(@"img\Weapon2.1.png");
			h1.BulletImg = new Bitmap(@"img\Bullet3n.png");
			h1.ChosenWeapon = new Weapon(cost: 20, damage: 3);
			ShipPreview.Image = h1.Draw();
		}

		private void Weapon4_Click(object sender, EventArgs e)
		{
			h1.WeaponImg = new Bitmap(@"img\Weapon3.png");
			h1.BulletImg = new Bitmap(@"img\Bullet4n.png");
			h1.ChosenWeapon = new Weapon(cost: 25, damage: 4);
			ShipPreview.Image = h1.Draw();
		}

		private void Weapon5_Click(object sender, EventArgs e)
		{
			h1.WeaponImg = new Bitmap(@"img\Weapon4.png");
			h1.BulletImg = new Bitmap(@"img\Bullet5n.png");
			h1.ChosenWeapon = new Weapon(cost: 30, damage: 5);
			ShipPreview.Image = h1.Draw();
		}

		private void StartGame_Click(object sender, EventArgs e)
		{

			h1.ChosenHull.Appearance = h1.HullImg;
			h1.ChosenWeapon.Appearance = h1.WeaponImg;
			h1.ChosenWeapon.BulletImg = h1.BulletImg;

			h1.ChoosenShip = new Ship(h1.ChosenHull, h1.ChosenWeapon);

			this.Hide();
			sf.Show();
			sf.GetShip(h1.ChoosenShip);

			Cursor.Hide();
		}

		public void GameOver(ShipScore dat)
		{
			Cursor.Show();
			int moneyEarned = dat.Score / 2;
			Money += moneyEarned;
			string message = " Score : " + dat.Score.ToString() + " Money earned : " + moneyEarned.ToString();
			MessageBox.Show(message);
			this.Show();
		}

		private void PurschaseWeapon1_Click(object sender, EventArgs e)
		{
			if (money > 24)
			{
				Weapon2.Enabled = true;
				Money -= 25;
				//MoneyLabel.Text = $"Money: {money.ToString()}";
				BuyWeapon2.Enabled = false;
				BuyWeapon2.Text = "SOLD";
			}
			else MessageBox.Show(message);
		}
		private void PurschaseWeapon2_Click(object sender, EventArgs e)
		{
			if (money > 49)
			{
				Weapon3.Enabled = true;
				Money -= 50;
				//MoneyLabel.Text = $"Money: {money.ToString()}";
				BuyWeapon3.Enabled = false;
				BuyWeapon3.Text = "SOLD";
			}
			else MessageBox.Show(message);
		}
		private void PurschaseWeapon3_Click(object sender, EventArgs e)
		{
			if (money > 99)
			{
				Weapon4.Enabled = true;
				Money -= 100;
				//MoneyLabel.Text = $"Money: {money.ToString()}";
				BuyWeapon4.Enabled = false;
				BuyWeapon4.Text = "SOLD";
			}
			else MessageBox.Show(message);
		}
		private void PurschaseWeapon4_Click(object sender, EventArgs e)
		{
			if (money > 249)
			{
				Weapon5.Enabled = true;
				Money -= 250;
				//MoneyLabel.Text = $"Money: {money.ToString()}";
				BuyWeapon5.Enabled = false;
				BuyWeapon5.Text = "SOLD";
			}
			else MessageBox.Show(message);
		}
		private void PurschaseHull2_Click(object sender, EventArgs e)
		{
			if (money > 249)
			{
				Hull1.Enabled = true;
				Money -= 250;
				//MoneyLabel.Text = $"Money: {money.ToString()}";
				BuyHull2.Enabled = false;
				BuyHull2.Text = "SOLD";
			}
			else MessageBox.Show(message);
		}
		private void PurschaseHull3_Click(object sender, EventArgs e)
		{
			if (money > 499)
			{
				Hull2.Enabled = true;
				Money -= 500;
				//MoneyLabel.Text = $"Money: {money.ToString()}";
				BuyHull3.Enabled = false;
				BuyHull3.Text = "SOLD";
			}
			else MessageBox.Show(message);
		}
	}
}
