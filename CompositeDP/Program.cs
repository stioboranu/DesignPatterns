var root = new CompositeDP.Directory("Root");

var file1 = new CompositeDP.File("File 1");
var file2 = new CompositeDP.File("File 2");
var file3 = new CompositeDP.File("File 3");

var subDirectory = new CompositeDP.Directory("Subdirectory");
var file4 = new CompositeDP.File("File 4");

subDirectory.AddItem(file4);
root.AddItem(file1);
root.AddItem(file2);
root.AddItem(file3);
root.AddItem(subDirectory);

root.Display();

//class File
//{
//    private readonly string name;

//    public File(string name)
//    {
//        this.name = name;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"-> {name}");
//    }
//}

//class Directory
//{
//    private readonly string name;
//    private readonly List<File> files;
//    private readonly List<Directory> directories;

//    public Directory(string name)
//    {
//        this.name = name;
//        this.files = new List<File>();
//        this.directories = new List<Directory>();
//    }

//    public void AddFile(File file)
//    {
//        files.Add(file);
//    }

//    public void AddDirectory(Directory directory)
//    {
//        directories.Add(directory);
//    }

//    public void Display()
//    {
//        Console.WriteLine(name);

//        foreach (var file in files)
//        {
//            file.Display();
//        }

//        foreach (var directory in directories)
//        {
//            directory.Display();
//        }
//    }
//}