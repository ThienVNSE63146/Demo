﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChecker
{
    class TimeChecker
    {
        private int day, month, year;
       
        public TimeChecker(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int DayInMonth()
        {
          
            if(month==1||month==3||month==5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else if(month==2)
            {
                if( year % 400 == 0)
                {
                    return 29;
                }
                else if(year%100 != 0 && year % 4 == 0)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else
            {
                return 0;
            }
        }
        public bool IsValidDate()
        {
            if (month < 1 || month > 12) return false;
            if (day < 1) return false;
            else
            {
                if (day <= DayInMonth()) return true;
                else
                {
                    return false;
                }
            }
        }
     
    }
}
