// See https://aka.ms/new-console-template for more information
Console.WriteLine("Greetings App");
Console.WriteLine("====================");
Console.WriteLine("enter 'help' for valid commands");
string cmdtype = string.Empty;
do
{
    string [] command  = Input.getInput();
    cmdtype= command[0]; 
    switch (cmdtype)
    {
        case "greet":
        Console.WriteLine(Output.Greet(command));
        break;
        case "greeted":
        Console.WriteLine(Output.Greeted(command));
        break;
        case "counter":
        Console.WriteLine(Output.Count());
        break;
        case "clear":
        Console.WriteLine(Output.Clear(command));
        break;
        case "help":
        Console.WriteLine(Output.help());
        break;

    }
}while(cmdtype !="exit");


Console.WriteLine("Thank you for using our greetings app, press any key to exit...");
Console.ReadKey();


