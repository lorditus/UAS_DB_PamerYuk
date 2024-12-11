using System;

namespace Class_PamerYuk
{
    public class Organisasi
    {
        #region Data Member
        private int id;
        private string nama;
        private Kota kota;
        #endregion

        #region Constructor
        public Organisasi(int id, string nama, Kota kota)
        {
            Id = id;
            Nama = nama;
            Kota = kota;
        }
        #endregion

        #region Property
        public int Id
        {
            get => id;
            private set
            {
                if (value < 1) throw new ArgumentException("Class: Organisasi | Id must be greater than 0!");
                else id = value;
            }
        }
        public string Nama 
        {
            get => nama;
            private set
            {
                if (value == null) throw new ArgumentNullException("Class: Organisasi | Nama can't be null!");
                else if (value == "") throw new ArgumentException("Class: Organisasi | Nama can't be empty!");
                else if (value.Length > 45) throw new ArgumentException("Class: Organisasi | The maximum value for Nama is 45 characters!");
                else nama = value;
            }
        }
        public Kota Kota 
        { 
            get => kota; 
            set
            {
                if (value == null) throw new ArgumentNullException("Class: Organisasi | Kota can't be null!");
                else kota = value;
            }
        }
        #endregion
    }
}
