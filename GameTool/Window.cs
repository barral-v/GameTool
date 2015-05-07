using Microsoft.ClearScript;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTool
{
    public class Window
    {
        public Window(Game game, dynamic opts)
        {
            this.Game = game;
            Width = 800;
            Height = 600;
            Name = "GameTool";

            if (opts != null)
            {
                Width = (uint)opts.width;
                Height = (uint)opts.height;
                Name = (string)opts.name;
            }
        }

        public void onClose(dynamic callback)
        {
            Game.MainWindow.Closed += new EventHandler(delegate(object sender, EventArgs e) {
                callback(e);
            });
        }

        public void onGainedFocus(dynamic callback)
        {
            Game.MainWindow.GainedFocus += new EventHandler(delegate(object sender, EventArgs e) {
                callback(e);
            });
        }

        public void onJoystickButtonPressed(dynamic callback)
        {
            Game.MainWindow.JoystickButtonPressed += new EventHandler<JoystickButtonEventArgs>(delegate(object sender, JoystickButtonEventArgs e) {
                callback(new EventJoystickButton(e));
            });
        }

        public void onJoystickButtonReleased(dynamic callback)
        {
            Game.MainWindow.JoystickButtonReleased += new EventHandler<JoystickButtonEventArgs>(delegate(object sender, JoystickButtonEventArgs e) {
                callback(new EventJoystickButton(e));
            });
        }

        public void onJoystickConnected(dynamic callback)
        {
            Game.MainWindow.JoystickConnected += new EventHandler<JoystickConnectEventArgs>(delegate(object sender, JoystickConnectEventArgs e) {
                callback(new EventJoystickConnect(e));
            });
        }

        public void onJoystickDisconnected(dynamic callback)
        {
            Game.MainWindow.JoystickDisconnected += new EventHandler<JoystickConnectEventArgs>(delegate(object sender, JoystickConnectEventArgs e) {
                callback(new EventJoystickConnect(e));
            });
        }

        public void onJoystickMoved(dynamic callback)
        {
            Game.MainWindow.JoystickMoved += new EventHandler<JoystickMoveEventArgs>(delegate(object sender, JoystickMoveEventArgs e) {
                callback(new EventJoystickMove(e));
            });
        }

        public void onKeyPress(dynamic callback)
        {
            Game.MainWindow.KeyPressed += new EventHandler<KeyEventArgs>(delegate(object sender, KeyEventArgs e) {
                Console.WriteLine(e.Code.ToString());
                callback(new EventKey(e));
            });
        }

        public void onKeyReleased(dynamic callback)
        {
            Game.MainWindow.KeyReleased += new EventHandler<KeyEventArgs>(delegate(object sender, KeyEventArgs e) {
                callback(new EventKey(e));
            });
        }

        public void onLostFocus(dynamic callback)
        {
            Game.MainWindow.LostFocus += new EventHandler(delegate(object sender, EventArgs e) {
                callback(e);
            });
        }

        public void onMouseButtonPressed(dynamic callback)
        {
            Game.MainWindow.MouseButtonPressed += new EventHandler<MouseButtonEventArgs>(delegate(object sender, MouseButtonEventArgs e) {
                callback(new EventMouseButton(e));
            });
        }

        public void onMouseButtonReleased(dynamic callback)
        {
            Game.MainWindow.MouseButtonReleased += new EventHandler<MouseButtonEventArgs>(delegate(object sender, MouseButtonEventArgs e) {
                callback(new EventMouseButton(e));
            });
        }

        public void onMouseEntered(dynamic callback)
        {
            Game.MainWindow.MouseEntered += new EventHandler(delegate(object sender, EventArgs e) {
                callback(e);
            });
        }

        public void onMouseLeft(dynamic callback)
        {
            Game.MainWindow.MouseLeft += new EventHandler(delegate(object sender, EventArgs e) {
                callback(e);
            });
        }

        public void onMouseMoved(dynamic callback)
        {
            Game.MainWindow.MouseMoved += new EventHandler<MouseMoveEventArgs>(delegate(object sender, MouseMoveEventArgs e) {
                callback(new EventMouseMove(e));
            });
        }

        public void onMouseWheelMoved(dynamic callback)
        {
            Game.MainWindow.MouseWheelMoved += new EventHandler<MouseWheelEventArgs>(delegate(object sender, MouseWheelEventArgs e) {
                callback(new EventMouseWheel(e));
            });
        }

        public void onResized(dynamic callback)
        {
            Game.MainWindow.Resized += new EventHandler<SizeEventArgs>(delegate(object sender, SizeEventArgs e) {
                callback(new EventSize(e));
            });
        }

        public void onSensorChanged(dynamic callback)
        {
            Game.MainWindow.SensorChanged += new EventHandler<SensorEventArgs>(delegate(object sender, SensorEventArgs e) {
                callback(new EventSensor(e));
            });
        }

        public void onTextEntered(dynamic callback)
        {
            Game.MainWindow.TextEntered += new EventHandler<TextEventArgs>(delegate(object sender, TextEventArgs e) {
                callback(new EventText(e));
            });
        }

        public void onTouchBegan(dynamic callback)
        {
            Game.MainWindow.TouchBegan += new EventHandler<TouchEventArgs>(delegate(object sender, TouchEventArgs e) {
                callback(new EventTouch(e));
            });
        }

        public void onTouchEnded(dynamic callback)
        {
            Game.MainWindow.TouchEnded += new EventHandler<TouchEventArgs>(delegate(object sender, TouchEventArgs e){
                callback(new EventTouch(e));
            });
        }

        public void onTouchMoved(dynamic callback)
        {
            Game.MainWindow.TouchMoved += new EventHandler<TouchEventArgs>(delegate(object sender, TouchEventArgs e){
                callback(new EventTouch(e));
            });
        }

        internal Game Game { get; set; }

        public uint Width { get; internal set; }
        public uint Height { get; internal set; }
        public string Name { get; internal set; }
    }
}
