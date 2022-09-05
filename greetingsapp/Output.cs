public static class Output 
{
    static Dictionary<string, int> users = new();
  
    public static string Greet(string[] command)
    {
        string greeting  = string.Empty;
        if(command.Length == 3  && command[2] != string.Empty)
        {
        switch (command[2])
        {
            case "english":
                greeting += $"Hello, {command[1]}";
            break;
            case "afrikaans":
                greeting += $"Hallo, {command[1]}";
            break;
            case "sesotho":
                greeting += $"Dumelang, {command[1]}";
            break;
            default:
                greeting += $"Hello, {command[1]}. {command[2]} laguage is curretly not supported";
            break;
        }
        }
        else
        {
             greeting += $"Hello, {command[1]}";
        }
        AddUser(command[1]);
        return greeting;
    }



    private static void AddUser(string name)
    {
        string newUser = name.ToLower();
        if(!users.ContainsKey(newUser))
            users.Add(newUser, 1);
        else
            users[newUser]++;
    }

    public static string Greeted(string[] command)
    {

        string sResult = string.Empty;

        if(command.Length == 2)
        {
            if(users.ContainsKey(command[1]))
                sResult += $"{command[1]}  has been greeted {users[command[1]]} times";
            else
                sResult += $"{command[1]} hasn't been greeted";
        }
        else
        {
            Console.WriteLine("GREETED USERS");
            Console.WriteLine("=================");
            foreach(var user in users)
            {
                sResult += $"{user.Key} : {user.Value} \n";
            }
        }
        return sResult;
    }
    public static string Count()
    {
        string  sResults = string.Empty;
        int count = users.Values.Count;
        sResults += $"The number of users is  {count}";
        return sResults;
    }
    public static string Clear(string[] command)
    {
        string sResult = string.Empty;
        if(command.Length == 2)
        {
            if(users.ContainsKey(command[1]))
            {
                users.Remove(command[1]);
                sResult += $"{command[1]} has been cleared";
            }
            else
                sResult += $"{command[1]} hasn't been greeted";
        }
        else
        {
            users.Clear();
            sResult += "users has been cleared";
        }
        return sResult;
    }

    public static string help()
    {
        string help ="App valid commands: \n" +
            "greet [name] [language] - greet followed by the name and the language the user is to be greeted in secified language \n" +
            "greeted                 - list of all users that has been greeted and how many time each user has been greeted \n"+
            "greeted [username]      - greeted followed by a username returns how many times that specfic user has been greeted \n"+
            "counter                 - counter returns a count of how many unique users has been greeted \n"+
            "clear                   - clear deletes of all users greeted  \n"+
            "clear [username]        - clear followed by a username delete the greet counter for the specified user\n"+
            "exit                    - exits the application \n"+
            "help                    - help shows valid commands \n";
        
        return help;
    }

}

