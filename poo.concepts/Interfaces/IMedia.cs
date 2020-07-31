using System;

namespace poo.concepts{

    public interface IMedia {
        long getFileSizeMb(int sizeBytes);
        string getFileExtension();
    }
}