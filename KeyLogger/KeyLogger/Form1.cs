﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FMUtils.KeyboardHook;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string data = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyDown(KeyboardHookEventArgs e)
        {
            Console.WriteLine(e.Key.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var KeyboardHook = new Hook("Global Action Hook");
            KeyboardHook.KeyDownEvent += KeyDown;
        }
    }
}
