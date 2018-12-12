using CustomListview_XF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListview_XF.Datas
{
    public class SettingsListviewData
    {
        public List<SettingsListviewModel> SettingsListviewModels = new List<SettingsListviewModel>()
        {
             new SettingsListviewModel
            {
                SettingsID=1,
                Settings="Bildirim Ayarları",
                SettingsImage="ileri.png",
                SettingsIcon="bildirimayarlari.png"
            },
            new SettingsListviewModel
            {
                SettingsID=2,
                Settings="Yardım Merkezi",
                SettingsImage="ileri.png",
                SettingsIcon="yardimmerkezi.png"
            },
            new SettingsListviewModel
            {
                SettingsID=3,
                Settings="Hakkımızda",
                SettingsImage="ileri.png",
                SettingsIcon="hakkimizda.png"
            },
            new SettingsListviewModel
            {
                SettingsID=4,
                Settings="Sorun Bildir",
                SettingsImage="ileri.png",
                SettingsIcon="sorunbildir.png"
            },
            new SettingsListviewModel
            {
                SettingsID=5,
                Settings="Canlı Destek",
                SettingsImage="ileri.png",
                SettingsIcon="canlidestek.png"
            },
            new SettingsListviewModel
            {
                SettingsID=6,
                Settings="Çıkış",
                SettingsImage="ileri.png",
                SettingsIcon="cikis.png"
            }
        };
    }
}
