﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciever
{
    //1st take the console output and store in list 
    //every line 1 element
    public class ConsoleReadAndMakeList
    {
        public List<string> ReadConsole()
        {
            //1 line data comment
            string buffer;
            List<string> content = new List<string>();
            //read till end line
            while (!string.IsNullOrEmpty(buffer = Console.ReadLine()))
            {
                string[] temp = buffer.Split(' ');  //data time comment
                content.Add(temp[2]);               //take  comment 
            }
            return content;
        }

        //send to dictionary make word count
    }
}
