namespace A15_Ex02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Fmessage : IMessage
    {

        public String CreateMessage(float result)
        {
            if (result > 0.66666)
            {
                return "Well done!!! Boys love you!!!";

            }
            else if (result < 0.3333)
            {
                return "You are geek!!!";
            }
            else
            {
                return "The fine. But can also be more";
            }
        }
        }
    }