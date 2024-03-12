using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_LexiconDotNet
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    public class CustomError1 : UserError
    {
        public override string UEMessage()
        {
            return "This workspace is not a personal geodatabase!";
        }
    }

    public class CustomError2 : UserError
    {
        public override string UEMessage()
        {
            return "Invalid database connection: path typed incorrectly or it does not exist.!";
        }
    }

   
}