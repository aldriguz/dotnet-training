using System;

namespace poo.concepts{

    public interface IMedia {
        string Extension {get; set;}
        long FileSizeBytes {get; set;}
        byte[] data {get; set;}

        public long getFileSizeMb();
        public string getFileExtension();
    }
}