using System;

namespace poo.concepts {

    interface IAudio : IMedia
    {
        string CompresionRatio {get; set;}
        void setFrequency();        
    }

}