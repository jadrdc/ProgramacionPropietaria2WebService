using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TimeWeb.models
{


    [DataContract]
    public class TimeModel
    {

        DateTime date ;
        int temperature;
    


          [DataMember]
       public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        [DataMember]
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
    }


    }
