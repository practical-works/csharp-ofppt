using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace Billet_de_Train
{
    static class SFX
    {
        static public SoundPlayer toot = new SoundPlayer(Billet_de_Train.Properties.Resources.toot);
        static public SoundPlayer train_crossing = new SoundPlayer(Billet_de_Train.Properties.Resources.train_crossing);
        static public SoundPlayer bingbing = new SoundPlayer(Billet_de_Train.Properties.Resources.Bingbing);
        static public SoundPlayer metal_hit = new SoundPlayer(Billet_de_Train.Properties.Resources.Metal_Hit);
    }
}
