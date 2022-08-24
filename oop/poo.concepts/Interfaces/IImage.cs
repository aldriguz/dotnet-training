using System;

namespace poo.concepts {

    interface IImage : IMedia{

        int heigth {get; set;}
        int width {get; set;}

        int getMegaPixels();

    }

}