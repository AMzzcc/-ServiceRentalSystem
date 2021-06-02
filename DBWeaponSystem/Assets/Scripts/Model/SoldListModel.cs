using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class SoldListModel
    {
        public string wno;
        public string sno;
        public string wname;
        public string wtype;
        public int wnumber;
        public float wprice;
        int number = 6;
        string strread;
        public SoldListModel(string Str)
       {
            foreach(char str in Str)
            {
                if(str!=' ')
                {
                    strread += str;
                }
                else if(strread!="")
                {
                    switch(number)
                    {
                        case 6:
                            wno = strread;
                            break;
                        case 5:
                            sno = strread;
                            break;
                        case 4:
                            wname = strread;
                            break;
                        case 3:
                            wtype= strread;
                            break;
                        case 2:
                            wnumber= int.Parse(strread);
                            break;
                        case 1:
                            wprice = float.Parse(strread);
                            break;

                    }
                    number --;
                    strread = "";
                }
            }
       }
    }
}
