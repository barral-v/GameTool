﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTool
{
    class Window
    {
        private Engine Engine;
        private int Width;
        private int Height;

        private Form Form { get; set; }

        public Window(Engine engine, int width, int height)
        {
            this.Engine = engine;
            this.Width = width;
            this.Height = height;
            this.Form = new Form();
            Form.Height = height;
            Form.Width = width;
            Form.ShowDialog();
        }

    }
}