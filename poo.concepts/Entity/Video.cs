using System;

namespace poo.concepts {

    public class Video : IImage, IAudio
    {
        public string Extension {get; set;}
        public long FileSizeBytes {get; set;}
        public void setFrequency(){

            //set audio frequency code
        }


        public long getFileSizeMb(){

            return this.FileSizeBytes / 1024;
        }

    }

}