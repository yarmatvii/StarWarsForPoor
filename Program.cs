﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace StarWarsForPoor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			ArmouryForm armoury = new ArmouryForm();
			//SpaceWinForm space = new SpaceWinForm(armoury);
            Application.Run(armoury);
        }
    }
}
