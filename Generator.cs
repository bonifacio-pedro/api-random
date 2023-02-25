namespace ApiRandomPasswd;

public class Generator
{
    

    public static string GenPasswd(int charQnt, bool alfachar)
    {
        string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string alfaChars = "$%#@-_";
        string passwd = string.Empty;
        if (alfachar)
        {
            for (int i = 0; passwd.Length < charQnt; i++)
            {
                Random randNum = new Random();
                passwd += randNum.Next(10).ToString();
                Random randAbc = new Random();
                passwd += abc[randAbc.Next(abc.Length)];
                Random randAlfa = new Random();
                passwd += alfaChars[randAlfa.Next(alfaChars.Length)];
            }
            return passwd;
        }
        else
        {
            for (int i = 0; passwd.Length < charQnt; i++)
            {
                Random randNum = new Random();
                passwd += randNum.Next(10).ToString();
                Random randAbc = new Random();
                passwd += abc[randAbc.Next(abc.Length)];
            }
            return passwd;
        }
    }

    private static char[] Shuffle(char[] arrPasswd)
    {
        Random rand = new Random();
        return arrPasswd.OrderBy(x => rand.Next()).ToArray();
    }

    public static string GenSecurityPasswd(int charQnt, bool alfachar)
    {
        if (alfachar)
        {
            string passwd = GenPasswd(charQnt, true);
            char[] arrPasswd = passwd.ToCharArray();
            return new string(Shuffle(arrPasswd));
        }
        else
        {
            string passwd = GenPasswd(charQnt, false);
            char[] arrPasswd = passwd.ToCharArray();
            return new string(Shuffle(arrPasswd));
        }
    }
}
