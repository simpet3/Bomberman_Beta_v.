using Bomberman_1.mouse_Event_Handler;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AllocConsole();
            
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void Form1_MouseDown(object sender, MouseEventArgs e){

            // MouseEvent_Handler handler = new MouseEvent_Handler();
            
            Console.WriteLine("mouse down");

        }
        private void Form1_MouseClick(Object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse event handler ");

            MouseEvent_Handler mouseEventHandler = new MouseEventHandlerAdapter();
            mouseEventHandler.handleMouseEvent(new HumanPlayer(), e);
        }
    }
}
