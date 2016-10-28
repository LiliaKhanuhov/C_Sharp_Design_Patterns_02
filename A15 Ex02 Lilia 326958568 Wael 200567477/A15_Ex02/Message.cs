namespace A15_Ex02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Message
    {
        public static String BuilderMessage(String userGender, float result)
        {
            if (userGender.Equals("female"))
            {
                Fmessage ea = new Fmessage();
                return ea.CreateMessage(result);


            }
            else
            {
                Bmessage aa = new Bmessage();
                return aa.CreateMessage(result);
            }
        }
    }
}