﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedAJob {
    public class MyException : Exception{
        public MyException(string msg)
            :base("Oops: " + msg){
            //this.Message = "oops";
        }
    }
}
