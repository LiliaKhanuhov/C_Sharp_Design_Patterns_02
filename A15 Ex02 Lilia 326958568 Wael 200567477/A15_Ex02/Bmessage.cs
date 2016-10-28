namespace A15_Ex02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bmessage : IMessage
    {
        public string CreateMessage(float result)
        {
            if (result > 0.66666)
            {
                return "You are nerd!!!";

            }
            else if (result < 0.3333)
            {
                return "Well done!!! Girls love you!!!";
            }
            else
            {
                return "The fine. But can also be more";
            }

        }
    }
}