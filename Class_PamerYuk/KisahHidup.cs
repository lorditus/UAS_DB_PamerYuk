using System;

namespace Class_PamerYuk
{
    public class KisahHidup
    {
        #region Data Member
        private Organisasi organisasi;
        private short thawal;
        private short thakhir;
        private string deskripsi;
        #endregion

        #region Constructor
        public KisahHidup(Organisasi organisasi, short thawal, short thakhir, string deskripsi)
        {
            if (thawal.CompareTo(thakhir) >= 0) throw new ArgumentException("Tahun akhir harus setelah tahun awal!");

            Organisasi = organisasi;
            Thawal = thawal;
            Thakhir = thakhir;
            Deskripsi = deskripsi;
        }
        #endregion

        #region Property
        public Organisasi Organisasi 
        {
            get => organisasi;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: KisahHidup | Organisasi can't be null!");
                else organisasi = value;
            }
        }
        public short Thawal 
        {
            get => thawal;
            private set
            {
                if (value < 1) throw new ArgumentNullException("Class: KisahHidup | Thakhir can't be negative!");
                thawal = value;
            }
        }
        public short Thakhir 
        {
            get => thakhir;
            private set
            {
                if (value < 1) throw new ArgumentNullException("Class: KisahHidup | Thakhir can't be negative!");
                thakhir = value;
            }
        }
        public string Deskripsi 
        { 
            get => deskripsi; 
            private set
            {
                if (value == null) throw new ArgumentException("Class: KisahHidup | Deskripsi can't be null!");
                else deskripsi = value;
            }
        }

        #endregion
    }
}