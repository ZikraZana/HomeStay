using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HomeStay
{
    class Session
    {
        public static int id_resepsionis { get; set; }
        public static string username { get; set; }
        public static string nama_resepsionis { get; set; }

        public static void Clear()
        {
            id_resepsionis = 0;
            username = null;
            nama_resepsionis = null;
        }
    }
}
