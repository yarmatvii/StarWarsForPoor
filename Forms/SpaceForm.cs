using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarWarsForPoor.Objects.Parts;
using StarWarsForPoor.Objects.InSpace;



namespace StarWarsForPoor
{
	public partial class SpaceWinForm : Form
	{
		public Space CurentSpace = new Space(1);
		System.Windows.Forms.Timer timer;
		public SpaceWinForm()
		{
			InitializeComponent();
			CurentSpace.ShipDead += GameOver;
			this.timer = new System.Windows.Forms.Timer();
			timer.Interval = 15;
			timer.Tick += new EventHandler((o, ev) =>
			{
				this.AmmoLabel.Text = "Ammo: " + (Space.ShipInSpace.GetStatus().Ammo).ToString();
				this.HealthLabel.Text = "Health: " + (Space.ShipInSpace.GetStatus().Health).ToString();
				this.ScoreLabel.Text = "Score " + (CurentSpace.Score).ToString();
				this.GameField.Image = CurentSpace.DrawFrame();
			});
		}
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			CurentSpace.ShipMove(new Point(e.Location.X, e.Location.Y));
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			CurentSpace.ShipFire();
		}
		public void GetShip(Ship selected)
		{

			CurentSpace.GetShip(selected);
			timer.Start();
		}
		public void GameOver(ShipScore dat)
		{
			this.timer.Stop();
			this.timer.Dispose();
			this.Hide();
		}

		private void AmmoLabel_Click(object sender, EventArgs e)
		{

		}

		private void SpaceWinForm_Load(object sender, EventArgs e)
		{
		}

		private void SpaceWinForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CurentSpace.ShipDead += GameOver;
		}
	}
}
