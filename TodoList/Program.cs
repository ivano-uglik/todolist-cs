string userChoice;
List<string> todos = new List<string>();
Console.WriteLine("Hello!");
while (true)
{
    do
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");
        userChoice = Console.ReadLine();
        Console.WriteLine(isUserChoiceValid(userChoice));
    } while (isUserChoiceValid(userChoice) == "Invalid choice.");
    var upperChoice = userChoice.ToUpper();
    if (upperChoice == "S")
    {
        if (todos.Count == 0)
        {
            Console.WriteLine("No TODOS have been added yet.");
        }
        else
        {
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todos[i]}");
            }
        }
        Console.ReadKey();
    }
    else if (upperChoice == "A")
    {
        Console.WriteLine("Enter the TODO description:");
        var newTodo = Console.ReadLine();
        while (newTodo == "" || newTodo == null || todos.Contains(newTodo))
        {
            if (newTodo == "" || newTodo == null)
            {
                Console.WriteLine("Description cannot be empty.");
            }
            else
            {
                Console.WriteLine("Description must be unique.");
            }
            Console.WriteLine("Enter the TODO description:");
            newTodo = Console.ReadLine();
        }
        todos.Add(newTodo);
        Console.WriteLine("TODO sucessfully added: " + newTodo);
    }
    else if (upperChoice == "R")
    {
        if (todos.Count == 0)
        {
            Console.WriteLine("No TODOS have been added yet.");
        }
        else
        {
            Console.WriteLine("Select the index of the TODO you want to remove:");
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todos[i]}");
            }
        }
        var todoSelected = Console.ReadLine();
        var parsedIndex = int.TryParse(todoSelected, out var index);
        if (todoSelected == null | todoSelected == "")
        {
            Console.WriteLine("Selected index cannot be empty.");
        }
        else if (parsedIndex == false)
        {
            Console.WriteLine("The input is not an index.");
        }
        else if (index-1 > todos.Count || index < 0)
        {
            Console.WriteLine("The index does not exist in the todo.");
        }
        else
        {
            Console.WriteLine($"Todo removed: {todos[index-1]}");
            todos.RemoveAt(index - 1);
        }
        Console.WriteLine("Todo removed.");
        Console.ReadKey();
    }
    else if (upperChoice == "E")
    {
        Console.WriteLine("Sayonara");
        return;
    }
}
string isUserChoiceValid(string userChoice)
{
    var capitalise = userChoice.ToUpper();
    if (capitalise == "S" || capitalise == "A" || capitalise == "R" || capitalise == "E")
    {
        return "";
    }
    return "Invalid choice.";
}