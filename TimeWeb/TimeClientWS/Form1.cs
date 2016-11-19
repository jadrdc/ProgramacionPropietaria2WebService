using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeClientWS.Services;

namespace TimeClientWS
{
    public partial class Form1 : Form
    {

        private Services.TimeAbleClient client;
        public Form1()
        {
            client = new Services.TimeAbleClient();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var time = (TimeModel)client.GetTime();

          switch(comboBox1.Text)
          {
              case "Hora" :
                  {

                      textBox1.Text=String.Format(time.Date.TimeOfDay.ToString(),"hh:mm");
                      break;
                  }
              case "Fecha":
                  {

                      textBox1.Text = time.Date.ToString();
                      break;
                  }
              case "Celcius":
                  {
                      textBox1.Text = time.Temperature.ToString();

                      break;

                  }
              case "Farenheit":
                  {
                      textBox1.Text = time.Temperature.ToString();
                      break;

                  }

          }


        }
    }
}
