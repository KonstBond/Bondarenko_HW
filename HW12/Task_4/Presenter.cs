using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Presenter
    {
        MainWindow window;
        Model model;

        public Presenter(MainWindow window)
        {
            this.window = window;
            model = new Model();
            window.InputEvent += Window_DigEvent;
            window.ClearEvent += Window_ClearEvent;
            window.RezEvent += Window_RezEvent;
        }

        private void Window_RezEvent(object sender, EventArgs e)
        {
            window.Output.Text = model.Rez(window.Output.Text);
        }

        private void Window_ClearEvent(object sender, EventArgs e)
        {
            window.Output.Text = model.Clear();
        }

        private void Window_DigEvent(object sender, EventArgs e)
        {
            if (sender.ToString().Last() == '-' ||
                sender.ToString().Last() == '+' ||
                sender.ToString().Last() == '/' ||
                sender.ToString().Last() == '*')
            {
                window.Badd.IsEnabled = false; window.Bsub.IsEnabled = false; window.Bmul.IsEnabled = false; window.Bdiv.IsEnabled = false;
            }       
            else
            {
                window.Badd.IsEnabled = true; window.Bsub.IsEnabled = true; window.Bmul.IsEnabled = true; window.Bdiv.IsEnabled = true;
            }
            window.Output.Text = model.Input(window.Output.Text, sender.ToString().Last());
        }
    }
}
