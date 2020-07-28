using System;

namespace poo.concepts{

    interface IMedia {
        string Extension {get; set;}
        long FileSizeBytes {get; set;}
        byte[] data {get; set;}

        long getFileSizeMb();
        long getFileSizeGb();
        string getFileExtension();
        void setData();
    }
}