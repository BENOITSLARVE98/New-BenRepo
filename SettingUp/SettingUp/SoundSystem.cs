using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingUp
{
    class SoundSystem
    {
        //Member variable
        int mVolume;

        


        public  int GetVolume()
        {
            return mVolume;
        }

        public void SetVolume(int _Volume)
        {
            mVolume = _Volume;
        }
    }
}
