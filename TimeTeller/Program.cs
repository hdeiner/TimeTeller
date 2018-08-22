using System;
using System.Net;
using System.Net.Mail;

namespace TimeTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1, 1, false));
            Console.WriteLine(GetResult(2, 1, false));
            Console.WriteLine(GetResult(1, 2, false));
            Console.WriteLine(GetResult(2, 2, false));
            Console.WriteLine(GetResult(1, 1, true));
            Console.WriteLine(GetResult(2, 1, true));
            Console.WriteLine(GetResult(1, 2, true));
            Console.WriteLine(GetResult(2, 2, true));
            Console.Read();
        }

        public static String GetResult(int whichOne, int how, Boolean special)
        {
            String result = "";
            int i = 0;
            int j = 0;
            int k = 0;

            switch (whichOne)
            {
                case 1:
                    i = DateTime.Now.Hour;
                    j = DateTime.Now.Minute;
                    k = DateTime.Now.Second;
                    break;
                case 2:
                    i = DateTime.UtcNow.Hour;
                    j = DateTime.UtcNow.Minute;
                    k = DateTime.UtcNow.Second;
                    break;
            }

            switch (how)
            {
                case 1:
                    result = i.ToString("00") + ":" + j.ToString("00") + ":" + k.ToString("00");
                    if (whichOne == 2)
                    {
                        result += "Z";
                    }
                    break;
                case 2:
                    result = "";

                    if (k >= 30) j++;

                    if (j <= 3)
                    {
                        result = result + "about ";
                    }
                    else if (j <= 8)
                    {
                        result = result + "a little after ";
                    }
                    else if (j <= 13)
                    {
                        result = result + "about ten after ";
                    }
                    else if (j <= 18)
                    {
                        result = result + "about a quarter after ";
                    }
                    else if (j <= 23)
                    {
                        result = result + "about twenty after ";
                    }
                    else if (j <= 28)
                    {
                        result = result + "almost half after ";
                    }
                    else if (j <= 33)
                    {
                        result = result + "about half past ";
                    }
                    else if (j <= 38)
                    {
                        result = result + "almost twenty before ";
                    }
                    else if (j <= 43)
                    {
                        result = result + "about twenty before ";
                    }
                    else if (j <= 48)
                    {
                        result = result + "about a quarter of ";
                    }
                    else if (j <= 53)
                    {
                        result = result + "about ten of ";
                    }
                    else if (j <= 58)
                    {
                        result = result + "almost ";
                    }
                    else
                    {
                        result = result + "about ";
                    }

                    if (j < 35)
                    {
                        if (i == 0)
                        {
                            result = result + "twelve ";
                        }
                        else if (i == 1)
                        {
                            result = result + "one ";
                        }
                        else if (i == 2)
                        {
                            result = result + "two ";
                        }
                        else if (i == 3)
                        {
                            result = result + "three ";
                        }
                        else if (i == 4)
                        {
                            result = result + "four ";
                        }
                        else if (i == 5)
                        {
                            result = result + "five ";
                        }
                        else if (i == 6)
                        {
                            result = result + "six ";
                        }
                        else if (i == 7)
                        {
                            result = result + "seven ";
                        }
                        else if (i == 8)
                        {
                            result = result + "eight ";
                        }
                        else if (i == 9)
                        {
                            result = result + "nine ";
                        }
                        else if (i == 10)
                        {
                            result = result + "ten ";
                        }
                        else if (i == 11)
                        {
                            result = result + "eleven ";
                        }
                        else if (i == 12)
                        {
                            result = result + "twelve ";
                        }
                        else if (i == 13)
                        {
                            result = result + "one ";
                        }
                        else if (i == 14)
                        {
                            result = result + "two ";
                        }
                        else if (i == 15)
                        {
                            result = result + "three ";
                        }
                        else if (i == 16)
                        {
                            result = result + "four ";
                        }
                        else if (i == 17)
                        {
                            result = result + "five ";
                        }
                        else if (i == 18)
                        {
                            result = result + "six ";
                        }
                        else if (i == 19)
                        {
                            result = result + "seven ";
                        }
                        else if (i == 20)
                        {
                            result = result + "eight ";
                        }
                        else if (i == 21)
                        {
                            result = result + "nine ";
                        }
                        else if (i == 22)
                        {
                            result = result + "ten ";
                        }
                        else if (i == 23)
                        {
                            result = result + "eleven ";
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            result = result + "one ";
                        }
                        else if (i == 1)
                        {
                            result = result + "two ";
                        }
                        else if (i == 2)
                        {
                            result = result + "three ";
                        }
                        else if (i == 3)
                        {
                            result = result + "four ";
                        }
                        else if (i == 4)
                        {
                            result = result + "five ";
                        }
                        else if (i == 5)
                        {
                            result = result + "six ";
                        }
                        else if (i == 6)
                        {
                            result = result + "seven ";
                        }
                        else if (i == 7)
                        {
                            result = result + "eight ";
                        }
                        else if (i == 8)
                        {
                            result = result + "nine ";
                        }
                        else if (i == 9)
                        {
                            result = result + "ten ";
                        }
                        else if (i == 10)
                        {
                            result = result + "eleven ";
                        }
                        else if (i == 11)
                        {
                            result = result + "twelve ";
                        }
                        else if (i == 12)
                        {
                            result = result + "one ";
                        }
                        else if (i == 13)
                        {
                            result = result + "two ";
                        }
                        else if (i == 14)
                        {
                            result = result + "three ";
                        }
                        else if (i == 15)
                        {
                            result = result + "four ";
                        }
                        else if (i == 16)
                        {
                            result = result + "five ";
                        }
                        else if (i == 17)
                        {
                            result = result + "six ";
                        }
                        else if (i == 18)
                        {
                            result = result + "seven ";
                        }
                        else if (i == 19)
                        {
                            result = result + "eight ";
                        }
                        else if (i == 20)
                        {
                            result = result + "nine ";
                        }
                        else if (i == 21)
                        {
                            result = result + "ten ";
                        }
                        else if (i == 22)
                        {
                            result = result + "eleven ";
                        }
                        else if (i == 23)
                        {
                            result = result + "twelve ";
                        }
                    }

                    if ((i >= 0) && (i <= 5))
                    {
                        result = result + "at night";
                    }
                    else if ((i >= 6) && (i <= 11))
                    {
                        result = result + "in the morning";
                    }
                    else if ((i >= 12) && (i <= 17))
                    {
                        result = result + "in the afternoon";
                    }
                    else if ((i >= 18) && (i <= 23))
                    {
                        result = result + "in the evening";
                    }

                    if (whichOne == 2)
                    {
                        result = result + " Zulu";
                    }

                    break;
            }

            if (special)
            {
                try
                {
                    var me = new NetworkCredential("howarddeiner.xyzzy@gmail.com", "birneraccount");

                    var mm = new MailMessage()
                    {
                        From = new MailAddress("howarddeiner.xyzzy@gmail.com"),
                        Subject = "TimeTeller",
                        Body = "The time is now " + result
                    };

                    mm.To.Add(new MailAddress("howarddeiner.xyzzy@gmail.com"));

                    var c = new SmtpClient()
                    {
                        Port = 587,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Host = "smtp.gmail.com",
                        EnableSsl = true,
                        Credentials = me
                    };

                    c.Send(mm);
                }
                catch (Exception ex)
                {
                    return result;
                }
            }

            return result;
        }
    }

}
