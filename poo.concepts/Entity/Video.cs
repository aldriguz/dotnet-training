using System;

namespace poo.concepts {

    public class Video : IMedia, IFileCompress
    {
        public string Extension = "mp4";
        private long FileSizeBytes = 1024;
        private byte[] data = { 0, 100, 120, 210, 255};

        public string getFileExtension(){

            return this.Extension;
        }

        public long getFileSizeMb(){

            return this.FileSizeBytes / 1024;
        }

        private byte[] compressFile(){
            byte[] arrayData = { 0, 100, 120, 210, 255};
            return arrayData;
        }

    }

}