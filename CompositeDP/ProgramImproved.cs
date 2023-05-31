namespace CompositeDP
{
    using System;
    using System.Collections.Generic;

    abstract class FileSystemItem
    {
        protected readonly string name;

        public FileSystemItem(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }

    class File : FileSystemItem
    {
        public File(string name) : base(name)
        {
        }

        public override void Display(int depth = 0)
        {
            Console.WriteLine(new string(' ', depth) + name);
        }
    }

    class Directory : FileSystemItem
    {
        private readonly List<FileSystemItem> items;

        public Directory(string name) : base(name)
        {
            items = new List<FileSystemItem>();
        }

        public void AddItem(FileSystemItem item)
        {
            items.Add(item);
        }

        public override void Display(int depth = 0)
        {
            Console.WriteLine(new string(' ', depth) + name);

            foreach (var item in items)
            {
                item.Display(depth+1);
            }
        }
    }
}
