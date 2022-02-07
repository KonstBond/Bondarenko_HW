using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_3
{
    class Presenter
    {
        MainWindow Window;
        Model model;

        public Presenter(MainWindow window)
        {
            Window = window;
            model = new Model();
            Window.Run += Window_Run;
            Window.ChangeValueDOWN += Window_ChangeValueDOWN;
            Window.ChangeValueUP += Window_ChangeValueUP;
        }

        public void Window_ChangeValueUP(object sender, EventArgs e)
        {
            this.Window.lblTime.Content = this.model.ValueUp();
        }

        public void Window_ChangeValueDOWN(object sender, EventArgs e)
        {
            this.Window.lblTime.Content = this.model.ValueDown();
        }

        public void Window_Run(object sender, EventArgs e)
        {
            this.Window.lblTime.Content = this.model.RUN();
        }
    }
}
