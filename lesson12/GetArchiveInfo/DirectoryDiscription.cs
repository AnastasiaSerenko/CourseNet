using System;

namespace GetArchiveInfo
{
    enum ComponentType
    { 
        FOLDER,
        FILE
    }

    class ComponentDiscription
    {
        public ComponentType Type { get; }
        public string Name { get; }
        public DateTime LastWriteTime { get; }

        public ComponentDiscription(ComponentType Type, string Name, DateTime LastWriteTime)
        {
            this.Type = Type;
            this.Name = Name;
            this.LastWriteTime = LastWriteTime;
        }

        public override string ToString()
        {
            return $"{Type}\t{Name}\t{LastWriteTime.ToString()}";
        }
    }
}
