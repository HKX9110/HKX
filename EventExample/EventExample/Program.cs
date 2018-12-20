using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EventExample
{
    class Program
    {
        //事件的拥有者   事件    事件的订阅   事件的处理器   事件的响应者
        static void Main(string[] args)
        {
            MyFrom form = new MyFrom();
            form.ShowDialog();
           
        }


    }

   class MyFrom:Form
   {
       private TextBox textBox;
       private Button button;

       public MyFrom()
       {
           this.textBox = new TextBox();
           this.button = new Button();
           this.Controls.Add(this.textBox);
           this.Controls.Add(this.button);
           this.button.Click += this.ButtonClicked;
       }

       private void ButtonClicked(object sender, EventArgs e)
       {
           this.textBox.Text = "Hello World!";
       }
      
   }
   
}
