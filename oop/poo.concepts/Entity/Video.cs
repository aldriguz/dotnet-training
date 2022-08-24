using System;

namespace poo.concepts {

    public class Video : IMedia, IFileCompress
    {
        public string getFileExtension(){

            string ext = "mp4";
            return ext;
        }

        public long getFileSizeMb(int sizeBytes){

            return sizeBytes / 1024;
        }

        public byte[] compressFile(){
            byte[] arrayData = { 0, 100, 120, 210, 255};
            return arrayData;
        }

    }

}