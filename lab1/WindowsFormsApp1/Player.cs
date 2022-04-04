using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Player
    {
        String playerId;
        String lastNam;
        String firstName;
        float height;
        float weight;
        String countryCode;

        public void setAll(String playerId, String lastNam, String firstName, float height, float weight, String countryCode)
        {
            this.playerId = playerId;
            this.lastNam = lastNam;
            this.firstName = firstName;
            this.height = height;
            this.weight = weight;
            this.countryCode = countryCode;


        }
    }
}
